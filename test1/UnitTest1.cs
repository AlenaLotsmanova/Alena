using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TZ;


namespace test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] stroka = { "bukv", "vkub" };
            string expected = "истина";

            // получение значения с помощью тестируемого метода
            Sum g = new Sum();
            string rezult = g.Nana(stroka);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }
        [TestMethod]
        public void TestMethod2()
        {
            string[] stroka = { "вфывв", "фывфывфыцц" };
            string expected = "ложь";

            // получение значения с помощью тестируемого метода
            Sum g = new Sum();
            string rezult = g.Nana(stroka);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }
        [TestMethod]
        public void TestMethod3()
        {
            string[] stroka = { "Сфывв", "фывфывфыццс" };
            string expected = "истина";

            // получение значения с помощью тестируемого метода
            Sum g = new Sum();
            string rezult = g.Nana(stroka);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }
        [TestMethod]
        public void TestMethod4()
        {
            string[] stroka = { "Сфывв" };
            string expected = "Вы ошиблись";

            // получение значения с помощью тестируемого метода
            Sum g = new Sum();
            string rezult = g.Nana(stroka);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }
        [TestMethod]
        public void TestMethod5()
        {
            string[] stroka = {  };
            string expected = "Вы ошиблись";

            // получение значения с помощью тестируемого метода
            Sum g = new Sum();
            string rezult = g.Nana(stroka);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }
        [TestMethod]
        public void TestMethod6()
        {
            string[] stroka = {"gkjhijgfh", "hngfhjmgknmg" , "lnlknmknm" };
            string expected = "истина";

            // получение значения с помощью тестируемого метода
            Sum g = new Sum();
            string rezult = g.Nana(stroka);

            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }
    }
}
