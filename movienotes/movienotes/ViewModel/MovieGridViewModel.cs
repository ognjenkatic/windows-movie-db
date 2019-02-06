using Microsoft.EntityFrameworkCore;
using movienotes.Data;
using movienotes.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.ViewModel
{
    public class MovieGridViewModel : BaseCrudViewModel
    {
        private ObservableCollection<MovieRowViewModel> _movies; 

        public MovieRowViewModel SelectedMovie { get; set; }

        public ObservableCollection<MovieRowViewModel> Movies
        {
            get
            {
                return _movies;
            }set
            {
                if (_movies == null || !_movies.Equals(value))
                {
                    _movies = value;
                    RaisePropertyChanged("Movies");
                }
            }
        }

        public MovieGridViewModel() : base()
        {
            
        }

        protected async override void SelectAll()
        {
            var movs = await MovieDbContext.Instance.Movie.OrderBy(m => m.YearOfRelease).ToListAsync();

            _movies = new ObservableCollection<MovieRowViewModel>();

            foreach (var mov in movs)
            {
                _movies.Add(new MovieRowViewModel(mov));
            }

            RaisePropertyChanged("Movies");
        }
    }
}
