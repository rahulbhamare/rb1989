using Xamarin.Forms;
using CustomLabel.Control;
using CustomLabel.Droid.Renderer;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomLabelControl), typeof(CustomLabelRenderer))]
namespace CustomLabel.Droid.Renderer
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            var baseLabel = (CustomLabelControl)this.Element;
            Control.SetLines(baseLabel.Lines);
        }
    }
}