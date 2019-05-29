using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTaskData.DataModal;


namespace UnitTestTestTaskData
{
    /// <summary>
    /// Тест класса Reverse  строки
    /// </summary>
    [TestClass]
    public class UnitTestReversePassword
    {
        /// <summary>
        /// Метод для Reverse  строки
        /// </summary>
        [TestMethod]
        public void EncodeString()
        {
            ReversePassword reversePassword = new ReversePassword();
            string result = reversePassword.GetLineReverse("12345абвг");
            Assert.IsNotNull(result);
            Assert.AreEqual("гвба54321", result);
        }
    }
}
