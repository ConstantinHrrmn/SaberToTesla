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
        
        public static List<Map> GetLatestMaps()
        {
            string url = MAPS_URL + "latest";
            WebClient client = new WebClient();
            var json = client.DownloadString(url);
            dynamic maps = JsonConvert.DeserializeObject(json);

            Console.WriteLine(maps.docs[0].id);

            return null;
        }

    }
}
