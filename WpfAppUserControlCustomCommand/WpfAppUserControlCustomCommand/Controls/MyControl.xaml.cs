using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppUserControlCustomCommand.Controls
{
    /// <summary>
    /// MyControl.xaml 的交互逻辑
    /// </summary>
    public partial class MyControl : UserControl
    {
        public MyControl()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty BtnClickCommandProperty = DependencyProperty.Register(
            "BtnClickCommand",
            typeof(ICommand),
            typeof(MyControl),
            new UIPropertyMetadata(default(ICommand)));

        public ICommand BtnClickCommand
        {
            get
            {
                return (ICommand)GetValue(BtnClickCommandProperty);
            }
            set
            {
                SetValue(BtnClickCommandProperty, value);
            }
        }

        public static readonly DependencyProperty TempValueProperty = DependencyProperty.Register("TempValue", typeof(double), typeof(MyControl), new PropertyMetadata(default(double)));

        public double TempValue
        {
            get
            {
                return (double)GetValue(TempValueProperty);
            }
            set
            {
                SetValue(TempValueProperty, value);
            }
        }

        public static readonly DependencyProperty TempSetValueProperty = DependencyProperty.Register("TempSetValue", typeof(double), typeof(MyControl), new PropertyMetadata(default(double)));

        public double TempSetValue
        {
            get
            {
                return (double)GetValue(TempSetValueProperty);
            }
            set
            {
                SetValue(TempSetValueProperty, value);
            }
        }
    }
}
