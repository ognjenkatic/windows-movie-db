using movienotes.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.ViewModel
{
    public class MovieRowViewModel
    {
        public Movie TheMovie { get; set; }

        public MovieRowViewModel()
        {
            TheMovie = new Movie();
        }

        public MovieRowViewModel(Movie movie)
        {
            this.TheMovie = movie;
        }
    }
}
