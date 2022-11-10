using HealthSafetyApp.Helpers;
using HealthSafetyApp.Models;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HealthSafetyApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region fields
        private List<Team> teams;
        private Team selectedItem;
        private bool isRefreshing;
        #endregion

        #region Properties
        public List<Team> Teams
        {
            get { return teams; }
            set { teams = value; OnPropertyChanged(nameof(Teams)); }
        }

        public Team SelectedTeam
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                System.Diagnostics.Debug.WriteLine("Team Selected : " + value.Name);
            }
        }

        public bool IsRefreshing
        {
            get { return isRefreshing; }
            set { isRefreshing = value; OnPropertyChanged(nameof(IsRefreshing)); }
        }

        public ICommand RefreshCommand { get; set; }
        #endregion

        public MainViewModel()
        {
            try
            {
                Teams = DummyDataProvider.GetTeams();
                RefreshCommand = new Command(CmdRefresh);
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }
           
        }

        private async void CmdRefresh()
        {
            IsRefreshing = true;
           // wait 3 secs for demo
           await Task.Delay(2000);
           IsRefreshing = false;
        }

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        #endregion
    }
}
