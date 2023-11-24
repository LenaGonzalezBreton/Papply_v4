using DynamicData;
using Microsoft.VisualBasic;
using Papply.Models;
using Papply.Storage;
using System.Collections.ObjectModel;

namespace Papply.ViewModels
{

    public class CreateTPViewModel : ViewModelBase
    {
        public ObservableCollection<string> ListPromo { get; set; }
        public ObservableCollection<string> Task_Titles { get; set; }
        public Degree newTP { get; }


        public CreateTPViewModel(Models.Degree tp)
        {
            newTP = new Degree();
            DataStorage.Tasks.AddOrUpdate(new Task(1, "Partie SQL", "Crée le script de BDD",newTP.IDDegree));
        }

        public void AddTask()
        {
            Models.Task newTask = new Models.Task();
            DataStorage.Tasks.AddOrUpdate(newTask);
            newTP.test = DateAndTime.Now;
        }
    }
}
