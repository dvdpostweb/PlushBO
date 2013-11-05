using System;
using System.Collections.Generic;
using System.Text;

namespace PlushTools
{
    public class ClsPrice
    {
        public static string FormatPrice(decimal result)
        {
            return FormatPrice(result.ToString());  

        }

        public static string castPriceDbToPriceBatch(decimal result)
        {
            return castPriceDbToPriceBatch(result.ToString());
        }

        //public static string castPriceBatchToPriceDb(string result) 
        //{
        //    Double dec;

        //    dec = Double.Parse(result, System.Globalization.NumberStyles.AllowDecimalPoint);
        //    dec = dec / 100;

        //    result = dec.ToString("#0.00");

        //    return FormatPrice(result);
        
        //}

        public static string FormatPrice(string  result)
        {
            return result.Replace(",", ".");
        
        }

        public static string castPriceDbToPriceBatch(string result)
        {
            //return result.Replace(".", ""); 

            result = result.Replace(".", ",");
            Double dec ;
            dec = Double.Parse(result, System.Globalization.NumberStyles.AllowDecimalPoint);
            dec = dec * 100;
         
            return dec.ToString("0");

        }
    }
}
