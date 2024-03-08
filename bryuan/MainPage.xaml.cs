namespace bryuan;

public partial class MainPage : ContentPage
{


	

	public MainPage()
	{
      InitializeComponent();
	}
private void BotaoCreditos(object sender, EventArgs args)
  {
   // frameSettings.IsVisible = true;

  }

private void botaoSTART(object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new JogoPage();
  }

}