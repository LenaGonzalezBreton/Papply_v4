using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Papply.ViewModels;
using PapplyAppli.Classes;

namespace Papply.Models 
{
    public partial class CardControl : UserControl
    {
        public CardControl(int x)
        {
            InitializeComponent();
            if (x == 0)
            {
                TaskViewModel vm = new TaskViewModel();
                DataContext = vm;
            }
            else
            {
                GroupTaskViewModel vm = new GroupTaskViewModel();
                DataContext = vm;
            }
        }

        public CardControl()
        {
            InitializeComponent();
            GroupTaskViewModel vm = new GroupTaskViewModel();
            DataContext = vm;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}