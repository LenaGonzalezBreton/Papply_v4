using Microsoft.VisualBasic;
using Papply.Models;
using Papply.Storage;
using System.Collections.ObjectModel;
using DynamicData;
using System;

namespace Papply.ViewModels
{

    public class CreateTPViewModel : ViewModelBase
    {
        public ObservableCollection<string> ListPromo { get; set; }
        public ObservableCollection<string> Task_Titles { get; set; }
        public Tp newTP { get; }



        public CreateTPViewModel(Models.Tp tp)
        {
            newTP = Tp.Create();
            DataStorage.Tasks.AddOrUpdate(new Task(0,1, "Partie SQL", "Crée le script de BDD", newTP.IdTp));
        }

        public void AddTask()
        {
            var index = new Random();
            Models.Task newTask = new Models.Task(index.Next(0,1000000),1,"Titre","Description",newTP.IdTp);
            DataStorage.Tasks.AddOrUpdate(newTask);
            newTP.test = DateAndTime.Now;

        }
    }
}
