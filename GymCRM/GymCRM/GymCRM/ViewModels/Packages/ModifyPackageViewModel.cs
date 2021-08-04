using AutoMapper;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GymCRM.Core.Application.Common.Interfaces;
using GymCRM.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GymCRM.ViewModels
{
    public abstract class ModifyPackageViewModel : ViewModelBase
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;
        private readonly IDialogService dialogService;
        public ModifyPackageViewModel(IMediator mediator, IDialogService dialogService)
        {
            this.mediator = mediator;
            this.mapper = mapper;
            this.dialogService = dialogService;
        }

        private SelectedPackageViewModel selectedPackage = new SelectedPackageViewModel();

        public SelectedPackageViewModel SelectedPackage
        {
            get => selectedPackage;
            set
            {
                selectedPackage = value;
                RaisePropertyChanged();
            }
        }

        protected abstract Task SavePackageAsync();

        public RelayCommand SaveCommand => new RelayCommand(async () => await SavePackageBaseAsync());

        public RelayCommand CancelCommand => new RelayCommand(async () => await App.Current.MainPage.Navigation.PopModalAsync());
        protected virtual async Task SavePackageBaseAsync()
        {
            if (string.IsNullOrEmpty(SelectedPackage.Name))
            {
                await dialogService.ShowMessageAsync("Mandatory field", "Please insert a name.");
                return;
            }

            await SavePackageAsync();
        }
    }
}
