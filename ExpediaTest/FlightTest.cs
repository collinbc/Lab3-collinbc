using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{
        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(new DateTime(2011, 2, 5), new DateTime(2011, 2, 6), 500);
            Assert.IsNotNull(target);
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForOneDayFlight()
        {
            var target = new Flight(new DateTime(2011, 2, 5), new DateTime(2011, 2, 6), 50);
            Assert.AreEqual(220, target.getBasePrice());
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTwoDayFlight()
        {
            var target = new Flight(new DateTime(2011, 2, 5), new DateTime(2011, 2, 7), 50);
            Assert.AreEqual(240, target.getBasePrice());
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTenDayFlight()
        {
            var target = new Flight(new DateTime(2011, 2, 5), new DateTime(2011, 2, 15), 50);
            Assert.AreEqual(400, target.getBasePrice());
        }

        [Test()]
        public void TestThatFlightHasCorrectMiles()
        {
            var target = new Flight(new DateTime(2011, 2, 5), new DateTime(2011, 2, 6), 500);
            Assert.AreEqual(500, target.Miles);
        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightThrowsOnBadDates()
        {
            new Flight(new DateTime(2011, 3, 5), new DateTime(2011, 2, 12), 10);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void testThatFlightThrowsOnBadMiles()
        {
            new Flight(new DateTime(2011, 2, 5), new DateTime(2011, 2, 6), -5);
        }
	}
}