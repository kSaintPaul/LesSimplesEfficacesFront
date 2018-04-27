using System.Windows.Input;
using LesSimpleEfficacesFront.Common;
using LesSimpleEfficacesFront.Views;
using Xamarin.Forms;

namespace LesSimpleEfficacesFront.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        #region Private Properties
        
        private readonly INavigation _navigation;

        #endregion

        #region CTOR

        public LoginViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        #endregion

        #region Propriete


        #region Normal Raised Prop => Login

        private string _login;

        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                RaisePropertyChanged("Login");
            }
        }

        #endregion


        #region Normal Raised Prop => Password

        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged("Password");
            }
        }

        #endregion

        #endregion

        #region Command


        #region Normal ICommand => LoginCommand

        private ICommand _loginCommand;

        public ICommand LoginCommand
        {
            get
            {
                _loginCommand = _loginCommand ?? new RelayCommand(DoLoginCommand);
                return _loginCommand;
            }
        }

        private void DoLoginCommand(object param)
        {

        }

        #endregion


        #region Normal ICommand => RegisterCommand

        private ICommand _registerCommand;

        public ICommand RegisterCommand
        {
            get
            {
                _registerCommand = _registerCommand ?? new RelayCommand(DoRegisterCommand);
                return _registerCommand;
            }
        }

        private void DoRegisterCommand(object param)
        {
            _navigation.PushAsync(new RegistrationView());
        }

        #endregion
        
        #endregion

    }
}
