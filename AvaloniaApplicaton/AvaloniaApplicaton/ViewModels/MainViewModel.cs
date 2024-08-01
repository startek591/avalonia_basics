using ReactiveUI;
using System.Reactive;
using System.Windows.Input;
using System.Reactive.Disposables;

namespace AvaloniaApplicaton.ViewModels;

public class MainViewModel : ViewModelBase, IActivatableViewModel
{
    public ViewModelActivator Activator { get; }
    private string? _textBlockName = "Welcome to MammaMiaDev";

    public MainViewModel()
    {
        Activator = new ViewModelActivator();
        ButtonOnClickCommand = ReactiveCommand.Create(ButtonOnClick);
    }

    public string? TextBlockName
    {
        get => _textBlockName;
        set
        {
            this.RaiseAndSetIfChanged(ref _textBlockName, value);
        }
    }

    public ICommand ButtonOnClickCommand { get; }

    private void ButtonOnClick()
    {
        TextBlockName = "CLICKED";
    }

}
