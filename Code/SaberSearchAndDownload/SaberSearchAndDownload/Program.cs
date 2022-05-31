using System;
using System.Collections.Generic;

namespace SaberSearchAndDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Map> maps = ApiManager.GetLatestMaps();

            //foreach (Map map in maps)
            //    Console.WriteLine(map);

            string search = "Imagine Dragons";

            List<Map> searchMaps = ApiManager.SearchMaps(search,0);

            //foreach (Map map in searchMaps)
            //    Console.WriteLine(map);

            Console.WriteLine(maps[0].DownloadPath);

            string path = DownloadManager.Download(maps[0].DownloadPath, maps[0].Id);

            foreach (string item in FileManager.GetFiles(path, "*.dat"))
            {
                Console.WriteLine(item);
            }

        }
    }
}
