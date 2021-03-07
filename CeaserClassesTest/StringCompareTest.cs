using CeasarMessage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Specialized;


namespace CeaserClassesTest
{
    [TestClass]
    public class StringCompareTest
    {
        private StringCollection wordsDictionary = new StringCollection();
        private const string stringToCheck = "test test test";
        private const int ecryptKey = 20;

        [TestMethod]
        public void checkStringCompare()
        {
            wordsDictionary = StringCollect.dictionaryCollect("englishWordsDictionary.txt");
            var ecryptedString = Ecrypt.EncryptStringLine(stringToCheck, ecryptKey);
            for (int key = 1; key < 27; key++)
            {
                string decryptedMessage = Ecrypt.DecryptStringLine(ecryptedString, key);
                decryptedMessage = decryptedMessage.ToLower();
                if (StringCompare.CompareStrings(decryptedMessage, wordsDictionary))
                {
                    Assert.AreEqual(decryptedMessage, stringToCheck);
                }
            }
        }
    }
}
