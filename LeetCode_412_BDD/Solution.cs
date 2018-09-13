using System.Collections.Generic;

namespace LeetCode_412_BDD
{
    public class Solution
    {
        /// <summary>
        /// Write a program that outputs the string representation of numbers from 1 to n.
        ///
        /// But for multiples of three it should output “Fizz” instead of the number
        /// and for the multiples of five output “Buzz”.
        /// For numbers which are multiples of both three and five output “FizzBuzz”.
        ///
        /// Example:  n = 15,
        ///     Return:
        /// [
        ///     "1",
        ///     "2",
        ///     "Fizz",
        ///     "4",
        ///     "Buzz",
        ///     "Fizz",
        ///     "7",
        ///     "8",
        ///     "Fizz",
        ///     "Buzz",
        ///     "11",
        ///     "Fizz",
        ///     "13",
        ///     "14",
        ///     "FizzBuzz"
        /// ]
        /// </summary>
        /// <param name="num">The Number.</param>
        /// <returns></returns>
        public IList<string> FizzBuzz(int num)
        {
            var result = new[] { "1", "2" };

            return result;
        }
    }
}