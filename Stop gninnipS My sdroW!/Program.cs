using System;
using System.Linq;

namespace Stop_gninnipS_My_sdroW_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpinWords("one two three"));
        }
        // My method
        public static string SpinWords(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ' });

            string result = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 5)
                {
                    char[] ch = words[i].ToCharArray();
                    Array.Reverse(ch);

                    for (int j = 0; j < ch.Length; j++)
                    {
                        result += ch[j].ToString();
                    }
                    if (i != words.Length - 1)
                        result += " ";
                }
                else
                {
                    result += Convert.ToString(words[i]);
                    if (i != words.Length - 1)
                        result += " ";
                }
            }
            return result;
        }
        // More profesional solution
        public static string SpinWords1(string sentence)
        {
            return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
        }
    }

}
