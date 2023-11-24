using Avalonia.Controls;
using Avalonia.Interactivity;
using Papply.ViewModels;
using Papply.Models;

namespace Papply.Views.TP
{
    public partial class CreateTP : UserControl
    {
        Papply.Models.Degree DegreeInstance { get; set; }

        public CreateTP()
        {
            InitializeComponent();
            DegreeInstance = new Papply.Models.Degree(1, "");
            CreateTPViewModel vm = new CreateTPViewModel(DegreeInstance);
            DataContext = vm;
        }
    }
}
