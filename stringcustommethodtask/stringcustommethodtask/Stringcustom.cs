using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace stringcustommethodtask
{
    internal class StringCustom
    {
        public static int LastIndexOf(string str, char searchStr) 
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == searchStr)
                {
                    return i; 
                }
            }

            return -1;
        }

        public static string[] Split(string str, char chr)
        {
            int count = 1; 
            foreach (char c in str)
            {
                if (c == chr)
                {
                    count++;
                }
            }

            string[] parts = new string[count];
            int index = 0;
            string currentPart = "";

            
            foreach (char c in str)
            {
                if (c == chr)
                {
                    parts[index] = currentPart;
                    index++;
                    currentPart = ""; 
                }
                else
                {
                    currentPart += c; 
                }
            }

            parts[index] = currentPart;

            return parts;
        }


        public static string Replace(string str, char chr, char newchr)
        {
            string newStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == chr)
                {
                    newStr += newchr;
                }
                else
                {
                    newStr += str[i];
                }
            }

            return newStr;
        }
    }
}
