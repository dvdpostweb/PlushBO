using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace PlushTools
{
    public class clsFile
    {
        public static Boolean WriteFileAppend (String path, string flux)
        {
            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            string[] listResult = flux.Split("\n".ToCharArray());

            StreamWriter s = new StreamWriter(fs);

            foreach (string strline in listResult)
            {
                s.WriteLine(strline);
            }


            s.Close();
            return true;
        }

        public static Boolean WriteFileNoExist(String path, string flux)
        {
            if (File.Exists(path)) {
                return false;
            } 
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            string[] listResult = flux.Split("\n".ToCharArray());

            StreamWriter s = new StreamWriter(fs);

            foreach (string strline in listResult)
            {
                s.WriteLine(strline);
            }


            s.Close();
            return true;
        }
        public static Boolean WriteFile(String path,string flux)
        {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            string[] listResult = flux.Split("\n".ToCharArray());
         
            StreamWriter s = new StreamWriter(fs);
         
            foreach (string strline in listResult)
            {
                s.WriteLine(strline);
            }
                       
         
            s.Close();
            return true; 
        }

        public static List<string> LoadFileTxt(string path) 
        {            
               
            if (File.Exists(path)) 
            {
                return openFile(path);
            }

            else
            {
                return null;
            }
          
                  
        
        } 

         public static List<string> openFile(string path) 
        {
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            List<string> ListResult = new List<string>();
            StreamReader s = new StreamReader(fs);

            s.BaseStream.Seek(0, SeekOrigin.Begin);
            while (s.Peek() > -1)
            {
                ListResult.Add(s.ReadLine()); 
            }
            s.Close();

            return ListResult; 
        } 



    }
    
}
