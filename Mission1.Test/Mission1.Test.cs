using System;
using System.Linq;
using Xunit;

namespace Kata
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("atl","ieer",true)]
        [InlineData("atl",null,false)]
        public void MatchTest(string firstWord, string secondWord, bool expectedResult)
        {
            var baseString = "Atelier";
            var result = Match(baseString, firstWord, secondWord);

            Assert.Equal(result, expectedResult);
        }

        private bool Match(string baseString, string firstWord, string secondWord)
        {
            var wordsConcatened = (firstWord + secondWord).ToLower();
            var orderedWords = new string(wordsConcatened.OrderBy(ch => ch).ToArray()); 

            var findWord = new string(baseString.ToLower().OrderBy(ch => ch).ToArray());

            return findWord == orderedWords;
        }
    }
}
