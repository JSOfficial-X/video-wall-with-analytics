//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license.
//
// Microsoft Cognitive Services (formerly Project Oxford): https://www.microsoft.com/cognitive-services
//
// Microsoft Cognitive Services (formerly Project Oxford) GitHub:
// https://github.com/Microsoft/ProjectOxford-ClientSDK
//
// Copyright (c) Microsoft Corporation
// All rights reserved.
//
// MIT License:
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED ""AS IS"", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using UserDataPath;

namespace Microsoft.ProjectOxford.Face.Controls
{
    /// <summary>
    /// Interaction logic for FaceDetectionPage.xaml
    /// </summary>
    public partial class FaceDetectionPage : Page, INotifyPropertyChanged
    {
        #region Fields

        /// <summary>
        /// Description dependency property
        /// </summary>
        public static readonly DependencyProperty DescriptionProperty = DependencyProperty.Register("Description", typeof(string), typeof(FaceDetectionPage));

        /// <summary>
        /// Face detection results in list container
        /// </summary>
        private ObservableCollection<Face> _detectedFaces = new ObservableCollection<Face>();

        /// <summary>
        /// Face detection results in text string
        /// </summary>
        private string _detectedResultsInText;

        /// <summary>
        /// Face detection results container
        /// </summary>
        private ObservableCollection<Face> _resultCollection = new ObservableCollection<Face>();

        /// <summary>
        /// Image path used for rendering and detecting
        /// </summary>
        private string _selectedFile;
        string IsSmileRe=null;
        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceDetectionPage" /> class
        /// </summary>
        public FaceDetectionPage()
        {
            InitializeComponent();
            GetFaceData();
            //this.Visibility = Visibility.Collapsed;
        }
        
        
        #endregion Constructors

        #region Events

        /// <summary>
        /// Implement INotifyPropertyChanged event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Events

        #region Properties

        /// <summary>
        /// Gets or sets description
        /// </summary>
        public string Description
        {
            get
            {
                return (string)GetValue(DescriptionProperty);
            }

            set
            {
                SetValue(DescriptionProperty, value);
            }
        }

        /// <summary>
        /// Gets face detection results
        /// </summary>
        public ObservableCollection<Face> DetectedFaces
        {
            get
            {
                return _detectedFaces;
            }
        }

        /// <summary>
        /// Gets or sets face detection results in text string
        /// </summary>
        public string DetectedResultsInText
        {
            get
            {
                return _detectedResultsInText;
            }

            set
            {
                _detectedResultsInText = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("DetectedResultsInText"));
                }
            }
        }

        /// <summary>
        /// Gets constant maximum image size for rendering detection result
        /// </summary>
        public int MaxImageSize
        {
            get
            {
                return 300;
            }
        }

        /// <summary>
        /// Gets face detection results
        /// </summary>
        public ObservableCollection<Face> ResultCollection
        {
            get
            {
                return _resultCollection;
            }
        }

        /// <summary>
        /// Gets or sets image path for rendering and detecting
        /// </summary>
        public string SelectedFile
        {
            get
            {
                return _selectedFile;
            }

            set
            {
                _selectedFile = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("SelectedFile"));
                }
            }
        }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Pick image for face detection and set detection result to result container
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event argument</param>
        private async void ImagePicker_Click(object sender, RoutedEventArgs e)
        {
           
            // Show file picker dialog
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".jpg";
            dlg.Filter = "Image files(*.jpg) | *.jpg";
            var result = dlg.ShowDialog();

            if (result.HasValue && result.Value)
            {
                // User picked one image
                var imageInfo = UIHelper.GetImageInfoForRendering(dlg.FileName);
                SelectedFile = dlg.FileName;

                // Clear last detection result
                ResultCollection.Clear();
                DetectedFaces.Clear();
                DetectedResultsInText = string.Format("Detecting...");

                MainWindow.Log("Request: Detecting {0}", SelectedFile);
                var sw = Stopwatch.StartNew();

                // Call detection REST API
                using (var fileStream = File.OpenRead(SelectedFile))
                {
                    try
                    {
                        MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
                        string subscriptionKey = "06af6f01c1174232bca3db94f945d19b";

                        var faceServiceClient = new FaceServiceClient(subscriptionKey);
                        Contract.Face[] faces = await faceServiceClient.DetectAsync(fileStream, false, true, new FaceAttributeType[] { FaceAttributeType.Gender, FaceAttributeType.Age, FaceAttributeType.Smile, FaceAttributeType.Glasses });
                        MainWindow.Log("Response: Success. Detected {0} face(s) in {1}", faces.Length, SelectedFile);

                        DetectedResultsInText = string.Format("{0} face(s) has been detected", faces.Length);

                        foreach (var face in faces)
                        {
                            DetectedFaces.Add(new Face()
                            {
                                ImagePath = SelectedFile,
                                Left = face.FaceRectangle.Left,
                                Top = face.FaceRectangle.Top,
                                Width = face.FaceRectangle.Width,
                                Height = face.FaceRectangle.Height,
                                FaceId = face.FaceId.ToString(),
                                Gender = face.FaceAttributes.Gender,
                                Age = string.Format("{0:#} years old", face.FaceAttributes.Age),
                                IsSmiling = face.FaceAttributes.Smile > 0.0 ? "Smile" : "Not Smile",
                                Glasses = face.FaceAttributes.Glasses.ToString(),
                            });
                        }

                        // Convert detection result into UI binding object for rendering
                        foreach (var face in UIHelper.CalculateFaceRectangleForRendering(faces, MaxImageSize, imageInfo))
                        {
                            ResultCollection.Add(face);
                        }
                    }
                    catch (FaceAPIException ex)
                    {
                        MainWindow.Log("Response: {0}. {1}", ex.ErrorCode, ex.ErrorMessage);
                        return;
                    }
                }
            }
        }
        #endregion Methods

        #region Method for TargetPromotion Project
        public async void GetFaceData()
        {
            //string filename = @"C:\Users\User\Desktop\TargetPromotionSolutionV3\Data\image.jpg";/*"C:/Game/Promotor_Person/ph.jpg";*/
                                                                                                // if (result.HasValue && result.Value)
            string filename = DataPath.imageDataPath;

            // User picked one image
            var imageInfo = UIHelper.GetImageInfoForRendering(filename);
                SelectedFile =filename;

                // Clear last detection result
                ResultCollection.Clear();
                DetectedFaces.Clear();
                DetectedResultsInText = string.Format("Detecting...");

                MainWindow.Log("Request: Detecting {0}", SelectedFile);
                var sw = Stopwatch.StartNew();

                // Call detection REST API
                using (var fileStream = File.OpenRead(SelectedFile))
                {
                    try
                    {
                        MainWindow mainWindow = Window.GetWindow(this) as MainWindow;
                    string subscriptionKey = /*"e7d6ef34e3a84801bde73fbde3597457"*/"f723a3f162cf4b2781c7f68cb6a43fe7";

                        var faceServiceClient = new FaceServiceClient(subscriptionKey);
                        Contract.Face[] faces = await faceServiceClient.DetectAsync(fileStream, false, true, new FaceAttributeType[] { FaceAttributeType.Gender, FaceAttributeType.Age, FaceAttributeType.Smile, FaceAttributeType.Glasses });
                        MainWindow.Log("Response: Success. Detected {0} face(s) in {1}", faces.Length, SelectedFile);

                        DetectedResultsInText = string.Format("{0} face(s) has been detected", faces.Length);
                    //System.IO.File.WriteAllText(@"C:\Game\Promotor_Person\PersonInfor_Age.txt", string.Empty);
                    //System.IO.File.WriteAllText(@"C:\Game\Promotor_Person\PersonInfor_Gender.txt", string.Empty);
                    //System.IO.File.WriteAllText(@"C:\Users\User\Desktop\TargetPromotionSolutionV3\Data\Age.txt", string.Empty);
                    //System.IO.File.WriteAllText(@"C:\Users\User\Desktop\TargetPromotionSolutionV3\Data\Gender.txt", string.Empty);
                    System.IO.File.WriteAllText(DataPath.ageDataPath, string.Empty);
                    System.IO.File.WriteAllText(DataPath.genderDataPath, string.Empty);
                    foreach (var face in faces) 
                        {
                        DetectedFaces.Add(new Face()
                        {
                            ImagePath = SelectedFile,
                            Left = face.FaceRectangle.Left,
                            Top = face.FaceRectangle.Top,
                            Width = face.FaceRectangle.Width,
                            Height = face.FaceRectangle.Height,
                            FaceId = face.FaceId.ToString(),
                            Gender = face.FaceAttributes.Gender,
                            Age = string.Format("{0:#} years old", face.FaceAttributes.Age),
                            //IsSmiling = face.FaceAttributes.Smile > 0.0 ? "Smile" : "Not Smile",
                            //Glasses = face.FaceAttributes.Glasses.ToString(),

                        });
                        //IsSmileRe = face.FaceAttributes.Smile > 0.0 ? "Smile" : "Not Smile";
                        string infor_Age = "/"+((int)face.FaceAttributes.Age).ToString()+"/";
                        string infor_Gender = "/"+face.FaceAttributes.Gender+"/";


                        //StreamWriter Age = File.AppendText(@"C:\Game\Promotor_Person\PersonInfor_Age.txt");
                        //StreamWriter Age = File.AppendText(@"C:\Game\Promotor_Person\PersonInfor_Age.txt");
                        //StreamWriter Age = File.AppendText(@"C:\Users\User\Desktop\TargetPromotionSolutionV3\Data\Age.txt");
                        StreamWriter Age = File.AppendText(DataPath.ageDataPath);
                        Age.Write(infor_Age);
                        Age.Close();
                        //StreamWriter Gender = File.AppendText(@"C:\Game\Promotor_Person\PersonInfor_Gender.txt");
                        //StreamWriter Gender = File.AppendText(@"C:\Users\User\Desktop\TargetPromotionSolutionV3\Data\Gender.txt");
                        StreamWriter Gender = File.AppendText(DataPath.genderDataPath);

                        Gender.Write(infor_Gender);
                        Gender.Close();

                        // File.AppendAllText(@"C:\Game\Promotor_Person\PersonInfor_Gender.txt",infor_Gender+Environment.NewLine);
                    }

                        // Convert detection result into UI binding object for rendering
                        foreach (var face in UIHelper.CalculateFaceRectangleForRendering(faces, MaxImageSize, imageInfo))
                        {
                            ResultCollection.Add(face);
                        }
                    }
                    catch (FaceAPIException ex)
                    {
                        //MainWindow.Log("Response: {0}. {1}", ex.ErrorCode, ex.ErrorMessage);
                        //return;
                    }
                }
            
        }
        #endregion


    }
}