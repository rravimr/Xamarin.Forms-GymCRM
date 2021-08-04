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
    public partial class AddPackagePage
    {
        private AddPackageViewModel ViewModel => (AddPackageViewModel)BindingContext;
        public AddPackagePage()
        {
            InitializeComponent();
            BindingContext = ViewModelLocator.AddPackagesViewModel;
           
            //var cancelItem = new ToolbarItem
            //{
                 
              //  Command = new Command(async () => await Navigation.PopModalAsync()),
            //    Text = "Cancel",
            //    Priority = 1,
            //    Order = ToolbarItemOrder.Primary
            //};

            //var saveItem = new ToolbarItem
            //{
            //    Command = new Command(() => ViewModel.SaveCommand.Execute(null)),
            //    Text = "Save",
            //    Priority = 1,
            //    Order = ToolbarItemOrder.Primary,
                
            //};
            //ToolbarItems.Add(cancelItem);
            //ToolbarItems.Add(saveItem);
        }
    }
}