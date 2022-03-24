using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.DirectX.AudioVideoPlayback;
using System.Speech.Synthesis;
using ObooltNet;
namespace TargetPromotionProjectV3
{

    public partial class FaceAnalysis : Form
    {

        private Process OpenFaceAPI;
        private System.Timers.Timer timerCapture;
        private bool pictureTaken = false;
        FilePicker AdvertisementVideoFile = new FilePicker();
        FilePicker defaultVideoFile = new FilePicker();
        private Video videoPlayer;
        //Thread ThreadPlayDefaultVideo;
        NetConnection server;
        private Size formSize;
        private Size pnlSize;
        private static object locker = new Object();
        private bool isEmergencyMessageStart = false;
        private bool isAdvertisementPlaying = false;
        string msgReceived;
        string msgReceivedEmergency;
        string msgMaleFemalePreference="male";

        public FaceAnalysis()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            formSize = new Size(this.Width, this.Height);
            pnlSize = new Size(this.Width, this.Height);

            //CameraHelper.folderpath = ProjectPath.imageDataPath;
            //if (File.Exists(CameraHelper.folderpath))
            //{
            //    File.Delete(CameraHelper.folderpath);
            //}
            StartServer();
            CameraHelper.Start();
            InitializeImageTimerCapture();


            FullScreen();
            //Task.Factory.StartNew(() =>
            //{

            //});

            //this.BeginInvoke(new MethodInvoker(delegate
            //{
            PlayDefaultVideo(ProjectPath.defaultVideoPath);

            //}));
            this.KeyDown += new KeyEventHandler(FaceAnalysis_KeyDown);




        }

        /// <summary>
        /// initialize timer (miliseconds)
        /// </summary>
        private void InitializeImageTimerCapture()
        {
            timerCapture = new System.Timers.Timer();
            timerCapture.Interval = 1000;
            timerCapture.Elapsed += TimerCapture_Elapsed;
            timerCapture.AutoReset = true;
            timerCapture.Start();

        }
        /// <summary>
        /// For each the timer is elapsed by "X" miliseconds, following action will trigger:
        /// take picture
        /// open face api
        /// dispose timer
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Even arguments</param>
        private void TimerCapture_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            if (pictureTaken == false && isAdvertisementPlaying == false && isEmergencyMessageStart == false)
            {

                try
                {


                    //lock (locker)
                    //{
                       

                        Task.Factory.StartNew(() =>
                        {
                            CameraHelper.img.Dispose();
                            Thread.Sleep(500);

                            CameraHelper.CaptureAndReplaceImage();
                        });
                    //}
                }

                //need to solve the generic GDI+ error

                //}
                catch (Exception)
                {
                    throw;
                }
                pictureTaken = true;

                if (pictureTaken == true && isAdvertisementPlaying == false && isEmergencyMessageStart == false)
                {
                    triggerFaceAPI();
                    pictureTaken = false;
                }

            }
        }



        /// <summary>
        /// Shut down all application when the program is closing
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Event argument</param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {

                CameraHelper.Stop();
                OpenFaceAPI.Kill();
                OpenFaceAPI.CloseMainWindow();
                Process.GetCurrentProcess().Kill();
                Application.ExitThread();
                Application.Exit();
            }
            catch { }
        }

        /// <summary>
        /// Open face api by microsoft and take data from face (age and gender)
        /// </summary>
        private void triggerFaceAPI()
        {


            Thread.Sleep(2000);
            OpenFaceAPI = new Process();
            OpenFaceAPI = Process.Start(ProjectPath.FaceAPIPath);
            Thread.Sleep(5250);
            try
            {
                OpenFaceAPI.Kill();
            }
            catch { }
            
            OpenFaceAPI.Close();
            string age = ReadPersonAge(ProjectPath.ageDataPath);
            string gender = ReadPersonGender(ProjectPath.genderDataPath);
            Data(age, gender);
            CollectGarbage();


        }
        private string ReadPersonAge(string textFileDataPath)
        {

            StreamReader ageDataFile = new StreamReader(textFileDataPath);
            string ageData = ageDataFile.ReadToEnd();
            ageDataFile.Close();
            StreamWriter ageDataFileWrite = new StreamWriter(textFileDataPath);
            ageDataFileWrite.Write(String.Empty);
            ageDataFileWrite.Close(); 
            return ageData;
        }
        private string ReadPersonGender(string textFileDataPath)
        {
            StreamReader genderDataFile = new StreamReader(textFileDataPath);
            string genderData = genderDataFile.ReadToEnd();
            genderDataFile.Close();
            StreamWriter genderDataFileWrite = new StreamWriter(textFileDataPath);
            genderDataFileWrite.Write(String.Empty);
            genderDataFileWrite.Close(); 
            return genderData;
        }

        /// <summary>
        /// Take down data from files about age and gender from face
        /// </summary>
        /// <param name="ageData">get age data</param>
        /// <param name="genderData">get gender data</param>
        void Data(string ageData, string genderData)
        {
            char[] redundant = { '/' };

            string[] ageInformation = ageData.Split(redundant, StringSplitOptions.RemoveEmptyEntries);
            string[] genderInformation = genderData.Split(redundant, StringSplitOptions.RemoveEmptyEntries);
            int numberOfMale = 0;
            int numberOfFemale = 0;
            int ageYouthM = 0;
            int ageMiddleAgeM = 0;
            int ageSeniorM = 0;
            int ageYouthF = 0;
            int ageMiddleAgeF = 0;
            int ageSeniorF = 0;
            int ageYouthTotal = 0;
            int ageMiddleAgeTotal = 0;
            int ageSeniorTotal = 0;


            List<Person> listDetectedPersons = new List<Person>();

            for (int i = 0; i < ageInformation.Length; i++)
            {
                Person p = new Person();
                p.Age = Convert.ToInt16(ageInformation[i]);
                p.Gender = genderInformation[i];
                listDetectedPersons.Add(p);
                //age = p.Age;
            }
            // after this for loop, all detected persons have been stored in the list, 
            //to access an individual person, 
            //you can use index, e.g. listDetectedPersons[1]  ---- 2nd person



            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate
                {
                    richTxtResult.AppendText("The number of persons detected is: ");
                    richTxtResult.AppendText(listDetectedPersons.Count.ToString());
                    richTxtResult.AppendText("\n");
                    richTxtResult.AppendText("\n");

                    foreach (Person p in listDetectedPersons)
                    {
                        richTxtResult.AppendText("Age: " + p.Age.ToString());
                        richTxtResult.AppendText("     ");
                        richTxtResult.AppendText("Gender: " + p.Gender);
                        richTxtResult.AppendText("\n");
                        
                        if (p.Age < 25)
                        {
                            if (p.Gender=="male")
                            {
                                ageYouthM++;
                                numberOfMale += 1;
                            }
                            else if (p.Gender=="female")
                            {
                                ageYouthF++;
                                numberOfFemale += 1;
                            }
                            //ageYouth += 1;
                        }
                        if (p.Age >= 25 && p.Age <= 54)
                        {
                            if (p.Gender == "male")
                            {
                                ageMiddleAgeM++;
                                numberOfMale += 1;
                            }
                            else if (p.Gender == "female")
                            {
                                ageMiddleAgeF++;
                                numberOfFemale += 1;
                            }

                        }
                        if (p.Age >= 55)
                        {
                            if (p.Gender == "male")
                            {
                                ageSeniorM++;
                                numberOfMale += 1;
                            }
                            else if (p.Gender == "female")
                            {
                                ageSeniorF++;
                                numberOfFemale += 1;
                            }
                        }
                        #region???
                        //if (p.Gender == "male")
                        //{
                        //    numberOfMale += 1;
                        //}
                        if (p.Age < 25)
                        {
                            ageYouthTotal++;
                            //ageYouth += 1;
                        }
                        if (p.Age >= 25 && p.Age <= 54)
                        {
                            ageMiddleAgeTotal++;
                            //ageMiddleAge += 1;
                        }
                        if (p.Age >= 55)
                        {
                            ageSeniorTotal++;
                            //ageSenior += 1;
                        }
                        //if(p.Gender=="female")
                        //{
                        //    numberOfFemale++;
                        //}
                        //numberOfFemale = listDetectedPersons.Count - numberOfMale;
                        #endregion
                        string totalMale = string.Format("Number of Male: {0}", numberOfMale.ToString() + Environment.NewLine);
                        string totalFemale = string.Format("Number of Female: {0}", numberOfFemale.ToString() + Environment.NewLine);
                        string ageLesserThan25 = string.Format("No. of people age <25: {0}", ageYouthTotal.ToString() + Environment.NewLine);
                        string middleAged = string.Format("No. of people age >25 and <49: {0}", ageMiddleAgeTotal.ToString() + Environment.NewLine);
                        string SeniorAged = string.Format("No. of people age >59: {0}", ageSeniorTotal.ToString() + Environment.NewLine);

                        richTxtResult.AppendText(totalMale);
                        richTxtResult.AppendText(totalFemale);
                        richTxtResult.AppendText(ageLesserThan25);
                        richTxtResult.AppendText(middleAged);
                        richTxtResult.AppendText(SeniorAged);





                    }

                }));
            }




            if (listDetectedPersons.Count != 0)
            {
                if (numberOfMale > numberOfFemale)
                {
                    //youth
                    if (ageYouthM > ageMiddleAgeM && ageYouthM > ageSeniorM)
                    {
                        PlayVideo(ProjectPath.videoPathForMaleYouth);
                    }
                    //adult
                    else if (ageMiddleAgeM > ageYouthM && ageMiddleAgeM > ageSeniorM)
                    {
                        PlayVideo(ProjectPath.videoPathForMaleMiddleAge);
                    }
                    //senior
                    else if (ageSeniorM > ageYouthM && ageSeniorM > ageMiddleAgeM)
                    {
                        PlayVideo(ProjectPath.videoPathForSeniorMale);
                    }
                    //youth and adult are equal
                    else if (ageYouthM == ageMiddleAgeM && ageYouthM > ageSeniorM)
                    {
                        PlayVideo(ProjectPath.videoPathForMaleMiddleAge);
                    }
                    //youth and and senior equal
                    else if (ageYouthM == ageSeniorM && ageYouthM > ageMiddleAgeM)
                    {
                        PlayVideo(ProjectPath.videoPathForSeniorMale);
                    }
                    //adult and senior are equal
                    else if (ageMiddleAgeM == ageSeniorM && ageMiddleAgeM > ageYouthM)
                    {
                        PlayVideo(ProjectPath.videoPathForSeniorMale);
                    }
                    else if (ageYouthM == ageSeniorM && ageYouthM == ageMiddleAgeM)
                    {
                        PlayVideo(ProjectPath.videoPathForSeniorMale);
                    }

                }

                else if (numberOfMale < numberOfFemale)
                {
                    //youth
                    if (ageYouthF > ageMiddleAgeF && ageYouthF > ageSeniorF)
                    {
                        PlayVideo(ProjectPath.videoPathForFemaleYouth);
                    }
                    //adult
                    else if (ageMiddleAgeF > ageYouthF && ageMiddleAgeF > ageSeniorF)
                    {
                        PlayVideo(ProjectPath.videoPathForFemaleMiddleAge);
                    }
                    //senior
                    else if (ageSeniorF > ageYouthF && ageSeniorF > ageMiddleAgeF)
                    {
                        PlayVideo(ProjectPath.videoPathForSeniorFemale);
                    }
                    //youth and adult are equal
                    else if (ageYouthF == ageMiddleAgeF && ageYouthF > ageSeniorF)
                    {
                        PlayVideo(ProjectPath.videoPathForFemaleMiddleAge);
                    }
                    //youth and and senior equal
                    else if (ageYouthF == ageSeniorF && ageYouthF > ageMiddleAgeF)
                    {
                        PlayVideo(ProjectPath.videoPathForSeniorFemale);
                    }
                    //adult and senior are equal
                    else if (ageMiddleAgeF == ageSeniorF && ageMiddleAgeF > ageYouthF)
                    {
                        PlayVideo(ProjectPath.videoPathForSeniorFemale);
                    }
                    //equal number of them
                    else if (ageYouthF == ageSeniorF && ageYouthF == ageMiddleAgeF)
                    {
                        PlayVideo(ProjectPath.videoPathForSeniorFemale);
                    }

                }

                else if (numberOfMale == numberOfFemale)//equal, serve male
                {
                    if (msgMaleFemalePreference == "male")
                    {
                        //youth
                        if (ageYouthM > ageMiddleAgeM && ageYouthM > ageSeniorM)
                        {
                            PlayVideo(ProjectPath.videoPathForMaleYouth);
                        }
                        //adult
                        else if (ageMiddleAgeM > ageYouthM && ageMiddleAgeM > ageSeniorM)
                        {
                            PlayVideo(ProjectPath.videoPathForMaleMiddleAge);
                        }
                        //senior
                        else if (ageSeniorM > ageYouthM && ageSeniorM > ageMiddleAgeM)
                        {
                            PlayVideo(ProjectPath.videoPathForSeniorMale);
                        }
                        //youth and adult are equal
                        else if (ageYouthM == ageMiddleAgeM && ageYouthM > ageSeniorM)
                        {
                            PlayVideo(ProjectPath.videoPathForMaleMiddleAge);
                        }
                        //youth and and senior equal
                        else if (ageYouthM == ageSeniorM && ageYouthM > ageMiddleAgeM)
                        {
                            PlayVideo(ProjectPath.videoPathForSeniorMale);
                        }
                        //adult and senior are equal
                        else if (ageMiddleAgeM == ageSeniorM && ageMiddleAgeM > ageYouthM)
                        {
                            PlayVideo(ProjectPath.videoPathForSeniorMale);
                        }
                        else if (ageYouthM == ageSeniorM && ageYouthM == ageMiddleAgeM)
                        {
                            PlayVideo(ProjectPath.videoPathForSeniorMale);
                        }

                    }
                    else if (msgMaleFemalePreference == "female")//equal, serve female
                    { //youth
                        if (ageYouthF > ageMiddleAgeF && ageYouthF > ageSeniorF)
                        {
                            PlayVideo(ProjectPath.videoPathForFemaleYouth);
                        }
                        //adult
                        else if (ageMiddleAgeF > ageYouthF && ageMiddleAgeF > ageSeniorF)
                        {
                            PlayVideo(ProjectPath.videoPathForFemaleMiddleAge);
                        }
                        //senior
                        else if (ageSeniorF > ageYouthF && ageSeniorF > ageMiddleAgeF)
                        {
                            PlayVideo(ProjectPath.videoPathForSeniorFemale);
                        }
                        //youth and adult are equal
                        else if (ageYouthF == ageMiddleAgeF && ageYouthF > ageSeniorF)
                        {
                            PlayVideo(ProjectPath.videoPathForFemaleMiddleAge);
                        }
                        //youth and and senior equal
                        else if (ageYouthF == ageSeniorF && ageYouthF > ageMiddleAgeF)
                        {
                            PlayVideo(ProjectPath.videoPathForSeniorFemale);
                        }
                        //adult and senior are equal
                        else if (ageMiddleAgeF == ageSeniorF && ageMiddleAgeF > ageYouthF)
                        {
                            PlayVideo(ProjectPath.videoPathForSeniorFemale);
                        }
                        else if (ageYouthF == ageSeniorF && ageYouthF == ageMiddleAgeF)
                        {
                            PlayVideo(ProjectPath.videoPathForSeniorFemale);
                        }
                    }

                }

               






            }
                //else if (listDetectedPersons.Count == 0 && videoPlayer.Stopped)
                //{

                //    Task.Factory.StartNew(() =>
                //    {
                //        PlayDefaultVideo(ProjectPath.defaultVideoPath);

                //    });
                //}


            }

        /// <summary>
        /// Play a random video according to the data (age and gender)
        /// </summary>
        /// <param name="videoPath">get folder path which contains video</param>
        void PlayVideo(string videoPath)
        {
            Thread ThreadPlayVideo = new Thread(new ThreadStart(() =>
            {
                try
                {
                    videoPlayer.Stop();
                    videoPlayer.Dispose();
                }
                catch { }
                pictureTaken = true;
                timerCapture.Enabled = false;
                isAdvertisementPlaying = true;
                try
                {
                    OpenFaceAPI.Kill();
                }
                catch { }
                OpenFaceAPI.Close();
                CollectGarbage();
                if (InvokeRequired)
                {
                    this.BeginInvoke(new MethodInvoker(delegate
                    {
                        string advertVidFile = AdvertisementVideoFile.WMVRandomFilePicker(videoPath);
                        videoPlayer = new Video(advertVidFile, false);
                        videoPlayer.Owner = pnlVideo;
                        pnlVideo.Size = pnlSize;
                        videoPlayer.HideCursor();
                        //videoPlayer.Audio.Volume = -2500;
                        videoPlayer.Play();
                        richTxtResult.AppendText("\n");

                        richTxtResult.AppendText("\n");
                        txtDetectionStatus.Text = "Detected!";
                        txtDetectionStatus.TextAlign = HorizontalAlignment.Center;
                        txtDetectionStatus.Show();
                        richTxtResult.AppendText("Video File: " + advertVidFile);
                        videoPlayer.Ending += VideoPlayer_Ending;



                    }));
                }
            }));
            ThreadPlayVideo.Start();

        }









        /// <summary>
        /// While the video is playing, the media player will adjust it to fullscreen
        /// 
        /// </summary>
        /// <param name="sender">Event sender</param>
        /// <param name="e">Enter agruments</param>



        private void FaceAnalysis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }






        private void FullScreen()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //pnlVideo.Size = formSize;
            this.TopMost = true;
            Cursor.Hide();
            
            //this.Activate();
        }
        private void PlayDefaultVideo(string defaultPath)
        {
            Thread ThreadPlayDefaultVideo = new Thread(new ThreadStart(() =>
            {
                try
            {
                    videoPlayer.Stop();
                    videoPlayer.Dispose();
                }
                catch { }
                CollectGarbage();



                if (InvokeRequired)
                {

                    this.BeginInvoke(new MethodInvoker(delegate
                    {

                        string defVidFile = defaultVideoFile.WMVRandomFilePicker(defaultPath);
                        videoPlayer = new Video(defVidFile, false);
                        videoPlayer.Owner = pnlVideo;
                        pnlVideo.Size = pnlSize;
                        videoPlayer.HideCursor();
                        
                        //pnlSize = videoPlayer.DefaultSize;
                        //videoPlayer.Audio.Volume = -2500;
                        videoPlayer.Play();
                        richTxtResult.AppendText("\n");
                        richTxtResult.AppendText("\n");
                        //label1.Text = Convert.ToInt32(videoPlayer.CurrentPosition);
                        richTxtResult.AppendText("Video File: " +defVidFile);
                        this.Invoke(new MethodInvoker(delegate
                        {
                            txtDetectionStatus.Text = "Detecting..";
                            txtDetectionStatus.TextAlign = HorizontalAlignment.Center;
                            txtDetectionStatus.BringToFront();
                        }));
                       
                        //Detecting();
                        //txtDetectionStatus.Show();
                        isAdvertisementPlaying =false;
                        videoPlayer.Ending += VideoPlayer_Ending;
                        
                    }));


                }
            }));
            ThreadPlayDefaultVideo.Start();



        }

     
     
      
        private void VideoPlayer_Ending(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        CollectGarbage();
                        videoPlayer.Stop();
                        videoPlayer.Dispose();

                        PlayDefaultVideo(ProjectPath.defaultVideoPath);
                        if (timerCapture.Enabled == false)
                        {
                            pictureTaken = false;
                            
                            timerCapture.Enabled = true;
                            isAdvertisementPlaying = false;
                           
                        }
                    }));

                }
            });
        }
        

        private void CollectGarbage()
        {
            Thread ThreadCollectGarbage = new Thread(new ThreadStart(() =>

              {
                  //GC.AddMemoryPressure(2000000000);
                  GC.Collect(0);
                  GC.Collect(1);
                  GC.Collect(2);
              }));
            ThreadCollectGarbage.Start();



        }
        private void StartServer()
        {
            server = new NetConnection();
            server.OnConnect += Server_OnConnect; 
            server.OnDataReceived += Server_OnDataReceived; 
            server.OnDisconnect += Server_OnDisconnect; 
            server.Start(8500);
        }

        private void Server_OnDisconnect(object sender, NetConnection connection)
        {
            
        }

        private void Server_OnDataReceived(object sender, NetConnection connection, byte[] e)
        {
            msgReceived = Encoding.UTF8.GetString(e);
            msgReceivedEmergency = Encoding.UTF8.GetString(e);
            //msgMaleFemalePreference = Encoding.UTF8.GetString(e);
            if (msgReceived == "STOP")
            {
                videoPlayer.Stop();
                videoPlayer.Dispose();
                try
                {
                    OpenFaceAPI.Kill();
                }
                catch{ }
                
                Application.ExitThread();
                Application.Exit();

            }
            else if (msgReceivedEmergency == "Return")
            {
                richTxtEmergencyMessage.SendToBack();
               // richTxtEmergencyMessage.Clear();
                pnlVideo.BringToFront();
                //SendToBackUneccessaryStuff();
                isEmergencyMessageStart = false;
                if(isAdvertisementPlaying==true)
                {
                    timerCapture.Enabled = false;
                }
                else if(isAdvertisementPlaying==false)
                {
                    timerCapture.Enabled = true;
                }
                isEmergencyMessageStart = false;
                videoPlayer.Play();
                txtDetectionStatus.BringToFront();

            }
            else if (msgReceived == "male" || msgReceived == "female")
            {
                msgMaleFemalePreference = msgReceived;
            }
            else /*if (/*msgReceivedEmergency != "male" || msgReceived != "male" || msgMaleFemalePreference != "male" || msgReceivedEmergency != "female" || msgReceived != "female" || msgMaleFemalePreference != "female" || *//*msgReceived != "Return" || msgMaleFemalePreference != "Return" || msgReceivedEmergency != "Return") */
            {

                timerCapture.Enabled = false;
                isEmergencyMessageStart = true;
                videoPlayer.Pause();
                try
                {
                    OpenFaceAPI.Kill();
                }
                catch { }
                OpenFaceAPI.Close();
                videoPlayer.Pause();
                richTxtEmergencyMessage.Text = msgReceivedEmergency;
                richTxtEmergencyMessage.SelectionAlignment = HorizontalAlignment.Center;
                //richTxtEmergencyMessage.SelectionAlignment = (HorizontalAlignment)VerticalAlignment.Center;
                //pnlVideo.SendToBack();
                SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
                //speechSynthesizer.SpeakCompleted += SpeechSynthesizer_SpeakCompleted;
                speechSynthesizer.SpeakAsync(richTxtEmergencyMessage.Text);
                richTxtEmergencyMessage.BringToFront();
                //Task.Delay(5000).Wait();
                txtDetectionStatus.SendToBack();

            }
        }

        private void Server_OnConnect(object sender, NetConnection connection)
        {
            
        }
    }
}










