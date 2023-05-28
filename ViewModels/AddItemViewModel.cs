using System.Reactive;
using ReactiveUI;
using SimpleToDo.Models;

namespace SimpleToDo.ViewModels;

public class AddItemViewModel : ViewModelBase
{
    private string? _description;

    public AddItemViewModel()
    {
        var okEnabled = this.WhenAnyValue(
            vm => vm.Description,
            description => !string.IsNullOrEmpty(description));

        OkCommand = ReactiveCommand.Create(
            () => new ToDoItem { Description = Description! },
            okEnabled);
        CancelCommand = ReactiveCommand.Create(() => { });
    }

    public ReactiveCommand<Unit, ToDoItem> OkCommand { get; }
    public ReactiveCommand<Unit, Unit> CancelCommand { get; }

    public string? Description
    {
        get => _description;
        set => this.RaiseAndSetIfChanged(ref _description, value);
    }
}