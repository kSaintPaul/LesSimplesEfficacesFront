using LesSimpleEfficacesFront.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LesSimpleEfficacesFront.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RouteView : ContentPage
	{
		public RouteView ()
		{
			InitializeComponent ();

            BindingContext = new RouteViewModel(Navigation);
        }
	}
}