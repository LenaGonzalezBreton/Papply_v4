using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using DynamicData;
using Papply.Models;
using Papply.Storage;

namespace Papply.Views.TP;

public partial class GestionTp : UserControl
{
    public GestionTp()
    {
        InitializeComponent();
    }

    //private void AddPromo(object? sender, RoutedEventArgs e)
    //{
    //
    //}
    private void AddPromo(object? sender, RoutedEventArgs e)
    {
        var promotion = Promotion.Create();
        promotion.NomPromotion = "wesh";
        DataStorage.Promotions.AddOrUpdate(promotion);
        //throw new System.NotImplementedException();
    }
    
}