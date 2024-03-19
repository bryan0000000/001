namespace bryuan;

public partial class JogoPage : ContentPage
{
List<historiadojogo> historia = new List<historiadojogo>();
  Historiadojogo Historiadojogoatual;
	public JogoPage()
	{
      InitializeComponent();
	}
  
  Historia.Add(new historiadojogo()

				  {
				
				Id = 0,
				Texto = "Ola amigo bem vindo ao cyberbullying, onde você pode fazer buling a vontade, eo melhor sem punição.",
				vaiterresposta=false
				  });

        Historia.Add(new historiadojogo()

 {
                Id = 1,
                Texto = "então não perca tempo, oque você fala se você encontra um gordinho",
                vaiterresposta=true,
                RespostasDoTexto01="descupe por ser um magro privilegiado",
                RespostasDoTexto02="sabia que gordo nao vai pro céu, pois a porta é estreita kkkkkkkkk",
                IdResposta01=-1,
                IdResposta02=2,

});

     Historia.Add(new historiadojogo()

{
	      Id = 2,
	      Texto = "eita pocha o muleke ta avançado",
	      vaiterresposta=false,

});
   Historia.Add(new historiadojogo()

   {
              Id =-1,
              Texto = "meu deus, seu preto tu não conseque fazer um buling direito, seu estranho",
	            mamouotario=true,
              vaiterresposta=false,
   });


    Historia.Add(new historiadojogo()

  { 
        Id = 3,
	Texto = "ae vo ti mostras o cara, mais soeiro da sidadi, bora la?",
        vaiterresposta=true,
        RespostasDoTexto01="Bora po",
        RespostasDoTexto02="to fora irmão, mais eu topo dar um passeio.",
        IdResposta01=4,
        IdResposta02=5, 
 });
     Historia.Add(new historiadojogo()
 { 
       
  
         Id = 4,
         Texto = "vo ti leva ate la",
         vaiterresposta=false,

  });
  
     Historia.Add(new historiadojogo() 

  {
          Id = 5,
          Texto = " ok...",
          vaiterresposta=false,   

  });


         Historia.Add(new historiadojogo() 
   
  {

          Id = 6,
          Texto = " eae Juba Longa quanto tempo, vim te ti avisar que tem carne nova na area ",
          vaiterresposta=false,   

  });

         Historia.Add(new historiadojogo() 
   
  {

          Id = 7,
          Texto = " serio memo, aiiiii qui dilisa",
          vaiterresposta=true,
          RespostasDoTexto01="e esse geitinho de baitola, por acaso eres gay?", 
          RespostasDoTexto02="...",
          IdResposta01=8,  
          IdResposta02=9, 

  });


         Historia.Add(new historiadojogo() 
  {
          Id = 8,
          Texto = " quer morrer anão de jardin, quem tu pensas que é pra falar do meu geito em ou mindinho do lula ",
          vaiterresposta=false,   
          mamouotario=true,
});

        Historia.Add(new historiadojogo() 


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
         Historia.Add(new historiadojogo() 

          Id = 10,
          Texto = "uau o cabra é zuera, e inteligente como uma porta, entretanto infelismente nao há espaço para dois nesse lindo mundo de merda...",
          mamouotario=true,
           vaiterresposta=false,   


  });



  {
         Historia.Add(new historiadojogo() 

          Id = 11,
          Texto = "uau vc é tao zuera quanto uma pedra, irmao vc esta apto para ser meu amigo...",
          finalbom=true
          vaiterresposta=false,  

  });
  Iniciar();

 }
 
 void Iniciar()


 {
    Historia.JogoPagetroca(0)
 }
 void preenceherP()


 {
  labelfala.text=Historia.JogoPagetroca
 
   if(Historia.JogoPagetroca.mamouotario)
     frameMamouotario.IsVisible = true;
 else
     frameMamouotario.IsVisible = false;
 
     if(Historia.JogoPagetroca.vaiterresposta)
 
 {
   botaoVer.IsVisible = false;     
   buttonResposta01.IsVisible = true;
   buttonResposta02.IsVisible = true;
  Historia.JogoPagetroca.Respostas buttonResposta01.Text = DoTexto01;
   buttonResposta02.Text = fHistoria.JogoPagetroca.RespostasDoTexto02;
 }
 
  else
 {
 botaoVer.IsVisible = true;
buttonResposta01.IsVisible = false;
buttonResposta02.IsVisible = false;

 }

}


  void botaover(object sender, EventArgs args)
  {
    var proximoId = HistoryStepAtual.Id + 1;
     Historia.JogoPagetroca(proximoId);
  }

  

  void RespostasDoTexto01(object sender, EventArgs args)
  {
   Historia.JogoPagetroca(HistoryStepAtual.IdLevelResposta01);
  }

  

  void RespostasDoTexto02(object sender, EventArgs args)
  {
    Historia.JogoPagetroca(HistoryStepAtual.IdLevelResposta02);
  }
  

  void mamouotario(object sender, EventArgs args)
  {
    Iniciar();
  }



