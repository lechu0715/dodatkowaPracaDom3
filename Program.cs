using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porównywanieLiczb
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Zadanie 3:
                -Stwórz metodę, które przyjmuje 2 argumenty typu int (num1, oraz num2) i zwraca true jeżeli jakaś cyfra powtarza się 3 razy z rzędu (jedna za drugą) w liczbie num1 i ta sama cyfra powtarza się 2 razy z rzędu (jedna za drugą) w liczbie num2.
                
                Przykład
                -Dla parametrów 12777121 oraz 771231 zostanie zwrócone 'true'
                -Dla parametrów 92727121 oraz 871231 zostanie zwrócone 'false'
                -Dla parametrów 3252111 oraz 14137117 zostanie zwrócone 'true'
                -Dla parametrów 2121212121 oraz 131313 zostanie zwrócone 'false'
            */

            Console.WriteLine("Podaj 2 liczby aby je porównać.\nPodaj pierwszą liczbę:");

            var number1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("podaj druga liczbę:");

            var number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(CompareNumbers(number1, number2));
            Console.ReadLine();

        }

        public static bool CompareNumbers(int value1, int value2)
        {

            string text1 = value1.ToString();
            string text2 = value2.ToString();
            
            if (text1.Length < 3 || text2.Length < 2)
            {
                return false;
            }

            char[] signs1 = text1.ToCharArray();
            char[] signs2 = text2.ToCharArray();

            List<int> firstNumbers = new List<int>();
            List<int> secondNumbers = new List<int>();

            
            int z = 0;
            int k = 0;
            while (k < text1.Length - 2)
            {
                int l = k + 1;
                int m = l + 1;

                int a = int.Parse(signs1[k].ToString());
                int b = int.Parse(signs1[l].ToString());
                int c = int.Parse(signs1[m].ToString());

                if (a == b && b == c)
                {
                    firstNumbers.Add(c);
                    z++;
                }

                k++;
            }


            int x = 0;
            int n = 0;

            
            while (n < text2.Length - 1)
            {
                int o = n + 1;

                int d = int.Parse(signs2[n].ToString());
                int e = int.Parse(signs2[o].ToString());

                if (d == e)
                {
                    secondNumbers.Add(d);
                    x++;
                }

                n++;
            }

            bool finish = false;

            foreach (int item in firstNumbers)
            {
                foreach (var item1 in secondNumbers)
                {
                    if (item == item1)
                    {
                        finish = true;
                        break;
                    }
                }

            }

            if (finish)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
