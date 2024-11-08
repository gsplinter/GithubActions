﻿using System;
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
        public void Subtract()
        {
            Assert.AreEqual(45 Program.Subtract("90", "45"));
            Assert.AreEqual(5, Program.Subtract("6", "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
    }
        [Test]
        public void Multiply()
        {
            Assert.AreEqual(12, Program.Multiply("1", "12"));
            Assert.AreEqual(14, Program.Multiply("7", "2"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
    
        [Test]
        public void Divide()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }
        
        [Test]
        public void Power()
        {
            Assert.AreEqual(49,Program.Power("7", "2"));
            Assert.AreEqual(4, Program.Power("4", "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
        // Implement 3 tests per operation, following a similar pattern as above
    }
}
