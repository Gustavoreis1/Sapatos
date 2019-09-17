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
    /// Lógica interna para EstoqueWindow.xaml
    /// </summary>
    public partial class EstoqueWindow : Window
    {
        //public ViewModel.EstoqueViewModel EstoqueViewModel { get; set; }
        public EstoqueWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void SalvarEstoque_Click(object sender, RoutedEventArgs e)
        {
            //this.EstoqueViewModel.Salvar();
            this.Close();
        }

        private void CancelarEstoque_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ExcluirEstoque_Click(object sender, RoutedEventArgs e)
        {
            //this.EstoqueViewModel.Excluir();
        }

        private void AdicionarEstoque_Click(object sender, RoutedEventArgs e)
        {
            //this.EstoqueViewModel.Adicionar();
        }
        
    }
}