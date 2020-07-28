using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK #1 in the Hello World exercise:
            Console.WriteLine("Howdy Y'all!!");
            //Console.ReadKey(); // What happens if you run the app without this line? - ARS: You get additional information about the code ...such as that the executable exited with code 0 - what does that mean??

            //Console Input exercise - part 1 :
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! Welcome to our world!");

            //TASK #2 in the Hello World exercise:
            var animalSet = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            foreach(var animal in animalSet)
            {
                Console.WriteLine(animal);
            }

            //Console Input exercise - part 2 :
            Console.WriteLine("What is your favorite color?");
            var userColor = Console.ReadLine();
            //Console.WriteLine($"Your favorite color is: {userColor}");
            //Generate random integer and use it as an index to retrieve a string value from the animalSet array:
            Random rnd = new Random();
            //FIRST: generate random indexes for pet names:
            int animalSetIndex = rnd.Next(animalSet.Length);
            //Display the result:
            Console.WriteLine($"Would you like to have a {userColor} {animalSet[animalSetIndex]}?");

            //Console Input exercise - practice:
            ConsoleKeyInfo enteredKey;
            do
            {
                enteredKey = Console.ReadKey();
                Console.WriteLine($"You pressed the {enteredKey.Key.ToString()} key");
                Console.WriteLine("consolekey object", enteredKey); //WHY CAN I not console the object??
            } while (enteredKey.Key != ConsoleKey.Escape);



            //TASK #3 in the Hello World exercise:
            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            
            int CountSyllables(string word)
            {
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
                string currentWord = word;
                int numVowels = 0;
                bool lastWasVowel = false;
                foreach (char wc in currentWord)
                {
                    bool foundVowel = false;
                    foreach (char v in vowels)
                    {
                        //don't count diphthongs:
                        if (v == wc && lastWasVowel)
                        {
                            foundVowel = true;
                            lastWasVowel = true;
                            break;
                        }
                        else if (v == wc && !lastWasVowel)
                        {
                            numVowels++;
                            foundVowel = true;
                            lastWasVowel = true;
                            break;
                        }
                    }
                    //if full cycle and no vowel found, set lastWasVowel to false;
                    if (!foundVowel)
                        lastWasVowel = false;
                }
                //remove es because it is usually silent!
                if (currentWord.Length > 2 &&
                    currentWord.Substring(currentWord.Length - 2) == "es")
                    numVowels--;
                //remove silent e:
                else if (currentWord.Length > 1 &&
                    currentWord.Substring(currentWord.Length - 1) == "e")
                    numVowels--;

                return numVowels;
            }

            for (int i = 0; i < animals.Length; i++)
            {
                int syllableCount = CountSyllables(animals[i]);
                //Console.WriteLine(syllableCount);
                if (syllableCount > 2)
                {
                    Console.WriteLine($"The name of the {animals[i]} has {syllableCount} syllables!");
                }
            
            }


            //TASK #4 in the  Hello World exercise:

            Console.WriteLine("Please select a dialect: Southern, Romanian, Midwestern?");
            var inputDialect = Console.ReadLine();
            //Console.Read(); //XXXX/why Read and not ReadLine???
            
            if (inputDialect == "Southern")
            {
                Console.WriteLine("Howdy!");
            } else if (inputDialect == "Romanian")
            {
                Console.WriteLine("Buna ziua!");
            } else if (inputDialect == "Midwestern")
            {
                Console.WriteLine("Wanna come with?");
            } else
            {
                Console.WriteLine("Check your spelling! You didn't pick one of the available options!");
            }
            
            //keep the console window open after the program has run:
            //Console.Read();
            //}
        }
    }
}
