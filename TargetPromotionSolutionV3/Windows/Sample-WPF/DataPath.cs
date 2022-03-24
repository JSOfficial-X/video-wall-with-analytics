using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDataPath
{
    class DataPath
    {
        public static string imageDataPath = Application.StartupPath.Replace(@"\Windows\Sample-WPF\bin\Debug", @"\Data\image.jpg");
        public static string ageDataPath = Application.StartupPath.Replace(@"\Windows\Sample-WPF\bin\Debug", @"\Data\Age.txt");
        public static string genderDataPath = Application.StartupPath.Replace(@"\Windows\Sample-WPF\bin\Debug", @"\Data\Gender.txt");
    }
}
