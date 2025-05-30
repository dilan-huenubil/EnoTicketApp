using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using EnoTicket_App.Vistas;


namespace EnoTicket_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }
    }
}
