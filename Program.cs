using System;

namespace Selection_Statememts_Exer
{
    class Program
    {
      

        static void Main(string[] args)
        {
         
            var r = new Random();
           var favNumber = r.Next(1, 1000);
            Console.WriteLine("Try to guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            if (favNumber < 1)
            {
                Console.WriteLine("too low");
            }
            else if (favNumber > 1000)
            {
                Console.WriteLine("too high");
            }
            if (favNumber == 0)

            {
                Console.WriteLine("Never Mind!");
            
            }
           

            Console.WriteLine("What is your favorite Subject?");
            
                var answer = "";


            answer = "English";
            answer = "History";
            answer = "None";
            answer = "Chemistry";
            answer = "Physics";


            switch (answer)
            {
                case "English":
                    Console.WriteLine("you should choose banking.");
                    break;
         
                case "History":
                    Console.WriteLine("you should choose blogging.");
                    break;
                case "Chemistry":
                    Console.WriteLine("you should choose lab.");
                    break;
                case "Physics":
                    Console.WriteLine("you should be a phsyician.");
                    break;
                case "None":
                    Console.WriteLine("you should think about the question more.");
                    break;
                default :
                    Console.WriteLine("restart again.");
                    break;
            }




        }
    }
}
