using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movienotes.ViewModel.Base
{
    public class BaseCrudViewModel : BaseViewModel
    {
        public BaseCrudViewModel()
        {
            SelectAll();
        }

        protected virtual void SelectAll()
        {

        }
    }
}
