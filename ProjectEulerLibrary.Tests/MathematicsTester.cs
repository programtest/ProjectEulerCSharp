using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ProjectEulerLibrary.Tests
{
    /// <summary>
    /// Test class for the Mathematics class.
    /// </summary>
    public class MathematicsTester
    {
        // GetMultiples() method.
        [Test]
        public void GetMultiples_NegativeNumValue_ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetMultiples(-1, 1));
        }

        [Test]
        public void GetMultiples_ZeroForNumValue_ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetMultiples(0, 1));
        }

        [Test]
        public void GetMultiples_NegativeMaxValue_ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetMultiples(1, -1));
        }

        [Test]
        public void GetMultiples_ZeroForMaxValue_ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetMultiples(1, 0));
        }

        [Test]
        public void GetMultiples_MaxLessThanNum_ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetMultiples(2, 1));
        }

        [Test]
        public void GetMultiples_MaxEqualToNum_ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetMultiples(1, 1));
        }

        [Test]
        public void GetMultiples_ValidNumAndMax_ListOfMultiples()
        {
            CollectionAssert.AreEqual(new List<int>() { 3, 6, 9, 12, 15, 18, 21, 24 }, Mathematics.GetMultiples(3, 25));
        }

        [Test]
        public void GetMultiples_ValidNumAndMaxMultipleOfNum_ListOfMultiples()
        {
            CollectionAssert.AreEqual(new List<int>() { 11, 22, 33, 44, 55, 66, 77, 88, 99, 110 }, Mathematics.GetMultiples(11, 121));
        }

        // GetFibonacciNumbers() method.
        [Test]
        public void GetFibonacciNumbers_NegativeMaxValue_ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetFibonacciNums(-1));
        }

        [Test]
        public void GetFibonacciNumbers_ZeroForMaxValue_ThrowArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetFibonacciNums(0));
        }

        [Test]
        public void GetFibonacciNumbers_OneForMaxValue_ReturnsListWithSingleElementValueZero()
        {
            CollectionAssert.AreEqual(new List<int>() { 0 }, Mathematics.GetFibonacciNums(1));
        }

        [Test]
        public void GetFibonacciNumbers_NormalMaxValue_ReturnsFibonacciNumbers()
        {
            CollectionAssert.AreEqual(new List<int>() { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 }, Mathematics.GetFibonacciNums(35));
        }

        // IsPalindrome() method.
        [Test]
        public void IsPalindrome_SingleDigitNumber_ReturnsTrue()
        {
            Assert.IsTrue(Mathematics.IsPalindrome(0));
        }

        [Test]
        public void IsPalindrome_NegativeNumber_ReturnsFalse()
        {
            Assert.IsFalse(Mathematics.IsPalindrome(-1));
        }

        [Test]
        public void IsPalindrome_PalindromeNumber_ReturnsTrue()
        {
            Assert.IsTrue(Mathematics.IsPalindrome(23455432));
        }
    }
}
