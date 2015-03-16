using Microsoft.Phone.Controls;
using System.Windows.Navigation;
using Tracker.ViewModel;

namespace Tracker
{
    public partial class TurnPage : PhoneApplicationPage
    {
        public TurnPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if(this.DataContext == null)
            {
                this.DataContext = new TurnViewModel();
            }
        }
    }
}