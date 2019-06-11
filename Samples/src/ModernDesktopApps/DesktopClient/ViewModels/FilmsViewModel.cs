using SWAPIRestClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopClient.ViewModels
{
    public class FilmsViewModel : ViewModelBase
    {
        private ISWAPIRestClient restClient;

        private ObservableCollection<string> filmNames;

        public ObservableCollection<string> ItemsSource
        {
            get
            {
                return filmNames;
            }
            set
            {
                filmNames = value;
                OnPropertyChanged();
            }
        }

        public FilmsViewModel(ISWAPIRestClient restClientImpl)
        {
            this.ItemsSource = new ObservableCollection<string>();

            this.restClient = restClientImpl;
        }

        public override async Task RefreshAsync()
        {
            this.ItemsSource = new ObservableCollection<string>(await this.restClient.GetFilmNames());
        }
    }
}
