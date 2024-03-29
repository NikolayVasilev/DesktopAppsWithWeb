﻿using SWAPIRestClient;
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

        public ObservableCollection<string> ItemsSource
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
            this.ItemsSource = new ObservableCollection<string>();

            this.restClient = restClientImpl;

            this.Refresh();
        }

        public override void Refresh()
        {
            this.ItemsSource = new ObservableCollection<string>(this.restClient.GetPlanetNames());
        }

    }
}
