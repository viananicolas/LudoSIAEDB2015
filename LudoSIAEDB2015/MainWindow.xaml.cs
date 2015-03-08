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

namespace LudoSIAEDB2015
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
		bool startgame = false;
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
            int numMovimentos = rand.Next(1, 7);
            string faceDados = numMovimentos.ToString();
            btnGirarDado.Content = FindResource(faceDados);
            numjogado.Content = faceDados;          
        }

        private void IniciaJogo_Click(object sender, RoutedEventArgs e)
        {
			startgame = true;

			/*Storyboard sdf = this.FindResource("MoverPeaoLado") as Storyboard;
			//Storyboard.SetTargetName(sdf, "PeaoAzul2");
			sdf.Begin();*/

			/*PointAnimation cookie = new PointAnimation();
			cookie.From = new Point(-38, 0);
			cookie.To = new Point(-58, 0);
			Storyboard.SetTargetName(cookie, "PeaoAzul1");
			Storyboard.SetTargetProperty(
				cookie, new PropertyPath(Ellipse.MarginProperty));
			Storyboard stb = new Storyboard();
			stb.Children.Add(cookie);*/


		
		}

		private void PeaoAzul1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			if (startgame)
			{
				Storyboard dsa = this.FindResource("PeaoSairBaseAzul") as Storyboard;
				Ellipse ell = (Ellipse)sender;
				//dsa.Stop();
				var x = ell.Name;
				dsa.SetValue(Storyboard.TargetNameProperty, x);
				dsa.Begin();
				Peao bluepiece = new Peao("Blue", "4");
				dsa.Completed += Dsa_Completed;
				
			}
			
           
        }

        private void Dsa_Completed(object sender, object e)
        {
            PeaoAzul1.Margin = new Thickness(497, 309.25, 0, 0);
            
        }

        private void PeaoAzul2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Storyboard dsad = this.FindResource("PeaoSairBaseAzul") as Storyboard;
            Ellipse ell = (Ellipse)sender;
           // dsad.Stop();
            var x = ell.Name;
            dsad.SetValue(Storyboard.TargetNameProperty, x);
            dsad.Begin();

			dsad.Completed += Dsad_Completed;
		}

        private void Dsad_Completed(object sender, EventArgs e)
        {
            PeaoAzul2.Margin = new Thickness(497, 309.25, 0, 0);
        }

        private void PeaoAzul4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Storyboard dsad = this.FindResource("PeaoSairBaseAzul") as Storyboard;
            Ellipse ell = (Ellipse)sender;
           // dsad.Stop();
            var x = ell.Name;
            dsad.SetValue(Storyboard.TargetNameProperty, x);
            dsad.Begin();
            dsad.Completed += Dsad2_Completed;
        }
        private void Dsad2_Completed(object sender, EventArgs e)
        {
            PeaoAzul4.Margin = new Thickness(497, 309.25, 0, 0);
        }
        /*private void PeoesDeixandoBase()
{

}*/
    }
}
/*public static Rect GetAbsoltutePlacement(this FrameworkElement element, bool relativeToScreen = false)
{
	var absolutePos = element.PointToScreen(new Point(0, 0));
	if (relativeToScreen)
	{
		return new Rect(absolutePos.X, absolutePos.Y, element.ActualWidth, element.ActualHeight);
	}
	var posMW = Application.Current.MainWindow.PointToScreen(new Point(0, 0));
	absolutePos = new Point(absolutePos.X - posMW.X, absolutePos.Y - posMW.Y);
	return new Rect(absolutePos.X, absolutePos.Y, element.ActualWidth, element.ActualHeight);
}*/