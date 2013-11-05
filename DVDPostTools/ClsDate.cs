using System;
using System.Collections.Generic;
using System.Text;

namespace PlushTools
{
    public class ClsDate
    {
        public static string formatDateDB(DateTime d)
        {
            return d.Year + "-" + d.Month + "-" + d.Day;
        }

        public static string formatDateTimeDB(DateTime d)
        {
            return d.Year + "-" + d.Month + "-" + d.Day + " " + d.Hour + ":" + d.Minute + ":" + d.Second   ;
        }
        public static string formatDate() 
        { 
         return DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day ;
        }

        public static string formatdate(DateTime d) 
        {
            return d.ToString("yyyy-MM-dd"); 
        }
    }
}
