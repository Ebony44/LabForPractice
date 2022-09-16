using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabForPractice.Fiddling
{
    class FTPUpload
    {
        string savedLogsFolderPath = @"C:/Users/Wooriline/AppData/LocalLow/MangoSoft/Indoplay";
        string userID = "draste02";

        //public bool UploadLogFiles()
        //{
        //    // savedLogsFolderPath = Application.dataPath + "/CommonPrefabs/Scripts/PacketTracker/";



        //    var di = new DirectoryInfo(savedLogsFolderPath);
        //    var files = di.GetFiles();

        //    // var userIDForFolderName = cGlobalInfos.GetLoginID();


        //    MakeFTPDir(urlForFTPServer, userID, ftpUser, ftpPassword, null);
        //    // MakeFTPDir(urlForFTPServer, userID, ftpUser, ftpPassword, null);
        //    if (files.Length <= 0)
        //    {
        //        Debug.LogError("there is no log files");
        //        return false;
        //    }

        //    foreach (var file in files)
        //    {
        //        if (!file.Name.Contains(".bin") || file.Name.Contains(".meta") || !file.Name.Contains(userID))
        //        {
        //            continue;
        //        }
        //        // Debug.Log(file.FullName);
        //        // Debug.Log(file.Name);
        //        UploadLogFilesToFTPServer(file.FullName, file.Name);
        //    }

        //    return true;

        //}

    }
}
