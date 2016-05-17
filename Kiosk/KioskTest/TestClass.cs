using System;
using System.Collections.Generic;
using System.Linq;
using Kiosk.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KioskTest
{
    [TestClass]
    public class TestClass
    {
        const int NumberOfRatingsToUse = 10;
        [TestMethod]
        public void TestMethod_AverageForOneReview()
        {

            var myKiosk = BuildKiosken(8);
            var rater = new KioskRater(myKiosk);
            var result = rater.ComputeOverallRate(NumberOfRatingsToUse);
            var actual = result.Rating;
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_AverageForTwoReviews()
        {

            //var kiosk = new Kiosken();
            //kiosk.Reviews=new List<Review>();
            //kiosk.Reviews.Add(new Review() {Rating = 4});
            //kiosk.Reviews.Add(new Review() { Rating = 6 });
            //var rater = new KioskRater(kiosk);
            var myKiosk = BuildKiosken(4, 6);
            var rater = new KioskRater(myKiosk);
            var result = rater.ComputeOverallRate(NumberOfRatingsToUse);
            var actual = result.Rating;
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod_ComputedTwoRatings()
        {
            var data = BuildKiosken(3,9);
            var rater = new KioskRater(data);
            var result = rater.ComputeWeightedRate(NumberOfRatingsToUse);
            var expected = 5;
           

        }

        private Kiosken BuildKiosken(params int[] ratings)
        {
            var result = new Kiosken();
            result.Reviews = ratings.Select(r => new Review() { Rating = r }).ToList();
            return result;
        }
    }
}
