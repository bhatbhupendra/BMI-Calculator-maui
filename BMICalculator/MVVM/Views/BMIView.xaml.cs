using BMICalculator.MVVM.ViewModels;

namespace BMICalculator.MVVM.Views;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
	}
}