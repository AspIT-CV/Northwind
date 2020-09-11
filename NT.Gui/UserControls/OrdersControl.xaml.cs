﻿using NT.DataAccess.Repos;
using NT.ViewModels.ViewModels;

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NT.Gui.UserControls
{
    /// <summary>
    /// Interaction logic for OrdersControl.xaml
    /// </summary>
    public partial class OrdersControl: UserControl
    {
        private readonly OrderViewModel viewModel;

        public OrdersControl()
        {
            InitializeComponent();

            viewModel = DataContext as OrderViewModel;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await viewModel.InitializeAsync();
        }
    }
}