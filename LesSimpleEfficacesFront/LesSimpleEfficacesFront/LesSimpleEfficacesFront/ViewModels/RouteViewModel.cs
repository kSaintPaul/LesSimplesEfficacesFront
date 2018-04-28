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
    public class RouteViewModel : BaseViewModel
    {
        #region Private Properties

        private readonly INavigation _navigation;

        #endregion

        #region CTOR

        public RouteViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        #endregion


        #region Normal Raised Prop => Routes

        private List<Route> _routes = new List<Route>()
        {
            new Route(){ Id = Guid.NewGuid(), Description = "Un super parcours pour tester ses connaissances tout en s'amusant", Designation ="Détente et joie de vivre", Duration = "Temps estimé : 1h", StartingDate = "Début : 14h", ParticipantsCount = "(Participants max : 3)"},
            new Route(){ Id = Guid.NewGuid(), Description = "Découvrez l'histoire de la ville à travers différentes activités", Designation ="Parcours découverte", Duration = "Temps estimé : 2h", StartingDate = "Début : 15h", ParticipantsCount = "(Participants max : 2)"}

        };

        public List<Route> Routes
        {
            get { return _routes; }
            set
            {
                _routes = value;
                RaisePropertyChanged("Routes");
            }
        }

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
            await _navigation.PushAsync(new DetailsRouteView());
        }
    }
}
