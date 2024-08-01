using Avalonia.Controls;
using Avalonia.ReactiveUI;
using AvaloniaApplicaton.ViewModels;
using ReactiveUI;
using System;

namespace AvaloniaApplicaton.Views;

public partial class MainView : ReactiveUserControl<MainViewModel>
{
    public MainView()
    {
        InitializeComponent();
        this.WhenActivated(disposables =>
        {
            this.OneWayBind(this.ViewModel, vm => vm.TextBlockName, v => v.TextBlockName.Text);
            this.BindCommand(this.ViewModel, vm => vm.ButtonOnClickCommand, v => v.Button);
        });
    }
}