using System.Collections.Specialized;
using System.IO;


namespace CeasarMessage
{
    
    public static class StringCollect
    {
        public static StringCollection dictionaryCollect(string path)
        {
            StringCollection wordsDictionary = new StringCollection();

            FileStream dictionaryStream = File.OpenRead(path);
            StreamReader dictionaryReader = new StreamReader(dictionaryStream);
            do
            {
                string nextWord = (string)(dictionaryReader.ReadLine());
                wordsDictionary.Add(nextWord);


            } while (!dictionaryReader.EndOfStream);

            return wordsDictionary;
        }
        

    }
}
