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

namespace TecladoNumerico
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreacionDeNBotonesNumericos(0, 0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PantallaTextBlock.Text += ((Button)sender).Tag.ToString();
        }
        private void CreacionDeNBotonesNumericos(int desde, int hasta)
        {
            //foreach (object obj in Enum.GetValues(typeof(Grid)))
            //{

            //}
        }           
    }
}
