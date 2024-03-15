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
			  Texto = "ae vo ti mostras o cara, mais soeiro da sidadi, bora la?",
        vaiterresposta=true,
        RespostasDoTexto01="Bora po",
        RespostasDoTexto02="to fora irmão, mais eu topo dar um passeio.",
        IdResposta01=4,
        IdResposta02=5, 
 });
     Historia.JogoPage.Add(new HistoriaDia()
 { 
       
  
        Id = 4,
			  Texto = "vo ti leva ate la",
			  vaiterresposta=false,

  });
  
     Historia.JogoPage.Add(new HistoriaDia() 

  {

          Id = 5,
          Texto = " ok...",
          vaiterresposta=false,   

  });


         Historia.JogoPage.Add(new HistoriaDia() 
   
  {

          Id = 6,
          Texto = " eae Juba Longa quanto tempo, vim te ti avisar que tem carne nova na area ",
          vaiterresposta=false,   

  });

         Historia.JogoPage.Add(new HistoriaDia() 
   
  {

          Id = 7,
          Texto = " serio memo, aiiiii qui dilisa",
          vaiterresposta=true,
          RespostasDoTexto01="e esse geitinho de baitola, por acaso eres gay?", 
          RespostasDoTexto02="...",
          IdResposta01=8,  
          IdResposta02=9, 

  });


         Historia.JogoPage.Add(new HistoriaDia() 
  {
          Id = 8,
          Texto = " quer morrer anão de jardin, quem tu pensas que é pra falar do meu geito em ou mindinho do lula ",
          vaiterresposta=false,   
          mamouotario=true,
});

        Historia.JogoPage.Add(new HistoriaDia() 


{
          Id = 9,
          Texto = "mordeu a lingua fiote de crus credo, ta longe de ser digno de ser zoera como eu...",
          vaiterresposta=true,   
          RespostasDoTexto01="não aguentou a sentada fadinha.",
          RespostasDoTexto02="obvio que não po ",
          IdResposta01=10,  
          IdResposta02=11, 

 });

  {
         Historia.JogoPage.Add(new HistoriaDia() 

          Id = 10,
          Texto = "uau o cabra é zuera, e inteligente como uma porta, entretanto infelismente nao há espaço para dois nesse lindo mundo de merda...",
          mamouotario=true,


  });




















}