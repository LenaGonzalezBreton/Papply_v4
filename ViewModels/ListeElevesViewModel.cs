using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Papply.Views;

namespace Papply.ViewModels;

public class ListeElevesViewModel : ViewModelBase
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        // Autres propriétés d'un étudiant
    }
    ObservableCollection<Student> students = new ObservableCollection<Student>
    {
        new Student { Name = "GOGO", Surname = "Alice" },
        new Student { Name = "GIGI", Surname = "Bob" },
        // Ajoutez d'autres étudiants ici
    };
    
}