using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NotesApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// 
    /// Missing so far:
    //// 1. Change note name
    //// 2. Delete notebooks and notes
    /// </summary>
    public partial class App : Application
    {
        public static string UserId = string.Empty;
        public static MobileServiceClient MobileServiceClient = new MobileServiceClient("https://evernoteclone.azurewebsites.net");
    }
}
