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
        public ViewModelCommand NavigateCommand { get; set; }

        public MainMenuViewModel() : base()
        {
            NavigateCommand = new ViewModelCommand(NavigatePage, CanNavigatePage);
        }
        
        public void NavigatePage(object parameter = null)
        {
            Messenger.Instance.SendNavigateMessage(new NavigateMessageArgs
            {
                PageName = parameter.ToString(),
                ViewModel = null
            });
        }

        public bool CanNavigatePage(object parameter = null)
        {
            return true;
        }
    }
}
