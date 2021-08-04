using GymCRM.Shared;
using GymCRM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GymCRM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PackagePage : ContentPage
    {
        private PackageViewModel ViewModel => (PackageViewModel)BindingContext;
        public PackagePage()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.PackagesViewModel;
        }

        protected override async void OnAppearing()
        {
            ViewModel.Subscribe();
            await ViewModel.InitializeAsync();
        }

        protected override void OnDisappearing() => ViewModel.Unsubscribe();
    }
}