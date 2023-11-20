using Papply.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Papply.Models
{
    public class Task
    {
        public double PointTask {  get; set; }

        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
            }
        }

        public string Description {  get; set; }

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
