using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Model.Entidade
{
	public class PeaoVermelho :Peao
	{
		public Tuple<int, string, double, double> Rotas(int posicaoindex, string posicaoquadrado, int numsorteado)
		{


			var RotasVermelhas = new List<Tuple<string, double, double>>();
			RotasVermelhas.Add(Tuple.Create("57", Convert.ToDouble(312), Convert.ToDouble(42.25)));
			RotasVermelhas.Add(Tuple.Create("60", Convert.ToDouble(312), Convert.ToDouble(80.25)));
			RotasVermelhas.Add(Tuple.Create("63", Convert.ToDouble(312), Convert.ToDouble(115.25)));
			RotasVermelhas.Add(Tuple.Create("66", Convert.ToDouble(312), Convert.ToDouble(152.25)));
			RotasVermelhas.Add(Tuple.Create("69", Convert.ToDouble(312), Convert.ToDouble(190.25)));
			RotasVermelhas.Add(Tuple.Create("33", Convert.ToDouble(351), Convert.ToDouble(230.25)));
			RotasVermelhas.Add(Tuple.Create("30", Convert.ToDouble(387), Convert.ToDouble(230.25)));
			RotasVermelhas.Add(Tuple.Create("27", Convert.ToDouble(424), Convert.ToDouble(230.25)));
			RotasVermelhas.Add(Tuple.Create("24", Convert.ToDouble(462), Convert.ToDouble(230.25)));
			RotasVermelhas.Add(Tuple.Create("21", Convert.ToDouble(497), Convert.ToDouble(230.25)));
			RotasVermelhas.Add(Tuple.Create("20", Convert.ToDouble(535), Convert.ToDouble(230.25)));
			RotasVermelhas.Add(Tuple.Create("19", Convert.ToDouble(535), Convert.ToDouble(270.25)));
			RotasVermelhas.Add(Tuple.Create("18", Convert.ToDouble(535), Convert.ToDouble(309.25)));
			RotasVermelhas.Add(Tuple.Create("22", Convert.ToDouble(497), Convert.ToDouble(309.25)));
			RotasVermelhas.Add(Tuple.Create("26", Convert.ToDouble(462), Convert.ToDouble(309.25)));
			RotasVermelhas.Add(Tuple.Create("29", Convert.ToDouble(424), Convert.ToDouble(309.25)));
			RotasVermelhas.Add(Tuple.Create("32", Convert.ToDouble(387), Convert.ToDouble(309.25)));
			RotasVermelhas.Add(Tuple.Create("35", Convert.ToDouble(351), Convert.ToDouble(309.25)));
			RotasVermelhas.Add(Tuple.Create("36", Convert.ToDouble(312), Convert.ToDouble(348.25)));
			RotasVermelhas.Add(Tuple.Create("39", Convert.ToDouble(312), Convert.ToDouble(385.25)));
			RotasVermelhas.Add(Tuple.Create("42", Convert.ToDouble(312), Convert.ToDouble(422.25)));
			RotasVermelhas.Add(Tuple.Create("45", Convert.ToDouble(312), Convert.ToDouble(458.25)));
			RotasVermelhas.Add(Tuple.Create("49", Convert.ToDouble(312), Convert.ToDouble(496)));
			RotasVermelhas.Add(Tuple.Create("51", Convert.ToDouble(312), Convert.ToDouble(532)));
			RotasVermelhas.Add(Tuple.Create("52", Convert.ToDouble(272), Convert.ToDouble(532)));
			RotasVermelhas.Add(Tuple.Create("53", Convert.ToDouble(232), Convert.ToDouble(532)));
			RotasVermelhas.Add(Tuple.Create("50", Convert.ToDouble(231), Convert.ToDouble(495)));
			RotasVermelhas.Add(Tuple.Create("47", Convert.ToDouble(231), Convert.ToDouble(458.25)));
			RotasVermelhas.Add(Tuple.Create("44", Convert.ToDouble(231), Convert.ToDouble(422.25)));
			RotasVermelhas.Add(Tuple.Create("41", Convert.ToDouble(231), Convert.ToDouble(385.25)));
			RotasVermelhas.Add(Tuple.Create("38", Convert.ToDouble(231), Convert.ToDouble(348.25)));
			RotasVermelhas.Add(Tuple.Create("17", Convert.ToDouble(192), Convert.ToDouble(309.25)));
			RotasVermelhas.Add(Tuple.Create("14", Convert.ToDouble(155), Convert.ToDouble(309.25)));
			RotasVermelhas.Add(Tuple.Create("11", Convert.ToDouble(118), Convert.ToDouble(309.25)));
			RotasVermelhas.Add(Tuple.Create("8", Convert.ToDouble(82), Convert.ToDouble(309.25)));
			RotasVermelhas.Add(Tuple.Create("5", Convert.ToDouble(45), Convert.ToDouble(309.25)));
			RotasVermelhas.Add(Tuple.Create("2", Convert.ToDouble(8), Convert.ToDouble(309.25)));
			RotasVermelhas.Add(Tuple.Create("1", Convert.ToDouble(8), Convert.ToDouble(270.25)));
			RotasVermelhas.Add(Tuple.Create("0", Convert.ToDouble(8), Convert.ToDouble(230.25)));
			RotasVermelhas.Add(Tuple.Create("3", Convert.ToDouble(45), Convert.ToDouble(230.25)));
			RotasVermelhas.Add(Tuple.Create("6", Convert.ToDouble(82), Convert.ToDouble(230.25)));
			RotasVermelhas.Add(Tuple.Create("9", Convert.ToDouble(118), Convert.ToDouble(230.25)));
			RotasVermelhas.Add(Tuple.Create("12", Convert.ToDouble(155), Convert.ToDouble(230.25)));
			RotasVermelhas.Add(Tuple.Create("15", Convert.ToDouble(192), Convert.ToDouble(230.25)));
			RotasVermelhas.Add(Tuple.Create("71", Convert.ToDouble(231), Convert.ToDouble(190.25)));
			RotasVermelhas.Add(Tuple.Create("68", Convert.ToDouble(231), Convert.ToDouble(152.25)));
			RotasVermelhas.Add(Tuple.Create("65", Convert.ToDouble(231), Convert.ToDouble(115.25)));
			RotasVermelhas.Add(Tuple.Create("62", Convert.ToDouble(231), Convert.ToDouble(80.25)));
			RotasVermelhas.Add(Tuple.Create("59", Convert.ToDouble(231), Convert.ToDouble(42.25)));
			RotasVermelhas.Add(Tuple.Create("56", Convert.ToDouble(231), Convert.ToDouble(7.25)));
			RotasVermelhas.Add(Tuple.Create("55", Convert.ToDouble(271), Convert.ToDouble(7.25)));
			RotasVermelhas.Add(Tuple.Create("54", Convert.ToDouble(312), Convert.ToDouble(7.25)));

			//Reta Final
			//var RotasVermelhasFinal = new List<Tuple<string, double, double>>();
			RotasVermelhas.Add(Tuple.Create("57F", Convert.ToDouble(312), Convert.ToDouble(42.25)));
			RotasVermelhas.Add(Tuple.Create("58", Convert.ToDouble(270), Convert.ToDouble(42.25)));
			RotasVermelhas.Add(Tuple.Create("61", Convert.ToDouble(270), Convert.ToDouble(78)));
			RotasVermelhas.Add(Tuple.Create("64", Convert.ToDouble(270), Convert.ToDouble(113)));
			RotasVermelhas.Add(Tuple.Create("67", Convert.ToDouble(270), Convert.ToDouble(152)));
			RotasVermelhas.Add(Tuple.Create("70", Convert.ToDouble(270), Convert.ToDouble(190)));
			RotasVermelhas.Add(Tuple.Create("FinalRed", Convert.ToDouble(270), Convert.ToDouble(226)));
			int z = 0;
			string c = null;
			bool encontrou = false;
			//int index = RotasVermelhas.IndexOf(new Tuple<string, double, double>("18", 535, 309.25));
			double x = 0;
			double y = 0;
			Verificar:
			foreach (var cookie in RotasVermelhas)
			{
				if (posicaoquadrado == cookie.Item1)
				{

					int index = RotasVermelhas.IndexOf(new Tuple<string, double, double>(cookie.Item1,
													cookie.Item2, cookie.Item3));
					var last = RotasVermelhas.GetRange(index, 2).Last();
					//var last = RotasVermelhas[index == -1 ? 0 : index % (RotasVermelhas.Count - 1)];
					//if (z < RotasVermelhas.Count)
					//{
					//var last = RotasVermelhas[z];
					//var last = TempList.Last();

					c = last.Item1;
					x = last.Item2;
					y = last.Item3;
					encontrou = true;
					break;
					//}
					if (posicaoquadrado == "FinalRed")
					{
						encontrou = true;
						break;
					}
				}
				z++;

			}

			Tuple<int, string, double, double> TempTuple = new Tuple<int, string, double, double>(z, c, x, y);
			if (encontrou)
			{
				return TempTuple;
			}
			else
				goto Verificar;
		}
	}
}
