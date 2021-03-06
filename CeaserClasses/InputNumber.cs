using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeasarMessage
{
   public class InputNumber
    {
        public static int InputValidNumber()
        {
            while (true)
            {
                Console.Write("Enter decryption key as integer number:");
                Console.WriteLine();
                string keyString = Console.ReadLine();
                if (Int32.TryParse(keyString, out int key))
                {
                    return key%26;
                }
                else
                {
                    Console.WriteLine($"We can not convert input: '{keyString}' \nto an integer number, please try again");
                }
            }
        }
    }
}
