using System.Diagnostics.CodeAnalysis;
using System.Net;

namespace ScrabbleScorer
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                Console.Write("Enter a single word: ");
                string input = Console.ReadLine();
                string word = input.ToUpper();
                getWord(word);
            
            
   
        }

        public static void getWord(string word)
        {
             
                List<char> letters = new List<char>();
                List<int> score = new List<int>();

                for (int i = 0; i < word.Length; i++)
                {
                    letters.Add(word[i]);


                    if (word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'L' || word[i] == 'N' || word[i] == 'R' || word[i] == 'U' || word[i] == 'O' || word[i] == 'S' || word[i] == 'T')
                    {
                        Console.WriteLine($"{word[i]} = 1");
                        score.Add(1);
                    }
                    else if (word[i] == 'D' || word[i] == 'G')
                    {
                        Console.WriteLine($"{word[i]} = 2");
                        score.Add(2);
                    }
                    else if (word[i] == 'B' || word[i] == 'C' || word[i] == 'M' || word[i] == 'P')
                    {
                        Console.WriteLine($"{word[i]} = 3");
                        score.Add(3);
                    }
                    else if (word[i] == 'F' || word[i] == 'H' || word[i] == 'V' || word[i] == 'W' || word[i] == 'Y')
                    {
                        Console.WriteLine($"{word[i]} = 4");
                        score.Add(4);
                    }
                    else if (word[i] == 'K')
                    {
                        Console.WriteLine($"{word[i]} = 5");
                        score.Add(5);
                    }
                    else if (word[i] == 'X' || word[i] == 'J')
                    {
                        Console.WriteLine($"{word[i]} = 8");
                        score.Add(8);
                    }
                    else if (word[i] == 'Q' || word[i] == 'Z')
                    {
                        Console.WriteLine($"{word[i]} = 10");
                        score.Add(10);
                    }

                }

                int sum = score.Sum();
                Console.WriteLine($"{word} is worth {sum} points!");

            
            
            }

    }
    }
