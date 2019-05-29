using System.Text;
using TestTaskData.Contract;

namespace TestTaskData.DataModal
{
    /// <summary>
    /// Специальный случай для определенного клиента
    /// </summary>
    public class EncoderSpecial : IDataEncoder
    {
        /// <summary>
        /// Шифрование строки в SHA-1
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>зашифрованную строку</returns>
        public string EncodeString(string str)
        {
            byte[] hash;
            using (var sha1 = new System.Security.Cryptography.SHA1CryptoServiceProvider())
            {
                hash = sha1.ComputeHash(Encoding.Unicode.GetBytes(str));
            }

            var sb = new StringBuilder();
            foreach (byte b in hash) sb.AppendFormat("{0:x2}", b);
            return sb.ToString();
        }
    }
}
