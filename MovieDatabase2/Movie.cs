using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase2
{
    internal class Movie
    {
        public string movieTitle;
        public string movieCategory;

        public Movie(string movieTitle, string movieCategory)
        {
            this.movieTitle = movieTitle;
            this.movieCategory = movieCategory;

        }
    }

}