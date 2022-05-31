using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberSearchAndDownload
{
    public class FileManager
    {
        public static string[] GetFiles(string path, string searchPattern)
        {
            return System.IO.Directory.GetFiles(path, searchPattern);
        }

        public static List<string> GetLevelFiles(string[] files)
        {
            List<string> returnList = new List<string>();

            foreach (string file in files)
            {
                if (!file.Contains("Info.dat"))
                {
                    returnList.Add(file);
                }
            }
            return returnList;
        }

        public static string GetInfoDat(string path)
        {
            foreach (string item in GetFiles(path, "*.dat"))
            {
                if (item.Contains("Info.dat"))
                {
                    return item;
                }
            }

            return "No Info.dat found.";
        }
    }
}
