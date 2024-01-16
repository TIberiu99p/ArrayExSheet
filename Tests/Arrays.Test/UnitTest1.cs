using ArrayExSheet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arrays.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetSumValOfArray_ShouldReturnCorrectSum()
        {
            // Arrange
            ArraysExercises arraysExercises = new ArraysExercises();
            object[] arr = { 1, 2, 3, 4, 5, 1.5f, 2.5f };

            // Act
            int result = arraysExercises.GetSumValOfArray(arr);

            // Assert
            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void GetSumOfIntNum_ShouldReturnCorrectSum()
        {
            // Arrange
            ArraysExercises arraysExercises = new ArraysExercises();
            
            int num = 12345;

            // Act
            int result = arraysExercises.GetSumOfIntNum(num);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void IsAPalindrome_ShouldReturnTrueForPalindrome()
        {
            // Arrange
            ArraysExercises arraysExercises = new ArraysExercises();
            string palindrome = "level";

            // Act
            bool result = arraysExercises.IsAPalindrome(palindrome);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsAPalindrome_ShouldReturnFalseForNonPalindrome()
        {
            // Arrange
            ArraysExercises arraysExercises = new ArraysExercises();
            string nonPalindrome = "hello";

            // Act
            bool result = arraysExercises.IsAPalindrome(nonPalindrome);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ReverseOrderInts_ShouldReturnReversedArray()
        {
            // Arrange
            ArraysExercises arraysExercises = new ArraysExercises();
            int[] arr = { 1, 2, 3, 4, 5 };

            // Act
            int[] result = arraysExercises.ReverseOrderInts(arr);

            // Assert
            CollectionAssert.AreEqual(new int[] { 5, 4, 3, 2, 1 }, result);
        }
    }
}
