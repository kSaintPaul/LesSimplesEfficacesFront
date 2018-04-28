using LesSimpleEfficacesFront.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LesSimpleEfficacesFront.ViewModels
{
    public class DetailRouteViewModel : BaseViewModel
    {

        #region Private Properties

        private readonly INavigation _navigation;

        #endregion

        #region CTOR

        public DetailRouteViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        #endregion
        
    }
}
