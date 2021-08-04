
using GymCRM.Shared;
using GymCRM.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GymCRM
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        private static void RegisterRoutes()
        {
            Routing.RegisterRoute(ViewModelLocator.PackageRoute, typeof(PackagePage));
            Routing.RegisterRoute(ViewModelLocator.AddPackageRoute, typeof(AddPackagePage));
            Routing.RegisterRoute(ViewModelLocator.ModifyPackageRoute, typeof(ModifyPackagePage));
        }
    }
}
