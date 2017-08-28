using System;
using System.Collections.Generic;
using System.Linq;

namespace Assesment
{
    public static class MovieRecommendations
    {
        public static List<Movie> getMovieRecommendations(Movie movie, int N)
        {
            Dictionary<int, Movie> network = new Dictionary<int, Movie>();
            Traverse(movie, ref network);
            //var flat = movie.getSimilarMovies().SelectMany(m => m.getSimilarMovies());
            //foreach (var mov in flat)
            //{
            //    if (/*mov.getId() != movie.getId() && */!network.ContainsKey(mov.getId()))
            //        network.Add(mov.getId(), mov);
            //}
            int count = N;
            if (count > network.Count)
                count = network.Count;

            var sorted = network.OrderByDescending(i => i.Value.getRating());
            var result = sorted.Take(count).Select(i => i.Value).ToList();
            return result;
        }

        public static void Traverse(Movie movie, ref Dictionary<int, Movie> network)
        {
            var similar = movie.getSimilarMovies();
            foreach (var mov in similar)
            {
                if (!network.ContainsKey(mov.getId()))
                {
                    network.Add(mov.getId(), mov);
                    Traverse(mov, ref network);
                }
            }
        }
    }
}
