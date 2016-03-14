using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculator
{
    public class Calculator
    {
        public int? Add(string numbers)

        {
            Regex regex = new Regex(@"^\d+[,]?\d+$");
            if (regex.IsMatch(numbers))
            {
                MatchCollection match = Regex.Matches(numbers, @"\d+");
                Console.WriteLine("Исходная строка:\n\n{0}\n\nСумма:\n", numbers);
                int summa, chislo;
                summa = chislo = 0;
                foreach (Match MassivNumbers in match)
                {
                    int.TryParse(MassivNumbers.Value, out chislo);
                    summa += chislo;

                }
                Console.WriteLine(summa);
                return summa;
            }
            else
            {
                Console.WriteLine("Введите два числа через запятую!");
                return null;
            }
        }

        public int? Add2(string numbers)

        {
            Regex regex = new Regex(@"^(\d+[,]?)+\d+$");
            if (regex.IsMatch(numbers))
            {
                MatchCollection match = Regex.Matches(numbers, @"\d+");
                Console.WriteLine("Исходная строка:\n\n{0}\n\nСумма:\n", numbers);
                int summa, chislo;
                summa = chislo = 0;
                foreach (Match MassivNumbers in match)
                {
                    int.TryParse(MassivNumbers.Value, out chislo);
                    summa += chislo;

                }
                Console.WriteLine(summa);
                return summa;
            }
            else
            {
                Console.WriteLine("Введите не менее двух чисел через запятую!");
                return null;
            }
        }
        public int? Add3(string numbers)

        {
            Regex regex = new Regex(@"^(\d+\D?)+\d+$");
            if (regex.IsMatch(numbers))
            {
                MatchCollection match = Regex.Matches(numbers, @"\d+");
                Console.WriteLine("Исходная строка:\n\n{0}\n\nСумма:\n", numbers);
                int summa, chislo;
                summa = chislo = 0;
                foreach (Match MassivNumbers in match)
                {
                    int.TryParse(MassivNumbers.Value, out chislo);
                    summa += chislo;

                }
                Console.WriteLine(summa);
                return summa;
            }
            else
            {
                Console.WriteLine("Введите не менее двух чисел!");
                return null;
            }
        }

        public int? Add4(string numbers)
        {
            Regex regex = new Regex(@"^(\d+[^\d\-]?)+\d+$");
            if (regex.IsMatch(numbers))
            {
                MatchCollection match = Regex.Matches(numbers, @"\d+");
                Console.WriteLine("Исходная строка:\n\n{0}\n\nСумма:\n", numbers);
                int summa, chislo;
                summa = chislo = 0;
                foreach (Match MassivNumbers in match)
                {
                    int.TryParse(MassivNumbers.Value, out chislo);
                    summa += chislo;

                }
                Console.WriteLine(summa);
                return summa;
            }
            else
            {
                Console.WriteLine("Введите не менее двух чисел без минусов!");
                return null;
            }
        }

        public int? Add5(string numbers)
        {
            Regex regex = new Regex(@"^(\d+\D*(?<![\-]))+\d+$");
            if (regex.IsMatch(numbers))
            {
                MatchCollection match = Regex.Matches(numbers, @"\d+");
                Console.WriteLine("Исходная строка:\n\n{0}\n\nСумма:\n", numbers);
                int summa, chislo;
                summa = chislo = 0;
                foreach (Match MassivNumbers in match)
                {
                    int.TryParse(MassivNumbers.Value, out chislo);
                    summa += chislo;

                }
                Console.WriteLine(summa);
                return summa;
            }
            else
            {
                Console.WriteLine("Введите не менее двух чисел без минусов с любым числом разделителей между ними!");
                return null;
            }
        }
    }
}
