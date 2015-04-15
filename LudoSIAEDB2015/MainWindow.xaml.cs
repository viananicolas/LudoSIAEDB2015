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
		string temp;
		int turnos = 0;
		int numMovimentos;
		string currentPOS = "22";
		string vez;
		bool primeirajogada = true;
		int pecasrestantes = 59;
		List<PeaoAzul> InicializarPecasAzuis = new List<Ludo.Model.Entidade.PeaoAzul>();
		List<PeaoAmarelo> InicializarPecasAmarelas = new List<Ludo.Model.Entidade.PeaoAmarelo>();
		List<PeaoVerde> InicializarPecasVerdes = new List<Ludo.Model.Entidade.PeaoVerde>();
		List<PeaoVermelho> InicializarPecasVermelhas = new List<Ludo.Model.Entidade.PeaoVermelho>();
		PeaoAzul pazul = new PeaoAzul();
		PeaoAmarelo pamarelo = new PeaoAmarelo();
		PeaoVerde pverde = new PeaoVerde();
		PeaoVermelho pvermelho = new PeaoVermelho();
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
		
			if (InicializarPecasAzuis.Count != 0)
			{
				if ((InicializarPecasAzuis[0].Index >= 53) && (InicializarPecasAzuis[0].Index <= 59))
				{
					if (numMovimentos > InicializarPecasAzuis[0].JogadasRestantes)
						InicializarPecasAzuis[0].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasAzuis[0].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasAzuis[0].CurrentPOS == "FinalBlue")
					{
						InicializarPecasAzuis[0].PeaoSelecionado.IsEnabled = false;
						pazul.PeoesChegada++;
					}
				

				}
				if ((InicializarPecasAzuis[1].Index >= 53) && (InicializarPecasAzuis[1].Index <= 59))
				{
					if (numMovimentos > InicializarPecasAzuis[1].JogadasRestantes)
						InicializarPecasAzuis[1].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasAzuis[1].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasAzuis[1].CurrentPOS == "FinalBlue")
					{
						InicializarPecasAzuis[1].PeaoSelecionado.IsEnabled = false;
						pazul.PeoesChegada++;
					}
				}
				if ((InicializarPecasAzuis[2].Index >= 53) && (InicializarPecasAzuis[2].Index <= 59))
				{
					if (numMovimentos > InicializarPecasAzuis[2].JogadasRestantes)
						InicializarPecasAzuis[2].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasAzuis[2].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasAzuis[2].CurrentPOS == "FinalBlue")
					{
						InicializarPecasAzuis[2].PeaoSelecionado.IsEnabled = false;
						pazul.PeoesChegada++;
					}
				}
				if ((InicializarPecasAzuis[3].Index >= 53) && (InicializarPecasAzuis[3].Index <= 59))
				{
					if (numMovimentos > InicializarPecasAzuis[3].JogadasRestantes)
						InicializarPecasAzuis[3].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasAzuis[3].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasAzuis[3].CurrentPOS == "FinalBlue")
					{
						InicializarPecasAzuis[3].PeaoSelecionado.IsEnabled = false;
						pazul.PeoesChegada++;
					}
				}
				

			}

			//dfds//
			if (InicializarPecasAmarelas.Count != 0)
			{
				if ((InicializarPecasAmarelas[0].Index >= 53) && (InicializarPecasAmarelas[0].Index <= 59))
				{
					if (numMovimentos > InicializarPecasAmarelas[0].JogadasRestantes)
						InicializarPecasAmarelas[0].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasAmarelas[0].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasAmarelas[0].CurrentPOS == "FinalYellow")
					{
						InicializarPecasAmarelas[0].PeaoSelecionado.IsEnabled = false;
						pamarelo.PeoesChegada++;
					}
				}
				if ((InicializarPecasAmarelas[1].Index >= 53) && (InicializarPecasAmarelas[1].Index <= 59))
				{
					if (numMovimentos > InicializarPecasAmarelas[1].JogadasRestantes)
						InicializarPecasAmarelas[1].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasAmarelas[1].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasAmarelas[1].CurrentPOS == "FinalYellow")
					{
						InicializarPecasAmarelas[1].PeaoSelecionado.IsEnabled = false;
						pamarelo.PeoesChegada++;
					}
				}
				if ((InicializarPecasAmarelas[2].Index >= 53) && (InicializarPecasAmarelas[2].Index <= 59))
				{
					if (numMovimentos > InicializarPecasAmarelas[2].JogadasRestantes)
						InicializarPecasAmarelas[2].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasAmarelas[2].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasAmarelas[2].CurrentPOS == "FinalYellow")
					{
						InicializarPecasAmarelas[2].PeaoSelecionado.IsEnabled = false;
						pamarelo.PeoesChegada++;
					}
				}
				if ((InicializarPecasAmarelas[3].Index >= 53) && (InicializarPecasAmarelas[3].Index <= 59))
				{
					if (numMovimentos > InicializarPecasAmarelas[3].JogadasRestantes)
						InicializarPecasAmarelas[3].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasAmarelas[3].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasAmarelas[3].CurrentPOS == "FinalYellow")
					{
						InicializarPecasAmarelas[3].PeaoSelecionado.IsEnabled = false;
						pamarelo.PeoesChegada++;
					}
				}
				
				
			}
			//658866868

			if (InicializarPecasVermelhas.Count != 0)
			{
				if ((InicializarPecasVermelhas[0].Index >= 53) && (InicializarPecasVermelhas[0].Index <= 59))
				{
					if (numMovimentos > InicializarPecasVermelhas[0].JogadasRestantes)
						InicializarPecasVermelhas[0].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasVermelhas[0].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasVermelhas[0].CurrentPOS == "FinalRed")
					{
						InicializarPecasVermelhas[0].PeaoSelecionado.IsEnabled = false;
						pvermelho.PeoesChegada++;
					}
				}
				if ((InicializarPecasVermelhas[1].Index >= 53) && (InicializarPecasVermelhas[1].Index <= 59))
				{
					if (numMovimentos > InicializarPecasVermelhas[1].JogadasRestantes)
						InicializarPecasVermelhas[1].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasVermelhas[1].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasVermelhas[1].CurrentPOS == "FinalRed")
					{
						InicializarPecasVermelhas[1].PeaoSelecionado.IsEnabled = false;
						pvermelho.PeoesChegada++;
					}
				}
				if ((InicializarPecasVermelhas[2].Index >= 53) && (InicializarPecasVermelhas[2].Index <= 59))
				{
					if (numMovimentos > InicializarPecasVermelhas[2].JogadasRestantes)
						InicializarPecasVermelhas[2].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasVermelhas[2].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasVermelhas[2].CurrentPOS == "FinalRed")
					{
						InicializarPecasVermelhas[2].PeaoSelecionado.IsEnabled = false;
						pvermelho.PeoesChegada++;
					}
				}
				if ((InicializarPecasVermelhas[3].Index >= 53) && (InicializarPecasVermelhas[3].Index <= 59))
				{
					if (numMovimentos > InicializarPecasVermelhas[3].JogadasRestantes)
						InicializarPecasVermelhas[3].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasVermelhas[3].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasVermelhas[3].CurrentPOS == "FinalRed")
					{
						InicializarPecasVermelhas[3].PeaoSelecionado.IsEnabled = false;
						pvermelho.PeoesChegada++;
					}
				}
				

			}
			else
			{
				PeaoVermelho1.IsEnabled = false;
				PeaoVermelho2.IsEnabled = false;
				PeaoVermelho3.IsEnabled = false;
				PeaoVermelho4.IsEnabled = false;

			}

			//658866868

			if (InicializarPecasVerdes.Count != 0)
			{
				if ((InicializarPecasVerdes[0].Index >= 53) && (InicializarPecasVerdes[0].Index <= 59))
				{
					if (numMovimentos > InicializarPecasVerdes[0].JogadasRestantes)
						InicializarPecasVerdes[0].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasVerdes[0].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasVerdes[0].CurrentPOS == "FinalGreen")
					{
						InicializarPecasVerdes[0].PeaoSelecionado.IsEnabled = false;
						pverde.PeoesChegada++;
					}
				}
				if ((InicializarPecasVerdes[1].Index >= 53) && (InicializarPecasVerdes[1].Index <= 59))
				{
					if (numMovimentos > InicializarPecasVerdes[1].JogadasRestantes)
						InicializarPecasVerdes[1].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasVerdes[1].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasVerdes[1].CurrentPOS == "FinalGreen")
					{
						InicializarPecasVerdes[1].PeaoSelecionado.IsEnabled = false;
						pverde.PeoesChegada++;
					}
				}
				if ((InicializarPecasVerdes[2].Index >= 53) && (InicializarPecasVerdes[2].Index <= 59))
				{
					if (numMovimentos > InicializarPecasVerdes[2].JogadasRestantes)
						InicializarPecasVerdes[2].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasVerdes[2].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasVerdes[2].CurrentPOS == "FinalGreen")
					{
						InicializarPecasVerdes[2].PeaoSelecionado.IsEnabled = false;
						pverde.PeoesChegada++;
					}
				}
				if ((InicializarPecasVerdes[3].Index >= 53) && (InicializarPecasVerdes[3].Index <= 59))
				{
					if (numMovimentos > InicializarPecasVerdes[3].JogadasRestantes)
						InicializarPecasVerdes[3].PeaoSelecionado.IsEnabled = false;
					else
						InicializarPecasVerdes[3].PeaoSelecionado.IsEnabled = true;
					if (InicializarPecasVerdes[3].CurrentPOS == "FinalGreen")
					{
						InicializarPecasVerdes[3].PeaoSelecionado.IsEnabled = false;
						pverde.PeoesChegada++;
					}
				}
				btnGirarDado.IsEnabled = false;
				

			}
			//if (vez == "Blue")
			//{
			//	if ((pazul.PeoesBase == 4) && (numMovimentos != 6))
			//	{

			//		if ((InicializarPecasAzuis[0].Jogou) || (InicializarPecasAzuis[1].Jogou) || (InicializarPecasAzuis[2].Jogou) || (InicializarPecasAzuis[3].Jogou))
			//		{
			//			Rodada(vez);
			//			vez = ProximoJogador("Red");
			//			InicializarPecasAzuis[0].Jogou = false;
			//			InicializarPecasAzuis[1].Jogou = false;
			//			InicializarPecasAzuis[2].Jogou = false;
			//			InicializarPecasAzuis[3].Jogou = false;
   //                 }
			//	}
				
			//}
			//else if (vez == "Green")
			//{
			//	if ((pverde.PeoesBase == 4) && (numMovimentos != 6))
			//	{

			//		if ((InicializarPecasVerdes[0].Jogou) || (InicializarPecasVerdes[1].Jogou) || (InicializarPecasVerdes[2].Jogou) || (InicializarPecasVerdes[3].Jogou))
			//		{
			//			Rodada(vez);
			//			vez = ProximoJogador("Yellow");
			//			InicializarPecasVerdes[0].Jogou = false;
			//			InicializarPecasVerdes[1].Jogou = false;
			//			InicializarPecasVerdes[2].Jogou = false;
			//			InicializarPecasVerdes[3].Jogou = false;
			//		}
			//	}
				
			//}
			//else if (vez == "Red")
			//{
			//	if ((pvermelho.PeoesBase == 4) && (numMovimentos != 6))
			//	{

			//		if ((InicializarPecasVermelhas[0].Jogou) || (InicializarPecasVermelhas[1].Jogou) || (InicializarPecasVermelhas[2].Jogou) || (InicializarPecasVermelhas[3].Jogou))
			//		{
			//			Rodada(vez);
			//			vez = ProximoJogador("Green");
			//			InicializarPecasVermelhas[0].Jogou = false;
			//			InicializarPecasVermelhas[1].Jogou = false;
			//			InicializarPecasVermelhas[2].Jogou = false;
			//			InicializarPecasVermelhas[3].Jogou = false;
			//		}
			//	}
				
			//}
			//else if (vez == "Yellow")
			//{
			//	if ((pamarelo.PeoesBase == 4) && (numMovimentos != 6))
			//	{

			//		if ((InicializarPecasAmarelas[0].Jogou) || (InicializarPecasAmarelas[1].Jogou) || (InicializarPecasAmarelas[2].Jogou) || (InicializarPecasAmarelas[3].Jogou))
			//		{
			//			Rodada(vez);
			//			vez = ProximoJogador("Blue");
			//			InicializarPecasAmarelas[0].Jogou = false;
			//			InicializarPecasAmarelas[1].Jogou = false;
			//			InicializarPecasAmarelas[2].Jogou = false;
			//			InicializarPecasAmarelas[3].Jogou = false;
			//		}
			//	}
				
			//}
		}


		private void IniciaJogo_Click(object sender, RoutedEventArgs e)
		{
			//if (((string)btnPlayer1.Content == "Jogador 1") || ((string)btnPlayer1.Content == "CPU 1"))
			if(btnPlayer1.IsChecked == false)
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
			if (btnPlayer2.IsChecked == false)
			{
				PeaoVerde pverde1 = new PeaoVerde();
				pverde1.PeaoSelecionado = PeaoVerde1;
				pverde1.NaBase = true;
				PeaoVerde pverde2 = new PeaoVerde();
				pverde2.PeaoSelecionado = PeaoVerde2;
				pverde2.NaBase = true;
				PeaoVerde pverde3 = new PeaoVerde();
				pverde3.PeaoSelecionado = PeaoVerde3;
				pverde3.NaBase = true;
				PeaoVerde pverde4 = new PeaoVerde();
				pverde4.PeaoSelecionado = PeaoVerde4;
				pverde4.NaBase = true;
				InicializarPecasVerdes.Add(pverde1);
				InicializarPecasVerdes.Add(pverde2);
				InicializarPecasVerdes.Add(pverde3);
				InicializarPecasVerdes.Add(pverde4);
			}
			if (btnPlayer3.IsChecked == false)
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
			if (btnPlayer4.IsChecked == false)
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
			if (InicializarPecasVermelhas.Count != 0)
			{
				vez = "Red";
			}
			else if (InicializarPecasAzuis.Count != 0)
			{
				vez = "Red";
			}
			else if (InicializarPecasAmarelas.Count != 0)
			{
				vez = "Red";
			}
			else if (InicializarPecasVerdes.Count != 0)
			{
				vez = "Red";
			}
			startgame = true;
			btnGirarDado.IsEnabled = true;
			btnIniciaJogo.IsEnabled = false;
			Storyboard Clearbtn1 = this.FindResource("SomeBotaoJogador1") as Storyboard;
			Storyboard.SetTarget(Clearbtn1, btnPlayer1);
			Clearbtn1.Begin();
			Storyboard Clearbtn2 = this.FindResource("SomeBotaoJogador1") as Storyboard;
			Storyboard.SetTarget(Clearbtn2, btnPlayer2);
			Clearbtn2.Begin();
			Storyboard Clearbtn3 = this.FindResource("SomeBotaoJogador1") as Storyboard;
			Storyboard.SetTarget(Clearbtn3, btnPlayer3);
			Clearbtn3.Begin();
			Storyboard Clearbtn4 = this.FindResource("SomeBotaoJogador1") as Storyboard;
			Storyboard.SetTarget(Clearbtn4, btnPlayer4);
			Clearbtn4.Begin();
			//btnPlayer1.IsEnabled = false;
			//btnPlayer2.IsEnabled = false;
			Jogo();
		}
		private void Jogo()
		{
			if (InicializarPecasVermelhas.Count != 0)
			{
				Rodada("Blue");
			}
			else if (InicializarPecasVerdes.Count != 0)
			{
				Rodada("Red");
			}
			else if (InicializarPecasAmarelas.Count != 0)
			{
				Rodada("Green");

			}
			else if		(InicializarPecasAzuis.Count != 0)
                {
				Rodada("Yellow");
			}
		}

		private void PeaoAzul1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAzuis[0].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasAzuis[0].Jogou=true;
				Movimentar(InicializarPecasAzuis[0], p1);
				primeirajogada = false;
				vez = ProximoJogador("Blue");
				Rodada(vez);
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
				pazul.NaBase = false;
			}
			else if (pazul.NaBase == false)
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
			//pazul.NaBase = false;
		}
		private void Movimentar(PeaoVerde pverde, Ellipse ell)
		{
			
			if (numMovimentos == 6 && pverde.NaBase)
			{
				Tuple<double, double> TempTuple = new Tuple<double, double>(45, 230.25);
				MovePeca(pverde.PeaoSelecionado, TempTuple);
				pverde.CurrentPOS = "3";
				pverde.PeoesBase--;
				pverde.NaBase = false;
			}
			else if (pverde.NaBase == false)
			//else
			{
				for (int i = 0; i < numMovimentos; i++)
				{
					pecasrestantes--;
					var y = pverde.Rotas(1, pverde.CurrentPOS, numMovimentos);
					Tuple<double, double> TempTuple = new Tuple<double, double>(y.Item3, y.Item4);
					MovePeca(ell, TempTuple);
					pverde.Index = y.Item1;
					pverde.CurrentPOS = y.Item2;
					pverde.JogadasRestantes--;
					if (pverde.CurrentPOS == "FinalGreen")
						ell.IsEnabled = false;
				}
			}
			//pverde.NaBase = false;
		}
		private void Movimentar(PeaoAmarelo pamarelo, Ellipse ell)
		{
			if (numMovimentos == 6 && pamarelo.NaBase)
			{
				Tuple<double, double> TempTuple = new Tuple<double, double>(231, 495);
				MovePeca(pamarelo.PeaoSelecionado, TempTuple);
				pamarelo.CurrentPOS = "50";
				pamarelo.PeoesBase--;
				pamarelo.NaBase = false;

			}
			else if (pamarelo.NaBase == false)
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
			//pamarelo.NaBase = false;
		}
		private void Movimentar(PeaoVermelho pvermelho, Ellipse ell)
		{
			if (numMovimentos == 6 && pvermelho.NaBase)
			{
				Tuple<double, double> TempTuple = new Tuple<double, double>(312, 42.25);
				MovePeca(pvermelho.PeaoSelecionado, TempTuple);
				pvermelho.CurrentPOS = "57";
				pvermelho.PeoesBase--;
				pvermelho.NaBase = false;

			}
			else if (pvermelho.NaBase == false)
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
			//pvermelho.NaBase = false;
		}



		//private void MoveUmaPosicao(object sender)
		//{
		//	Thread.Sleep(1000);
		//	PeaoAzul pazul = new PeaoAzul();
		//	Ellipse ell = (Ellipse)sender;

		//	var y = pazul.Rotas(1, currentPOS, numMovimentos);
		//	Tuple<double, double> TempTuple = new Tuple<double, double>(y.Item3, y.Item4);
		//	MovePeca(ell, TempTuple);
		//	currentPOS = y.Item2;
		//}


		private void PeaoAzul2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAzuis[1].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasAzuis[1].Jogou = true;
				Movimentar(InicializarPecasAzuis[1], p1);
				primeirajogada = false;
				vez = ProximoJogador("Blue");
				Rodada(vez);
			}
		}
		private void MovePeca(Ellipse sender, Tuple<double, double> route)
		{

			ThicknessAnimation b = new ThicknessAnimation();
			b.Duration = TimeSpan.FromSeconds(0.7);
			b.To = new Thickness(route.Item1, route.Item2, 0, 0);



			Storyboard PularPeca = this.FindResource("PulaPeca") as Storyboard;
		
            Storyboard.SetTarget(b, sender);
			Storyboard.SetTargetProperty(b, new PropertyPath(Ellipse.MarginProperty));
			Storyboard.SetTarget(PularPeca, sender);
			Storyboard tentando = new Storyboard();
			tentando.Children.Add(b);
			tentando.Begin();
			PularPeca.Begin();
		}

		private void PeaoAzul4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAzuis[3].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasAzuis[3].Jogou = true;
				Movimentar(InicializarPecasAzuis[3], p1);
				primeirajogada = false;
				vez = ProximoJogador("Blue");
				Rodada(vez);
			}
		}

		private void PeaoAmarelo2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAmarelas[1].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasAmarelas[1].Jogou = true;
				Movimentar(InicializarPecasAmarelas[1], p1);
				primeirajogada = false;
				vez = ProximoJogador("Yellow");
				Rodada(vez);
			}
		}

		private void PeaoAzul3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAzuis[2].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasAzuis[2].Jogou = true;
				Movimentar(InicializarPecasAzuis[2], p1);
				primeirajogada = false;
				vez = ProximoJogador("Blue");
				Rodada(vez);
			}
		}

		private void PeaoAmarelo1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAmarelas[0].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasAmarelas[0].Jogou = true;
				Movimentar(InicializarPecasAmarelas[0], p1);
				primeirajogada = false;
				vez = ProximoJogador("Yellow");
				Rodada(vez);
			}
		}

		private void PeaoAmarelo3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAmarelas[2].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasAmarelas[2].Jogou = true;
				Movimentar(InicializarPecasAmarelas[2], p1);
				primeirajogada = false;
				vez = ProximoJogador("Yellow");
				Rodada(vez);
			}

		}

		private void PeaoAmarelo4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasAmarelas[3].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasAmarelas[3].Jogou = true;
				Movimentar(InicializarPecasAmarelas[3], p1);
				primeirajogada = false;
				vez = ProximoJogador("Yellow");
				Rodada(vez);
			}
		}

		private void PeaoVermelho2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasVermelhas[1].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasVermelhas[1].Jogou = true;
				Movimentar(InicializarPecasVermelhas[1], p1);
				primeirajogada = false;
				vez = ProximoJogador("Red");
				Rodada(vez);
			}
		}

		private void PeaoVermelho1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasVermelhas[0].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasVermelhas[0].Jogou = true;
				Movimentar(InicializarPecasVermelhas[0], p1);
				primeirajogada = false;
				vez = ProximoJogador("Red");
				Rodada(vez);
			}
		}

		private void PeaoVermelho4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasVermelhas[3].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasVermelhas[3].Jogou = true;
				Movimentar(InicializarPecasVermelhas[3], p1);
				primeirajogada = false;
				vez = ProximoJogador("Red");
				Rodada(vez);
			}
		}

		private void PeaoVermelho3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasVermelhas[2].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasVermelhas[2].Jogou = true;
				Movimentar(InicializarPecasVermelhas[2], p1);
				primeirajogada = false;
				vez = ProximoJogador("Red");
				Rodada(vez);
			}
		}

		private void PeaoVerde3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasVerdes[2].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasVerdes[2].Jogou = true;
				Movimentar(InicializarPecasVerdes[2], p1);
				primeirajogada = false;
				vez = ProximoJogador("Green");
				Rodada(vez);
			}
		}

		private void PeaoVerde4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasVerdes[3].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasVerdes[3].Jogou = true;
				Movimentar(InicializarPecasVerdes[3], p1);
				primeirajogada = false;
				vez = ProximoJogador("Green");
				Rodada(vez);
			}
		}

		private void PeaoVerde1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasVerdes[0].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasVerdes[0].Jogou = true;
				Movimentar(InicializarPecasVerdes[0], p1);
				primeirajogada = false;
				vez = ProximoJogador("Green");
				Rodada(vez);
			}
		}

		private void PeaoVerde2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			var p1 = InicializarPecasVerdes[1].PeaoSelecionado;
			if (startgame)
			{
				InicializarPecasVerdes[0].Jogou = true;
				Movimentar(InicializarPecasVerdes[1], p1);
				primeirajogada = false;
				vez = ProximoJogador("Green");
				Rodada(vez);
			}
		}
		private void Rodada(string turn)
		{
			Storyboard stbTurnos = this.FindResource("Turnos") as Storyboard;
			stbTurnos.Begin();
			Storyboard stbRodadas = this.FindResource("Rodadas") as Storyboard;
			if (turn == "Blue")
			{
				
                turnos++;
				
				
				lblnumTurnos.Content = turnos.ToString();
				stbRodadas.Begin();
				lblVezJogador.Content = "Agora é a vez do Jogador Vermelho";
				lblVezJogador.Foreground = new SolidColorBrush(Colors.Red);
				//InicializarPecasAzuis[0].Jogou = false;
				//InicializarPecasAzuis[1].Jogou = false;
				//InicializarPecasAzuis[2].Jogou = false;
				//InicializarPecasAzuis[3].Jogou = false;
				if (InicializarPecasAzuis.Count != 0)
				{

					InicializarPecasAzuis[0].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAzuis[1].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAzuis[2].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAzuis[3].PeaoSelecionado.IsEnabled = false;
				}
				if (InicializarPecasVermelhas.Count != 0)
				{
					InicializarPecasVermelhas[0].PeaoSelecionado.IsEnabled = true;
					InicializarPecasVermelhas[1].PeaoSelecionado.IsEnabled = true;
					InicializarPecasVermelhas[2].PeaoSelecionado.IsEnabled = true;
					InicializarPecasVermelhas[3].PeaoSelecionado.IsEnabled = true;
				}
				if (InicializarPecasVerdes.Count != 0)
				{

					InicializarPecasVerdes[0].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVerdes[1].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVerdes[2].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVerdes[3].PeaoSelecionado.IsEnabled = false;
				}
				if (InicializarPecasAmarelas.Count != 0)
				{
					InicializarPecasAmarelas[0].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAmarelas[1].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAmarelas[2].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAmarelas[3].PeaoSelecionado.IsEnabled = false;
					btnGirarDado.IsEnabled = true;
				}
				//if (numMovimentos == 6)
				//{
				//	lblVezJogador.Content = "Jogador Vermelho, jogue novamente";
				//	goto Jogada;
				//}
            }

			if (turn == "Red")
			{
				turnos++;
				stbTurnos.Begin();
				lblnumTurnos.Content = turnos.ToString();
				stbRodadas.Begin();
				lblVezJogador.Content = "Agora é a vez do Jogador Verde";
				lblVezJogador.Foreground = new SolidColorBrush(Colors.DarkGreen);
				//InicializarPecasVermelhas[0].Jogou = false;
				//InicializarPecasVermelhas[1].Jogou = false;
				//InicializarPecasVermelhas[2].Jogou = false;
				//InicializarPecasVermelhas[3].Jogou = false;
				if (InicializarPecasAzuis.Count != 0)
				{
					InicializarPecasAzuis[0].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAzuis[1].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAzuis[2].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAzuis[3].PeaoSelecionado.IsEnabled = false;
				}
				if (InicializarPecasVermelhas.Count != 0)
				{
					InicializarPecasVermelhas[0].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVermelhas[1].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVermelhas[2].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVermelhas[3].PeaoSelecionado.IsEnabled = false;
				}
				if (InicializarPecasVerdes.Count != 0)
				{
					InicializarPecasVerdes[0].PeaoSelecionado.IsEnabled = true;
					InicializarPecasVerdes[1].PeaoSelecionado.IsEnabled = true;
					InicializarPecasVerdes[2].PeaoSelecionado.IsEnabled = true;
					InicializarPecasVerdes[3].PeaoSelecionado.IsEnabled = true;
				}
				if (InicializarPecasAmarelas.Count != 0)
				{
					InicializarPecasAmarelas[0].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAmarelas[1].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAmarelas[2].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAmarelas[3].PeaoSelecionado.IsEnabled = false;
				}
				btnGirarDado.IsEnabled = true;
				//if (numMovimentos == 6)
				//{
				//	lblVezJogador.Content = "Jogador Verde, jogue novamente";
				//	goto Jogada;
				//}

			}
			if (turn == "Green")
			{
				turnos++;
				stbTurnos.Begin();
				lblnumTurnos.Content = turnos.ToString();
				stbRodadas.Begin();
				lblVezJogador.Content = "Agora é a vez do Jogador Amarelo";
				lblVezJogador.Foreground = new SolidColorBrush(Colors.Yellow);
				//InicializarPecasVerdes[0].Jogou = false;
				//InicializarPecasVerdes[1].Jogou = false;
				//InicializarPecasVerdes[2].Jogou = false;
				//InicializarPecasVerdes[3].Jogou = false;
				if (InicializarPecasAzuis.Count != 0)
				{
					InicializarPecasAzuis[0].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAzuis[1].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAzuis[2].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAzuis[3].PeaoSelecionado.IsEnabled = false;
				}
				if (InicializarPecasVermelhas.Count != 0)
				{
					InicializarPecasVermelhas[0].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVermelhas[1].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVermelhas[2].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVermelhas[3].PeaoSelecionado.IsEnabled = false;
				}
				if (InicializarPecasVerdes.Count != 0)
				{
					InicializarPecasVerdes[0].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVerdes[1].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVerdes[2].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVerdes[3].PeaoSelecionado.IsEnabled = false;
				}
				if (InicializarPecasAmarelas.Count != 0)
				{
					InicializarPecasAmarelas[0].PeaoSelecionado.IsEnabled = true;
					InicializarPecasAmarelas[1].PeaoSelecionado.IsEnabled = true;
					InicializarPecasAmarelas[2].PeaoSelecionado.IsEnabled = true;
					InicializarPecasAmarelas[3].PeaoSelecionado.IsEnabled = true;
				}
				btnGirarDado.IsEnabled = true;
				//if (numMovimentos == 6)
				//{
				//	lblVezJogador.Content = "Jogador Amarelo, jogue novamente";
				//	goto Jogada;
				//}

			}
			if (turn == "Yellow")
			{
				turnos++;
				stbTurnos.Begin();
				lblnumTurnos.Content = turnos.ToString();
				stbRodadas.Begin();
				lblVezJogador.Content = "Agora é a vez do Jogador Azul";
				lblVezJogador.Foreground = new SolidColorBrush(Colors.DarkBlue);
				//InicializarPecasAmarelas[0].Jogou = false;
				//InicializarPecasAmarelas[1].Jogou = false;
				//InicializarPecasAmarelas[2].Jogou = false;
				//InicializarPecasAmarelas[3].Jogou = false;
				if (InicializarPecasAzuis.Count != 0)
				{
					InicializarPecasAzuis[0].PeaoSelecionado.IsEnabled = true;
					InicializarPecasAzuis[1].PeaoSelecionado.IsEnabled = true;
					InicializarPecasAzuis[2].PeaoSelecionado.IsEnabled = true;
					InicializarPecasAzuis[3].PeaoSelecionado.IsEnabled = true;
				}
				if (InicializarPecasVermelhas.Count != 0)
				{
					InicializarPecasVermelhas[0].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVermelhas[1].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVermelhas[2].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVermelhas[3].PeaoSelecionado.IsEnabled = false;
				}
				if (InicializarPecasVerdes.Count != 0)
				{
					InicializarPecasVerdes[0].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVerdes[1].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVerdes[2].PeaoSelecionado.IsEnabled = false;
					InicializarPecasVerdes[3].PeaoSelecionado.IsEnabled = false;
				}
				if (InicializarPecasAmarelas.Count != 0)
				{
					InicializarPecasAmarelas[0].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAmarelas[1].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAmarelas[2].PeaoSelecionado.IsEnabled = false;
					InicializarPecasAmarelas[3].PeaoSelecionado.IsEnabled = false;
				}
				btnGirarDado.IsEnabled = true;
				/*if (numMovimentos == 6)
				{
					lblVezJogador.Content = "Jogador Azul, jogue novamente";
					goto Jogada;
				}*/

			}
			if (pazul.PeoesChegada == 4)
			{
				lblVezJogador.Content = "Jogador Azul Venceu!";
				lblVezJogador.Foreground = new SolidColorBrush(Colors.DarkBlue);
				startgame = false;
				DesativaPecas();
			}
			if (pverde.PeoesChegada == 4)
			{
				lblVezJogador.Content = "Jogador Verde Venceu!";
				lblVezJogador.Foreground = new SolidColorBrush(Colors.DarkGreen);
				startgame = false;
				DesativaPecas();
			}
			if (pvermelho.PeoesChegada == 4)
			{
				lblVezJogador.Content = "Jogador Vermelho Venceu!";
				lblVezJogador.Foreground = new SolidColorBrush(Colors.Red);
				startgame = false;
				DesativaPecas();
			}
			if (pamarelo.PeoesChegada == 4)
			{
				lblVezJogador.Content = "Jogador Amarelo Venceu!";
				lblVezJogador.Foreground = new SolidColorBrush(Colors.Yellow);
				startgame = false;
				DesativaPecas();
			}

	}
		private void DesativaPecas()
		{
			InicializarPecasAzuis[0].PeaoSelecionado.IsEnabled = false;
			InicializarPecasAzuis[1].PeaoSelecionado.IsEnabled = false;
			InicializarPecasAzuis[2].PeaoSelecionado.IsEnabled = false;
			InicializarPecasAzuis[3].PeaoSelecionado.IsEnabled = false;

			InicializarPecasVermelhas[0].PeaoSelecionado.IsEnabled = false;
			InicializarPecasVermelhas[1].PeaoSelecionado.IsEnabled = false;
			InicializarPecasVermelhas[2].PeaoSelecionado.IsEnabled = false;
			InicializarPecasVermelhas[3].PeaoSelecionado.IsEnabled = false;

			InicializarPecasVerdes[0].PeaoSelecionado.IsEnabled = false;
			InicializarPecasVerdes[1].PeaoSelecionado.IsEnabled = false;
			InicializarPecasVerdes[2].PeaoSelecionado.IsEnabled = false;
			InicializarPecasVerdes[3].PeaoSelecionado.IsEnabled = false;

			InicializarPecasAmarelas[0].PeaoSelecionado.IsEnabled = false;
			InicializarPecasAmarelas[1].PeaoSelecionado.IsEnabled = false;
			InicializarPecasAmarelas[2].PeaoSelecionado.IsEnabled = false;
			InicializarPecasAmarelas[3].PeaoSelecionado.IsEnabled = false;
		}

		private void btnPlayer1_Checked(object sender, RoutedEventArgs e)
		{

		}

		private void btnPlayer2_Checked(object sender, RoutedEventArgs e)
		{
			
		}

		private void btnPlayer3_Checked(object sender, RoutedEventArgs e)
		{
			
        }

		private void btnPlayer4_Checked(object sender, RoutedEventArgs e)
		{
			
        }
		private void VerificaJogadores()
		{
			if ((btnPlayer4.IsChecked == false) && (btnPlayer3.IsChecked == false) && (btnPlayer2.IsChecked == false) && (btnPlayer1.IsChecked == false))
			{
				btnIniciaJogo.IsEnabled = false;
			}
			else
				btnIniciaJogo.IsEnabled = true;
		}

		private void btnPlayer1_Indeterminate(object sender, RoutedEventArgs e)
		{
			VerificaJogadores();
		}

		private void btnPlayer2_Indeterminate(object sender, RoutedEventArgs e)
		{
			VerificaJogadores();
		}

		private void btnPlayer3_Indeterminate(object sender, RoutedEventArgs e)
		{
			VerificaJogadores();
		}

		private void btnPlayer4_Indeterminate(object sender, RoutedEventArgs e)
		{
			VerificaJogadores();
		}
		private string ProximoJogador(string jogadoratual)
		{
			if (jogadoratual == "Blue")
			{
				if (InicializarPecasVermelhas.Count != 0)
				{
					return "Blue";
				}
				else if (InicializarPecasVerdes.Count != 0)
				{
					return "Red";
				}
				else if (InicializarPecasAmarelas.Count != 0)
				{
					return "Green";

				}
				else if (InicializarPecasAzuis.Count != 0)
				{
					return "Yellow";
				}
			}

			if (jogadoratual == "Yellow")
			{
				if (InicializarPecasAzuis.Count != 0)
				{
					return "Yellow";
				}
				else if (InicializarPecasVermelhas.Count != 0)
				{
					return "Blue";
				}
				else if (InicializarPecasVerdes.Count != 0)
				{
					return "Red";

				}
				else if (InicializarPecasAmarelas.Count != 0)
				{
					return "Green";
				}
			}

			if (jogadoratual == "Green")
			{
				if (InicializarPecasAmarelas.Count != 0)
				{
					return "Green";
				}
				else if (InicializarPecasAzuis.Count != 0)
				{
					return "Yellow";
				}
				else if (InicializarPecasVermelhas.Count != 0)
				{
					return "Blue";

				}
				else if (InicializarPecasVerdes.Count != 0)
				{
					return "Red";
				}
			}

			if (jogadoratual == "Red")
			{
				if (InicializarPecasVerdes.Count != 0)
				{
					return "Red";
				}
				else if (InicializarPecasAmarelas.Count != 0)
				{
					return "Green";
				}
				else if (InicializarPecasAzuis.Count != 0)
				{
					return "Yellow";

				}
				else if (InicializarPecasVermelhas.Count != 0)
				{
					return "Blue";
				}
			}

			return null;
		}
		private void Checagem()
		{
			if (vez == "Red")
			{
				//if(pvermelho.PeoesBase==4) && (numsorteado!=6))
				{

				}
			}
		}
	}
}