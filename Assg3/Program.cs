using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assg3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ssize;
            int size;

            start: Console.Write("input the size of the integer sequence:");
            ssize = Console.ReadLine();
            while (!isnumeric(ssize))
            {
                Console.Write("Your input is invalid,please input again.");
                ssize = Console.ReadLine();
            }
            size = int.Parse(ssize);
            int[] numbers = new int[size];

            Console.WriteLine("\ninput the numbers in an integer sequence one by one(one number per line).");
            int notnumber = 1;
            string snum;
            while (notnumber == 1)
            {
                int i;
                for(i = 0; i < size; i++)
                {
                   snum = Console.ReadLine();
                    if (!isint(snum))
                    {
                        Console.WriteLine(" \nThe input is invalid, please input the whole integer sequence again.");
                        break;
                    }
                    numbers[i] = int.Parse(snum);
                }
                if(i == size)
                    notnumber = 0;
            }

            int sort;
            Console.Write("\n\nsort the integer sequence in ascending (by entering “A”) or descending order (by entering “D”):");
            sort = Console.Read();
           
            while((sort!='A')&&(sort != 'D'))
            {
                Console.WriteLine(" enter neither “A” nor “D”, please input again. ");
                Console.ReadLine();
                sort = Console.Read();
            }
            if (sort == 'A')
                ascendingsort(numbers);
            else
            {
                ascendingsort(numbers);
                swap(ref numbers);
            }
            Console.WriteLine("the sorted sequence:");
            printarray(numbers);

            int continuesort;
            Console.Write("continue to sort another integer sequence ? (entering “Y” or “N”):");
            Console.ReadLine();
            continuesort = Console.Read();
            while ((continuesort != 'Y') && (continuesort != 'N'))
            {
                Console.WriteLine(" enter neither “Y” nor “N”, please input again. ");
                Console.ReadLine();
                continuesort = Console.Read();
            }
            if (continuesort == 'Y')
            {
                Console.WriteLine(" \n\r");
                Console.ReadLine();
                goto start;
            }
            
        }
        private static bool isnumeric(string str)
        {
            if (str.Length == 0)
                return false;
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] < 48 || ch[i] > 57)
                    return false;
            }
            return true;
        }

        private static bool isint(string str)
        {
            if (str.Length == 0)
                return false;
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if ((ch[i] < 48 || ch[i] > 57)&&(ch[i] != '-'))
                    return false;
            }
            return true;
        }

        private static void ascendingsort(int[] a)
        {
            int i,j,temp;
            for(i = 0; i < a.Length - 1; i++)
                for(j = i+1; j < a.Length; j++)
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
        }

        private static void swap (ref int[] a)
        {
            int[] b = new int[a.Length];
            for(int i = 0; i < a.Length; i++)
                b[a.Length - 1 - i] = a[i];
            a = b;
        }

        private static void printarray(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
                Console.WriteLine("{0,4}", a[i]);
            Console.WriteLine();
        }
    }
}
