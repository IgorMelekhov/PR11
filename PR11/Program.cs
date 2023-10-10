//Практическая работа номер 11
//Выполнил Мелехов Игорь
//Проверка слова на повторяющиеся символы 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PR11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Title = "Практическая работа номер 11";
                Console.Clear();
                Console.Write("Здравствуйте\nВведите Y чтобы продолжить или N чтобы выйти ");
                bool flag = false;
                string select_key = Console.ReadLine();
                switch (select_key)
                {
                    case "Y":
                        try
                        {
                            try
                            {
                                Console.WriteLine("Практическая работа номер 11");
                                string s1;
                                Console.Write("Введите, пожалуйста, слово ");
                                s1 = Console.ReadLine();
                                if (s1 == string.Empty)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Пожалуйста, введите какое нибудь слово");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                for (int i = 0; i < s1.Length; i++)
                                {
                                    if (char.IsUpper(s1[i]))//Проверяет на наличие верхнего регистра
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Введите, пожалуйста, слово без больших букв");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        flag = true;
                                    }
                                }
                                if (flag == true) continue;
                                string result = string.Empty;//Изначальное нолевое значение
                                for (int i = 0; i < s1.Length; i++)
                                {
                                    if (!result.Contains(s1[i]))//Проверяет , присутсвует ли эта буква в s1, если да, то в результат не выводит
                                    {
                                        result += s1[i];
                                    }
                                }
                                Console.WriteLine(result);  
                                Thread.Sleep(3000);
                            }
                            catch (FormatException fe)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(fe.Message);
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(ex.Message);
                        }
                        Console.ReadLine();
                        break;
                    case "N":
                        Console.WriteLine("До свидания");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
