using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LesSimpleEfficacesFront.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LesSimpleEfficacesFront.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ValidGameView : ContentPage
	{
		public ValidGameView ()
		{
			InitializeComponent ();

		    BindingContext = new ValidGameViewModel();
		}
	}
}