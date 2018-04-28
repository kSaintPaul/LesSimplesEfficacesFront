using System.Windows.Input;
using LesSimpleEfficacesFront.Common;
using Xamarin.Forms;

namespace LesSimpleEfficacesFront.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        private INavigation _navigation;

        #region CTOR

        public MainViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        #endregion

        #region Propriete
        


        #endregion

        #region Command
        
        #region Normal ICommand => RoutCommand

        private ICommand _routCommand;

        public ICommand RoutCommand
        {
            get
            {
                _routCommand = _routCommand ?? new RelayCommand(DoRoutCommand);
                return _routCommand;
            }
        }

        private void DoRoutCommand(object param)
        {

        }

        #endregion
        
        #region Normal ICommand => FriendCommand

        private ICommand _friendCommand;

        public ICommand FriendCommand
        {
            get
            {
                _friendCommand = _friendCommand ?? new RelayCommand(DoFriendCommand);
                return _friendCommand;
            }
        }

        private void DoFriendCommand(object param)
        {

        }

        #endregion
        
        #region Normal ICommand => GroupCommand

        private ICommand _groupCommand;

        public ICommand GroupCommand
        {
            get
            {
                _groupCommand = _groupCommand ?? new RelayCommand(DoGroupCommand);
                return _groupCommand;
            }
        }

        private void DoGroupCommand(object param)
        {

        }

        #endregion
        
        #region Normal ICommand => StatCommand

        private ICommand _statCommand;

        public ICommand StatCommand
        {
            get
            {
                _statCommand = _statCommand ?? new RelayCommand(DoStatCommand);
                return _statCommand;
            }
        }

        private void DoStatCommand(object param)
        {

        }

        #endregion
        
        #region Normal ICommand => AccountCommand

        private ICommand _accountCommand;

        public ICommand AccountCommand
        {
            get
            {
                _accountCommand = _accountCommand ?? new RelayCommand(DoAccountCommand);
                return _accountCommand;
            }
        }

        private void DoAccountCommand(object param)
        {

        }

        #endregion
        
        #endregion

    }
}
