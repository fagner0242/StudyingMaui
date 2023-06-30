namespace StudyingMaui;

public partial class StudyingContentPage : ContentPage
{
	public StudyingContentPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }
}