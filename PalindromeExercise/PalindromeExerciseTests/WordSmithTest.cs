using PalindromeExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PalindromeExerciseTests
{
    public class WordSmithTest
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Hannah", true)]
        [InlineData("Kayak", true)]
        [InlineData("Ryan", false)]
        [InlineData("Audi", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsAPalindrome_Test(string word, bool expected)
        {
            //Arrange
            var ws = new WordSmith();


            //Act
            var actual = ws.IsAPalindrome(word);


            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
