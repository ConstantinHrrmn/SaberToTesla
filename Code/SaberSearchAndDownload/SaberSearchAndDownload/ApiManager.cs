using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Dynamic;
using Newtonsoft.Json.Converters;

namespace SaberSearchAndDownload
{
    public class ApiManager
    {
        private const string BASE_URL = "https://api.beatsaver.com/";
        private const string MAPS_URL = BASE_URL + "maps/";
        
        /// <summary>
        /// Get the last 20 maps from the server
        /// </summary>
        /// <returns>A list of Maps</returns>
        public static List<Map> GetLatestMaps()
        {
            string url = MAPS_URL + "latest?sort=LAST_PUBLISHED";
            WebClient client = new WebClient();
            var json = client.DownloadString(url);
            dynamic maps = JsonConvert.DeserializeObject(json);

            List<Map> mapList = new List<Map>();

            if (maps.docs.Count > 0)
            {
                for (int i = 0; i < maps.docs.Count; i++)
                {
                    Map map = new Map();
                    map.Id = maps.docs[i].id;
                    map.Name = maps.docs[i].name;
                    map.Description = maps.docs[i].description;

                    map.DownloadPath = maps.docs[i].versions[0].downloadURL;
                    map.ImagePath = maps.docs[i].versions[0].coverURL;
                    map.SongPath = maps.docs[i].versions[0].previewURL;

                    mapList.Add(map);
                }

                return mapList;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Search for maps depending on the search term
        /// </summary>
        /// <param name="search">Search term to match</param>
        /// <param name="page">The page to download</param>
        /// <returns>The list of maps that corresponds to the search terms</returns>
        public static List<Map> SearchMaps(string search, int page)
        {
            search = search.Replace(" ", "%20");
            string url = BASE_URL + "search/text/"+page+"?q="+search+"&sortOrder=Latest";
            WebClient client = new WebClient();
            var json = client.DownloadString(url);
            dynamic maps = JsonConvert.DeserializeObject(json);

            List<Map> mapList = new List<Map>();

            if (maps.docs.Count > 0)
            {
                for (int i = 0; i < maps.docs.Count; i++)
                {
                    Map map = new Map();
                    map.Id = maps.docs[i].id;
                    map.Name = maps.docs[i].name;
                    map.Description = maps.docs[i].description;

                    map.DownloadPath = maps.docs[i].versions[0].downloadURL;
                    map.ImagePath = maps.docs[i].versions[0].coverURL;
                    map.SongPath = maps.docs[i].versions[0].previewURL;

                    mapList.Add(map);
                }

                return mapList;
            }
            else
            {
                return null;
            }
        }

    }
}
