using System.Collections.Generic;
using SimpleToDo.Models;

namespace SimpleToDo.Service;

public class Database
{
    public IEnumerable<ToDoItem> GetItems() => new[]
    {
        new ToDoItem { Description = "Walk the dog" },
        new ToDoItem { Description = "Buy some milk" },
        new ToDoItem { Description = "Learn Avalonia", IsChecked = true }
    };
}