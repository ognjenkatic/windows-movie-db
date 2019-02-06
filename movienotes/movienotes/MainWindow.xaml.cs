using movienotes.Data;
using movienotes.Model.Base;
using movienotes.Utility;
using movienotes.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace movienotes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Messenger.Instance.NavigateEvent += ReceiveNavigateMessage;
        }

        private void ReceiveNavigateMessage(object sender, NavigateMessageArgs args)
        {
            try
            {
                Page page = null;
                switch (args.PageName)
                {
                    case ("FrontPage"):
                        {
                            page = new FrontPage();
                            break;
                        }
                    case ("NewMovie"):
                        {
                            page = new NewMovie();
                            break;
                        }
                }
                if (page != null)
                {
                    if (args.ViewModel != null)
                        page.DataContext = args.ViewModel;
                    navigationFrame.NavigationService.Navigate(page);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception while loading page " + args.PageName + " " + exc.Message);
            }
        }
    }
}
