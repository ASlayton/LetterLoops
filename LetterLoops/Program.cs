using System;

namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get User Input and save to variable
            Console.WriteLine("Please write something below.");
            var userInput = Console.ReadLine();

            var myCounter = 1;
            var myOutput = "";

            foreach (var letter in userInput)
            {
                var letterGroup = ""; 
                //Add the letter based on Index position 
                for (var i = 0; i < myCounter; i++)
                {
                    letterGroup += letter;
                }
                //Add a hyphen between letters
                if (myCounter < userInput.Length)
                {
                    letterGroup += "-";
                }

                //Capitatize the first letter in each letter group
                myOutput += letterGroup[0].ToString().ToUpper() + letterGroup.Substring(1);

                myCounter++;
            }
            Console.WriteLine(myOutput);
            Console.WriteLine("Press enter to Exit.");
            Console.ReadLine();
        }
    }
}
