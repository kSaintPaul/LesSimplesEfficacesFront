using LesSimpleEfficacesFront.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LesSimpleEfficacesFront.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
		public LoginView ()
		{
			InitializeComponent ();

		    BindingContext = new LoginViewModel(Navigation, this);
		}
	}
}