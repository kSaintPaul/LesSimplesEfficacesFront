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

		    BindingContext = new ValidGameViewModel(Navigation, this);
		}
	}
}