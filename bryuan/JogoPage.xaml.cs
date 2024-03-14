namespace bryuan;

public partial class JogoPage : ContentPage
{
List<Historia.JogoPage> historia = new List<Historia.JogoPage>();
  Historia.JogoPage HistoriaDia;
	public JogoPage()
	{
      InitializeComponent();
	}
  
  Historia.JogoPage.Add(new HistoriaDia()

				  {
				
				Id = 0,
				Texto = "Ola amigo bem vindo ao cyberbullying, onde você pode fazer buling a vontade, eo melhor sem punição.",
				vaiterresposta=false
				  });

        Historia.JogoPage.Add(new HistoriaDia()

 {
                Id = 1,
                Texto = "então não perca tempo, oque você fala se você encontra um gordinho",
                vaiterresposta=true,
                RespostasDoTexto01="descupe por ser um magro privilegiado",
                RespostasDoTexto02="sabia que gordo nao vai pro céu, pois a porta é estreita kkkkkkkkk",
                IdResposta01=-1,
                IdResposta02=2,

});

     Historia.JogoPage.Add(new HistoriaDia()

{
				Id = 2,
				Texto = "eita pocha o muleke ta avançado",
				vaiterresposta=false,

});
   Historia.JogoPage.Add(new HistoriaDia()

   {
              Id = -1,
			  Texto = "meu deus, seu preto tu não conseque fazer um buling direito, seu estranho",
			  vaiterresposta=false,
   });


    Historia.JogoPage.Add(new HistoriaDia()

  {
              Id = 3,
			  Texto = "ae vo ti mostras o cara mais soeiro da sidadi, bora la?", 

  }























































































  }

