using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HealthSafetyApp.Controls
{
    public class CustomCheckbox : View
    {
#pragma warning disable CS0618 // Type or member is obsolete
        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create<CustomCheckbox, bool>(p => p.IsChecked, true, propertyChanged: (s, o, n) => { (s as CustomCheckbox).OnChecked(new EventArgs()); });

        internal void OnChecked(EventArgs eventArgs)
        {
            if (Checked != null)
                Checked(this, eventArgs);
        }
#pragma warning restore CS0618 // Type or member is obsolete
#pragma warning disable CS0618 // Type or member is obsolete
        public static readonly BindableProperty ColorProperty = BindableProperty.Create<CustomCheckbox, Color>(p => p.Color, Color.Default);
#pragma warning restore CS0618 // Type or member is obsolete
        public static readonly BindableProperty NameProperty = BindableProperty.Create("Name", typeof(string), typeof(Label), "");
        public static readonly BindableProperty IdProperty = BindableProperty.Create("Id", typeof(string), typeof(Label), "");
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
        public string Id
        {
            get { return (string)GetValue(IdProperty); }
            set { SetValue(IdProperty, value); }
        }
        public bool IsChecked
        {
            get
            {
                return (bool)GetValue(IsCheckedProperty);
            }
            set
            {
                SetValue(IsCheckedProperty, value);
            }
        }

        public Color Color
        {
            get
            {
                return (Color)GetValue(ColorProperty);
            }
            set
            {
                SetValue(ColorProperty, value);
            }
        }

        public event EventHandler Checked;
       
    }
}
