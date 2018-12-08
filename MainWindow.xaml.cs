using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
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

namespace Jacobi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty RProperty = DependencyProperty.Register("R", typeof(int), typeof(MainWindow), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public int R { get { return (int)GetValue(RProperty); } set { SetValue(RProperty, value); } }

        public MainWindow()
        {
            DataContext = this;

            InitializeComponent();
        }

        private void Slider_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            //if(sender == SliderR || sender == IntegerR)
            //    R += e.Delta;
        }
    }

    public class IntToDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)(int)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (int)(double)value;
        }
    }
}
