using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;

namespace TargetPromotionProjectV3
{
    public static class CameraHelper
    {
        private static FilterInfoCollection CameraCaptureDevices;
        private static VideoCaptureDevice CameraSource;
        private static List<string> cameraList = new List<string>();
        public static Image img;
        //private static int index = 1;
        //public static string folderpath { get; set; }

        static CameraHelper()
        {
            CameraCaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in CameraCaptureDevices)
            {
                cameraList.Add(VideoCaptureDevice.Name);
            }
            
            CameraSource = new VideoCaptureDevice(CameraCaptureDevices[0].MonikerString);
            
        }

        //public CameraHelper()
        //{

        //}

        private static void CameraSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Image image =(Bitmap)eventArgs.Frame.Clone();
            image.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            img = image;
            //GlobalData.shareImage = image; 

        }
        public static void Start()
        {
            try
            {
                CameraSource.NewFrame -= CameraSource_NewFrame;
                CameraSource.Start();
            }
            catch { }

            CameraSource.NewFrame += CameraSource_NewFrame;
            #region used to check what resolutions your camera support
            int index = 0;
            for (int i = 0; i < CameraSource.VideoCapabilities.Length; i++)
            {
                string resolution = "Resolution Number " + Convert.ToString(i);
                string resolution_size = CameraSource.VideoCapabilities[i].FrameSize.ToString();

                //MessageBox.Show(resolution + "    " + resolution_size);

                if (resolution_size == "{Width=1920, Height=1080}")
                    index = i;
                else if (resolution_size == "{Width=1280, Height=720}")
                    index = i;
                else if (resolution_size == "{Width=640, Height=480}")
                    index = i;
            }
            #endregion

            CameraSource.VideoResolution = CameraSource.VideoCapabilities[index];
            CameraSource.Start();
        }
        public static void Stop()
        {
            try
            {
                CameraSource.NewFrame -= CameraSource_NewFrame;
                CameraSource.Stop();
            }
            catch { }
        }
        public static void CaptureAndReplaceImage()
        {
            //using (var stream = File.Open(folderpath, FileMode.Open, FileAccess.Write, FileShare.Read))
            //{
           
                if (img != null)
                {
                    if (File.Exists(ProjectPath.imageDataPath))
                        File.Delete(ProjectPath.imageDataPath);
                    Thread.Sleep(100);
                if (!File.Exists(ProjectPath.imageDataPath))
                {
                    img.Save(ProjectPath.imageDataPath, ImageFormat.Jpeg);
                    
                    //parameter is not valid?????
                }


                
                    //img.Dispose();
                }
                else
                {

                }

        }

            //try
            //{
            //    if (GlobalData.shareImage != null)
            //    {
            //        if (File.Exists(ProjectPath.imageDataPath))
            //            File.Delete(ProjectPath.imageDataPath);
            //        Thread.Sleep(500);
            //        GlobalData.shareImage.Save(ProjectPath.imageDataPath, ImageFormat.Jpeg);
            //        GlobalData.shareImage.Dispose();
            //    }
            //    else
            //    {

            //    }

            //}

          
    }
}
