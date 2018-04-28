using LesSimpleEfficacesFront.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LesSimpleEfficacesFront.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainView : ContentPage
	{
		public MainView ()
		{
			InitializeComponent();

		    BindingContext = new MainViewModel(Navigation);
		}
	}
}