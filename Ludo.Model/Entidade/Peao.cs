﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace Ludo.Model.Entidade
{

   
    public abstract class Peao 
    {
        private string cor;
		private string numPeao;
		private bool naBase;
		private bool venceu;
		private string quadrado;
		private Ellipse peaoSelecionado;
		private int peoesBase=4;
		private int peoesChegada = 0;

		public int PeoesBase
		{
			get
			{
				return this.peoesBase;
			}

			set
			{
				this.peoesBase = value;
			}
		}
		
		public Ellipse PeaoSelecionado
		{
			get { return peaoSelecionado; }
			set { peaoSelecionado = value; }
		}

		public int PeoesChegada
		{
			get
			{
				return this.peoesChegada;
			}

			set
			{
				this.peoesChegada = value;
			}
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

		public Tuple<string, double, double> Rotas(int posicaoindex, string posicaoquadrado, int numsorteado)
		{


			var RotasAzuis = new List<Tuple<string, double, double>>();
			RotasAzuis.Add(Tuple.Create("22", Convert.ToDouble(497), Convert.ToDouble(309.25)));
			RotasAzuis.Add(Tuple.Create("26", Convert.ToDouble(462), Convert.ToDouble(309.25)));
			RotasAzuis.Add(Tuple.Create("29", Convert.ToDouble(424), Convert.ToDouble(309.25)));
			RotasAzuis.Add(Tuple.Create("32", Convert.ToDouble(387), Convert.ToDouble(309.25)));
			RotasAzuis.Add(Tuple.Create("35", Convert.ToDouble(351), Convert.ToDouble(309.25)));
			RotasAzuis.Add(Tuple.Create("36", Convert.ToDouble(312), Convert.ToDouble(348.25)));
			RotasAzuis.Add(Tuple.Create("39", Convert.ToDouble(312), Convert.ToDouble(385.25)));
			RotasAzuis.Add(Tuple.Create("42", Convert.ToDouble(312), Convert.ToDouble(422.25)));
			RotasAzuis.Add(Tuple.Create("45", Convert.ToDouble(312), Convert.ToDouble(458.25)));
			RotasAzuis.Add(Tuple.Create("49", Convert.ToDouble(312), Convert.ToDouble(496)));
			RotasAzuis.Add(Tuple.Create("51", Convert.ToDouble(312), Convert.ToDouble(532)));
			RotasAzuis.Add(Tuple.Create("52", Convert.ToDouble(232), Convert.ToDouble(532)));
			RotasAzuis.Add(Tuple.Create("53", Convert.ToDouble(232), Convert.ToDouble(532)));
			RotasAzuis.Add(Tuple.Create("50", Convert.ToDouble(231), Convert.ToDouble(495)));
			RotasAzuis.Add(Tuple.Create("47", Convert.ToDouble(231), Convert.ToDouble(458.25)));
			RotasAzuis.Add(Tuple.Create("44", Convert.ToDouble(231), Convert.ToDouble(422.25)));
			RotasAzuis.Add(Tuple.Create("41", Convert.ToDouble(231), Convert.ToDouble(385.25)));
			RotasAzuis.Add(Tuple.Create("38", Convert.ToDouble(231), Convert.ToDouble(348.25)));
			RotasAzuis.Add(Tuple.Create("17", Convert.ToDouble(192), Convert.ToDouble(309.25)));
			RotasAzuis.Add(Tuple.Create("14", Convert.ToDouble(155), Convert.ToDouble(309.25)));
			RotasAzuis.Add(Tuple.Create("11", Convert.ToDouble(118), Convert.ToDouble(309.25)));
			RotasAzuis.Add(Tuple.Create("8", Convert.ToDouble(82), Convert.ToDouble(309.25)));
			RotasAzuis.Add(Tuple.Create("5", Convert.ToDouble(45), Convert.ToDouble(309.25)));
			RotasAzuis.Add(Tuple.Create("2", Convert.ToDouble(8), Convert.ToDouble(309.25)));
			RotasAzuis.Add(Tuple.Create("1", Convert.ToDouble(8), Convert.ToDouble(270.25)));
			RotasAzuis.Add(Tuple.Create("0", Convert.ToDouble(8), Convert.ToDouble(230.25)));
			RotasAzuis.Add(Tuple.Create("3", Convert.ToDouble(45), Convert.ToDouble(230.25)));
			RotasAzuis.Add(Tuple.Create("6", Convert.ToDouble(82), Convert.ToDouble(230.25)));
			RotasAzuis.Add(Tuple.Create("9", Convert.ToDouble(118), Convert.ToDouble(230.25)));
			RotasAzuis.Add(Tuple.Create("12", Convert.ToDouble(155), Convert.ToDouble(230.25)));
			RotasAzuis.Add(Tuple.Create("15", Convert.ToDouble(192), Convert.ToDouble(230.25)));
			RotasAzuis.Add(Tuple.Create("71", Convert.ToDouble(231), Convert.ToDouble(190.25)));
			RotasAzuis.Add(Tuple.Create("68", Convert.ToDouble(231), Convert.ToDouble(152.25)));
			RotasAzuis.Add(Tuple.Create("65", Convert.ToDouble(231), Convert.ToDouble(115.25)));
			RotasAzuis.Add(Tuple.Create("62",Convert.ToDouble(231), Convert.ToDouble(80.25)));
			RotasAzuis.Add(Tuple.Create("59", Convert.ToDouble(231), Convert.ToDouble(42.25)));
			RotasAzuis.Add(Tuple.Create("56", Convert.ToDouble(231), Convert.ToDouble(7.25)));
			RotasAzuis.Add(Tuple.Create("55", Convert.ToDouble(271), Convert.ToDouble(7.25)));
			RotasAzuis.Add(Tuple.Create("54", Convert.ToDouble(312), Convert.ToDouble(7.25)));
			RotasAzuis.Add(Tuple.Create("57", Convert.ToDouble(312), Convert.ToDouble(42.25)));
			RotasAzuis.Add(Tuple.Create("60", Convert.ToDouble(312), Convert.ToDouble(80.25)));
			RotasAzuis.Add(Tuple.Create("63", Convert.ToDouble(312), Convert.ToDouble(115.25)));
			RotasAzuis.Add(Tuple.Create("66", Convert.ToDouble(312), Convert.ToDouble(152.25)));
			RotasAzuis.Add(Tuple.Create("69", Convert.ToDouble(312), Convert.ToDouble(190.25)));
			RotasAzuis.Add(Tuple.Create("33", Convert.ToDouble(351), Convert.ToDouble(230.25)));
			RotasAzuis.Add(Tuple.Create("30", Convert.ToDouble(387), Convert.ToDouble(230.25)));
			RotasAzuis.Add(Tuple.Create("27", Convert.ToDouble(424), Convert.ToDouble(230.25)));
			RotasAzuis.Add(Tuple.Create("24", Convert.ToDouble(462), Convert.ToDouble(230.25)));
			RotasAzuis.Add(Tuple.Create("21", Convert.ToDouble(497), Convert.ToDouble(230.25)));
			RotasAzuis.Add(Tuple.Create("20", Convert.ToDouble(535), Convert.ToDouble(230.25)));
			RotasAzuis.Add(Tuple.Create("19", Convert.ToDouble(535), Convert.ToDouble(270.25)));
			RotasAzuis.Add(Tuple.Create("18", Convert.ToDouble(535), Convert.ToDouble(309.25)));
			//Reta Final
			var RotasAzuisFinal = new List<Tuple<string, double, double>>();
			RotasAzuis.Add(Tuple.Create("22", Convert.ToDouble(497), Convert.ToDouble(309.25)));
			RotasAzuis.Add(Tuple.Create("23", Convert.ToDouble(500), Convert.ToDouble(270.25)));
			RotasAzuis.Add(Tuple.Create("25", Convert.ToDouble(462), Convert.ToDouble(270.25)));
			RotasAzuis.Add(Tuple.Create("28", Convert.ToDouble(425), Convert.ToDouble(270.25)));
			RotasAzuis.Add(Tuple.Create("31", Convert.ToDouble(388), Convert.ToDouble(270.25)));
			RotasAzuis.Add(Tuple.Create("34", Convert.ToDouble(351), Convert.ToDouble(270.25)));
			RotasAzuis.Add(Tuple.Create("FinalBlue", Convert.ToDouble(314), Convert.ToDouble(270.25)));
			int z = RotasAzuis.Count;
			string c = null;
			bool encontrou = false;
			//int index = RotasAzuis.IndexOf(new Tuple<string, double, double>("18", 535, 309.25));
			double x=0;
			double y=0;
			Verificar:
			foreach (var cookie in RotasAzuis)
			{
				if (posicaoquadrado == cookie.Item1)
				{
					z--;
					int index = RotasAzuis.IndexOf(new Tuple<string, double, double>(cookie.Item1,
													cookie.Item2, cookie.Item3));
					if (z == RotasAzuis.Count)
					{

					}

					//var TempList = RotasAzuis.GetRange(z, z+2);
					//var last = RotasAzuis[index == -1 ? 0 : index % (RotasAzuis.Count - 1)];
					var last = RotasAzuis[index + 1];
					//var last = TempList.Last();
					c = last.Item1;
					x = last.Item2;
					y = last.Item3;
					encontrou = true;
					break;
				}
				//z++;
				
			}
			if (z == 0)
			{
				foreach (var cookie2 in RotasAzuisFinal)
				{
					int index = RotasAzuis.IndexOf(new Tuple<string, double, double>(cookie2.Item1,
												cookie2.Item2, cookie2.Item3));
					var last = RotasAzuis[index + 1];
					//var last = TempList.Last();
					c = last.Item1;
					x = last.Item2;
					y = last.Item3;
					encontrou = true;
					break;
				}
			}
			
			Tuple<string, double, double> TempTuple = new Tuple<string, double, double>(c, x, y);
			if (encontrou)
			{
				return TempTuple;
			}
			else
				goto Verificar;
		}

	}
}
