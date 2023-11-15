using Papply.ViewModels;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Papply.Models
{
    public class Task : ViewModelBase
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private double _pointtask;
        public double PointTask
        {
            get { return _pointtask; }
            set
            {
                if (_pointtask != value)
                {
                    _pointtask = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _desc;
        public string Description
        {
            get { return _desc; }
            set
            {
                if (_desc != value)
                {
                    _desc = value;
                    OnPropertyChanged();
                }
            }
        }

        public CardControl card { get; set; }

        public Task()
        {
            PointTask = 0;
            Title = "Titre";
            Description = string.Empty;
            card = new CardControl(0);
        }
    }
}
