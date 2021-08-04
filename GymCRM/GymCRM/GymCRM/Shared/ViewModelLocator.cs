using Autofac;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GymCRM.ViewModels;
using GymCRM.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymCRM.Shared
{
    public class ViewModelLocator
    {

        static ViewModelLocator()
        {
            if (!ServiceLocator.IsLocationProviderSet && ViewModelBase.IsInDesignModeStatic)
            {
                RegisterServices(new ContainerBuilder());
            }

        }

        public static void RegisterServices(ContainerBuilder registrations)
        {
            IContainer container = registrations.Build();

            if (container != null)
            { 
                ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(container));
            }
        }

        public static string PackageRoute => nameof(PackagePage);

        public static string AddPackageRoute => nameof(AddPackagePage);

        public static string ModifyPackageRoute => nameof(ModifyPackagePage);

        public static PackageViewModel PackagesViewModel => ServiceLocator.Current.GetInstance<PackageViewModel>();

        public static AddPackageViewModel AddPackagesViewModel => ServiceLocator.Current.GetInstance<AddPackageViewModel>();

       // public static ModifyPackageViewModel ModifyPackagesViewModel => ServiceLocator.Current.GetInstance<ModifyPackageViewModel>();
    }
}
