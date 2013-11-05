using System;
using System.Collections.Generic;
using System.Text;

namespace PlushTools
{
    public class clsEnum
    {
        public static int getValueEnum(object en) 
        {
            return (int)en;  
        }

        public static string getValueStrEnum(object en)
        {
            return getValueEnum(en).ToString(); 
        }

        public static string getNameStrEnum(object en)
        {
            return en.ToString();
        }    

    }
}
