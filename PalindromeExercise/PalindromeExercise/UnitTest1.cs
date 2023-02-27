using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InLineData("racecar", true)]
        [InLineData("hello", false)]
        [InLineData("Racecar", false)]
        public void MyTest(string word, bool expected)
        {
            //arrange
            var tester = new IsAPalindrome();
            
            //act
            bool actual = tester.IsAPalindrome(word);
            
            //assert
            Assert.Equal(expected, actual):

        }
    }
}
