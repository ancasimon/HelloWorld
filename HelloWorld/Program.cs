using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK #1 in the exercise:
            //Console.WriteLine("Howdy Y'all!!");
            //Console.ReadKey(); // What happens if you run the app without this line? - ARS: You get additional information about the code ...such as that the executable exited with code 0 - what does that mean??


            //TASK #2 in the exercies:
            //var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            //foreach(var animal in animals)
            //{
            //    Console.WriteLine(animal);
            //}


            //TASK #3 in the exercise:
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
                    Console.WriteLine($"The {animals[i]} has {syllableCount} syllables!");
                }
            
            }


            //TASK #4 in the exercise:
            //STILL NOT SURE: how exactly do I define args? I tried to do it in Properties but it's not reading it!!!
            //var args = new string[] { "Southern", "Romanian", "Midwestern" };

            //if (args.Length == 0)
            //{
            //display message to user to provide parameters
            //System.Console.WriteLine("please enter dialect");
            //Console.Read(); //XXXX/why Read and not ReadLine???
            //}
            //else
            //{
            //loop through array to list args parameters.
            //for (int i = 0; i < args.Length; i++)
            //{
            //Console.Write(args[i] + Environment.NewLine);
            //}
            //keep the console window open after the program has run:
            //Console.Read();
            //}
        }
    }
}
