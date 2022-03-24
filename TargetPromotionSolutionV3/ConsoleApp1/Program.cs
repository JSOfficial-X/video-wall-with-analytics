using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string y = Application.StartupPath.Replace(@"\ConsoleApp1\bin\Debug", @"\Resources")+@"\Male Youth\";
            //Application.StartupPath.Replace(@"\RoboticCoach2_Body\bin\Debug", @"\Database");
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
