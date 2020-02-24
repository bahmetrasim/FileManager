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
            var stringtext = new string[] { "1,2,3" };

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
            var stringtext = new string[] { " " };

            var actual = new Editor().makeintlist(stringtext);

            Assert.AreEqual(0, actual.Count);
            Assert.IsTrue(actual.Count == 0);

            // Normal Class'ta Methoda sağ tıklayıp, "Create Unit Tests"
            // ilk değer beklenen değer 2.değer dönecek değer
            // Assert ile karşılaştır.
            //Assert.Fail();
            // 2 dosya 1. CSV  - 2. "/r/n" her satırda bir sayı var. 
            // 
        }

        [TestMethod()]
        public void finding_seperatorsTest_withlinebreak()
        {
            var expected = new char[] { '\r', '\n' };
            var stringtext = "43\r\n21";

            var actual = new Editor().finding_seperators(stringtext);
            //Assert.AreEqual(actual, expected); - Sor Debugda ok ama test fail
            Assert.IsTrue(actual.Length == expected.Length);
            Assert.AreEqual(actual[0], expected[0]);
        }

        [TestMethod()]
        public void finding_seperatorsTest_commaand()
        {
            var expected = new char[] { ',', '&' };
            var stringtext = "43,&21";

            var actual = new Editor().finding_seperators(stringtext);
            //Assert.AreEqual(actual, expected); - Sor Debugda ok ama test fail
            Assert.AreEqual(actual[0], expected[0]);
            Assert.AreEqual(actual[1], expected[1]);
        }

        [TestMethod()]
        public void finaltextTest_with_questionmark()
        {

            var seperators = new char[] { '?' };
            var sorted = new List<int> { 2, 7, 8, 56, 435 };
            var expected = "2?7?8?56?435";

            var actual = new Editor().finaltext(sorted,seperators);
            //Assert.AreEqual(actual, expected); - Sor Debugda ok ama test fail
            Assert.AreEqual(expected,actual);
            //Assert.AreSame(expected, actual) - Farkı ne? fail

        }
    }
}