using System;
using System.Collections.Generic;

namespace Assesment
{
    public class Movie
    {
        private int _id;
        private float _rating;
        private List<Movie> _similarMovies = new List<Movie>();

        public Movie(int movieId, float rating)
        {
            _id = movieId;
            _rating = rating;
        }

        public int getId()
        {
            return _id;
        }

        public float getRating()
        {
            return _rating;
        }

        public void addSimilarMovie(Movie movie)
        {
            _similarMovies.Add(movie);
        }

        public List<Movie> getSimilarMovies()
        {
            return _similarMovies;
        }
    }
}
