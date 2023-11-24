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

    private readonly ReadOnlyObservableCollection<Task> _tasks;
    public ReadOnlyObservableCollection<Task> Tasks => _tasks;

    public ViewModelBase()
    {
        DataStorage.Degrees
            .Connect()
            .Bind(out _degrees)
            .Subscribe();


        DataStorage.Tasks
            .Connect()
            .Bind(out _tasks)
            .Subscribe();
    }
}