using DynamicData;
using Papply.Storage;
using Papply.Models;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;

namespace Papply.ViewModels;

public class ViewModelBase{

    private readonly ReadOnlyObservableCollection<Degree> _degrees;
    public ReadOnlyObservableCollection<Degree> Degrees => _degrees;

    public ViewModelBase()
    {
        DataStorage.Degrees
            .Connect()
            .Bind(out _degrees)
            .Subscribe();
    }
}