using LesSimpleEfficacesFront.Common;
using LesSimpleEfficacesFront.Models;
using LesSimpleEfficacesFront.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LesSimpleEfficacesFront.ViewModels
{
    public class ThemeViewModel : BaseViewModel
    {
        #region Private Properties

        private readonly INavigation _navigation;

        #endregion

        #region CTOR

        public ThemeViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        #endregion

        #region Normal Raised Prop => Title

        private string _title = "Thèmes";

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                RaisePropertyChanged("Title");
            }
        }

        #endregion

        #region Normal Raised Prop => Themes

        private List<Theme> _themes = new List<Theme>()
        {
            new Theme() { Id = Guid.NewGuid(), Designation = "Découverte/Histoire", Description= "Mégaparcours" },
            new Theme() { Id = Guid.NewGuid(), Designation = "Spécialités locales", Description= "Simpleparcours" },
            new Theme() { Id = Guid.NewGuid(), Designation = "Nature", Description= "Gigaparcours" },
            new Theme() { Id = Guid.NewGuid(), Designation = "Culture générale", Description= "Nanoparcours" }
        };

        public List<Theme> Themes
        {
            get { return _themes; }
            set
            {
                _themes = value;
                RaisePropertyChanged("Themes");
            }
        }

        #endregion

        #region Command

        #region Normal ICommand => ThemeTappedCommand

        private ICommand _themeTappedCommand;

        public ICommand ThemeTappedCommand
        {
            get
            {
                _themeTappedCommand = _themeTappedCommand ?? new RelayCommand(DoThemeTappedCommandCommand);
                return _themeTappedCommand;
            }
        }

        private async void DoThemeTappedCommandCommand(object param)
        {
            await _navigation.PushAsync(new RouteView());
        }

        #endregion


        #endregion



        private ICommand _goToRoutesCommand;

        public ICommand GoToRoutesCommand
        {
            get
            {
                _goToRoutesCommand = _goToRoutesCommand ?? new RelayCommand(DoGoToRoutesCommandCommand);
                return _goToRoutesCommand;
            }
        }

        private async void DoGoToRoutesCommandCommand(object param)
        {
            await _navigation.PushAsync(new RouteView());
        }
    }
}
