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
		int turnos=0;
		int numMovimentos;
		string currentPOS="22";
		bool primeirajogada = true;
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
            Random rand = new Random();
            numMovimentos = rand.Next(1, 7);
            string faceDados = numMovimentos.ToString();
            btnGirarDado.Content = FindResource(faceDados);
            numjogado.Content = faceDados;          
        }

        private void IniciaJogo_Click(object sender, RoutedEventArgs e)
        {
			startgame = true;
		
		}

		private void PeaoAzul1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			//Jogo startgame = new Jogo();
			if (startgame)
			{
				
				Ellipse ell = (Ellipse)sender;
				PeaoAzul pazul = new PeaoAzul();
				pazul.PeaoSelecionado = ell;
				pazul.NaBase = true;
				Movimentar(pazul, ell);
				primeirajogada = false;
			}
        }

		private void Movimentar(PeaoAzul pazul, Ellipse ell)
		{
			if (numMovimentos == 6 && pazul.NaBase)
			{
				Tuple<double, double> TempTuple = new Tuple<double, double>(497, 309.25);
				MovePeca(pazul.PeaoSelecionado, TempTuple);
				currentPOS = "22";
				pazul.PeoesBase--;
			}
			//if (pazul.NaBase == false)
				else
			{

				
				for (int i = 0; i < numMovimentos; i++)
				{
					var y = pazul.Rotas(1, currentPOS, numMovimentos);
					Tuple<double, double> TempTuple = new Tuple<double, double>(y.Item2, y.Item3);
					MovePeca(ell, TempTuple);
					currentPOS = y.Item1;
				}

				pazul.NaBase = false;

				/*for (int i = 0; i <= numMovimentos; i++)
					MoveUmaPosicao(sender);*/
			}
		}

		private void MoveUmaPosicao(object sender)
		{
			Thread.Sleep(1000);
			PeaoAzul pazul = new PeaoAzul();
			Ellipse ell = (Ellipse)sender;

			var y = pazul.Rotas(1, currentPOS, numMovimentos);
			Tuple<double, double> TempTuple = new Tuple<double, double>(y.Item2, y.Item3);
			MovePeca(ell, TempTuple);
			currentPOS = y.Item1;
		}


		private void PeaoAzul2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			/*Ellipse ell = (Ellipse)sender;
			Peao pazul = new Peao("Azul");
			var y = pazul.Rotas(1, "45", 6, 497, 309.25);
			MovePeca(ell, y);*/
			if (startgame)
			{

				Ellipse ell = (Ellipse)sender;
				PeaoAzul pazul = new PeaoAzul();
				pazul.PeaoSelecionado = ell;
				pazul.NaBase = true;
				Movimentar(pazul, ell);
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
			/*Ellipse ell = (Ellipse)sender;
			Peao pazul = new Peao("Azul");
			var y = pazul.Rotas(1, "45", 6, 497, 309.25);
			MovePeca(ell, y);*/
			if (startgame)
			{

				Ellipse ell = (Ellipse)sender;
				PeaoAzul pazul = new PeaoAzul();
				pazul.PeaoSelecionado = ell;
				pazul.NaBase = true;
				Movimentar(pazul, ell);
				primeirajogada = false;
			}
		}

		private void PeaoAzul3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			/*Ellipse ell = (Ellipse)sender;
			Peao pazul = new Peao("Azul");
			var y = pazul.Rotas(1, "45", 6, 497, 309.25);
			MovePeca(ell, y);*/
			if (startgame)
			{

				Ellipse ell = (Ellipse)sender;
				PeaoAzul pazul = new PeaoAzul();
				pazul.PeaoSelecionado = ell;
				pazul.NaBase = true;
				Movimentar(pazul, ell);
				primeirajogada = false;
			}
		}
	
	}
}