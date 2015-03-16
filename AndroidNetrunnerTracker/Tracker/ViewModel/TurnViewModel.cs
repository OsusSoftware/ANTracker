using System.Collections.Generic;
using System.Collections.ObjectModel;
using Tracker.Commands;

namespace Tracker.ViewModel
{
    public class TurnViewModel
    {
        public TurnViewModel()
        {
            TurnProperties = new List<IncreaseDecreasePropertyViewModel>();

            IncreaseDecreasePropertyViewModel clicks = new IncreaseDecreasePropertyViewModel("Clicks");
            clicks.DecreaseCommand = new ButtonCommand(null, null);
            TurnProperties.Add(clicks);

            IncreaseDecreasePropertyViewModel tokens = new IncreaseDecreasePropertyViewModel("Tokens");
            tokens.Count = 5;
            TurnProperties.Add(tokens);

            IncreaseDecreasePropertyViewModel agendas = new IncreaseDecreasePropertyViewModel("Agendas");
            TurnProperties.Add(agendas);

        }

        public List<IncreaseDecreasePropertyViewModel> TurnProperties { get; set; }

        public string Name { get; set; }
    }
}
