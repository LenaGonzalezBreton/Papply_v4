using Avalonia.Controls;
using Avalonia.Interactivity;
using Papply.ViewModels;
using Papply.Models;

namespace Papply.Views.TP
{
    public partial class CreateTP : UserControl
    {
        private Models.Tp TPInstance { get; set; }

        public CreateTP()
        {
            InitializeComponent();
            TPInstance = Tp.Create();
            CreateTPViewModel vm = new CreateTPViewModel(TPInstance);
            DataContext = vm;
        }
    }
}
