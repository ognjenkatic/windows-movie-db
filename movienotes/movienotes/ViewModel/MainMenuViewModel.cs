using movienotes.Utility;
using movienotes.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.ViewModel
{
    public class MainMenuViewModel : BaseViewModel
    {
        public ViewModelCommand NavigateFrontPageCommand { get; set; }

        public MainMenuViewModel() : base()
        {
            NavigateFrontPageCommand = new ViewModelCommand(NavigateFrontPage, CanNavigateFrontPage);
        }

        public void NavigateFrontPage(object parameter = null)
        {
            Messenger.Instance.SendNavigateMessage("FrontPage");
        }

        public bool CanNavigateFrontPage(object parameter = null)
        {
            return true;
        }
    }
}
