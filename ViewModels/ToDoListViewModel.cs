using System.Collections.Generic;
using System.Collections.ObjectModel;
using SimpleToDo.Models;

namespace SimpleToDo.ViewModels;

public class ToDoListViewModel : ViewModelBase
{
    public ToDoListViewModel(IEnumerable<ToDoItem> items)
    {
        Items = new ObservableCollection<ToDoItem>(items);
    }
    
    public ObservableCollection<ToDoItem> Items { get; }
}