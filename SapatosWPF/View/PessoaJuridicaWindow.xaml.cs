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
    /// Lógica interna para PessoaJuridicaWindow.xaml
    /// </summary>
    public partial class PessoaJuridicaWindow : Window
    {
        public ViewModel.PessoaJuridicaViewModel PJViewModel { get; set; }
        public PessoaJuridicaWindow()
        {
            InitializeComponent();
            this.PJViewModel = new ViewModel.PessoaJuridicaViewModel();
            this.DataContext = this.PJViewModel;
        }

        private void SalvarPJ_Click(object sender, RoutedEventArgs e)
        {
            this.PJViewModel.Salvar();
            this.Close();
        }

        private void CancelarPJ_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ExcluirPJ_Click(object sender, RoutedEventArgs e)
        {
            this.PJViewModel.Excluir();
        }

        private void AdicionarPJ_Click(object sender, RoutedEventArgs e)
        {
            this.PJViewModel.Adicionar();
        }
    }
}
