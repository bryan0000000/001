namespace bryuan;

public partial class JogoPage : ContentPage
{

	public JogoPage()
	{
      InitializeComponent();
	}
  private void botaovoltar(object sender, EventArgs args)
  {
      Application.Current.MainPage = new MainPage();
  }

}