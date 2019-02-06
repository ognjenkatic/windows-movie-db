using movienotes.Data;
using movienotes.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.ViewModel
{
    public class EditMovieViewModel : BaseViewModel
    {
        public MovieRowViewModel Movie { get; set; }

        public ViewModelCommand SaveMovieCommand { get; set; }

        public EditMovieViewModel()
        {
            SaveMovieCommand = new ViewModelCommand(SaveMovie, CanSaveMovie);
            Movie = new MovieRowViewModel();
        }

        public void SaveMovie(object parameter = null)
        {
            MovieDbContext.Instance.Movie.Add(Movie.TheMovie);
            Movie.TheMovie.RatingID = 1;
            MovieDbContext.Instance.SaveChanges();
            Movie = new MovieRowViewModel();
            RaisePropertyChanged("Movie");
        }

        public bool CanSaveMovie(object parameter = null)
        {
            return true;
        }


    }
}
