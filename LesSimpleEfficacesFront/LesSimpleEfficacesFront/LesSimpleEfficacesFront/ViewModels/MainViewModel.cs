using System.Windows.Input;
using LesSimpleEfficacesFront.Common;

namespace LesSimpleEfficacesFront.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Hello = "Hello World";
        }

        #region Propriete


        #region Normal Raised Prop => Hello

        private string _hello;

        public string Hello
        {
            get { return _hello; }
            set
            {
                _hello = value;
                RaisePropertyChanged("Hello");
            }
        }

        #endregion


        #endregion

        #region Command


        #region Normal ICommand => ButtonCommand    

        private ICommand _buttonCommand;

        public ICommand ButtonCommand
        {
            get
            {
                _buttonCommand = _buttonCommand ?? new RelayCommand(DoButtonCommand);
                return _buttonCommand;
            }
        }

        private void DoButtonCommand(object param)
        {

        }

        #endregion


        #endregion

    }
}
