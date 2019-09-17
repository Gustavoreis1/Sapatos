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
using System.Windows.Shapes;

namespace SapatosWPF.View
{
    /// <summary>
    /// Lógica interna para CidadesWindow.xaml
    /// </summary>
    public partial class CidadesWindow : Window
    {
        //public ViewModel.CidadesViewModel CidadesViewModel { get; set; }
        public CidadesWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void SalvarCidade_Click(object sender, RoutedEventArgs e)
        {
            //this.CidadesViewModel.Salvar();
            this.Close();
        }

        private void CancelarCidade_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ExcluirCidade_Click(object sender, RoutedEventArgs e)
        {
            //this.CidadesViewModel.Excluir();
        }

        private void AdicionarCidade_Click(object sender, RoutedEventArgs e)
        {
            //this.CidadesViewModel.Adicionar();
        }
    }
}
