using System;

namespace Test1
{
    class Program
    {
        /// <summary>
        /// Reverse words appearing within a sentence.
        /// </summary>
        /// <param name="str">Sentence with words in original order</param>
        private static void ReverseWords(string str)
        {
            Console.WriteLine("Initial Phrase: {0}", str);

            /* 
             * Write code to reverse the order of each word in the input phrase (str). For example
             * 
             *   red green blue
             *   
             * would become:
             * 
             *   blue green red
             * 
             * You will need to modify the statement below to output the result.
             */

            Console.WriteLine("Reversed Phrase: {0}", str);
        }

        static void Main(string[] args)
        {
            // You shouldn't need to modify this function.
            string inputPhrase = "This month I have mostly been eating fish fingers";
            ReverseWords(inputPhrase);
            Console.ReadKey();
        }
    }
}
