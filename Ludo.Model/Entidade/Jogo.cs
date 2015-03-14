using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Model.Entidade
{
	public class Jogo
	{
		private int numTurnos;
		private bool iniciaJogo;
		private bool terminaJogo;
		private List<Player> player;
		public Player TurnoJogador;
		private int turnojogadpr;
		private bool jogouSeis;
		public Acoes proximaAcao = Acoes.Nada;

		public void ComecaJogo(List<Player> Jogadores, List<Peao>PeoesJogo)
		{
			this.player = Jogadores;
			jogouSeis = false;
			numTurnos = 1;
			proximaAcao = Acoes.JogarDado;
			TurnoJogador = this.player[0];
		}
		public void EncerrarJogo()
		{
			proximaAcao = Acoes.EncerrarJogo;
		}

		public void MoverPeca()
		{

		}
		
	}
}
