using BMICalculator.MVVM.Views;

namespace BMICalculator
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new BMIView();
		}
	}
}
