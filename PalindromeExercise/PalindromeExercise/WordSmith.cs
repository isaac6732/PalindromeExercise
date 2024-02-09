using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string originalWord)
        {
            string reverseWord = "";
            
            for (int i = originalWord.Length - 1; i >= 0; i--)
            {
                reverseWord += originalWord[i];
            }
            return originalWord.ToLower() == reverseWord.ToLower();
        }
    }
}
