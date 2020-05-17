using System;
using System.Text;
using System.Linq;

namespace LR2
{
    internal class Program
    {
        private static void Main()
        {
            StringBuilder txt1 = new StringBuilder("");
            StringBuilder txt2 = new StringBuilder("");
            StringBuilder txt3 = new StringBuilder("");


            // Вариант 2
            Console.WriteLine("enter string(mix string) :  ");
            string str = Console.ReadLine();
            String[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            foreach (string s in words)
            {
                txt1.Append(s);
                txt1.Append(" ");
            }
            Console.WriteLine(txt1);


            // Вариант 15
            Console.WriteLine("\nenter string(change letters) :  ");
            string str2 = Console.ReadLine();
            CheckLetters(str2);
            int numb = 0;
            char[] alfavit = {
                'a', 'b', 'c', 'd',
                'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] vowel = { 'a', 'e', 'i', 'o', 'u', 'y' };
            Console.Write(str2[0]);
            for (int i = 1; i < str2.Length; i++)
            {
                if (vowel.Contains(str2[i - 1]) && !Char.IsWhiteSpace(str2[i]))
                {
                    if (str2[i] == 'z')
                    {
                        numb = 0;
                    }
                    else
                    {
                        numb = Array.IndexOf(alfavit, str2[i]) + 1;
                    }
                    txt2.Append(alfavit[numb]);
                }
                else
                {
                    txt2.Append(str2[i]);
                }
            }
            Console.WriteLine(txt2);


            // Вариант 12
            Console.WriteLine("\nEnter random string : ");
            string str3 = Console.ReadLine();
            CheckSymb(str3);
            string engl = "abcdefghijklmnopkrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            String[] stringWords = str3.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            bool check = false;
            for (int i = 0; i < stringWords.Length; i++)
            {
                for (int j = 0; j < stringWords[i].Length; j++)
                {
                    if (!engl.Contains(stringWords[i][j]))
                    {
                        txt3.Append(stringWords[i]);
                        txt3.Append(" ");
                        check = true;
                        break;
                    }
                }
            }
            if (check)
            {
                Console.Write(txt3);
            }
            else
            {
                Console.Write("There are no words with non-english letters");
            }
        }

        static void CheckLetters(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!(Char.IsLetter(str[i]) || Char.IsWhiteSpace(str[i])))
                {
                    Console.WriteLine("String should consists of English letters amd white spaces.");
                    Environment.Exit(0);
                }
            }
        }
        static void CheckSymb(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsSymbol(str[i]) || Char.IsNumber(str[i]) || Char.IsPunctuation(str[i]))
                {
                    Console.WriteLine("String should consists of letters amd white spaces.");
                    Environment.Exit(0);
                }
            }
        }
    }
}
