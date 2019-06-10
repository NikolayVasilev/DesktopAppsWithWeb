using SWAPIRestClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClient.ViewModels
{
    public class PlanetsViewModel : ViewModelBase
    {
        private ISWAPIRestClient restClient;

        private ObservableCollection<string> planetNames;

        public ObservableCollection<string> PlanetNames
        {
            get
            {
                return planetNames;
            }
            set
            {
                planetNames = value;
                OnPropertyChanged();
            }
        }

        public PlanetsViewModel(ISWAPIRestClient restClientImpl)
        {
            this.PlanetNames = new ObservableCollection<string>();

            this.restClient = restClientImpl;

            this.Refresh();
        }

        public void Refresh()
        {
            this.PlanetNames = new ObservableCollection<string>(this.restClient.GetPlanetNames());
        }

    }
}
