using System;
using System.Net.Http;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Sinsegye.DeviceManager.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";


    [ObservableProperty] private string _result;
}