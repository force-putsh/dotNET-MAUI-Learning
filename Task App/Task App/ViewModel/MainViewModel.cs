using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Task_App.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<string> items;

    public MainViewModel()
    {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    string _text;

    [RelayCommand]
    void AddTask()
    {
        if (string.IsNullOrWhiteSpace(Text))
            return;
        Items.Add(Text);
        //Add the text to the list
        Text = String.Empty;
    }

    [RelayCommand]
    void RemoveTask(string item)
    {
        if (Items.Contains(item))
            Items.Remove(item);
    }
}
