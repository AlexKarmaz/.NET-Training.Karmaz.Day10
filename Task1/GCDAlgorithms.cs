using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class GCDAlgorithms
    {
        #region Public Methods

        #region Euclidean
        /// <summary>
        /// Calculate the greatest common divisor by Euclidean algorithm and algorithm execution time
        /// </summary>
        /// <param name="a">The first number</param>
        /// <param name="b">The second number</param>
        /// <param name="time">The algorithm execution time</param>
        /// <returns>The greatest common divisor</returns>
        public static long Euclidean(long a, long b, out long time) => Calculate(a, b, out time, EuclideanAlgorithm);

        /// <summary>
        /// Calculate the greatest common divisor by Euclidean algorithm
        /// </summary>
        /// <param name="a">The first number</param>
        /// <param name="b">The second number</param>
        /// <returns>The greatest common divisor</returns>
        public static long Euclidean(long a, long b) => Calculate(a, b, EuclideanAlgorithm);

        /// <summary>
        /// Calculate the greatest common divisor by Euclidean algorithm and algorithm execution time
        /// </summary>
        /// <param name="time">The algorithm execution time</param>
        /// <param name="array">Array of parameters for calculating the greatest common divisor</param>
        /// <returns>The greatest common divisor</returns>
        public static long Euclidean(out long time, params long[] array) => Calculate(EuclideanAlgorithm, out time, array);

        /// <summary>
        /// Calculate the greatest common divisor by Euclidean algorithm
        /// </summary>
        /// <param name="array">Array of parameters for calculating the greatest common divisor</param>
        /// <returns>The greatest common divisor</returns>
        public static long Euclidean(params long[] array) => Calculate(EuclideanAlgorithm, array);
        #endregion

        #region Stein
        /// <summary>
        /// Calculate the greatest common divisor by Stein algorithm
        /// </summary>
        /// <param name="a">The first number</param>
        /// <param name="b">The second number</param>
        /// <returns>The greatest common divisor</returns>
        public static long Stein(long a, long b) => Calculate(a, b, SteinAlgorithm);

        /// <summary>
        /// Calculate the greatest common divisor by Stein algorithm and algorithm execution time
        /// </summary>
        /// <param name="a">The first number</param>
        /// <param name="b">The second number</param>
        /// <param name="time">The algorithm execution time</param>
        /// <returns>The greatest common divisor</returns>
        public static long Stein(long a, long b, out long time) => Calculate(a, b, out time, SteinAlgorithm);

        /// <summary>
        /// Calculate the greatest common divisor by Stein algorithm
        /// </summary>
        /// <param name="array">Array of parameters for calculating the greatest common divisor</param>
        /// <returns>The greatest common divisor</returns>
        public static long Stein(params long[] array) => Calculate(SteinAlgorithm, array);

        /// <summary>
        /// Calculate the greatest common divisor by Stein algorithm and algorithm execution time
        /// </summary>
        /// <param name="time">The algorithm execution time</param>
        /// <param name="array">Array of parameters for calculating the greatest common divisor</param>
        /// <returns>The greatest common divisor</returns>
        public static long Stein(out long time, params long[] array) => Calculate( SteinAlgorithm, out time, array);
        #endregion

        #endregion

        #region Private Methods
        private static long Calculate(long a, long b, out long time, Func<long, long, long> algorithm)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            long result = Calculate(a, b, algorithm);
            timer.Stop();
            time = timer.ElapsedTicks;
            return result;
        }

        private static long Calculate(long a, long b, Func<long, long, long> algorithm)
        {
            if (a < 0)
                a *= -1;
            if (b < 0)
                b *= -1;
            if (a == b)
                return b;
            if (a == 0)
                return b;
            else if (b == 0)
                return a;
            if (a < b)
            {
                return algorithm(b, a);
            }
            else
            {
                return algorithm(a, b);
            }
        }

        private static long Calculate(Func<long, long, long> algorithm, out long time, long[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
    
            long result = 0;
            time = 0;

            foreach (long element in array)
            {
                long t;
                result = Calculate(result, element, out t, algorithm);
                time += t;
            }
            return result;
        }

        private static long Calculate(Func<long, long, long> algorithm, params long[] array)
        {
            if (array == null)
                throw new ArgumentNullException(nameof(array));
            
            long result = 0;

            foreach (long element in array)
            {
                result = Calculate(result, element, algorithm);
            }
            return result;
        }

        private static long EuclideanAlgorithm(long a, long b)
        {
            long temp;
            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private static long SteinAlgorithm(long a, long b)
        {
            int shift;
            for (shift = 0; ((a | b) & 1) == 0; ++shift)
            {
                a >>= 1;
                b >>= 1;
            }
            while ((a & 1) == 0)
                a >>= 1;
            do
            {
                while ((b & 1) == 0)
                    b >>= 1;
                if (a > b)
                {
                    long t = b;
                    b = a;
                    a = t;
                }
                b = b - a;
            } while (b != 0);
            return a << shift;
        }
        #endregion
    }
}
