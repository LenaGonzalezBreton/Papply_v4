using Avalonia.Controls;
using Avalonia;
using Avalonia.Markup.Xaml;
using System;
using Papply.Models;
using Papply.Storage;
using DynamicData;
using Avalonia.Interactivity;

namespace Papply.Views
{
    public partial class DashBoard : UserControl
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        public void Button_Click(object? sender, RoutedEventArgs e)
        {
            Promotion ptoadd = Promotion.Create();
            DataStorage.Promotions.AddOrUpdate(ptoadd);
        }
    }
}
