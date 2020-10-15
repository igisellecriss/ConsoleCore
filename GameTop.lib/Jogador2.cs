using  GameTop.Interface;
namespace GameTop.lib
{
  public class Jogador2 : iJogador
  {
    public string Chuta()
    {
      return "Maradona estas pateando \n";
    }
    //corre
    public string Corre()
    {
      return "Maradona estas corriendo \n";
    }
    //passe
    public string Passe()
    {

      return "Maradona estas pasando \n";
    }
  }
}