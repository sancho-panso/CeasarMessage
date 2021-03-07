using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeasarMessage
{
    public class StringCompare
    {
        public static bool CompareStrings(string input, StringCollection words)
        {
            string[] inputs = input.Split(' ');
            
            for (int index = 0; index < inputs.Length; index++)
            {
                if (!words.Contains(inputs[index])) return false;
               
            }

            return true;
            
        }
    }
}
