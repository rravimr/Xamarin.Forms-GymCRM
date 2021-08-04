using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GymCRM.Droid.Renderer;
using GymCRM.Shared.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ModalContentPage), typeof(ModalContentPageRenderer))]
namespace GymCRM.Droid.Renderer
{
    public class ModalContentPageRenderer : PageRenderer
    {
        public ModalContentPageRenderer(Context context) : base(context)
        {
        }
    }
}