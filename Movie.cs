using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoUni_Tasks
{
    internal class Movie
    {
        public string Title { get; private set; }
        public int ReleaseYear { get; private set; }

        public Movie(string title, int releaseYear)
        {
            Title = title;
            ReleaseYear = releaseYear;
        }
    }
}
