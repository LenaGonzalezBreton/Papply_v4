using Avalonia.Controls;
using Avalonia.Rendering;
using Papply.Models;
using PapplyAppli.Classes;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Papply.ViewModels
{
    public class CreateTPViewModel : ViewModelBase
    {

        public ObservableCollection<Task> Tasks { get; set; }
        public Degree TP { get; }

        


        

        public CreateTPViewModel(Degree tp)
        {
            TP = tp;
            Tasks = new ObservableCollection<Task>();
            Tasks.Add(new Task(1, "Partie SQL", "Crée le script de BDD"));
        }

        public void AddTask()
        {
            var newTask = new Task();
            Tasks.Add(newTask);
        }
    }
}
