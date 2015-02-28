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
            GirarDado.Content = FindResource(faceDados);
            numjogado.Content = faceDados;
          
        }
    }
}
