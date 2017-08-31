using Xamarin.Forms;

namespace CustomLabel.Control
{
    public class CustomLabelControl : Label
    {                
        public static readonly BindableProperty LinesProperty =
            BindableProperty.Create(
                nameof(Lines),
                typeof(int),
                typeof(Label),
                default(int));

        public int Lines
        {
            get { return (int)GetValue(LinesProperty); }
            set { SetValue(LinesProperty, value); }
        }
    }
}
