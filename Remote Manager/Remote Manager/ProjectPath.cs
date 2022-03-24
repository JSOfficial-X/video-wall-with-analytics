using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_Manager
{
    /// <summary>
    /// This class is just to contain path for this project. nothing else :D
    /// </summary>
    class ProjectPath
    {
        //image data path
        public static string imageDataPath = Application.StartupPath.Replace(@"\FaceAnalytic\bin\x86\Debug", @"\RawData\image.jpg");

        //video path
        //public static string videoPathForMaleYouth = Application.StartupPath.Replace(@"\FaceAnalytic\bin\x86\Debug", @"\Resources\Youth - below 25") + @"\MALE";
        //public static string videoPathForFemaleYouth = Application.StartupPath.Replace(@"\FaceAnalytic\bin\x86\Debug", @"\Resources\Youth - below 25") + @"\FEMALE";

        //public static string videoPathForMaleMiddleAge = Application.StartupPath.Replace(@"\TargetPromotionProjectV3\bin\Debug", @"\Resources\PMET - 25 to 54") + @"\MALE";
        //public static string videoPathForFemaleMiddleAge = Application.StartupPath.Replace(@"\TargetPromotionProjectV3\bin\Debug", @"\Resources\PMET - 25 to 54") + @"\FEMALE";

        //public static string videoPathForSeniorMale = Application.StartupPath.Replace(@"\TargetPromotionProjectV3\bin\Debug", @"\Resources\Seniors - 55 and above") + @"\MALE";
        //public static string videoPathForSeniorFemale = Application.StartupPath.Replace(@"\TargetPromotionProjectV3\bin\Debug", @"\Resources\Seniors - 55 and above") + @"\FEMALE";

        public static string videoPathForMaleYouth = @"C:\Users\"+Environment.UserName+@"\OneDrive\Youth - below 25\MALE";
        public static string videoPathForFemaleYouth = @"C:\Users\" + Environment.UserName + @"\OneDrive\Youth - below 25\FEMALE";

        public static string videoPathForMaleMiddleAge = @"C:\Users\"+Environment.UserName+@"\OneDrive\PMET - 25 to 54\MALE";
        public static string videoPathForFemaleMiddleAge = @"C:\Users\" + Environment.UserName + @"\OneDrive\PMET - 25 to 54\FEMALE";

        public static string videoPathForSeniorMale = @"C:\Users\" + Environment.UserName + @"\OneDrive\Seniors - 55 and above\MALE";
        public static string videoPathForSeniorFemale = @"C:\Users\" + Environment.UserName + @"\OneDrive\Seniors - 55 and above\FEMALE";
        //default video path
        public static string defaultVideoPath = @"C:\Users\" + Environment.UserName + @"\OneDrive\Default Videos";
       

        //age and gender data path
        public static string ageDataPath = Application.StartupPath.Replace(@"\FaceAnalytic\bin\x86\Debug", @"\RawData\Age.txt");
        public static string genderDataPath = Application.StartupPath.Replace(@"\FaceAnalytic\bin\x86\Debug", @"\RawData\Gender.txt");

        //Face API path
       // public static string FaceAPIPath = Application.StartupPath.Replace(@"\TargetPromotionProjectV3\bin\Debug", @"\Windows\Sample-WPF\bin\Debug\FaceAPI-WPF-Samples.exe");

    }
}

//public static string videoPathForMaleYouth = Application.StartupPath.Replace(@"\TargetPromotionProjectV3\bin\Debug", @"\Resources") + @"\Male Youth";
//public static string videoPathForFemaleYouth = Application.StartupPath.Replace(@"\TargetPromotionProjectV3\bin\Debug", @"\Resources") + @"\Female Youth";
//public static string videoPathForMaleMiddleAge = Application.StartupPath.Replace(@"\TargetPromotionProjectV3\bin\Debug", @"\Resources") + @"\Male Middle Age";
//public static string videoPathForFemaleMiddleAge = Application.StartupPath.Replace(@"\TargetPromotionProjectV3\bin\Debug", @"\Resources") + @"\Female Middle Age";
//public static string videoPathForSeniorMale = Application.StartupPath.Replace(@"\TargetPromotionProjectV3\bin\Debug", @"\Resources") + @"\Senior Male";
//public static string videoPathForSeniorFemale = Application.StartupPath.Replace(@"\TargetPromotionProjectV3\bin\Debug", @"\Resources") + @"\Senior Female"
// public static string defaultVideoPath = Application.StartupPath.Replace(@"\TargetPromotionProjectV3\bin\Debug", @"\Resources") + @"\Government Videos";
//public static string defaultVideoPathWithHighFrequency1 = Application.StartupPath.Replace(@"\TargetPromotionProjectV3\bin\Debug", @"\Resources\Government Videos\(High Freq) People_s Association - Service Staff of the Year Awards 2017.wmv");
//public static string defaultVideoPathWithHighFrequency2 = Application.StartupPath.Replace(@"\TargetPromotionProjectV3\bin\Debug", @"\Resources\Government Videos\(High Freq) People_s Association - Great Service Team Awards 2017.wmv");
