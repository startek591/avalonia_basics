using Avalonia.Controls;
using Avalonia.ReactiveUI;
using BasicMvvmSample.ViewModels;
using ReactiveUI;
using System.Reactive.Disposables;


namespace BasicMvvmSample.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
        {
            var viewModel = ViewModel?.ReactiveViewModel;

            if (viewModel != null)
            {
                this.Bind(viewModel, vm => vm.Name, v => v.FirstName.Text).DisposeWith(disposables);
                this.OneWayBind(viewModel, vm => vm.Greeting, v => v.Greeting.Text).DisposeWith(disposables);
            }
        });
    }
}