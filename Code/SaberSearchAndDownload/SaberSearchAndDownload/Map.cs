using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaberSearchAndDownload
{
    public class Map
    {
        private string id;
        private string name;
        private string description;
        private string imagePath;
        private string songPath;
        private string downloadPath;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public string SongPath { get => songPath; set => songPath = value; }
        public string DownloadPath { get => downloadPath; set => downloadPath = value; }

        public Map(string id, string name, string description, string imagePath, string songPath, string downloadPath)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.imagePath = imagePath;
            this.songPath = songPath;
            this.downloadPath = downloadPath;
        }

        public Map() { }

        public override string ToString()
        {
            return name;
        }
    }
}
