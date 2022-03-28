using System;

namespace _28._03__Task2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Qrup1";
            Console.WriteLine(Check(word));
            string word1 = "qrup1";
            Console.WriteLine(Check(word1));
            string word2 = "Qrup";
            Console.WriteLine(Check(word2));
            string word3 = "qrup";
            Console.WriteLine(Check(word3));
        }
        public static bool Check(string word)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;

            foreach (char letters in word)
            {
                if (char.IsDigit(letters))
                {
                    hasDigit = true;
                    continue;
                }
                if (char.IsUpper(letters))
                {
                    hasUpper = true;
                    continue;
                }
                if (char.IsLower(letters))
                {
                    hasLower = true;
                }
            }
            bool result = hasDigit && hasUpper && hasLower;
            return result;
        }
    }
}
