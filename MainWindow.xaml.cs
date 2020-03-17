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
using Parcial2_Maria.Registro;


namespace Parcial2_Maria
{
 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LlamadasButton_Click(object sender, RoutedEventArgs e)
        {
            RParcial2 rParcial = new RParcial2();
            rParcial.Show();
        }
    }
}
