using AutoMapper;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GymCRM.Core.Application.Common.Interfaces;
using GymCRM.Core.Domain.Commands;
using GymCRM.Shared;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GymCRM.ViewModels
{
    public class AddPackageViewModel : ModifyPackageViewModel
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;
        private readonly IDialogService dialogService;
        public AddPackageViewModel(IMediator mediator, IDialogService dialogService) : base(mediator, dialogService)
        {
            this.mediator = mediator;
            this.mapper = mapper;
            this.dialogService = dialogService;
        }

        protected override async Task SavePackageAsync()
    => await mediator.Send(new CreatePackageCommand(SelectedPackage.Name, SelectedPackage.Months, SelectedPackage.Amount));
    }
}
