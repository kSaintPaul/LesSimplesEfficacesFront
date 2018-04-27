using LesSimpleEfficacesFront.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LesSimpleEfficacesFront.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegistrationView : ContentPage
	{
		public RegistrationView ()
		{
			InitializeComponent ();

            BindingContext = new RegistrationViewModel(Navigation, this);
		}
	}
}