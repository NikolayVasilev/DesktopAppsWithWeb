using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DesktopClient.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void Refresh()
        {

        }

        public virtual async Task RefreshAsync()
        {

        }
    }
}