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

            foreach (Map map in maps)
                Console.WriteLine(map);

            string search = "Imagine Dragons";

            List<Map> searchMaps = ApiManager.SearchMaps(search,0);

            foreach (Map map in searchMaps)
                Console.WriteLine(map);
        }
    }
}
