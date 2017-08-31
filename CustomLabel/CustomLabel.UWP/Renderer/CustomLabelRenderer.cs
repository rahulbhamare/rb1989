using CustomLabel.Control;
using CustomLabel.UWP.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomLabelControl), typeof(CustomLabelRenderer))]
namespace CustomLabel.UWP.Renderer
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            var baseLabel = (CustomLabelControl)this.Element;
            Control.TextWrapping = Windows.UI.Xaml.TextWrapping.WrapWholeWords;
            Control.MaxLines = baseLabel.Lines;
        }
    }
}
