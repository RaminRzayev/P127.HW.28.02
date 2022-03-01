using System;
using System.Collections.Generic;
using System.Text;

namespace P127.HW._28._02
{
   static class Extension
    {


        public static string ToCapitalize(this string str)
        {
            string result="";
            string[] arr = str.Split(" ");
            foreach (var item in arr)
            {
                item.ToLower();

                Char.ToUpper(item[0]);
                result =String.Concat(arr);

               
            }

            return result;
        }




        public static bool ToSearch(this string str, string srch)
        {

            for (int i = 0; i < str.Length; i++)
            {

                for (int j = 0; j < srch.Length; j++)
                {
                    if (str[i]==srch[j])
                    {
                        return true;
                    }
                }
            }
            return false;

        }
    }
}
