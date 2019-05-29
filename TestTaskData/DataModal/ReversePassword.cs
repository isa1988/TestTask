using System.Text;
using TestTaskData.Contract;

namespace TestTaskData.DataModal
{
    /// <summary>
    /// Reverse  строки
    /// </summary>
    public class ReversePassword
    {
        /// <summary>
        /// Метод для Reverse  строки
        /// </summary>
        /// <param name="value">Строка</param>
        /// <returns>Reverse  строки</returns>
        public string GetLineReverse(string value)
        {
            StringBuilder retVal = new StringBuilder();

            for (int i = value.Length - 1; i >= 0; i--)
                retVal.Append(value[i].ToString());

            return retVal.Length > 0 ? retVal.ToString() : string.Empty;
        }
    }
}
