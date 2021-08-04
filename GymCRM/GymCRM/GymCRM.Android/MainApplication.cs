using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Autofac;
using GymCRM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymCRM.Droid
{
    [Application]
    public class MainApplication : Android.App.Application
    {
        public MainApplication(IntPtr handle, JniHandleOwnership transer) : base(handle, transer)
        {
        }

        public override void OnCreate()
        {

            RegisterServices();
            base.OnCreate();
        }

        private void RegisterServices()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule<AndroidModule>();

            ViewModelLocator.RegisterServices(builder);
        }

    }

}