using GymCRM.Core.Interfaces;
using GymCRM.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GymCRM.Core.Services
{
    public class DialogService : IDialogService
    {
        public async Task ShowMessageAsync(string title, string message)
        {
            var messageDialog = new MessageDialog(title, message);
            await messageDialog.ShowAsync();
        }
    }
}