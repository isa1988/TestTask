using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTaskData.DataModal;

namespace UnitTestTestTaskData
{
    /// <summary>
    /// Тест класса Оычный случай
    /// </summary>
    [TestClass]
    public class UnitTestEncoder
    {
        /// <summary>
        /// Шифрование строки
        /// </summary>
        [TestMethod]
        public void EncodeString()
        {
            Encoder encoder = new Encoder();
            string result = encoder.EncodeString("12345абвг");
            Assert.IsNotNull(result);
            Assert.AreEqual("23456бвгд", result);
        }
    }
}
