using ReactiveUI;

namespace BasicMvvmSample.ViewModels;

public class MainWindowViewModel : ViewModelBase, IActivatableViewModel
{
    public ViewModelActivator Activator { get; }
    public MainWindowViewModel()
    {
        Activator = new ViewModelActivator();
    }
    public ReactiveViewModel ReactiveViewModel { get; } = new ReactiveViewModel();
}
