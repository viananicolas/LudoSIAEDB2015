using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Model.Entidade
{

   
    public class Peao
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

		public Tuple<double, double> Rotas(string posicaoquadrado, int numsorteado, double posicaoatualx, double posicaoatualy)
		{
			/*string[] RotasAmarelo = {"50", "47", "44", "31", "48",
									 "17", "14", "11", "8", "5", "2",
									 "1", "0", "3", "6", "9", "12", "15",
									 "71", "68", "65", "62", "59", "56",
									 "55", "54", "57", "60", "63", "66", "69",
									"33", "};*/
			
			Dictionary<string, Tuple<double, double>> RotasAzuis = new Dictionary<string, Tuple<double, double>>();
			RotasAzuis.Add("22", Tuple.Create(Convert.ToDouble(497), Convert.ToDouble(309.25)));
			RotasAzuis.Add("26", Tuple.Create(Convert.ToDouble(462), Convert.ToDouble(309.25)));
			RotasAzuis.Add("29", Tuple.Create(Convert.ToDouble(424), Convert.ToDouble(309.25)));
			RotasAzuis.Add("32", Tuple.Create(Convert.ToDouble(387), Convert.ToDouble(309.25)));
			RotasAzuis.Add("35", Tuple.Create(Convert.ToDouble(351), Convert.ToDouble(309.25)));
			RotasAzuis.Add("36", Tuple.Create(Convert.ToDouble(312), Convert.ToDouble(348.25)));
			RotasAzuis.Add("42", Tuple.Create(Convert.ToDouble(312), Convert.ToDouble(385.25)));
			RotasAzuis.Add("45", Tuple.Create(Convert.ToDouble(312), Convert.ToDouble(422.25)));
			RotasAzuis.Add("49", Tuple.Create(Convert.ToDouble(312), Convert.ToDouble(458.25)));
			RotasAzuis.Add("51", Tuple.Create(Convert.ToDouble(312), Convert.ToDouble(495.25)));
			RotasAzuis.Add("52", Tuple.Create(Convert.ToDouble(271), Convert.ToDouble(495.25)));
			RotasAzuis.Add("53", Tuple.Create(Convert.ToDouble(231), Convert.ToDouble(495.25)));
			RotasAzuis.Add("50", Tuple.Create(Convert.ToDouble(231), Convert.ToDouble(495.25)));
			RotasAzuis.Add("47", Tuple.Create(Convert.ToDouble(231), Convert.ToDouble(458.25)));
			RotasAzuis.Add("44", Tuple.Create(Convert.ToDouble(231), Convert.ToDouble(422.25)));
			RotasAzuis.Add("41", Tuple.Create(Convert.ToDouble(231), Convert.ToDouble(385.25)));
			RotasAzuis.Add("38", Tuple.Create(Convert.ToDouble(231), Convert.ToDouble(348.25)));
			RotasAzuis.Add("17", Tuple.Create(Convert.ToDouble(192), Convert.ToDouble(309.25)));
			RotasAzuis.Add("14", Tuple.Create(Convert.ToDouble(155), Convert.ToDouble(309.25)));
			RotasAzuis.Add("11", Tuple.Create(Convert.ToDouble(118), Convert.ToDouble(309.25)));
			RotasAzuis.Add("8", Tuple.Create(Convert.ToDouble(82), Convert.ToDouble(309.25)));
			RotasAzuis.Add("5", Tuple.Create(Convert.ToDouble(45), Convert.ToDouble(309.25)));
			RotasAzuis.Add("2", Tuple.Create(Convert.ToDouble(8), Convert.ToDouble(309.25)));
			RotasAzuis.Add("1", Tuple.Create(Convert.ToDouble(8), Convert.ToDouble(270.25)));
			RotasAzuis.Add("0", Tuple.Create(Convert.ToDouble(8), Convert.ToDouble(230.25)));

			RotasAzuis.Add("3", Tuple.Create(Convert.ToDouble(45), Convert.ToDouble(230.25)));
			RotasAzuis.Add("6", Tuple.Create(Convert.ToDouble(82), Convert.ToDouble(230.25)));
			RotasAzuis.Add("9", Tuple.Create(Convert.ToDouble(118), Convert.ToDouble(230.25)));
			RotasAzuis.Add("12", Tuple.Create(Convert.ToDouble(155), Convert.ToDouble(230.25)));
			RotasAzuis.Add("15", Tuple.Create(Convert.ToDouble(192), Convert.ToDouble(230.25)));

			RotasAzuis.Add("71", Tuple.Create(Convert.ToDouble(231), Convert.ToDouble(190.25)));
			RotasAzuis.Add("68", Tuple.Create(Convert.ToDouble(231), Convert.ToDouble(152.25)));
			RotasAzuis.Add("65", Tuple.Create(Convert.ToDouble(231), Convert.ToDouble(115.25)));
			RotasAzuis.Add("62", Tuple.Create(Convert.ToDouble(231), Convert.ToDouble(80.25)));
			RotasAzuis.Add("59", Tuple.Create(Convert.ToDouble(231), Convert.ToDouble(42.25)));
			RotasAzuis.Add("56", Tuple.Create(Convert.ToDouble(231), Convert.ToDouble(7.25)));
			RotasAzuis.Add("55", Tuple.Create(Convert.ToDouble(271), Convert.ToDouble(7.25)));
			RotasAzuis.Add("54", Tuple.Create(Convert.ToDouble(312), Convert.ToDouble(7.25)));

			RotasAzuis.Add("57", Tuple.Create(Convert.ToDouble(312), Convert.ToDouble(42.25)));
			RotasAzuis.Add("60", Tuple.Create(Convert.ToDouble(312), Convert.ToDouble(80.25)));
			RotasAzuis.Add("63", Tuple.Create(Convert.ToDouble(312), Convert.ToDouble(115.25)));
			RotasAzuis.Add("66", Tuple.Create(Convert.ToDouble(312), Convert.ToDouble(152.25)));
			RotasAzuis.Add("69", Tuple.Create(Convert.ToDouble(312), Convert.ToDouble(190.25)));

			RotasAzuis.Add("33", Tuple.Create(Convert.ToDouble(351), Convert.ToDouble(230.25)));
			RotasAzuis.Add("30", Tuple.Create(Convert.ToDouble(387), Convert.ToDouble(230.25)));
			RotasAzuis.Add("27", Tuple.Create(Convert.ToDouble(424), Convert.ToDouble(230.25)));
			RotasAzuis.Add("24", Tuple.Create(Convert.ToDouble(462), Convert.ToDouble(230.25)));
			RotasAzuis.Add("21", Tuple.Create(Convert.ToDouble(497), Convert.ToDouble(230.25)));
			RotasAzuis.Add("20", Tuple.Create(Convert.ToDouble(535), Convert.ToDouble(230.25)));
			RotasAzuis.Add("19", Tuple.Create(Convert.ToDouble(535), Convert.ToDouble(270.25)));
			RotasAzuis.Add("18", Tuple.Create(Convert.ToDouble(535), Convert.ToDouble(309.25)));

			return Tuple.Create(0.0,0.0);
		}
	}
}
