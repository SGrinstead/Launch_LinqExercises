using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launch_LinqExercises
{
    public class OrderByTest
    {
        [Fact]
        public void SortAlphabetically()
        {
            var words = new List<string> { "broccoli", "Carrots", "FISH", "Bacon", "candy" };

            var sorted = words.OrderBy(w => w.ToLowerInvariant()).ToList();

            var expected = new List<string> { "Bacon", "broccoli", "candy", "Carrots", "FISH" };
            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void SortAlphabeticallyByLastLetter()
        {
            var things = new List<string> { "pill", "box", "glass", "water", "sponge" };

            var sorted = things.OrderBy(t =>
              t.Last()
            ).ToList();

            var expected = new List<string> { "sponge", "pill", "water", "glass", "box" };
            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void SortByDistance()
        {
            var distances = new List<string> { "1cm", "9cm", "30cm", "4cm", "2cm" };

            var sorted = distances.OrderBy(d =>
              int.Parse(d.Replace("cm", ""))
            ).ToList();

            var expected = new List<string> { "1cm", "2cm", "4cm", "9cm", "30cm" };
            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void SortByLength()
        {
            var words = new List<string> { "heteromorph", "ancyloceratina", "bioengineering", "mathematical", "bug" };

            var sorted = words.OrderBy(w =>
              w.Length
            ).ToList();

            var expected = new List<string> { "bug", "heteromorph", "mathematical", "ancyloceratina", "bioengineering" };
            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void SortByProximityToTen()
        {
            var prices = new List<double> { 3.02, 9.91, 17.9, 10.01, 11.0 };

            var sorted = prices.OrderBy(p =>
                Math.Abs(10 - p)
            ).ToList();

            var expected = new List<double> { 10.01, 9.91, 11.0, 3.02, 17.9 };
            Assert.Equal(expected, sorted);
        }

        [Fact]
        public void SortByNumberOfCents()
        {
            var prices = new List<double> { 3.02, 9.91, 7.9, 10.01, 11.0 };

            var sorted = prices.OrderBy(p =>
              p - Math.Truncate(p)
            ).ToList();

            var expected = new List<double> { 11.0, 10.01, 3.02, 7.9, 9.91 };
            Assert.Equal(expected, sorted);
        }
    }
}
