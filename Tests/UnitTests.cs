using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }
        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
    
        [Test]
        public void Subtract_ValidSplinter()
        {
            Assert.AreEqual(45, Program.Subtract("90", "45"));
            Assert.AreEqual(5, Program.Subtract("6", "1"));
            Assert.AreEqual(3, Program.Subtract("5", "2"));
        }
        [Test]
        public void Subtract_InvalidSplinter()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }
        [Test]
        public void Subtract_NullSplinter()
        {
            
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }
        [Test]
        public void Multiply_ValidSplinter()
        {
            Assert.AreEqual(12, Program.Multiply("1", "12"));
            Assert.AreEqual(14, Program.Multiply("7", "2"));
            Assert.AreEqual(4, Program.Multiply("2", "2"));
        }
        [Test]
        public void Multiply_InvalidSplinter()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }
        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Multiply_NullSplinter()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }
        [Test]
        public void Divide_InvalidSplinter()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }
        [Test]
        public void Divide_NullSplinter()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }
        
        [Test]
        public void Power_ValidSplinter()
        {
            Assert.AreEqual(49, Program.Power("7", "2"));
            Assert.AreEqual(4, Program.Power("4", "1"));
            Assert.AreEqual(9, Program.Power("3", "2"));
        }
        
        [Test]
        public void Power_InvalidSplinter()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }
        [Test]
        public void Power_NullSplinter()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
        // Implement 3 tests per operation, following a similar pattern as above
    }
}
