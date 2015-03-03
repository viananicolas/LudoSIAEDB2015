using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Model.Entidade
{
    public class Player
    {
        private string nomeJogador;
        private int numeroJogado;
        private bool jogadorAI;
		private bool jogadorVenceu;

		public int NumeroJogado {
			get {
				return this.numeroJogado;
			}
			set
			{
				numeroJogado = value;
			}
		}
		public string NomeJogador
		{
			get
			{
				return this.nomeJogador;
			}
			set
			{
				nomeJogador = value;
			}
		}
		public bool JogadorAI
		{
			get
			{
				return this.jogadorAI;
			}
			set
			{
				jogadorAI = value;
			}
		}
		public bool JogadorVenceu
		{
			get
			{
				return this.jogadorVenceu;
			}
			set
			{
				jogadorVenceu = value;
			}
		}
	}
}
