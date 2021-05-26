using System;

namespace ConsoleApp2
{
    
        
     class info
             {
               public string Name;
               public int Age;
               public string Month;
           public void Display()
            {
                  Console.WriteLine("Your name is: {0}",Name);
            	  Console.WriteLine("Your age is: {0}", Age);
                  Console.WriteLine("you birth month is:{0}",Month);

            if(Month=="march")
                 {
                Console.WriteLine("you are an Aries");
                 
                 }
            else if(Month=="april")
            {
                Console.WriteLine("Your are a Taurs");
            }
            
                
            }
     }
    class Survey
    {
        static void Main(string[] args)
        {
            var data = new Data();

            Console.WriteLine("What is your name?: ");
            var Name = TryAnswer();

            Console.WriteLine("What is your age?: ");
            var Age = TryAnswer();

            Console.WriteLine("What is your birth month?: ");
            var Month = TryAnswer();

            data.Display();

            static string TryAnswer()
            {
                var question = Console.ReadLine();
                if (question == "")
                {
                    Console.WriteLine("you did not type anything, please type..");
                    return Console.ReadLine();
                }
                return question;
            }

        }
    }
}
