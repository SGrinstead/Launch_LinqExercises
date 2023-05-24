namespace Launch_LinqExercises
{
    public class AnyTest
    {
        [Fact]
        public void HasAtLeastOneZero()
        {
            var numbers = new List<int> { 2, 0, 9, 3, 0, 1 };
            var hasZero = numbers.Any(n => n == 0);
            Assert.True(hasZero);
        }

        [Fact]
        public void DoesNotHaveAnyZeros()
        {
            var numbers = new List<int> { 3, 1, 3, 2, 4, 9, 8 };
            var hasZero = numbers.Any(n =>
                n == 0
            );
            Assert.False(hasZero);
        }

        [Fact]
        public void HasAtLeastOneAlice()
        {
            var names = new List<string> { "Bill", "Bob", "Burton", "Alice", "Brandon" };
            var hasAlice = names.Any(name => name == "Alice");
            Assert.True(hasAlice);
        }

        [Fact]
        public void NoAlices()
        {
            var names = new List<string> { "Chuck", "Charlene", "Cory", "Chris", "Carl" };
            var hasAlice = names.Any(name => name == "Alice");
            Assert.False(hasAlice);
        }

        [Fact]
        public void HasAMultiWordPhrase()
        {
            var phrases = new List<string> { "Sure!", "OK.", "I have no idea.", "Really?Whatever." };
            var hasMultiwordPhrase = phrases.Any(phrase => phrase.Contains(" "));
            Assert.True(hasMultiwordPhrase);
        }

        [Fact]
        public void NoMonkeys()
        {
            var animals = new List<string> { "elephant", "hippo", "jaguar", "python" };
            var hasMonkeys = animals.Any(animal => animal == "monkey");
            Assert.False(hasMonkeys);
        }

        [Fact]
        public void NoMultiplesOfFive()
        {
            var numbers = new List<int> { 3, 1, 3, 2, 4, 9, 8 };
            var multiplesOf5 = numbers.Any(n => n % 5 == 0);
            Assert.False(multiplesOf5);
        }
    }
}
