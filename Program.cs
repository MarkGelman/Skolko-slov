using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skolko_slov
{
    class Program
    {
        static void Main(string[] args)
        { 
            /*Вводится строка.Посчитать количество слов в строке. Слова разделяются одним или несколькими пробелами.

            Начальные данные: строка текста.
            Вывод результата: 1 число - количество слов.

            Полезные ссылки: Метод Split()*/
        {
            char[] charSeparators = new char[] { ' ' };
            string[] s = Console.ReadLine().Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(s.Length);
        }
    }
}
