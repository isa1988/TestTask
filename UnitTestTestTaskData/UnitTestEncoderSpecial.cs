using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTaskData.DataModal;

namespace UnitTestTestTaskData
{
    /// <summary>
    /// Тест класса Специальный случай для определенного клиента
    /// </summary>
    [TestClass]
    public class UnitTestEncoderSpecial
    {
        /// <summary>
        /// Шифрование строки
        /// </summary>
        [TestMethod]
        public void EncodeString()
        {
            EncoderSpecial encoderSpecial = new EncoderSpecial();
            string result = encoderSpecial.EncodeString("12345абвг");
            Assert.IsNotNull(result);
            Assert.AreEqual("ceaa38c3ceb47c0e8c0cd65340d36be465ba032b", result);
        }
    }
}
