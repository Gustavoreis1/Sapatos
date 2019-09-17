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
    /// Lógica interna para EnderecoWindow.xaml
    /// </summary>
    public partial class EnderecoWindow : Window
    {
        //public ViewModel.EnderecoViewModel EnderecoViewModel { get; set; }
        public EnderecoWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void SalvarEndereco_Click(object sender, RoutedEventArgs e)
        {
            //this.EnderecoViewModel.Salvar();
            this.Close();
        }

        private void ExcluirEndereco_Click(object sender, RoutedEventArgs e)
        {
            //this.EnderecoViewModel.Excluir();
        }

        private void AdicionarEndereco_Click(object sender, RoutedEventArgs e)
        {
            //this.EnderecoViewModel.Adicionar();
        }

        private void CancelarEndereco_Click(object sender, RoutedEventArgs e)
        {
            
            //this.EnderecoViewModel.Adicionar();
        }
    }
}
