using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SaberSearchAndDownload
{
    public class DownloadManager
    {
        
        public static void CreateFolder(string folder)
        {
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
        }
        
        public static string Download(string url, string fileName)
        {
            string downloadFolder = "";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                downloadFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\SaberSearchAndDownload\\";
            else
                downloadFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/SaberSearchAndDownload/";


            CreateFolder(downloadFolder);
            
            string localPath = downloadFolder + fileName + ".zip";
            
            using (var client = new WebClient())
            {
                client.DownloadFile(url, localPath);
            }

            if (!Directory.Exists(downloadFolder + fileName))
            {
                ExtractDownload(localPath, downloadFolder + fileName);
            }
            

            return downloadFolder + fileName;
        }

        public static void ExtractDownload(string zipPath, string extractPath)
        {
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}
