using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter a String = ");
            string a = Console.ReadLine();
            int temp = a.Length - 1;
            string reversal="";
            while (temp >= 0)
            {
                reversal = reversal + a[temp];
                temp--;
            }
            Console.Write("Before = ");
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine(a);
            Console.ForegroundColor=ConsoleColor.White;
            Console.Write("After = ");
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine(reversal);
            Console.ReadLine();



            //reverse();


            //reverseSentence();


        }

        public static void reverseSentence()
        {
            Console.WriteLine("Enter the String:");

            string s = Console.ReadLine();

            string[] a = s.Split(' ');

            Array.Reverse(a);

            Console.WriteLine("Reverse String is:");

            for (int i = 0; i <= a.Length - 1; i++)
            {
                Console.Write(a[i] + "" + ' ');
            }

            Console.ReadKey();
        }

        public static void reverse()
        {
            string inp = "hai how are you?";
            StringBuilder strb = new StringBuilder();
            List<char> charlist = new List<char>();
            for (int c = 0; c < inp.Length; c++)
            {

                if (inp[c] == ' ' || c == inp.Length - 1)
                {
                    if (c == inp.Length - 1)
                        charlist.Add(inp[c]);
                    for (int i = charlist.Count - 1; i >= 0; i--)
                        strb.Append(charlist[i]);

                    strb.Append(' ');
                    charlist = new List<char>();
                }
                else
                    charlist.Add(inp[c]);
            }
            string output = strb.ToString();
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
