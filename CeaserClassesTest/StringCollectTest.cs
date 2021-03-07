using CeasarMessage;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Specialized;


namespace CeaserClassesTest
{
    [TestClass]
    public class StringCollectTest
    {
        private StringCollection wordsDictionary = new StringCollection();

        [TestMethod]
        public void StringCollectionContentTypeCheck()
        {
            wordsDictionary = StringCollect.dictionaryCollect("englishWordsDictionary.txt");
            foreach (object line in wordsDictionary)
            {
                Assert.IsInstanceOfType(line, typeof(string));
            }
        }

        [TestMethod]
        public void StringCollectionLengthCheck()
        {
            int collectionLength = 370105;
            wordsDictionary = StringCollect.dictionaryCollect("englishWordsDictionary.txt");

            Assert.AreEqual(collectionLength, wordsDictionary.Count);

        }
    }
}
