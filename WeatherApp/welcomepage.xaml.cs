namespace WeatherApp.Services;

public partial class welcomepage : ContentView
{
	public welcomepage()
	{
		InitializeComponent();
	}
	private void BtnGetStarted_Clicked(object sender, EventArgs e)
	{
		Navigation.PushModalAsync(new WeatherPage());
	}
}