using Microsoft.VisualBasic;
using Papply.Models;
using Papply.Storage;
using System.Collections.ObjectModel;
using DynamicData;
using System;
using System.Reactive.Concurrency;

namespace Papply.ViewModels
{

    public class CreateTPViewModel : ViewModelBase
    {
        public ObservableCollection<string> ListPromo { get; set; }
        //public ObservableCollection<string> Task_Titles { get; set; }
        public Tp newTP { get; }



        public CreateTPViewModel()
        {
            newTP = Tp.Create();
            string guid = Guid.NewGuid().ToString();
            DataStorage.Tasks.AddOrUpdate(new Task(guid,1, "Partie SQL", "Crée le script de BDD", newTP.IdTp));
        }

        public void AddTask()
        {
            var newTask = Models.Task.Create();
            newTask.IdTp = newTP.IdTp;
            DataStorage.Tasks.AddOrUpdate(newTask);

            newTP.test = DateAndTime.Now;
        }
    }
}
