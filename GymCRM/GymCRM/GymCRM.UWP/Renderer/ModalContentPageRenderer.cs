using GymCRM.Shared.Controls;
using GymCRM.UWP.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(ModalContentPage), typeof(ModalContentPageRenderer))]
namespace GymCRM.UWP.Renderer
{
    public class ModalContentPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Page> e)
        {
            base.OnElementChanged(e);
        }

    }
}
