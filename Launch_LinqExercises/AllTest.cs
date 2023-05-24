namespace Launch_LinqExercises
{
    public class AllTest
    {
        [Fact]
        public void AllZeros()
        {
            var numbers = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
            var allZeros = numbers.All(n => n == 0);
            Assert.True(allZeros);
        }

        [Fact]
        public void NotAllZeros()
        {
            var numbers = new List<int> { 0, 0, 0, 0, 1, 0, 0 };
            var allZeros = numbers.All(n =>
                    n == 0
            );
            Assert.False(allZeros);
        }

        [Fact]
        public void AllGone()
        {
            var words = new List<string> { "gone", "gone", "gone", "gone", "gone", "gone", "gone" };
            var allGone = words.All(w => w == "gone");
            Assert.True(allGone);
        }

        [Fact]
        public void NotAllGone()
        {
            var words = new List<string> { "gone", "gone", "gone", "gone", "there", "gone", "gone" };
            var allGone = words.All(w => w == "gone");
            Assert.False(allGone);
        }

        [Fact]
        public void AllEmpty()
        {
            var strings = new List<string> { "", "", "", "", "", "", "" };
            var allEmpty = strings.All(w => w == "");
            Assert.True(allEmpty);
        }

        [Fact]
        public void NotAllEmpty()
        {
            var strings = new List<string> { "", "", "", "Full", "", "", "" };
            var allEmpty = strings.All(w => w == "");
            Assert.False(allEmpty);
        }

        [Fact]
        public void NotAllUppercase()
        {
            var words = new List<string> { "DOUGHNUT", "CASH", "MAIN", "bOWl", "SMACK", "SAND" };
            var allCaps = words.All(w => w == w.ToUpper());
            Assert.False(allCaps);
        }

        [Fact]
        public void AllLies()
        {
            var lies = new List<bool> { false, false, false, false };
            var allLies = lies.All(l => l == false);
            Assert.True(allLies);
        }

        [Fact]
        public void AllMultiplesOf7()
        {
            var numbers = new List<int> { 42, 14, 35, 49, 28, 56, 21, 7 };
            var allMultiplesOf7 = numbers.All(n => n % 7 == 0);
            Assert.True(allMultiplesOf7);
        }

        [Fact]
        public void NotAll3DigitsLong()
        {
            var numbers = new List<int> { 981, 831, 509, 332, 892, 8999, 110 };
            var all3Digits = numbers.All(n => n.ToString().Length == 3);
            Assert.False(all3Digits);
        }

        [Fact]
        public void All4LetterWords()
        {
            var words = new List<string> { "love", "hate", "fire", "bird", "call" };
            var all4Letters = words.All(w => w.Length == 4);
            Assert.True(all4Letters);
        }
    }
}