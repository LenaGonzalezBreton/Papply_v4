using Papply.Models;
using PapplyAppli.Classes;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Task = Papply.Models.Task;

namespace Papply.ViewModels
{
    public class CreateTPViewModel
    {
        public ObservableCollection<GroupTask> GroupTasks { get; set; }
        public ObservableCollection<CardControl> PartCards { get; set; }

        public ObservableCollection<CardControl> SPartCards {  get; set; }

        public int index = 0;

        public CreateTPViewModel(Degree TP)
        {
            GroupTasks = new ObservableCollection<GroupTask>(TP._gtaskList);
            PartCards = new ObservableCollection<CardControl>();
            SPartCards = new ObservableCollection<CardControl>();
            foreach(GroupTask g in TP._gtaskList)
            {
                PartCards.Add(g._partcard);
                foreach(Task t in g._listtask)
                {
                    SPartCards.Add(t.card);
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private GroupTask selectedPart;
        public GroupTask SelectedPart { 
            get {
                return GroupTasks[index]; 
            } 
            set {
                selectedPart = value;
                OnPropertyChanged();
            }
        }
    }
}
