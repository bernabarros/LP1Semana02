using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string user_question;
            Boolean active = true;

            while(active == true)
            {
                Console.Write("What is your question? ");
                user_question = Console.ReadLine();

                if (user_question == "How are you?")
                {
                    Console.WriteLine("I'm fine, thank you");
                }
                else if (user_question == "What's your name?")
                {
                    Console.WriteLine("ChatGPTOne");
                }
                else if (user_question == "What's your mission?")
                {
                    Console.WriteLine("To help mankind");
                }
                else if (user_question == "Are you more intelligent than me?")
                {
                    Console.WriteLine("Not really");
                }
                else if (user_question == "EXIT")
                {
                    active = false;
                }
                else
                {
                    Console.WriteLine("Can you please repeat that?");
                }
            }
        }
    }
}
