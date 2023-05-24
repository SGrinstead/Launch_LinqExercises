using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launch_LinqExercises
{
    public class FirstTest
    {
        [Fact]
        public void FindFirstSevenLetterWord()
        {
            var words = new List<string>
          { "capricious", "berry", "unicorn", "bag", "apple", "festering", "pretzel", "pencil" };
            var found = words.First(w => w.Length == 7);
            Assert.Equal("unicorn", found);
        }

        [Fact]
        public void NoWaldo()
        {
            var words = new List<string> { "scarf", "sandcastle", "flag", "pretzel", "crow", "key" };
            var found = words.FirstOrDefault(w =>
              w == "waldo"
            );
            Assert.Null(found);
        }

        [Fact]
        public void FindWaldo()
        {
            var words = new List<string> { "noise", "dog", "fair", "house", "waldo", "bucket", "fish" };
            var found = words.First(w => w == "waldo");
            Assert.Equal("waldo", found);
        }

        [Fact]
        public void CannotFind3LetterWords()
        {
            var words = new List<string> { "piglet", "porridge", "bear", "blueberry" };
            var found = words.FirstOrDefault(w => w.Length == 3);
            Assert.Null(found);
        }

        [Fact]
        public void Find13()
        {
            var numbers = new List<int> { 2, 13, 19, 8, 3, 27 };
            var found = numbers.First(n => n == 13);
            Assert.Equal(13, found);
        }

        [Fact]
        public void FindFirstEvenNumber()
        {
            var numbers = new List<int> { 3, 7, 13, 11, 10, 2, 17 };
            var found = numbers.First(n => n % 2 == 0);
            Assert.Equal(10, found);
        }

        [Fact]
        public void FindFirstMultipleOf3()
        {
            var numbers = new List<int> { 2, 8, 9, 27, 24, 5 };
            var found = numbers.First(n => n % 3 == 0);
            Assert.Equal(9, found);
        }

        [Fact]
        public void FindFirstWordStartingWithQ()
        {
            var words = new List<string> { "weirdo", "quill", "fast", "quaint", "quitter", "koala" };
            var found = words.First(w => w.StartsWith("q"));
            Assert.Equal("quill", found);
        }

        [Fact]
        public void FindFirstWordEndingWithEr()
        {
            var words = new List<string> { "biggest", "pour", "blight", "finger", "pie", "border" };
            var found = words.First(w => w.EndsWith("er"));
            Assert.Equal("finger", found);
        }

        [Fact]
        public void FindFirstNumberGreaterThan20()
        {
            var numbers = new List<int> { 1, 8, 19, 21, 29, 31, 34 };
            var found = numbers.First(n => n > 20);
            Assert.Equal(21, found);
        }
    }
}
