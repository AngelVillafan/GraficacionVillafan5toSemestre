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

namespace PriPanPrd
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

        private void txtPan_KeyDown(object sender, KeyEventArgs e)
        {
            double escala = double.Parse(txtPan.Text);
            if (e.Key == Key.Enter)
            {
                if (escala >= 0 && escala <= 100)
                {
                    RecPan.ScaleY = escala;
                }
                else
                    MessageBox.Show("Atencion", "Solo numeros dentro del 0 al 100", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void txtPri_KeyDown(object sender, KeyEventArgs e)
        {
            double escala = double.Parse(txtPri.Text);
            if (e.Key == Key.Enter)
            {
                if (escala >= 0 && escala <= 100)
                {
                    RecPri.ScaleY = escala;
                }
                else
                    MessageBox.Show("Atencion", "Solo numeros dentro del 0 al 100", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void txtPrd_KeyDown(object sender, KeyEventArgs e)
        {
            double escala = double.Parse(txtPrd.Text);
            if (e.Key == Key.Enter)
            {
                if (escala >= 0 && escala <= 100)
                {
                    RecPrd.ScaleY = escala;
                }
                else
                    MessageBox.Show("Atencion", "Solo numeros dentro del 0 al 100", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        //private void TextBox_KeyDown(object sender, KeyEventArgs e)
        //{

        //}



    }
}
