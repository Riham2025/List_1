using System.Security.Cryptography.X509Certificates;

namespace List_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Top N Frequent Numbers>Given a List<int> of numbers, find the top N most frequent numbers

            {
                List<int> numbers = new List<int> { 50, 10, 50, 12, 10, 30, 50, 20, 12 };
                int N = 2;

                List<int> result = GetTopNFrequentNumbers(numbers, N);

                Console.WriteLine("Top " + N + " frequent numbers:");
                foreach (int num in result)
                {
                    Console.WriteLine(num);
                }

                //2. Palindrome Filter

                List<string> words = new List<string>

                    { "madam", "hello", "level", "world", "racecar", "openai" };
        

                List<string> palindromes = FilterPalindromes(words);

                Console.WriteLine("Palindrome words:");
                foreach (string word in palindromes)
                {
                    Console.WriteLine(word);
                }



            }

            //1. 

            static List<int> GetTopNFrequentNumbers(List<int> numbers, int n)
            {
                return numbers
                    .GroupBy(num => num)                          // We collect the similar numbers
                    .OrderByDescending(group => group.Count())    // We arrange them according to the number of repetitions.
                    .Take(n)                                      // We take the first N numbers.
                    .Select(group => group.Key)                   // Return the numbers only.
                    .ToList();
            }

            //2.  //  Palindrome

            static List<string> FilterPalindromes(List<string> input)
            {
                return input
                    .Where(word => IsPalindrome(word))
                    .ToList();
            }

            //  Palindrome
            static bool IsPalindrome(string word)
            {
                string reversed = new string(word.Reverse().ToArray());
                return word.Equals(reversed, StringComparison.OrdinalIgnoreCase);
            }



        }




    }
    
}
