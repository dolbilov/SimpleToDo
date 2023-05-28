using System;

namespace SimpleToDo.ViewModels;

public class AddItemViewModel : ViewModelBase
{
    public string Description { get; set; } = string.Empty;
}