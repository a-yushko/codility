using System;
using System.Collections.Generic;
using Assesment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MovieRecommendationsTest
    {
        [TestMethod]
        public void TestSimple()
        {
            var movies = GetTestCase1();

            var result = MovieRecommendations.getMovieRecommendations(movies[0], 1);

            Assert.AreEqual(1, result.Count);
            CollectionAssert.Contains(result, movies[1]);
        }

        [TestMethod]
        public void TestSimple2()
        {
            var movies = GetTestCase1();

            var result = MovieRecommendations.getMovieRecommendations(movies[0], 3);

            Assert.AreEqual(2, result.Count);
            CollectionAssert.Contains(result, movies[1]);
            CollectionAssert.Contains(result, movies[2]);
        }

        [TestMethod]
        public void TestNormal()
        {
            var movies = GetTestCase2();

            var result = MovieRecommendations.getMovieRecommendations(movies[0], 4);

            Assert.AreEqual(4, result.Count);
            CollectionAssert.Contains(result, movies[3]);
            CollectionAssert.Contains(result, movies[5]);
            CollectionAssert.Contains(result, movies[6]);
            CollectionAssert.Contains(result, movies[7]);
        }

        [TestMethod]
        public void TestNormal2()
        {
            var movies = GetTestCase2();

            var result = MovieRecommendations.getMovieRecommendations(movies[0], 5);

            Assert.AreEqual(5, result.Count);
            CollectionAssert.Contains(result, movies[3]);
            CollectionAssert.Contains(result, movies[4]);
            CollectionAssert.Contains(result, movies[5]);
            CollectionAssert.Contains(result, movies[6]);
            CollectionAssert.Contains(result, movies[7]);
        }

        [TestMethod]
        public void TestNormal3()
        {
            var movies = GetTestCase2();

            var result = MovieRecommendations.getMovieRecommendations(movies[0], 0);

            Assert.AreEqual(0, result.Count);
        }

        /*
            (1)1.2
            /    \
        (2)3.6  (3)2.4
        */
        private List<Movie> GetTestCase1()
        {
            Movie m1 = new Movie(1, 1.2F);
            Movie m2 = new Movie(2, 3.6F);
            Movie m3 = new Movie(3, 2.4F);
            m1.addSimilarMovie(m2);
            m1.addSimilarMovie(m3);
            return new List<Movie>() {m1, m2, m3 };
        }
        /*
               (1)6.2
             /   |   \
            /    |    \
        (2)3.6 (3)2.4 (4)9.8
            \   /     /     \
           (5)5.1  (6)8.4---(7)8.4
                               |
                             (8)8.0
        */
        private List<Movie> GetTestCase2()
        {
            Movie m1 = new Movie(1, 6.2F);
            Movie m2 = new Movie(2, 3.6F);
            Movie m3 = new Movie(3, 2.4F);
            Movie m4 = new Movie(4, 9.8F);
            Movie m5 = new Movie(5, 5.1F);
            Movie m6 = new Movie(6, 8.4F);
            Movie m7 = new Movie(7, 8.4F);
            Movie m8 = new Movie(8, 8.0F);

            m1.addSimilarMovie(m2);
            m1.addSimilarMovie(m3);
            m1.addSimilarMovie(m4);

            m2.addSimilarMovie(m5);
            m3.addSimilarMovie(m5);
            m4.addSimilarMovie(m6);
            m4.addSimilarMovie(m7);
            m6.addSimilarMovie(m7);

            m7.addSimilarMovie(m8);
            return new List<Movie>() {m1, m2, m3, m4, m5, m6, m7, m8};
        }
    }
}
