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
            
            //Console.Write("Please enter intput file name");
            //Console.WriteLine();
            //string inputName = Console.ReadLine();

        
            //Console.Write("Please enter output file name");
            //Console.WriteLine();
            //string outputName = Console.ReadLine();

            string messagePath = "C:\\Users\\Michail\\source\\repos\\" +
                "CeasarMessage\\CeasarMessage";

            //wordsDictionary = StringCollect.dictionaryCollect(messagePath, "englishWordsDictionary.txt");
            wordsDictionary = StringCollect.dictionaryCollect(".\\englishWordsDictionary.txt");
            

            FileStream messageStream = File.OpenRead(Path.Combine(messagePath, "inputMessage.txt"));
            StreamReader messageReader = new StreamReader(messageStream);
            string message = (string)(messageReader.ReadLine());
            for(int key = 1; key < 27; key++)
            {
                string decryptedMessage = Ecrypt.DecryptStringLine(message, key);
                decryptedMessage = decryptedMessage.ToLower();
                if(StringCompare.CompareStrings(decryptedMessage,wordsDictionary)) Console.WriteLine(decryptedMessage);

               // Console.WriteLine(StringCompare.CompareStrings(decryptedMessage,wordsDictionary));

            }
           

            Console.ReadKey();

        }
    }
}
