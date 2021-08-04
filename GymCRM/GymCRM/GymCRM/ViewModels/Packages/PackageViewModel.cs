using AutoMapper;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GymCRM.Core.Application.Common.Interfaces;
using GymCRM.Core.Application.Common.Messages;
using GymCRM.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GymCRM.ViewModels
{
    public class PackageViewModel : ViewModelBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;
        private readonly IDialogService dialogService;
        private bool isRunning;
        public PackageViewModel(IMediator mediator, IDialogService dialogService)
        {
            this.mediator = mediator;
            this.mapper = mapper;
            this.dialogService = dialogService;
        }

        public RelayCommand GoToAddCategoryCommand => new RelayCommand(async () => await Shell.Current.GoToModalAsync(ViewModelLocator.AddPackageRoute));

        public void Subscribe() => MessengerInstance.Register<ReloadMessage>(this, async (m) => await InitializeAsync());

        public void Unsubscribe() => MessengerInstance.Unregister<ReloadMessage>(this);

        public async Task InitializeAsync()
        {
            if (isRunning)
            {
                return;
            }

            try
            {
                isRunning = true;
            }
            finally
            {
                isRunning = false;
            }
        }
    }
}
