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
    /// Lógica interna para PessoaFisicaWindow.xaml
    /// </summary>
    public partial class PessoaFisicaWindow : Window
    {
        public ViewModel.PessoaFisicaViewModel PFViewModel { get; set; }
        public PessoaFisicaWindow()
        {
            InitializeComponent();
            this.PFViewModel = new ViewModel.PessoaFisicaViewModel();
            this.DataContext = this.PFViewModel;
        }

        private void SalvarPF_Click(object sender, RoutedEventArgs e)
        {
            this.PFViewModel.Salvar();
            this.Close();
        }

        private void CancelarPF_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ExcluirPF_Click(object sender, RoutedEventArgs e)
        {
            //this.PFViewModel.Excluir();
        }

        private void AdicionarPF_Click(object sender, RoutedEventArgs e)
        {
            this.PFViewModel.Adicionar();
        }
    }
}
