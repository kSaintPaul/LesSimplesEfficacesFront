using System;
using System.Windows.Input;
using LesSimpleEfficacesFront.Common;
using LesSimpleEfficacesFront.Views;
using Xamarin.Forms;

namespace LesSimpleEfficacesFront.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {

        #region Private Properties

        private readonly INavigation _navigation;
        private readonly Page _page;

        #endregion

        #region CTOR

        public RegistrationViewModel(INavigation navigation, Page page)
        {
            _navigation = navigation;
            _page = page;
        }

        #endregion
        
        #region Properties
        
        #region Normal Raised Prop => LastName

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                RaisePropertyChanged("LastName");
            }
        }

        #endregion
        
        #region Normal Raised Prop => FirstName

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                RaisePropertyChanged("FirstName");
            }
        }

        #endregion
        
        #region Normal Raised Prop => Mail

        private string _mail;

        public string Mail
        {
            get { return _mail; }
            set
            {
                _mail = value;
                RaisePropertyChanged("Mail");
            }
        }

        #endregion
        
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
        
        #region Normal Raised Prop => PasswordConfirm

        private string _passwordConfirm;

        public string PasswordConfirm
        {
            get { return _passwordConfirm; }
            set
            {
                _passwordConfirm = value;
                RaisePropertyChanged("PasswordConfirm");
            }
        }

        #endregion
        
        #region Normal Raised Prop => DateBirthDay

        private DateTime _dateBirthDay;

        public DateTime DateBirthDay
        {
            get { return _dateBirthDay; }
            set
            {
                _dateBirthDay = value;
                RaisePropertyChanged("DateBirthDay");
            }
        }

        #endregion
        
        #endregion

        #region Command
        
        #region Normal ICommand => SaveCommand

        private ICommand _saveCommand;

        public ICommand SaveCommand
        {
            get
            {
                _saveCommand = _saveCommand ?? new RelayCommand(DoSaveCommand);
                return _saveCommand;
            }
        }

        private async void DoSaveCommand(object param)
        {
            if (Password != PasswordConfirm)
            {
                await _page.DisplayAlert("Confirmation", "Les mots de passe doivent être identique", "Ok");
                return;
            }

            await _navigation.PushAsync(new MainView());
        }

        #endregion
        
        #region Normal ICommand => ResetCommand

        private ICommand _resetCommand;

        public ICommand ResetCommand
        {
            get
            {
                _resetCommand = _resetCommand ?? new RelayCommand(DoResetCommand);
                return _resetCommand;
            }
        }

        private async void DoResetCommand(object param)
        {
            if (await _page.DisplayAlert("Confirmation", "Voulez-vous effacer tous les champs ?", "Oui", "Nom"))
            {
                LastName = string.Empty;
                FirstName = string.Empty;
                Mail = string.Empty;
                Login = string.Empty;
                Password = string.Empty;
                PasswordConfirm = string.Empty;
                DateBirthDay = DateTime.Now;
            }
        }

        #endregion
        
        #endregion

    }
}
