using System.Text;
using TestTaskData.Contract;

namespace TestTaskData.DataModal
{
    /// <summary>
    /// Оычный случай
    /// </summary>
    public class Encoder : IDataEncoder
    {
        /// <summary>
        /// Шифрование строки
        /// каждый символ переводит в последующий символ
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>зашифрованную строку</returns>
        public string EncodeString(string str)
        {
            StringBuilder res = new StringBuilder();//Исправил так так в данном случае он более подходит
            foreach (char ch in str)
            {
                char s = ch;
                s++;
                res.Append(s);
            }
            return res?.Length > 0 ? res.ToString() : string.Empty;
        }
    }
}
