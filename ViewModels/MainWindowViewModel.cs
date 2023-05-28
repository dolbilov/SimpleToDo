using System.Reactive.Linq;
using ReactiveUI;
using System;
using SimpleToDo.Models;
using SimpleToDo.Service;

namespace SimpleToDo.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase? _content;

    public MainWindowViewModel(Database db)
    {
        Content = List = new ToDoListViewModel(db.GetItems());
    }

    public ViewModelBase? Content
    {
        get => _content;
        set => this.RaiseAndSetIfChanged(ref _content, value);
    }

    public ToDoListViewModel List { get; }

    public void AddItem()
    {
        var vm = new AddItemViewModel();
        Observable.Merge(
                vm.OkCommand,
                vm.CancelCommand.Select(_ => null as ToDoItem))
            .Take(1)
            .Subscribe(model =>
            {
                if (model is not null)
                    List.Items.Add(model);

                Content = List;
            });

        Content = vm;
    }
}