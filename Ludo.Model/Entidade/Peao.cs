using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Model.Entidade
{

   
    public abstract class Peao
    {
        private string cor;
		private string numPeao;
		private bool naBase;
		private bool venceu;
		private string quadrado;

		public Peao(string Cor, string numPeao)
		{
			this.cor = Cor;
			this.numPeao = numPeao;
		}
		public string NumPeao
		{
			get
			{
				return this.numPeao;
			}

			set
			{
				this.numPeao = value;
			}
		}

		public string Quadrado
		{
			get
			{
				return this.quadrado;
			}

			set
			{
				this.quadrado = value;
			}
		}
			public bool NaBase
		{

			get
			{
				return this.naBase;
			}

			set
			{
				this.naBase = value;
			}

		}
		public bool Venceu
		{

			get
			{
				return this.venceu;
			}

			set
			{
				this.venceu = value;
			}
		}
		public void StatusPeca(bool NaBase, bool Venceu)
		{
			this.NaBase = naBase;
			this.Venceu = venceu;
		}

		public void Rotas()
		{
			/*string[] RotasAmarelo = {"50", "47", "44", "31", "48",
									 "17", "14", "11", "8", "5", "2",
									 "1", "0", "3", "6", "9", "12", "15",
									 "71", "68", "65", "62", "59", "56",
									 "55", "54", "57", "60", "63", "66", "69",
									"33", "};*/
		}
	}
}
