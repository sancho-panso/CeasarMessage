using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CeasarMessage
{
    class Program
    {
        static void Main(string[] args) {

            StringCollection wordsDictionary = new StringCollection();
            wordsDictionary = StringCollect.dictionaryCollect("..\\..\\..\\englishWordsDictionary.txt");

            Console.Write("Please enter message, try use english words only:");
            Console.WriteLine();
            string inputString = Console.ReadLine();

            int ecryptKey = InputNumber.InputValidNumber();
  
            string encryptedString = Ecrypt.EncryptStringLine(inputString, ecryptKey);
            Console.WriteLine("Below is you encryted message");
            Console.WriteLine(encryptedString);
            Console.WriteLine("Press any key if you want to decrypt this message back");
            Console.ReadKey();

            bool success = false;
            for (int key = 1; key < 27; key++)
            {
                string decryptedMessage = Ecrypt.DecryptStringLine(inputString, key);
                decryptedMessage = decryptedMessage.ToLower();
                if (StringCompare.CompareStrings(decryptedMessage, wordsDictionary))
                {
                    Console.WriteLine(decryptedMessage);
                    success = true;
                }
            }
            if (!success)
            {
                Console.WriteLine("Sorry, message contains not english words \nand cannot be properly decrypted");
            }
            Console.ReadKey();
        }
    }
}
