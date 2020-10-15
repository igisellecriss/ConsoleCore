using System;
using GameTop.Interface;
using GameTop.lib;

namespace GameTOP
{
  class Program
  {
    static void Main(string[] args)
    {
      var jogo = new JogoFODA(
          new Jogador2(),
          new Jogador3()
          );
      jogo.IniciarJogo();
    }
  }


}
