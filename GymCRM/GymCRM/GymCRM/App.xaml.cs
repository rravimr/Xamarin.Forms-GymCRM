
using CommonServiceLocator;
using GymCRM.Views;
using MediatR;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymCRM
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            App.Current.UserAppTheme = OSAppTheme.Light;
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            ExecuteStartupTasks();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            ExecuteStartupTasks();
        }

        private void ExecuteStartupTasks()
        {
            Task.Run(async () =>
            {
                await StartupTasksAsync();
            }).ConfigureAwait(false);
        }

        private async Task StartupTasksAsync()
        {
            IMediator mediator = ServiceLocator.Current.GetInstance<IMediator>();
        }
     }
}
