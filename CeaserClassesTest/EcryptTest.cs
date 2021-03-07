using CeasarMessage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Specialized;


namespace CeaserClassesTest
{
    [TestClass]
    public class EcryptTest
    {
        private StringCollection wordsDictionary = new StringCollection();


        private const char charToCheck = 'A';
        private const string stringToCheck = "test test test";
        private const int ecryptKey = 20;

        [TestMethod]
        public void checkCharEcryption()
        {
            var result = Ecrypt.EncryptChar(charToCheck, ecryptKey);

            Assert.AreNotEqual(result, charToCheck);

        } 
        
        [TestMethod]
        public void checkCharDecryption()
        {
            var ecryptedChar = Ecrypt.EncryptChar(charToCheck, ecryptKey);
            var result = Ecrypt.DecryptChar(ecryptedChar, ecryptKey);

            Assert.AreEqual(result, charToCheck);

        }

        [TestMethod]
        public void checkStringEcryption()
        {
            var result = Ecrypt.EncryptStringLine(stringToCheck, ecryptKey);

            Assert.AreNotEqual(result, stringToCheck);

        }
    }
}
