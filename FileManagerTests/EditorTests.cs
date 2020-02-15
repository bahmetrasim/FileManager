using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Tests
{
    [TestClass()]
    public class EditorTests
    {
        [TestMethod()]
        public void makeintlistTest()
        {
            var expected = new List<int>() { 1, 2, 3 };
            var stringtext = "1,2,3";

            var actual = new Editor().makeintlist(stringtext);
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

            //Assert.Fail();
        }

        [TestMethod()]
        public void makeintlistTest_emptystring()
        {
            var expected = new List<int>() { };
            var stringtext = " ";

            var actual = new Editor().makeintlist(stringtext);

            Assert.AreEqual(0, actual.Count);
            Assert.IsTrue(actual.Count==0);

            // Normal Class'ta Methoda sağ tıklayıp, "Create Unit Tests"
            // ilk değer beklenen değer 2.değer dönecek değer
            // Assert ile karşılaştır.
            //Assert.Fail();
            // 2 dosya 1. CSV  - 2. "/r/n" her satırda bir sayı var. 
            // 
        }
    }
}