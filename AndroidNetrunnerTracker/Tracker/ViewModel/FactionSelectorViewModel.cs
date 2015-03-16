using Microsoft.Phone.Controls;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Tracker.Commands;
using Tracker.Model;

namespace Tracker.ViewModel
{
    public class FactionSelectorViewModel
    {
        ButtonCommand _navigateToFaction;

        public FactionSelectorViewModel()
        {
            this._navigateToFaction = new ButtonCommand(
                (o) => 
                { 
                    Faction f = (Faction)Enum.Parse(typeof(Faction), o.ToString());
                    PhoneApplicationFrame root = Application.Current.RootVisual as PhoneApplicationFrame;
                    root.Navigate(new Uri(string.Format("/TurnPage.xaml?selctedFaction={0}", f) , UriKind.Relative));
                },
                null);
        }

        public ICommand NavigateToFaction
        {
            get
            {
                return this._navigateToFaction;
            }

        }

    }
}
