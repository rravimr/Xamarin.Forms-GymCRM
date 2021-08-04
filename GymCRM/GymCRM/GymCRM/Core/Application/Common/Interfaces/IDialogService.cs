using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GymCRM.Core.Application.Common.Interfaces
{
    public interface IDialogService
    {
        Task ShowMessageAsync(string title, string message);

        //Task<bool> ShowConfirmMessageAsync(string title,
        //                                   string message,
        //                                   string positiveButtonText = null,
        //                                   string negativeButtonText = null);

        //Task ShowLoadingDialogAsync(string message = null);

        //Task HideLoadingDialogAsync();
    }
}
