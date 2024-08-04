using Avalonia.Controls;
using Avalonia.ReactiveUI;
using CommandSample.ViewModels;
using ReactiveUI;
using System.Reactive.Disposables;


namespace CommandSample.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();

        this.WhenActivated(disposables =>
       {
           var viewModel = ViewModel;

           if (viewModel != null)
           {
               this.BindCommand(viewModel, vm => vm.OpenThePodBayDoorsDirectCommand, v => v.OpenThePodBayDoorBtn).DisposeWith(disposables);
               this.Bind(viewModel, vm => vm.RobotName, v => v.RobotName.Text).DisposeWith(disposables);
               this.BindCommand(viewModel, vm => vm.OpenThePodBayDoorsFellowRobotCommand, v => v.OpenThePodBayDoorFellowRobotBtn).DisposeWith(disposables);
               this.BindCommand(viewModel, vm => vm.OpenThePodBayDoorsAsyncCommand, v => v.OpenThePodBayDoorAsyncBtn).DisposeWith(disposables);
               this.OneWayBind(viewModel, vm => vm.ConversationLog, v => v.ConversationLog.ItemsSource).DisposeWith(disposables);
           }
       });
    }
}