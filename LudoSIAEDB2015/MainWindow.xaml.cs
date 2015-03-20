using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Media3D;
using LudoSIAEDB2015;
using System.Windows.Media.Animation;
using Ludo.Model.Entidade;
using System.Globalization;
using System.Threading;

namespace LudoSIAEDB2015
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		bool startgame = false;
		int turnos = 0;
		int numMovimentos;
		string currentPOS = "22";
		bool primeirajogada = true;
		int pecasrestantes = 59;
		List<PeaoAzul> InicializarPecasAzuis = new List<Ludo.Model.Entidade.PeaoAzul>();
		List<PeaoAmarelo> InicializarPecasAmarelas = new List<Ludo.Model.Entidade.PeaoAmarelo>();
		/*List<PeaoVerde> InicializarPecasVerdes = new List<Ludo.Model.Entidade.PeaoVerde>();*/
		List<PeaoVermelho> InicializarPecasVermelhas = new List<Ludo.Model.Entidade.PeaoVermelho>();
		PeaoAzul pazul = new PeaoAzul();
		public MainWindow()
		{
			InitializeComponent();
		}

		private void vistadado_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{

		}


		private void vistadado_MouseMove(object sender, MouseEventArgs e)
		{

		}

		private void GirarDado_Click(object sender, RoutedEventArgs e)
		{

			ArremesaDado();
		}

		private void ArremesaDado()
		{
			Random rand = new Random();
			numMovimentos = rand.Next(1, 7);
			string faceDados = numMovimentos.ToString();
			btnGirarDado.Content = FindResource(faceDados);
			numjogado.Content = faceDados;
			if ((InicializarPecasAzuis[0].Index >= 53) && (InicializarPecasAzuis[0].Index <= 59))
			{
				if (numMovimentos > InicializarPecasAzuis[0].JogadasRestantes)
					InicializarPecasAzuis[0].PeaoSelecionado.IsEnabled = false;
				else
					InicializarPecasAzuis[0].PeaoSelecionado.IsEnabled = true;
				if (InicializarPecasAzuis[0].CurrentPOS == "FinalBlue")
					InicializarPecasAzuis[0].PeaoSelecionado.IsEnabled = false;
			}
			if ((InicializarPecasAzuis[1].Index >= 53) && (InicializarPecasAzuis[1].Index <= 59))
			{
				if (numMovimentos > InicializarPecasAzuis[1].JogadasRestantes)
					InicializarPecasAzuis[1].PeaoSelecionado.IsEnabled = false;
				else
					InicializarPecasAzuis[1].PeaoSelecionado.IsEnabled = true;
				if (InicializarPecasAzuis[1].CurrentPOS == "FinalBlue")
					InicializarPecasAzuis[1].PeaoSelecionado.IsEnabled = false;
			}
			if ((InicializarPecasAzuis[2].Index >= 53) && (InicializarPecasAzuis[2].Index <= 59))
			{
				if (numMovimentos > InicializarPecasAzuis[2].JogadasRestantes)
					InicializarPecasAzuis[2].PeaoSelecionado.IsEnabled = false;
				else
					InicializarPecasAzuis[2].PeaoSelecionado.IsEnabled = true;
				if (InicializarPecasAzuis[2].CurrentPOS == "FinalBlue")
					InicializarPecasAzuis[2].PeaoSelecionado.IsEnabled = false;
			}
			if ((InicializarPecasAzuis[3].Index >= 53) && (InicializarPecasAzuis[3].Index <= 59))
			{
				if (numMovimentos > InicializarPecasAzuis[3].JogadasRestantes)
					InicializarPecasAzuis[3].PeaoSelecionado.IsEnabled = false;
				else
					InicializarPecasAzuis[3].PeaoSelecionado.IsEnabled = true;
				if (InicializarPecasAzuis[3].CurrentPOS == "FinalBlue")
					InicializarPecasAzuis[3].PeaoSelecionado.IsEnabled = false;
			}



			//dfds//
			if ((InicializarPecasAmarelas[0].Index >= 53) && (InicializarPecasAmarelas[0].Index <= 59))
			{
				if (numMovimentos > InicializarPecasAmarelas[0].JogadasRestantes)
					InicializarPecasAmarelas[0].PeaoSelecionado.IsEnabled = false;
				else
					InicializarPecasAmarelas[0].PeaoSelecionado.IsEnabled = true;
				if (InicializarPecasAmarelas[0].CurrentPOS == "FinalYellow")
					InicializarPecasAmarelas[0].PeaoSelecionado.IsEnabled = false;
			}
			if ((InicializarPecasAmarelas[1].Index >= 53) && (InicializarPecasAmarelas[1].Index <= 59))
			{
				if (numMovimentos > InicializarPecasAmarelas[1].JogadasRestantes)
					InicializarPecasAmarelas[1].PeaoSelecionado.IsEnabled = false;
				else
					InicializarPecasAmarelas[1].PeaoSelecionado.IsEnabled = true;
				if (InicializarPecasAmarelas[1].CurrentPOS == "FinalYellow")
					InicializarPecasAmarelas[1].PeaoSelecionado.IsEnabled = false;
			}
			if ((InicializarPecasAmarelas[2].Index >= 53) && (InicializarPecasAmarelas[2].Index <= 59))
			{
				if (numMovimentos > InicializarPecasAmarelas[2].JogadasRestantes)
					InicializarPecasAmarelas[2].PeaoSelecionado.IsEnabled = false;
				else
					InicializarPecasAmarelas[2].PeaoSelecionado.IsEnabled = true;
				if (InicializarPecasAmarelas[2].CurrentPOS == "FinalYellow")
					InicializarPecasAmarelas[2].PeaoSelecionado.IsEnabled = false;
			}
			if ((InicializarPecasAmarelas[3].Index >= 53) && (InicializarPecasAmarelas[3].Index <= 59))
			{
				if (numMovimentos > InicializarPecasAmarelas[3].JogadasRestantes)
					InicializarPecasAmarelas[3].PeaoSelecionado.IsEnabled = false;
				else
					InicializarPecasAmarelas[3].PeaoSelecionado.IsEnabled = true;
				if (InicializarPecasAmarelas[3].CurrentPOS == "FinalYellow")
					InicializarPecasAmarelas[3].PeaoSelecionado.IsEnabled = false;
			}

			//658866868


			if ((InicializarPecasVermelhas[0].Index >= 53) && (InicializarPecasVermelhas[0].Index <= 59))
			{
				if (numMovimentos > InicializarPecasVermelhas[0].JogadasRestantes)
					InicializarPecasVermelhas[0].PeaoSelecionado.IsEnabled = false;
				else
					InicializarPecasVermelhas[0].PeaoSelecionado.IsEnabled = true;
				if (InicializarPecasVermelhas[0].CurrentPOS == "FinalRed")
					InicializarPecasVermelhas[0].PeaoSelecionado.IsEnabled = false;
			}
			if ((InicializarPecasVermelhas[1].Index >= 53) && (InicializarPecasVermelhas[1].Index <= 59))
			{
				if (numMovimentos > InicializarPecasVermelhas[1].JogadasRestantes)
					InicializarPecasVermelhas[1].PeaoSelecionado.IsEnabled = false;
				else
					InicializarPecasVermelhas[1].PeaoSelecionado.IsEnabled = true;
				if (InicializarPecasVermelhas[1].CurrentPOS == "FinalRed")
					InicializarPecasVermelhas[1].PeaoSelecionado.IsEnabled = false;
			}
			if ((InicializarPecasVermelhas[2].Index >= 53) && (InicializarPecasVermelhas[2].Index <= 59))
			{
				if (numMovimentos > InicializarPecasVermelhas[2].JogadasRestantes)
					InicializarPecasVermelhas[2].PeaoSelecionado.IsEnabled = false;
				else
					InicializarPecasVermelhas[2].PeaoSelecionado.IsEnabled = true;
				if (InicializarPecasVermelhas[2].CurrentPOS == "FinalRed")
					InicializarPecasVermelhas[2].PeaoSelecionado.IsEnabled = false;
			}
			if ((InicializarPecasVermelhas[3].Index >= 53) && (InicializarPecasVermelhas[3].Index <= 59))
			{
				if (numMovimentos > InicializarPecasVermelhas[3].JogadasRestantes)
					InicializarPecasVermelhas[3].PeaoSelecionado.IsEnabled = false;
				else
					InicializarPecasVermelhas[3].PeaoSelecionado.IsEnabled = true;
				if (InicializarPecasVermelhas[3].CurrentPOS == "FinalRed")
					InicializarPecasVermelhas[3].PeaoSelecionado.IsEnabled = false;
			}

		}


		private void IniciaJogo_Click(object sender, RoutedEventArgs e)
		{
			if (((string)btnPlayer1.Content == "Jogador 1") || ((string)btnPlayer1.Content == "CPU 1"))
			{
				PeaoVermelho pvermelha1 = new PeaoVermelho();
				pvermelha1.PeaoSelecionado = PeaoVermelho1;
				pvermelha1.NaBase = true;
				PeaoVermelho pvermelha2 = new PeaoVermelho();
				pvermelha2.PeaoSelecionado = PeaoVermelho2;
				pvermelha2.NaBase = true;
				PeaoVermelho pvermelha3 = new PeaoVermelho();
				pvermelha3.PeaoSelecionado = PeaoVermelho3;
				pvermelha3.NaBase = true;
				PeaoVermelho pvermelha4 = new PeaoVermelho();
				pvermelha4.PeaoSelecionado = PeaoVermelho4;
				pvermelha4.NaBase = true;
				InicializarPecasVermelhas.Add(pvermelha1);
				InicializarPecasVermelhas.Add(pvermelha2);
				InicializarPecasVermelhas.Add(pvermelha3);
				InicializarPecasVermelhas.Add(pvermelha4);
			}
			if (((string)btnPlayer3.Content == "Jogador 3") || ((string)btnPlayer3.Content == "CPU 3"))
			{
				PeaoAmarelo pamarela1 = new PeaoAmarelo();
				pamarela1.PeaoSelecionado = PeaoAmarelo1;
				pamarela1.NaBase = true;
				PeaoAmarelo pamarela2 = new PeaoAmarelo();
				pamarela2.PeaoSelecionado = PeaoAmarelo2;
				pamarela2.NaBase = true;
				PeaoAmarelo pamarela3 = new PeaoAmarelo();
				pamarela3.PeaoSelecionado = PeaoAmarelo3;
				pamarela3.NaBase = true;
				PeaoAmarelo pamarela4 = new PeaoAmarelo();
				pamarela4.PeaoSelecionado = PeaoAmarelo4;
				pamarela4.NaBase = true;
				InicializarPecasAmarelas.Add(pamarela1);
				InicializarPecasAmarelas.Add(pamarela2);
				InicializarPecasAmarelas.Add(pamarela3);
				InicializarPecasAmarelas.Add(pamarela4);
			}
			if (((string)btnPlayer4.Content == "Jogador 4") || ((string)btnPlayer4.Content == "CPU 4"))
			{
				PeaoAzul pazul1 = new PeaoAzul();
				pazul1.PeaoSelecionado = PeaoAzul1;
				pazul1.NaBase = true;
				pazul1.Cor = "Blue";
				PeaoAzul pazul2 = new PeaoAzul();
				pazul2.PeaoSelecionado = PeaoAzul2;
				pazul2.NaBase = true;
				pazul2.Cor = "Blue";
				PeaoAzul pazul3 = new PeaoAzul();
				pazul3.PeaoSelecionado = PeaoAzul3;
				pazul3.NaBase = true;
				pazul3.Cor = "Blue";
				PeaoAzul pazul4 = new PeaoAzul();
				pazul4.PeaoSelecionado = PeaoAzul4;
				pazul4.NaBase = true;
				pazul4.Cor = "Blue";
				InicializarPecasAzuis.Add(pazul1);
				InicializarPecasAzuis.Add(pazul2);
				InicializarPecasAzuis.Add(pazul3);
				InicializarPecasAzuis.Add(pazul4);
			}

			startgame = true;
			btnGirarDado.IsEnabled = true;
			//Jogo();
		}
		private void Jogo()
		{
			InicializarPecasAzuis[0].PeaoSelecionado.IsEnabled = false;
			InicializarPecasAzuis[1].PeaoSelecionado.IsEnabled = false;
			InicializarPecasAzuis[2].PeaoSelecionado.IsEnabled = false;
			InicializarPecasAzuis[3].PeaoSelecionado.IsEnabled = false;
			InicializarPecasAmarelas[0].PeaoSelecionado.IsEnabled = false;
			InicializarPecasAmarelas[1].PeaoSelecionado.IsEnabled = false;
			InicializarPecasAmarelas[2].PeaoSelecionado.IsEnabled = false;
			InicializarPecasAmarelas[3].PeaoSelecionado.IsEnabled = false;
			string Jogador="Blue";
			while (startgame)
			{
				switch (Jogador)
				{
					case "Blue":
						InicializarPecasAzuis[0].PeaoSelecionado.IsEnabled = true;
						InicializarPecasAzuis[1].PeaoSelecionado.IsEnabled = true;
						InicializarPecasAzuis[2].PeaoSelecionado.IsEnabled = true;
						InicializarPecasAzuis[3].PeaoSelecionado.IsEnabled = true;
						lblVezJogador.Content = "Agora é a vez do Jogador 4";
					//	if(InicializarPecasAzuis[0].CurrentPOS)
                        break;
					case "Yellow":
						InicializarPecasAzuis[0].PeaoSelecionado.IsEnabled = true;
						InicializarPecasAzuis[1].PeaoSelecionado.IsEnabled = true;
						InicializarPecasAzuis[2].PeaoSelecionado.IsEnabled = true;
						InicializarPecasAzuis[3].PeaoSelecionado.IsEnabled = true;
						lblVezJogador.Content = "Agora é a vez do Jogador 3";
						break;
					default:
						break;
				}
				startgame = false;
			}
		}

		private void PeaoAzul1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAzuis[0].PeaoSelecionado;
			if (startgame)
			{
				Movimentar(InicializarPecasAzuis[0], p1);
				primeirajogada = false;
			}
		}

		private void Movimentar(PeaoAzul pazul, Ellipse ell)
		{
			if (numMovimentos == 6 && pazul.NaBase)
			{
				Tuple<double, double> TempTuple = new Tuple<double, double>(497, 309.25);
				MovePeca(pazul.PeaoSelecionado, TempTuple);
				pazul.CurrentPOS = "22";
				pazul.PeoesBase--;
			}
			if (pazul.NaBase == false)
			//else
			{
				for (int i = 0; i < numMovimentos; i++)
				{
					pecasrestantes--;
					var y = pazul.Rotas(1, pazul.CurrentPOS, numMovimentos);
					Tuple<double, double> TempTuple = new Tuple<double, double>(y.Item3, y.Item4);
					MovePeca(ell, TempTuple);
					pazul.Index = y.Item1;
					pazul.CurrentPOS = y.Item2;
					pazul.JogadasRestantes--;
					if (pazul.CurrentPOS == "FinalBlue")
						ell.IsEnabled = false;
				}
			}
			pazul.NaBase = false;
		}

		private void Movimentar(PeaoAmarelo pamarelo, Ellipse ell)
		{
			if (numMovimentos == 6 && pamarelo.NaBase)
			{
				Tuple<double, double> TempTuple = new Tuple<double, double>(231, 495);
				MovePeca(pamarelo.PeaoSelecionado, TempTuple);
				pamarelo.CurrentPOS = "50";
				pamarelo.PeoesBase--;
			}
			if (pamarelo.NaBase == false)
			//else
			{
				for (int i = 0; i < numMovimentos; i++)
				{
					pecasrestantes--;
					var y = pamarelo.Rotas(1, pamarelo.CurrentPOS, numMovimentos);
					Tuple<double, double> TempTuple = new Tuple<double, double>(y.Item3, y.Item4);
					MovePeca(ell, TempTuple);
					pamarelo.Index = y.Item1;
					pamarelo.CurrentPOS = y.Item2;
					pamarelo.JogadasRestantes--;
					if (pamarelo.CurrentPOS == "FinalYellow")
						ell.IsEnabled = false;
				}
			}
			pamarelo.NaBase = false;
		}
		private void Movimentar(PeaoVermelho pvermelho, Ellipse ell)
		{
			if (numMovimentos == 6 && pvermelho.NaBase)
			{
				Tuple<double, double> TempTuple = new Tuple<double, double>(312, 42.25);
				MovePeca(pvermelho.PeaoSelecionado, TempTuple);
				pvermelho.CurrentPOS = "57";
				pvermelho.PeoesBase--;
			}
			if (pvermelho.NaBase == false)
			//else
			{
				for (int i = 0; i < numMovimentos; i++)
				{
					pecasrestantes--;
					var y = pvermelho.Rotas(1, pvermelho.CurrentPOS, numMovimentos);
					Tuple<double, double> TempTuple = new Tuple<double, double>(y.Item3, y.Item4);
					MovePeca(ell, TempTuple);
					pvermelho.Index = y.Item1;
					pvermelho.CurrentPOS = y.Item2;
					pvermelho.JogadasRestantes--;
					if (pvermelho.CurrentPOS == "FinalRed")
						ell.IsEnabled = false;
				}
			}
			pvermelho.NaBase = false;
		}



		private void MoveUmaPosicao(object sender)
		{
			Thread.Sleep(1000);
			PeaoAzul pazul = new PeaoAzul();
			Ellipse ell = (Ellipse)sender;

			var y = pazul.Rotas(1, currentPOS, numMovimentos);
			Tuple<double, double> TempTuple = new Tuple<double, double>(y.Item3, y.Item4);
			MovePeca(ell, TempTuple);
			currentPOS = y.Item2;
		}


		private void PeaoAzul2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAzuis[1].PeaoSelecionado;
			if (startgame)
			{
				Movimentar(InicializarPecasAzuis[1], p1);
				primeirajogada = false;
			}
		}
		private void MovePeca(Ellipse sender, Tuple<double, double> route)
		{

			ThicknessAnimation b = new ThicknessAnimation();
			b.Duration = TimeSpan.FromSeconds(0.5);
			b.To = new Thickness(route.Item1, route.Item2, 0, 0);

			Storyboard.SetTarget(b, sender);
			Storyboard.SetTargetProperty(b, new PropertyPath(Ellipse.MarginProperty));
			Storyboard tentando = new Storyboard();
			tentando.Children.Add(b);
			tentando.Begin();
		}

		private void PeaoAzul4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAzuis[3].PeaoSelecionado;
			if (startgame)
			{
				Movimentar(InicializarPecasAzuis[3], p1);
				primeirajogada = false;
			}
		}

		private void PeaoAmarelo2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAmarelas[1].PeaoSelecionado;
			if (startgame)
			{
				Movimentar(InicializarPecasAmarelas[1], p1);
				primeirajogada = false;
			}
		}

		private void PeaoAzul3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAzuis[2].PeaoSelecionado;
			if (startgame)
			{
				Movimentar(InicializarPecasAzuis[2], p1);
				primeirajogada = false;
			}
		}

		private void PeaoAmarelo1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAmarelas[0].PeaoSelecionado;
			if (startgame)
			{
				Movimentar(InicializarPecasAmarelas[0], p1);
				primeirajogada = false;
			}
		}

		private void PeaoAmarelo3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAmarelas[2].PeaoSelecionado;
			if (startgame)
			{
				Movimentar(InicializarPecasAmarelas[2], p1);
				primeirajogada = false;
			}

		}

		private void PeaoAmarelo4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAmarelas[3].PeaoSelecionado;
			if (startgame)
			{
				Movimentar(InicializarPecasAmarelas[3], p1);
				primeirajogada = false;
			}
		}

		private void PeaoVermelho2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasVermelhas[1].PeaoSelecionado;
			if (startgame)
			{
				Movimentar(InicializarPecasVermelhas[1], p1);
				primeirajogada = false;
			}
		}

		private void PeaoVermelho1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasVermelhas[0].PeaoSelecionado;
			if (startgame)
			{
				Movimentar(InicializarPecasVermelhas[0], p1);
				primeirajogada = false;
			}
		}

		private void PeaoVermelho4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasVermelhas[3].PeaoSelecionado;
			if (startgame)
			{
				Movimentar(InicializarPecasVermelhas[3], p1);
				primeirajogada = false;
			}
		}

		private void PeaoVermelho3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasVermelhas[2].PeaoSelecionado;
			if (startgame)
			{
				Movimentar(InicializarPecasVermelhas[2], p1);
				primeirajogada = false;
			}
		}
	}
}