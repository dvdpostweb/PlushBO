using System;
using System.Collections.Generic;
using System.Text;
using System.Net;

namespace PlushTools
{
    public class clsFtp
    {

        public static bool DisplayFileFromServer(string serverAdresse, string fileName, string userName, string pwd)
        {
            //string remoteUri = "http://www.dvdpost.be/images/newsletters/movies/FR/";
            //string fileName = "04.jpg"; 
            string myStringWebResource ;
            // Create a new WebClient instance.
            WebClient myWebClient = new WebClient();
            // Concatenate the domain with the Web resource filename.
            myStringWebResource = serverAdresse + fileName;
            //Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
            // Download the Web resource and save it into the current filesystem folder.
            //myWebClient.Credentials = new NetworkCredential("anonymous", "janeDoe@contoso.com");
            try
            {
                myWebClient.DownloadFile(myStringWebResource, fileName);
                return true;

            }
            catch (Exception ex )
            {

                return false;
            }
            
            //Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myStringWebResource);
            //Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + Application.StartupPath);


        }
    }
}
