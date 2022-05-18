using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiShell.ViewModels
{
    [INotifyPropertyChanged]
    public partial class MainPageViewModel
    {
        [ObservableProperty]
        private string firstName;

        [ObservableProperty]
        private string counterText;

        [ObservableProperty]
        private int count;

        public MainPageViewModel()
        {
            FirstName = "Ali Raza";
            CounterText = "Click me";
        }

        [ICommand]
        private void OnCounter()
        {
            Count++;

            if (Count == 1)
                CounterText = $"Clicked {count} time";
            else
                CounterText = $"Clicked {count} times";

        }

        [ICommand]
        private void GreetUser(string user)
        {
            Console.WriteLine($"Hello {user}!");
        }
    }
}
