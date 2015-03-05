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

namespace LudoSIAEDB2015
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
	
			Storyboard fds = this.FindResource("MoverPeaoLado") as Storyboard;
			//fds.Begin();
			var x = Canvas.GetLeft(R01);
			var y = Canvas.GetTop(R01);
			Canvas.SetLeft(R01, 98);
			Canvas.SetTop(R01, 54);
			DoubleAnimationUsingKeyFrames movy = this.FindName("PeaoMovimentoY") as DoubleAnimationUsingKeyFrames;

			foreach (var pular in fds.Children)
			{
				Storyboard.SetTarget(pular, R01);
			}
		}
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