using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ludo.Model.Entidade
{
	public class PeaoAmarelo : Peao
	{
		public Tuple<int, string, double, double> Rotas(int posicaoindex, string posicaoquadrado, int numsorteado)
		{


			var RotasAmarelas = new List<Tuple<string, double, double>>();
			RotasAmarelas.Add(Tuple.Create("50", Convert.ToDouble(231), Convert.ToDouble(495)));
			RotasAmarelas.Add(Tuple.Create("47", Convert.ToDouble(231), Convert.ToDouble(458.25)));
			RotasAmarelas.Add(Tuple.Create("44", Convert.ToDouble(231), Convert.ToDouble(422.25)));
			RotasAmarelas.Add(Tuple.Create("41", Convert.ToDouble(231), Convert.ToDouble(385.25)));
			RotasAmarelas.Add(Tuple.Create("38", Convert.ToDouble(231), Convert.ToDouble(348.25)));
			RotasAmarelas.Add(Tuple.Create("17", Convert.ToDouble(192), Convert.ToDouble(309.25)));
			RotasAmarelas.Add(Tuple.Create("14", Convert.ToDouble(155), Convert.ToDouble(309.25)));
			RotasAmarelas.Add(Tuple.Create("11", Convert.ToDouble(118), Convert.ToDouble(309.25)));
			RotasAmarelas.Add(Tuple.Create("8", Convert.ToDouble(82), Convert.ToDouble(309.25)));
			RotasAmarelas.Add(Tuple.Create("5", Convert.ToDouble(45), Convert.ToDouble(309.25)));
			RotasAmarelas.Add(Tuple.Create("2", Convert.ToDouble(8), Convert.ToDouble(309.25)));
			RotasAmarelas.Add(Tuple.Create("1", Convert.ToDouble(8), Convert.ToDouble(270.25)));
			RotasAmarelas.Add(Tuple.Create("0", Convert.ToDouble(8), Convert.ToDouble(230.25)));
			RotasAmarelas.Add(Tuple.Create("3", Convert.ToDouble(45), Convert.ToDouble(230.25)));
			RotasAmarelas.Add(Tuple.Create("6", Convert.ToDouble(82), Convert.ToDouble(230.25)));
			RotasAmarelas.Add(Tuple.Create("9", Convert.ToDouble(118), Convert.ToDouble(230.25)));
			RotasAmarelas.Add(Tuple.Create("12", Convert.ToDouble(155), Convert.ToDouble(230.25)));
			RotasAmarelas.Add(Tuple.Create("15", Convert.ToDouble(192), Convert.ToDouble(230.25)));
			RotasAmarelas.Add(Tuple.Create("71", Convert.ToDouble(231), Convert.ToDouble(190.25)));
			RotasAmarelas.Add(Tuple.Create("68", Convert.ToDouble(231), Convert.ToDouble(152.25)));
			RotasAmarelas.Add(Tuple.Create("65", Convert.ToDouble(231), Convert.ToDouble(115.25)));
			RotasAmarelas.Add(Tuple.Create("62", Convert.ToDouble(231), Convert.ToDouble(80.25)));
			RotasAmarelas.Add(Tuple.Create("59", Convert.ToDouble(231), Convert.ToDouble(42.25)));
			RotasAmarelas.Add(Tuple.Create("56", Convert.ToDouble(231), Convert.ToDouble(7.25)));
			RotasAmarelas.Add(Tuple.Create("55", Convert.ToDouble(271), Convert.ToDouble(7.25)));
			RotasAmarelas.Add(Tuple.Create("54", Convert.ToDouble(312), Convert.ToDouble(7.25)));
			RotasAmarelas.Add(Tuple.Create("57", Convert.ToDouble(312), Convert.ToDouble(42.25)));
			RotasAmarelas.Add(Tuple.Create("60", Convert.ToDouble(312), Convert.ToDouble(80.25)));
			RotasAmarelas.Add(Tuple.Create("63", Convert.ToDouble(312), Convert.ToDouble(115.25)));
			RotasAmarelas.Add(Tuple.Create("66", Convert.ToDouble(312), Convert.ToDouble(152.25)));
			RotasAmarelas.Add(Tuple.Create("69", Convert.ToDouble(312), Convert.ToDouble(190.25)));
			RotasAmarelas.Add(Tuple.Create("33", Convert.ToDouble(351), Convert.ToDouble(230.25)));
			RotasAmarelas.Add(Tuple.Create("30", Convert.ToDouble(387), Convert.ToDouble(230.25)));
			RotasAmarelas.Add(Tuple.Create("27", Convert.ToDouble(424), Convert.ToDouble(230.25)));
			RotasAmarelas.Add(Tuple.Create("24", Convert.ToDouble(462), Convert.ToDouble(230.25)));
			RotasAmarelas.Add(Tuple.Create("21", Convert.ToDouble(497), Convert.ToDouble(230.25)));
			RotasAmarelas.Add(Tuple.Create("20", Convert.ToDouble(535), Convert.ToDouble(230.25)));
			RotasAmarelas.Add(Tuple.Create("19", Convert.ToDouble(535), Convert.ToDouble(270.25)));
			RotasAmarelas.Add(Tuple.Create("18", Convert.ToDouble(535), Convert.ToDouble(309.25)));
			RotasAmarelas.Add(Tuple.Create("22", Convert.ToDouble(497), Convert.ToDouble(309.25)));
			RotasAmarelas.Add(Tuple.Create("26", Convert.ToDouble(462), Convert.ToDouble(309.25)));
			RotasAmarelas.Add(Tuple.Create("29", Convert.ToDouble(424), Convert.ToDouble(309.25)));
			RotasAmarelas.Add(Tuple.Create("32", Convert.ToDouble(387), Convert.ToDouble(309.25)));
			RotasAmarelas.Add(Tuple.Create("35", Convert.ToDouble(351), Convert.ToDouble(309.25)));
			RotasAmarelas.Add(Tuple.Create("36", Convert.ToDouble(312), Convert.ToDouble(348.25)));
			RotasAmarelas.Add(Tuple.Create("39", Convert.ToDouble(312), Convert.ToDouble(385.25)));
			RotasAmarelas.Add(Tuple.Create("42", Convert.ToDouble(312), Convert.ToDouble(422.25)));
			RotasAmarelas.Add(Tuple.Create("45", Convert.ToDouble(312), Convert.ToDouble(458.25)));
			RotasAmarelas.Add(Tuple.Create("49", Convert.ToDouble(312), Convert.ToDouble(496)));
			RotasAmarelas.Add(Tuple.Create("51", Convert.ToDouble(312), Convert.ToDouble(532)));
			RotasAmarelas.Add(Tuple.Create("52", Convert.ToDouble(272), Convert.ToDouble(532)));
			RotasAmarelas.Add(Tuple.Create("53", Convert.ToDouble(232), Convert.ToDouble(532)));
			//Reta Final
			//var RotasAmarelasFinal = new List<Tuple<string, double, double>>();
			RotasAmarelas.Add(Tuple.Create("50F", Convert.ToDouble(231), Convert.ToDouble(495)));
			RotasAmarelas.Add(Tuple.Create("48", Convert.ToDouble(272), Convert.ToDouble(495)));
			RotasAmarelas.Add(Tuple.Create("46", Convert.ToDouble(272), Convert.ToDouble(458)));
			RotasAmarelas.Add(Tuple.Create("43", Convert.ToDouble(272), Convert.ToDouble(422.25)));
			RotasAmarelas.Add(Tuple.Create("40", Convert.ToDouble(272), Convert.ToDouble(385.25)));
			RotasAmarelas.Add(Tuple.Create("37", Convert.ToDouble(272), Convert.ToDouble(348.25)));
			RotasAmarelas.Add(Tuple.Create("FinalYellow", Convert.ToDouble(272), Convert.ToDouble(309.25)));
			int z = 0;
			string c = null;
			bool encontrou = false;
			//int index = RotasAmarelas.IndexOf(new Tuple<string, double, double>("18", 535, 309.25));
			double x = 0;
			double y = 0;
			Verificar:
			foreach (var cookie in RotasAmarelas)
			{
				if (posicaoquadrado == cookie.Item1)
				{

					int index = RotasAmarelas.IndexOf(new Tuple<string, double, double>(cookie.Item1,
													cookie.Item2, cookie.Item3));
					var last = RotasAmarelas.GetRange(index, 2).Last();
					//var last = RotasAmarelas[index == -1 ? 0 : index % (RotasAmarelas.Count - 1)];
					//if (z < RotasAmarelas.Count)
					//{
					//var last = RotasAmarelas[z];
					//var last = TempList.Last();

					c = last.Item1;
					x = last.Item2;
					y = last.Item3;
					encontrou = true;
					break;
					//}
					if (posicaoquadrado == "FinalYellow")
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
