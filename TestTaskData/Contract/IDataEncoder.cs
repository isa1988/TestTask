namespace TestTaskData.Contract
{
    public interface IDataEncoder
    {
        /// <summary>
        /// Шифрование строки
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>каждый символ переводит в последующий символ</returns>
        string EncodeString(string str);
    }
}
