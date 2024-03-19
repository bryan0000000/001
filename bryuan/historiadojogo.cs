public class Historiadojogos
{
  public int Id; // serve para organizar a historia, como o jeck stripador vamos por partes 
  public string? Texto;// as falas
  public bool vaiterresposta = false;//variavel que diz que tem resposta ou não
  public string?  RespostasDoTexto01;// botão resposta01
  public string?  RespostasDoTexto02;// botão resposta02
  public int  IdResposta01;//leva para prosima fala da resposta01
  public int  IdResposta02;//leva para prosima fala da resposta02
  public bool mamouotario = false;//diz que seu personagen morreu

}
