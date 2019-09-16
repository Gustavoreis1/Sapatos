using SapatosWPF.View;
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

namespace SapatosWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CidadesMenu_Click(object sender, RoutedEventArgs e)
        {
            Window window = new CidadesWindow();
            window.ShowDialog();
        }

        private void EstadosMenu_Click(object sender, RoutedEventArgs e)
        {
            Window window = new EstadosWindow();
            window.ShowDialog();
        }

        private void SairMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PessoaJuridicaMenu_Click(object sender, RoutedEventArgs e)
        {
            Window window = new PessoaJuridicaWindow();
            window.ShowDialog();
        }

        private void PessoaFisicaMenu_Click(object sender, RoutedEventArgs e)
        {
            Window window = new PessoaFisicaWindow();
            window.ShowDialog();
        }

        private void EstoqueMenu_Click(object sender, RoutedEventArgs e)
        {
            Window window = new EstoqueWindow();
            window.ShowDialog();
        }
    }
}
