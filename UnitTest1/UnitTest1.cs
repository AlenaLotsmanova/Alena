using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TZ;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Буквы_не_совпадают()
        {
            string[] stroka = { "вфывв", "фывфывфыцц" };
            bool expected = false;
            // получение значения с помощью тестируемого метода
            Program f = new Program();
            bool rezult = f.razdelenie(stroka);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }
        [TestMethod]
        public void Буквы_совпадают()
        {
            string[] stroka = { "Сфывв", "фывфывфыццс" };
            bool expected = true;
            // получение значения с помощью тестируемого метода
            Program f = new Program();
            bool rezult = f.razdelenie(stroka);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }
        [TestMethod]
        public void Ввод_одного_слова()
        {
            string[] stroka = { "Сфывв" };
            bool expected = false;
            // получение значения с помощью тестируемого метода
            Program f = new Program();
            bool rezult = f.razdelenie(stroka);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }
        [TestMethod]
        public void Не_ввели_слова()
        {
            string[] stroka = { };
            bool expected = false;
            // получение значения с помощью тестируемого метода
            Program f = new Program();
            bool rezult = f.razdelenie(stroka);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);
            

        }
        [TestMethod]
        public void Ввели_более_двух_слов_и_буквы_совпадают()
        {
            string[] stroka = { "gkjhijgfh", "hngfhjmgknmg", "lnlknmknm" };
            bool expected = true;
            // получение значения с помощью тестируемого метода
            Program f = new Program();
            bool rezult = f.razdelenie(stroka);
            // сравнение ожидаемого результата с полученным
            Assert.AreEqual(expected, rezult);

        }
    }
}
