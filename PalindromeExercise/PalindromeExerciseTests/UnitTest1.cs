using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true )]
        [InlineData("hello", false  )]
        [InlineData("level", true )]
        [InlineData("radar", true )]
        public void Test1(string word,bool expected)
        {
            WordSmith intance = new WordSmith();

            bool actual = intance.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
