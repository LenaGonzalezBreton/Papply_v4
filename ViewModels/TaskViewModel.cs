using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Papply.ViewModels
{
    internal class TaskViewModel
    {
        public TaskViewModel() { }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Papply.Models.Task task;

        public Papply.Models.Task _Task
        {
            get
            {
                return task;
            }
            set
            {
                task = value;
                OnPropertyChanged();
            }
        }
    }

}
