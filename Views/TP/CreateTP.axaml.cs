using Avalonia.Controls;
using Avalonia.Interactivity;
using Papply.ViewModels;
using Papply.Models;

namespace Papply.Views.TP
{
    public partial class CreateTP : UserControl
    {
        Papply.Models.Tp TPInstance { get; set; }

        public CreateTP()
        {
            InitializeComponent();
            TPInstance = new Papply.Models.Tp(1, "");
            CreateTPViewModel vm = new CreateTPViewModel(TpInstance);
            DataContext = vm;
        }
    }
}
