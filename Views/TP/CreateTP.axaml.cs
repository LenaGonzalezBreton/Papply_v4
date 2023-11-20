using Avalonia.Controls;
using Avalonia.Interactivity;
using Papply.ViewModels;

namespace Papply.Views.TP
{
    public partial class CreateTP : UserControl
    {
        PapplyAppli.Classes.Degree DegreeInstance { get; set; }

        public CreateTP()
        {
            InitializeComponent();
            DegreeInstance = new PapplyAppli.Classes.Degree(1, "");
            CreateTPViewModel vm = new CreateTPViewModel(DegreeInstance);
            DataContext = vm;
        }
    }
}
