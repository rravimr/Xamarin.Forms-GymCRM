using Acr.UserDialogs;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Autofac;
using GymCRM.Core;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GymCRM.Presentation;

namespace GymCRM.Droid
{
    public class AndroidModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => UserDialogs.Instance).As<IUserDialogs>();
            builder.RegisterInstance(GalaSoft.MvvmLight.Messaging.Messenger.Default).AsImplementedInterfaces();


            builder.RegisterModule<GymCRMModule>();
        }
    }
}