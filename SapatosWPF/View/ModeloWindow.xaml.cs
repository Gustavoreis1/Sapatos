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
    /// Lógica interna para ModeloWindow.xaml
    /// </summary>
    public partial class ModeloWindow : Window
    {
        public ViewModel.ModeloViewModel ModeloViewModel { get; set; }
        public ModeloWindow()
        {
            InitializeComponent();
            this.ModeloViewModel = new ViewModel.ModeloViewModel();
            this.DataContext = this.ModeloViewModel;
        }

        private void SalvarModelo_Click(object sender, RoutedEventArgs e)
        {
            this.ModeloViewModel.Salvar();
            this.Close();
        }

        private void CancelarModelo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ExcluirModelo_Click(object sender, RoutedEventArgs e)
        {
            this.ModeloViewModel.Excluir();
        }

        private void AdicionarModelo_Click(object sender, RoutedEventArgs e)
        {
            this.ModeloViewModel.Adicionar();
        }
    }
}