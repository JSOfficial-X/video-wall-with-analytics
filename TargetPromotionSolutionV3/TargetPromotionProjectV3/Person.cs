using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TargetPromotionProjectV3
{
    public class Person
    {
        private int _age;   // a "field" of Class person
        public int Age   //propety of _age
        {
            get
            {
                return _age;

            }

            set
            {
                _age = value;
            }
        }

        private string _gender; // another "field" of Class person
        public string Gender
        {
            get;
            set;
        }
        //public static string ReadPersonAge(string textFileDataPath)
        //{

        //    StreamReader ageDataFile = new StreamReader(textFileDataPath);
        //    string ageData = ageDataFile.ReadToEnd();
        //    ageDataFile.Close();
        //    return ageData;
        //}
        //public static string ReadPersonGender(string textFileDataPath)
        //{
        //    StreamReader genderDataFile = new StreamReader(textFileDataPath);
        //    string genderData = genderDataFile.ReadToEnd();
        //    genderDataFile.Close();
        //    return genderData;
        //}
        private int _numberOfMale;
        public int NumberOfMale
        {
            get
            {
                return _numberOfMale;
            }
            set
            {
                if (value < 0)
                    value = 0;
                else
                    value = _numberOfMale;
            }
        }
        private int _numberOfFemale;
        public int NumberOfFemale
        {
            get
            {
                return _numberOfMale;
            }
            set
            {
                if (value < 0)
                    value = 0;
                else
                    value = _numberOfMale;
            }
        }


    }
}
