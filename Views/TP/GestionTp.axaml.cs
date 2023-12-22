using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using DynamicData;
using Papply.Models;
using Papply.Storage;
using Papply.ViewModels;

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
        for (int i = 0; i < 5; i++)
        {
            
            var promotion = Promotion.Create();
            promotion.NomPromotion = "classe " + i;
            promotion.TravauxPratiques = new Tp(i.ToString(), "Tp " + i, "description");
            DataStorage.Promotions.AddOrUpdate(promotion);
            
        }
    }
    
}