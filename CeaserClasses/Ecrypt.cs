using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeasarMessage
{
    public static class Ecrypt
    {
        

        public static char EncryptChar(char input, int key)
        {
            
            char encryptChar =(char)( input + key);
            return encryptChar;
        }

        public static char DecryptChar(char input, int key)
        {
            if (input > 'A' && input < 'Z')
                {
                    int letterAsNumber = (int)input - 'A';
                    int encryptedLetter = (letterAsNumber - key + 26)%26;
                    char decriptedChar = (char)(encryptedLetter +'A');
                    return decriptedChar;
                }

            return input;

        }

        public static string EncryptStringLine(string input, int key)
        {
            input = input.ToUpper();
            string output = "";
            for( int i = 0; i <input.Length; i++)
            {
                output = output + EncryptChar(input[i], key);
            }

            return output;
        }  
        public static string DecryptStringLine(string input, int key)
        {
            input = input.ToUpper();
            string output = "";
            for( int i = 0; i <input.Length; i++)
            {
                output = output + DecryptChar(input[i], key);
            }

            return output;
        }


    }

       
}
