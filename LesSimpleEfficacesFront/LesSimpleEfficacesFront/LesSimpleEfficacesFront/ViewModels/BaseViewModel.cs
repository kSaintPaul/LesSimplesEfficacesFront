using System.ComponentModel;

namespace LesSimpleEfficacesFront.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        #region RaisePropertyChanged & Event

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
