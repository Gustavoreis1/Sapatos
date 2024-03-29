﻿using System;
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
    /// Lógica interna para VendaWindow.xaml
    /// </summary>
    public partial class VendaWindow : Window
    {
        public ViewModel.VendaViewModel VendaViewModel { get; set; }
        public VendaWindow()
        {
            InitializeComponent();
            VendaViewModel = new ViewModel.VendaViewModel();
            this.DataContext = this.VendaViewModel;
        }

        private void SalvarVenda_Click(object sender, RoutedEventArgs e)
        {
            this.VendaViewModel.Salvar();
            this.Close();
        }

        private void CancelarVenda_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ExcluirVenda_Click(object sender, RoutedEventArgs e)
        {
            this.VendaViewModel.Excluir();
        }

        private void AdicionarVenda_Click(object sender, RoutedEventArgs e)
        {
            this.VendaViewModel.Adicionar();
        }
    }
}
