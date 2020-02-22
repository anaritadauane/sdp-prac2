using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string word = "hello";
            Prefix(word);
        }

        public static string Prefix(string input)
        {
             
            int str = input.Length;
            string[] words = input.Split(" ");
            int counter = 0;
            int num_Words = words.Length;

            if (input == ""){
                num_Words = 0;
            }

            foreach(string i in words){
                if (i != "")
                {
                    counter++;
                }
            }

            //Console.WriteLine( str + "," + num_Words + ":" + input);
            string answer = str + "," + counter + ":" + input;
            return answer;
            
        }
    }
}
