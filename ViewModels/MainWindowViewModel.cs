using Avalonia.Interactivity;
using ReactiveUI;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;

namespace Papply.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _greeting = "Welcome to Avalonia!";
    public string Greeting
    {
        get => _greeting;
        set => this.RaiseAndSetIfChanged(ref _greeting, value);
    }
    public ICommand MarkAsDoneCommand { get; set; }

    public MainWindowViewModel()
    {
        MarkAsDoneCommand = ReactiveCommand.Create(MarkAsDone);
    }

    void MarkAsDone()
    {
        Random random = new Random();
        int x = random.Next(1,100);
        if(x < 50)
        {
            this.Greeting = "Sauvez Willy " + x.ToString();
        }
        else
        {
            this.Greeting = "Tuez Willy " + x.ToString();
        }
    }
}