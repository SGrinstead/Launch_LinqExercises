namespace Launch_LinqExercises
{
    public class CountTest
    {
        [Fact]
        public void CountWordsWithE()
        {
            var words = new List<string> { "thing", "phone", "bark", "belt", "shoe", "bath" };
            var tally = words.Count(word => word.Contains('e'));
            Assert.Equal(3, tally);
        }

        [Fact]
        public void CountNumbersGreaterThan17()
        {
            var numbers = new List<int> { 9, 18, 12, 17, 1, 3, 99 };
            var tally = numbers.Count(n =>
                    n > 17
            );
            Assert.Equal(2, tally);
        }

        [Fact]
        public void CountWordsThatAreUppercase()
        {
            var words = new List<string> { "trousers", "SOCKS", "sweater", "Cap", "SHOE", "TIE" };
            var tally = words.Count(w => w == w.ToUpper());
            Assert.Equal(3, tally);
        }

        [Fact]
        public void CountWordsEndingInIng()
        {
            var words = new List<string> { "thought", "brake", "shin", "juice", "trash" };
            var tally = words.Count(w => w.EndsWith("ing"));
            Assert.Equal(0, tally);
        }

        [Fact]
        public void CountEventNumbers()
        {
            var numbers = new List<int> { 9, 2, 1, 3, 18, 39, 71, 4, 6 };
            var tally = numbers.Count(n => n % 2 == 0);
            Assert.Equal(4, tally);
        }

        [Fact]
        public void CountMultiplesOf5()
        {
            var numbers = new List<int> { 2, 5, 19, 25, 35, 67 };
            var tally = numbers.Count(n => n % 5 == 0);
            Assert.Equal(3, tally);
        }

        [Fact]
        public void CountRoundPrices()
        {
            var prices = new List<double> { 1.0, 3.9, 5.99, 18.5, 20.0 };
            var tally = prices.Count(p => ((int)p) == p);
            Assert.Equal(2, tally);
        }

        [Fact]
        public void CountFourLetterWords()
        {
            var words = new List<string> { "bake", "bark", "corn", "apple", "wart", "bird", "umbrella", "fart" };
            var tally = words.Count(w => w.Length == 4);
            Assert.Equal(6, tally);
        }
    }
}
