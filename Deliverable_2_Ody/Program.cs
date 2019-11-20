using System;

namespace Deliverable_2_Ody
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string message = "";
            //defined variable//
            Console.WriteLine("What is your message?");
            {
                string input = Console.ReadLine();
                string upperCaseinput = input.ToUpper();
                foreach (char ch in upperCaseinput)
                //console reads user input and converts characters to upper case//
                {
                    int characterVal = (int)ch;
                    message += (characterVal % 32).ToString() + "-";
                            
                    sum += characterVal % 32;
                    // finds unicode for each input letter, line break, adds letter converted to remaining interger to the string and formats with "-", Line break, brings in sum of all converted letters//
                }
                Console.WriteLine("Your encoded message is " + message);
                Console.WriteLine("Your checksum is " + sum);
            }

        }
    }
}
