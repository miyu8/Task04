using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculator
{
    [Serializable()]
    public class Exception2 : Exception
    {
        public Exception2() : base() { }
        public Exception2(string message) : base(message) { }
        public Exception2(string message, System.Exception inner) : base(message, inner) { }
        protected Exception2(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context)
        { }
    }
    public class Calculator
    {
        public double Add(string numbers)
        {
            Regex regex = new Regex(@"^[+-]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))[,]{1}[+-]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))$");
            if (regex.IsMatch(numbers))
            {
                double summa, chislo;
                summa = chislo = 0;
                foreach (string s in Regex.Split(numbers, ","))
                {
                    double.TryParse(s.Replace('.', ','), out chislo);
                    summa += chislo;
                }
                return summa;
            }
            else        
                throw new Exception2();
        }
        public double Add()
        {
            Regex regex = new Regex(@"^[+-]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))[,]{1}[+-]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))$");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            if (regex.IsMatch(str))
            {
                double summa, chislo;
                summa = chislo = 0;
                foreach (string s in Regex.Split(str, ","))
                {
                    double.TryParse(s.Replace('.', ','), out chislo);
                    summa += chislo;
                }
                return summa;
            }
            else
                throw new Exception2();
        }
        public double Add2(string numbers)
        {
            Regex regex = new Regex(@"^([+-]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))[,]{1})+[+-]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))$");
            if (regex.IsMatch(numbers))
            {
                double summa, chislo;
                summa = chislo = 0;
                foreach (string s in Regex.Split(numbers, ","))
                {
                    double.TryParse(s.Replace('.', ','), out chislo);
                    summa += chislo;
                }
                return summa;
            }
            else
                throw new Exception2();
        }
        public double Add2()
        {
            Regex regex = new Regex(@"^([+-]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))[,]{1})+[+-]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))$");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            if (regex.IsMatch(str))
            {
                double summa, chislo;
                summa = chislo = 0;
                foreach (string s in Regex.Split(str, ","))
                {
                    double.TryParse(s.Replace('.', ','), out chislo);
                    summa += chislo;
                }
                return summa;
            }
            else
                throw new Exception2();
        }
        public double Add3(string numbers)
        {
            Regex regex = new Regex(@"^([+-]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))[\,\#\@\$\%\! ]{1})+[+-]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))$");
            if (regex.IsMatch(numbers))
            {
                double summa, chislo;
                summa = chislo = 0;
                foreach (string s in Regex.Split(numbers, @"[\,\#\@\$\%\! ]"))
                {
                    double.TryParse(s.Replace('.', ','), out chislo);
                    summa += chislo;
                }
                return summa;
            }
            else
                throw new Exception2();
        }
        public double Add3()
        {
            Regex regex = new Regex(@"^([+-]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))[\,\#\@\$\%\! ]{1})+[+-]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))$");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            if (regex.IsMatch(str))
            {
                double summa, chislo;
                summa = chislo = 0;
                foreach (string s in Regex.Split(str, @"[\,\#\@\$\%\! ]"))
                {
                    double.TryParse(s.Replace('.', ','), out chislo);
                    summa += chislo;
                }
                return summa;
            }
            else
                throw new Exception2();
        }
        public double Add4(string numbers)
        {
            Regex regex = new Regex(@"^([+]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))[\,\#\@\$\%\! ]{1})+[+]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))$");
            if (regex.IsMatch(numbers))
            {
                double summa, chislo;
                summa = chislo = 0;
                foreach (string s in Regex.Split(numbers, @"[\,\#\@\$\%\! ]"))
                {
                    double.TryParse(s.Replace('.', ','), out chislo);
                    summa += chislo;
                }
                return summa;
            }
            else
                throw new Exception2();
        }
        public double Add4()
        {
            Regex regex = new Regex(@"^([+]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))[\,\#\@\$\%\! ]{1})+[+]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))$");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            if (regex.IsMatch(str))
            {
                double summa, chislo;
                summa = chislo = 0;
                foreach (string s in Regex.Split(str, @"[\,\#\@\$\%\! ]"))
                {
                    double.TryParse(s.Replace('.', ','), out chislo);
                    summa += chislo;
                }
                return summa;
            }
            else
                throw new Exception2();
        }
        public double Add5(string numbers)
        {
            Regex regex = new Regex(@"^([+]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))[\,\#\@\$\%\! ]+)+[+]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))$");
            if (regex.IsMatch(numbers))
            {
                double summa, chislo;
                summa = chislo = 0;
                foreach (string s in Regex.Split(numbers, @"[\,\#\@\$\%\! ]+"))
                {
                    double.TryParse(s.Replace('.', ','), out chislo);
                    summa += chislo;
                }
                return summa;
            }
            else
                throw new Exception2();
        }
        public double Add5()
        {
            Regex regex = new Regex(@"^([+]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))[\,\#\@\$\%\! ]+)+[+]?((\d+)|(\d+\.?\d*)|(\d\.?\d*E[+-]?\d+))$");
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            if (regex.IsMatch(str))
            {
                double summa, chislo;
                summa = chislo = 0;
                foreach (string s in Regex.Split(str, @"[\,\#\@\$\%\! ]+"))
                {
                    double.TryParse(s.Replace('.', ','), out chislo);
                    summa += chislo;
                }
                return summa;
            }
            else
                throw new Exception2();
        }
    }
}