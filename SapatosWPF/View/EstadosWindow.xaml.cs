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
    /// Lógica interna para EstadosWindow.xaml
    /// </summary>
    public partial class EstadosWindow : Window
    {
        public ViewModel.EstadosViewModel EstadosViewModel { get; set; }
        public EstadosWindow()
        {
            InitializeComponent();
            this.EstadosViewModel = new ViewModel.EstadosViewModel();
            this.DataContext = this.EstadosViewModel;
        }

        private void SalvarEstado_Click(object sender, RoutedEventArgs e)
        {
            this.EstadosViewModel.Salvar();
            this.Close();
        }

        private void CancelarEstado_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ExcluirEstado_Click(object sender, RoutedEventArgs e)
        {
            this.EstadosViewModel.Excluir();
        }

        private void AdicionarEstado_Click(object sender, RoutedEventArgs e)
        {
            this.EstadosViewModel.Adicionar();
        }
    }
}
