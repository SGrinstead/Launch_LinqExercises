namespace Launch_LinqExercises
{
    public class SelectTest
    {
        [Fact]
        public void Capitalize()
        {
            var names = new List<string> { "alice", "bob", "charlie" };

            var capitalizedNames = names.Select(n =>
              n[..1].ToUpper() + n.Substring(1)
            );

            var expectedNames = new List<string> { "Alice", "Bob", "Charlie" };
            Assert.Equal(capitalizedNames, expectedNames);
        }

        [Fact]
        public void Doubles()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            var doubles = numbers.Select(n =>
              n * 2
            );


            Assert.Equal(new List<int> { 2, 4, 6, 8, 10 }, doubles);
        }

        [Fact]
        public void Squares()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };

            var squares = numbers.Select(n =>
              n * n
            );

            Assert.Equal(new List<int> { 1, 4, 9, 16, 25 }, squares);
        }

        [Fact]
        public void Lengths()
        {
            var names = new List<string> { "alice", "bob", "charlie", "david", "eve" };

            var lengths = names.Select(n =>
              n.Length
            );

            Assert.Equal(new List<int> { 5, 3, 7, 5, 3 }, lengths);
        }

        [Fact]
        public void NormalizeZipCodes()
        {
            string zeroes = "00000";
            var numbers = new List<int> { 234, 10, 9119, 38881 };

            var zipCodes = numbers.Select(n =>
              zeroes.Substring(0, 5 - n.ToString().Length) + n.ToString()
            );

            Assert.Equal(new List<string> { "00234", "00010", "09119", "38881" }, zipCodes);
        }

        [Fact]
        public void Backwards()
        {
            var names = new List<string> { "alice", "bob", "charlie", "david", "eve" };

            var backwards = names.Select(n =>
              n.Reverse()
            );

            Assert.Equal(new List<string> { "ecila", "bob", "eilrahc", "divad", "eve" }, backwards);
        }

        [Fact]
        public void WordsWithNoVowels()
        {
            var words = new List<string> { "green", "sheep", "travel", "least", "boat" };

            var withoutVowels = words.Select(w =>
              w.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
            );

            Assert.Equal(new List<string> { "grn", "shp", "trvl", "lst", "bt" }, withoutVowels);
        }

        [Fact]
        public void TrimLastLetter()
        {
            var animals = new List<string> { "dog", "cat", "mouse", "frog", "platypus" };

            var trimmed = animals.Select(a =>
              a.Remove(a.Length - 1)
            );

            Assert.Equal(new List<string> { "do", "ca", "mous", "fro", "platypu" }, trimmed);
        }
    }
}
