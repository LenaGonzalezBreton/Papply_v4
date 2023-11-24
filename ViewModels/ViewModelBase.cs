using DynamicData;
using Papply.Storage;
using Papply.Models;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;

namespace Papply.ViewModels;

public class ViewModelBase{

    private readonly ReadOnlyObservableCollection<Tp> _tps;
    public ReadOnlyObservableCollection<Tp> Tps => _tps;

    private readonly ReadOnlyObservableCollection<Task> _tasks;
    public ReadOnlyObservableCollection<Task> Tasks => _tasks;

    private readonly ReadOnlyObservableCollection<Student> _students;
    public ReadOnlyObservableCollection<Student> Students => _students;

    private readonly ReadOnlyObservableCollection<Promotion> _promotions;
    public ReadOnlyObservableCollection<Promotion> Promotions => _promotions;

    public ViewModelBase()
    {
        DataStorage.TPS
            .Connect()
            .Bind(out _tps)
            .Subscribe();

        DataStorage.Tasks
            .Connect()
            .Bind(out _tasks)
            .Subscribe();

        DataStorage.Students
            .Connect()
            .Bind(out _students)
            .Subscribe();

        DataStorage.Promotions
            .Connect()
            .Bind(out _promotions)
            .Subscribe();
    }
}