using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MethodsThirdQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача, создать метод, принимающий текст. 
            //Результатом работы метода должен быть новый текст, в котором 
            //удалены все кратные рядом стоящие символы оставив по одному.
            //ПРИМЕР: "ХХХХООООРРРРООООШШШИИИЙЙЙЙ ДДДДЕЕЕЕНННЬЬЬ"
            //ОТВЕТ: "ХОРОШИЙ ДЕНЬ"

            string text = "ХХХХООООРРРООООШШШИИИЙЙЙЙ ДДДДЕЕЕЕНННЬЬЬ";
            Console.WriteLine(text);

            string textSort = SortText(text);

            Console.WriteLine(textSort);

            Console.ReadKey();
        }
        
        /// <summary>
        /// Метод, принимающий текст(string), возвращающий строковую переменную в нижнем регистре, в которой удалены кратные рядом стоящие символы.
        /// В случае если строка оказалась пустой, возвращает пустую строку.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string SortText(string text)
        {
            if (text == "")
            {
                return text;
            }

            string textSort = text.ToLower();
            int row = text.Length - 1;

            string resultText = "";
            resultText += textSort[0];

            for (int i = 0; i < row; i++)
            {
                if (textSort[i] != textSort[i + 1])
                {
                    resultText += textSort[i + 1];
                }
            }

            return resultText;
        }
    }
}
