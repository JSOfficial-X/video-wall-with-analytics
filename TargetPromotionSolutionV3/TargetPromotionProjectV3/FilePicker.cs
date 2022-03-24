using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TargetPromotionProjectV3
{
    class FilePicker
    {
        private string[] fullMP4FilePath;
        public string PreviousMP4RandomFile { get; set; } = null;
        private string[] fullWMVFilePath;
        public string PreviousWMVRandomFile /*{ get; set; }*/ = null;
        private string randomWMVFile;
        /// <summary>
        /// Get a random MP4 files from a folder
        /// </summary>
        /// <param name="path"></param>
        /// <returns>randomFile</returns>
        public string MP4RandomFilePicker(string path)
        {
            fullMP4FilePath = Directory.GetFiles(path, "*.mp4");
            List<string> listMP4File = new List<string>();
            if (fullMP4FilePath != null)
            {
                for (int i = 0; i < fullMP4FilePath.Length; i++)
                {
                    if (fullMP4FilePath[i] != PreviousMP4RandomFile)
                    {
                        listMP4File.Add(fullMP4FilePath[i]);
                    }

                }

            }
            var random1 = new Random();
            string randomMP4File = listMP4File[random1.Next(0, listMP4File.Count)];
            if (listMP4File.Count >1)
            {
                PreviousMP4RandomFile = randomMP4File;
            }
            listMP4File.Clear();
            return randomMP4File;
        }
        public string WMVRandomFilePicker(string path)
        {
            fullWMVFilePath = Directory.GetFiles(path, "*.wmv");
            List<string> listWMVFile = new List<string>();
            if (fullWMVFilePath != null)
            {
                for (int i = 0; i < fullWMVFilePath.Length; i++)
                {
                    if (fullWMVFilePath[i] != PreviousWMVRandomFile)
                    {
                        listWMVFile.Add(fullWMVFilePath[i]);
                    }

                }

            }
            var random2 = new Random();
            string randomWMVFile = listWMVFile[random2.Next(0, listWMVFile.Count)];
            PreviousWMVRandomFile = randomWMVFile;
            //if (listWMVFile.Count >1)
            //{
            //    PreviousWMVRandomFile = randomWMVFile;
            //}
            listWMVFile.Clear();
            return randomWMVFile;
        }

        public string WMVRandomFilePickerModified(string path)
        {
            fullWMVFilePath = Directory.GetFiles(path, "*.wmv");
            List<string> listWMVFile = new List<string>();
            if (fullWMVFilePath != null)
            {
                for (int i = 0; i < fullWMVFilePath.Length; i++)
                {
                    if (fullWMVFilePath[i] != PreviousWMVRandomFile)
                    {
                        listWMVFile.Add(fullWMVFilePath[i]);
                    }

                }

            }
            var random3 = new Random();
            int randomNumber= random3.Next(0, listWMVFile.Count+4);
            if (randomNumber>=0 && randomNumber<listWMVFile.Count)
            {
                randomWMVFile = listWMVFile[randomNumber];
                PreviousWMVRandomFile = randomWMVFile;
            }
            else if (randomNumber >=listWMVFile.Count && randomNumber < listWMVFile.Count+2)
            {
                //string randomWMVFile = listWMVFile[randomNumber];
                randomWMVFile = ProjectPath.defaultVideoPathWithHighFrequency2;
            }
            else if (randomNumber >= listWMVFile.Count+2 && randomNumber < listWMVFile.Count+4)
            {
                //string randomWMVFile = listWMVFile[randomNumber];
                randomWMVFile = ProjectPath.defaultVideoPathWithHighFrequency1;

            }
            //if (listWMVFile.Count >1)
            //{
            //PreviousWMVRandomFile = randomWMVFile;
            //}
            listWMVFile.Clear();
            return randomWMVFile;
        }
    }
}
