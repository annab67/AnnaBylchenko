using NUnit.Framework;
using System;
using TimeLibrary;

namespace TimeLibrary.Tests
{
    [TestFixture]
    public class TimeTests
    {
        [Test]
        public void Constructor_ValidCorrectData_SetsPropertiesAndTotalSeconds()
        {
            var time = new Time(1, 10, 30);

            Assert.That(time.Hours, Is.EqualTo(1));
            Assert.That(time.Minutes, Is.EqualTo(10));
            Assert.That(time.Seconds, Is.EqualTo(30));
            Assert.That(time.TotalSeconds, Is.EqualTo(4230));
        }

        [Test]
        public void Constructor_InvalidHours_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Time(24, 0, 0));
            Assert.Throws<ArgumentException>(() => new Time(-1, 0, 0));
        }

        [Test]
        public void Constructor_InvalidMinutesAndSeconds_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Time(12, 60, 0));
            Assert.Throws<ArgumentException>(() => new Time(12, 0, -5));
        }

        [Test]
        public void ToString_FormatsWithLeadingZeros_ReturnsCorrectString()
        {
            var time = new Time(5, 9, 1);
            Assert.That(time.ToString(), Is.EqualTo("05:09:01"));
        }

        [Test]
        public void OperatorPlus_AddsTimeCorrectly_HandlesDayOverflow()
        {
            var t1 = new Time(23, 0, 0);
            var t2 = new Time(2, 30, 0);

            var result = t1 + t2; // 23:00 + 02:30 = 01:30 следующего дня

            Assert.That(result.ToString(), Is.EqualTo("01:30:00"));
        }

        [Test]
        public void OperatorMinus_SubtractsTimeCorrectly_HandlesNegativeResult()
        {
            var t1 = new Time(1, 0, 0);
            var t2 = new Time(2, 0, 0);

            var result = t1 - t2; // 01:00 - 02:00 = 23:00 предыдущего дня

            Assert.That(result.ToString(), Is.EqualTo("23:00:00"));
        }

        [Test]
        public void EqualsAndOperators_ComparesCorrectly()
        {
            var t1 = new Time(12, 0, 0);
            var t2 = new Time(12, 0, 0);
            var t3 = new Time(13, 0, 0);

            Assert.That(t1 == t2, Is.True);
            Assert.That(t1 != t3, Is.True);
            Assert.That(t1.Equals(t2), Is.True);
            Assert.That(t1.GetHashCode(), Is.EqualTo(t2.GetHashCode()));
        }

        [Test]
        public void ComparisonOperators_WorkCorrectly()
        {
            var early = new Time(8, 30, 0);
            var late = new Time(17, 45, 0);

            Assert.That(early < late, Is.True);
            Assert.That(late > early, Is.True);
            Assert.That(early <= early, Is.True);
        }
    }
}