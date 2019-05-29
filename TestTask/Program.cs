using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTaskData.Contract;
using TestTaskData.DataModal;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1 работа с Reverse со строкой введите строку");
            string line = Console.ReadLine();
            Console.Write("Ответ  ");
            Console.WriteLine(new ReversePassword().GetLineReverse(line));
            Console.WriteLine(new String('-', 50));
            Console.WriteLine("Задание 2");
            IDataEncoder encoder = null;
            Console.WriteLine("Вы хотите зашифровать пароль в SHA1? Д/Н");
            line = Console.ReadLine();
            if (line.ToUpper() == "Н") encoder = new TestTaskData.DataModal.Encoder();
            else encoder = new EncoderSpecial();
            Console.WriteLine("Введите строку для шифрования");
            line = Console.ReadLine();
            Console.WriteLine("зашфированная строка:");
            Console.WriteLine(encoder.EncodeString(line));
            Console.ReadLine();
        }
    }
}
