using SimpleToDo.Service;

namespace SimpleToDo.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel(Database db)
    {
        List = new ToDoListViewModel(db.GetItems());
    }
    
    public ToDoListViewModel List { get; }
}