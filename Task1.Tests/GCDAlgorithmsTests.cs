using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Tests
{
    [TestFixture]
    public class GCDAlgorithmsTests
    {
        #region EuclideanTests
        [TestCase(0, 10, ExpectedResult = 10)]
        [TestCase(10, 0, ExpectedResult = 10)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(8, 8, ExpectedResult = 8)]
        [TestCase(30, 15, ExpectedResult = 15)]
        [TestCase(30, 45, ExpectedResult = 15)]
        [TestCase(7, 19, ExpectedResult = 1)]
        [TestCase(-30, 45, ExpectedResult = 15)]
        [TestCase(-3, -9, ExpectedResult = 3)]
        [TestCase(95, 25, ExpectedResult = 5)]
        [Test]
        public long Euclidean_TwoParameters_PositiveTest(long a, long b)
        {
            long time;

            long result = GCDAlgorithms.Euclidean(a, b, out time);
            return result;
        }

        [TestCase(0, 10, ExpectedResult = 10)]
        [TestCase(10, 0, ExpectedResult = 10)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(8, 8, ExpectedResult = 8)]
        [TestCase(30, 15, ExpectedResult = 15)]
        [TestCase(30, 45, ExpectedResult = 15)]
        [TestCase(7, 19, ExpectedResult = 1)]
        [TestCase(-30, 45, ExpectedResult = 15)]
        [TestCase(-3, -9, ExpectedResult = 3)]
        [TestCase(95, 25, ExpectedResult = 5)]
        [Test]
        public long Euclidean_TwoParametersWithoutTime_PositiveTest(long a, long b)
        {
            long result = GCDAlgorithms.Euclidean(a, b);
            return result;
        }

        [TestCase(0, 10, 0, ExpectedResult = 10)]
        [TestCase(27, 9, 54, ExpectedResult = 9)]
        [TestCase(30, 15, 45, ExpectedResult = 15)]
        [TestCase(54, 108, 27, ExpectedResult = 27)]
        [TestCase(17, 81, 112, ExpectedResult = 1)]
        [TestCase(30, 15, 90, 45, 135, ExpectedResult = 15)]
        [TestCase(1, 3, 5, 7, 9, 11, 13, 15, ExpectedResult = 1)]
        [TestCase(81, 1, 123, 89346, 2893, 39847, ExpectedResult = 1)]
        [TestCase(750, 450, 325, 1025, 25, 3250, 50, 115, ExpectedResult = 5)]
        [Test]
        public long Euclidean_Array_Test(params long[] array)
        {
            long time;

            long result = GCDAlgorithms.Euclidean(out time, array);
            return result;
        }

        [TestCase(0, 10, 0, ExpectedResult = 10)]
        [TestCase(27, 9, 54, ExpectedResult = 9)]
        [TestCase(30, 15, 45, ExpectedResult = 15)]
        [TestCase(54, 108, 27, ExpectedResult = 27)]
        [TestCase(17, 81, 112, ExpectedResult = 1)]
        [TestCase(30, 15, 90, 45, 135, ExpectedResult = 15)]
        [TestCase(1, 3, 5, 7, 9, 11, 13, 15, ExpectedResult = 1)]
        [TestCase(81, 1, 123, 89346, 2893, 39847, ExpectedResult = 1)]
        [TestCase(750, 450, 325, 1025, 25, 3250, 50, 115, ExpectedResult = 5)]
        [Test]
        public long Euclidean_ArrayWithoutTime_Test(params long[] array)
        {
            long result = GCDAlgorithms.Euclidean(array);
            return result;
        }

        [TestCase(null)]
        [Test]
        public void Euclidean_Array_ArgumentNullException(long[] array)
        {
            long ticks;
            Assert.Throws<ArgumentNullException>(() => GCDAlgorithms.Euclidean(out ticks, array));
        }
        #endregion

        #region SteinTests
        [TestCase(0, 10, ExpectedResult = 10)]
        [TestCase(10, 0, ExpectedResult = 10)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(8, 8, ExpectedResult = 8)]
        [TestCase(30, 15, ExpectedResult = 15)]
        [TestCase(30, 45, ExpectedResult = 15)]
        [TestCase(7, 19, ExpectedResult = 1)]
        [TestCase(-30, 45, ExpectedResult = 15)]
        [TestCase(-3, -9, ExpectedResult = 3)]
        [TestCase(95, 25, ExpectedResult = 5)]
        [Test]
        public long Stein_TwoParameters_PositiveTest(long a, long b)
        {
            long time;

            long result = GCDAlgorithms.Stein(a, b, out time);
            return result;
        }

        [TestCase(0, 10, ExpectedResult = 10)]
        [TestCase(10, 0, ExpectedResult = 10)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(8, 8, ExpectedResult = 8)]
        [TestCase(30, 15, ExpectedResult = 15)]
        [TestCase(30, 45, ExpectedResult = 15)]
        [TestCase(7, 19, ExpectedResult = 1)]
        [TestCase(-30, 45, ExpectedResult = 15)]
        [TestCase(-3, -9, ExpectedResult = 3)]
        [TestCase(95, 25, ExpectedResult = 5)]
        [Test]
        public long Stein_TwoParametersWithoutTime_PositiveTest(long a, long b)
        {
            long result = GCDAlgorithms.Stein(a, b);
            return result;
        }

        [TestCase(0, 10, 0, ExpectedResult = 10)]
        [TestCase(27, 9, 54, ExpectedResult = 9)]
        [TestCase(30, 15, 45, ExpectedResult = 15)]
        [TestCase(54, 108, 27, ExpectedResult = 27)]
        [TestCase(17, 81, 112, ExpectedResult = 1)]
        [TestCase(30, 15, 90, 45, 135, ExpectedResult = 15)]
        [TestCase(1, 3, 5, 7, 9, 11, 13, 15, ExpectedResult = 1)]
        [TestCase(81, 1, 123, 89346, 2893, 39847, ExpectedResult = 1)]
        [TestCase(750, 450, 325, 1025, 25, 3250, 50, 115, ExpectedResult = 5)]
        [Test]
        public long Stein_Array_Test(params long[] array)
        {
            long time;

            long result = GCDAlgorithms.Stein(out time, array);
            return result;
        }

        [TestCase(0, 10, 0, ExpectedResult = 10)]
        [TestCase(27, 9, 54, ExpectedResult = 9)]
        [TestCase(30, 15, 45, ExpectedResult = 15)]
        [TestCase(54, 108, 27, ExpectedResult = 27)]
        [TestCase(17, 81, 112, ExpectedResult = 1)]
        [TestCase(30, 15, 90, 45, 135, ExpectedResult = 15)]
        [TestCase(1, 3, 5, 7, 9, 11, 13, 15, ExpectedResult = 1)]
        [TestCase(81, 1, 123, 89346, 2893, 39847, ExpectedResult = 1)]
        [TestCase(750, 450, 325, 1025, 25, 3250, 50, 115, ExpectedResult = 5)]
        [Test]
        public long Stein_ArrayWithoutTime_Test(params long[] array)
        {
            long result = GCDAlgorithms.Stein(array);
            return result;
        }

        [TestCase(null)]
        [Test]
        public void Stein_Array_ArgumentNullException(long[] array)
        {
            long ticks;
            Assert.Throws<ArgumentNullException>(() => GCDAlgorithms.Euclidean(out ticks, array));
        }
        #endregion
    }
}
