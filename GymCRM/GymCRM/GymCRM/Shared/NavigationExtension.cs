using NLog;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GymCRM.Shared
{
    public static class NavigationExtension
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public static Task GoToModalAsync(this Shell shell, string route)
        {
            try
            {
                if (!(Routing.GetOrCreateContent(route) is Page page))
                {
                    return Task.CompletedTask;
                }

                return shell.Navigation.PushModalAsync(new NavigationPage(page)
                {
                    BarBackgroundColor = Color.Transparent
                });
            }
            catch (Exception ex)
            {
                var exception = new Exception($"Navigation to route {route} failed. ", ex);
                logger.Error(exception);
                throw exception;
            }
        }
    }
}
