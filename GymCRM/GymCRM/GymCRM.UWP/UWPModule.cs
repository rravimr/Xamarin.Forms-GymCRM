using Acr.UserDialogs;
using Autofac;
using GalaSoft.MvvmLight.Messaging;
using GymCRM.Core;
using GymCRM.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymCRM.UWP
{
    public class UWPModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => UserDialogs.Instance).As<IUserDialogs>();
            builder.RegisterInstance(Messenger.Default).AsImplementedInterfaces();

            builder.RegisterModule<GymCRMModule>();
        }
    }
}
