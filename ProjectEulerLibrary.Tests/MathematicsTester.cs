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

        // GetMaxNum() method.
        [Test]
        public void GetMaxNum_NullList_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Mathematics.GetMaxNum(null));
        }

        [Test]
        public void GetMaxNum_EmptyList_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Mathematics.GetMaxNum(new List<int>()));
        }

        [Test]
        public void GetMaxNum_ListWithNums_ReturnsMaxNum()
        {
            Assert.AreEqual(999, Mathematics.GetMaxNum(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 6, 5, 4, 999, 2, 1, 2, 3, 4 } ));
        }

        [Test]
        public void GetMaxNum_ListWithSameNums_ReturnsSameNum()
        {
            Assert.AreEqual(999, Mathematics.GetMaxNum(new List<int>() { 999, 999, 999, 999 }));
        }

        // GetMaxNumIndex() method.
        [Test]
        public void GetMaxNumIndex_NullList_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Mathematics.GetMaxNumIndex(null));
        }

        [Test]
        public void GetMaxNumIndex_EmptyList_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Mathematics.GetMaxNumIndex(new List<int>()));
        }

        [Test]
        public void GetMaxNumIndex_ListWithNums_ReturnsMaxIndex()
        {
            Assert.AreEqual(10, Mathematics.GetMaxNumIndex(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 6, 5, 4, 999, 2, 1, 2, 3, 4 }));
        }

        [Test]
        public void GetMaxNumIndex_ListWithMultipleMaxValues_ReturnsFirstMaxIndex()
        {
            Assert.AreEqual(1, Mathematics.GetMaxNumIndex(new List<int>() { 1, 2, 2, 2, 2, 2, 2, 2 }));
        }

        // AreElementsEqualToNum() method.
        [Test]
        public void AreElementsEqualToNum_NullList_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Mathematics.AreElementsEqualToNum(null, 0));
        }

        [Test]
        public void AreElementsEqualToNum_EmptyList_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Mathematics.AreElementsEqualToNum(new List<int>(), 0));
        }

        [Test]
        public void AreElementsEqualToNum_ListWithElementsEqualToNum_ReturnsTrue()
        {
            Assert.IsTrue(Mathematics.AreElementsEqualToNum(new List<int>() { 2, 2, 2, 2, 2, 2, 2 }, 2));
        }

        [Test]
        public void AreElementsEqualToNum_ListWithElementNotEqualToNum_ReturnsFalse()
        {
            Assert.IsFalse(Mathematics.AreElementsEqualToNum(new List<int>() { 2, 1, 2, 2, 2, 2, 2 }, 2));
        }

        // GetLeastCommonMultiple() method.
        [Test]
        public void GetLeastCommonMultiple_ListOfNumbers_ReturnsLeastCommonMultiple()
        {
            Assert.AreEqual(2520, Mathematics.GetLeastCommonMultiple(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
        }

        [Test]
        public void GetLeastCommonMultiple_NullList_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Mathematics.GetLeastCommonMultiple(null));
        }

        [Test]
        public void GetLeastCommonMultiple_EmptyList_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Mathematics.GetLeastCommonMultiple(new List<int>()));
        }

        // IsEven() method.
        [Test]
        public void IsEven_PositiveEvenNumber_ReturnsTrue()
        {
            Assert.IsTrue(Mathematics.IsEven(2));
        }

        [Test]
        public void IsEven_Zero_ReturnsTrue()
        {
            Assert.IsTrue(Mathematics.IsEven(0));
        }

        [Test]
        public void IsEven_NegativeEvenNumber_ReturnsTrue()
        {
            Assert.IsTrue(Mathematics.IsEven(-2));
        }

        [Test]
        public void IsEven_OddNumber_ReturnsFalse()
        {
            Assert.IsFalse(Mathematics.IsEven(-3));
        }

        // IsOdd() method.
        [Test]
        public void IsOdd_PositiveOddNumber_ReturnsTrue()
        {
            Assert.IsTrue(Mathematics.IsOdd(1));
        }

        [Test]
        public void IsOdd_Zero_ReturnsFalse()
        {
            Assert.IsFalse(Mathematics.IsOdd(0));
        }

        [Test]
        public void IsOdd_NegativeOddNumber_ReturnsTrue()
        {
            Assert.IsTrue(Mathematics.IsOdd(-3));
        }

        [Test]
        public void IsOdd_EvenNumber_ReturnsFalse()
        {
            Assert.IsFalse(Mathematics.IsOdd(-2));
        }

        // GetSumOfConsecutivePositiveSquares() method.
        [Test]
        public void GetSumOfConsecutivePositiveSquares_StopNumGreaterThanStartNum_ReturnsSumOfSquares()
        {
            Assert.AreEqual(385, Mathematics.GetSumOfConsecutivePositiveSquares(1, 10));
        }

        [Test]
        public void GetSumOfConsecutivePositiveSquares_SameStartNumAndStopNum_ReturnsSumOfSquares()
        {
            Assert.AreEqual(100, Mathematics.GetSumOfConsecutivePositiveSquares(10, 10));
        }

        [Test]
        public void GetSumOfConsecutivePositiveSquares_StopNumLessThanStartNum_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetSumOfConsecutivePositiveSquares(2, 1));
        }

        [Test]
        public void GetSumOfConsecutivePositiveSquares_LargeStopNum_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetSumOfConsecutivePositiveSquares(2, (int)Math.Sqrt(int.MaxValue) + 1));
        }

        [Test]
        public void GetSumOfConsecutivePositiveSquares_NegativeStartNum_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetSumOfConsecutivePositiveSquares(-1, 1));
        }

        [Test]
        public void GetSumOfConsecutivePositiveSquares_ZeroForStartNum_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetSumOfConsecutivePositiveSquares(0, 1));
        }

        // GetSumOfConsecutiveNumbers() method.
        [Test]
        public void GetSumOfConsecutiveNumbers_ValidStartNumAndStopNum_ReturnsSumOfConsecutiveNumbers()
        {
            Assert.AreEqual(55, Mathematics.GetSumOfConsecutiveNumbers(1, 10));
        }

        [Test]
        public void GetSumOfConsecutiveNumbers_SameStartNumAndStopNum_ReturnsSumOfConsecutiveNumbers()
        {
            Assert.AreEqual(9, Mathematics.GetSumOfConsecutiveNumbers(9, 9));
        }

        [Test]
        public void GetSumOfConsecutiveNumbers_NegativeStartNum_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetSumOfConsecutiveNumbers(-1, 1));
        }

        [Test]
        public void GetSumOfConsecutiveNumbers_ZeroForStartNum_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetSumOfConsecutiveNumbers(0, 1));
        }

        [Test]
        public void GetSumOfConsecutiveNumbers_StopNumLessThanStartNum_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.GetSumOfConsecutiveNumbers(2, 1));
        }
    }
}
