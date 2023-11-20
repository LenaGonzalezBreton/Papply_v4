using Papply.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Papply.Models
{
    public class Task : ViewModelBase
    {
        private double _pointtask;
        public double PointTask {  
            get=>_pointtask;
            set
            {
                _pointtask = value;
                OnPropertyChanged();
            }
        }

        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private string _description;
        public string Description {  
            get=>_description; 
            set {
                _description=value;
                OnPropertyChanged();
            } 
        }

        public Task()
        {
            PointTask = 0;
            Title = "Titre Sous Partie";
            Description = "Description Sous Partie";
        }

        public Task(double pointTask, string title, string description)
        {
            PointTask = pointTask;
            Title = title;
            Description = description;
        }
    }
}
