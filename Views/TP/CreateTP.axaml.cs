using Avalonia.Controls;
using Avalonia.Interactivity;
using Papply.ViewModels;
using Papply.Models;

namespace Papply.Views.TP
{
    public partial class CreateTP : UserControl
    {
        Papply.Models.TP TPInstance { get; set; }

        public CreateTP()
        {
            InitializeComponent();
            TPInstance = new Papply.Models.TP(1, "");
            CreateTPViewModel vm = new CreateTPViewModel(TPInstance);
            DataContext = vm;
        }
    }
}
