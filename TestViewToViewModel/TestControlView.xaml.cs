using Catel.MVVM.Views;
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
using catelC = Catel.Windows.Controls;
namespace TestViewToViewModel
{
    /// <summary>
    /// Interaction logic for TestControlView.xaml
    /// </summary>
    public partial class TestControlView : catelC.UserControl
    {
        public TestControlView()
        {
            InitializeComponent();
        }



        [ViewToViewModel]
        public TestModel SomeModelProperty
        {
            get { return (TestModel)GetValue(SomeModelPropertyProperty); }
            set { SetValue(SomeModelPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SomeModelProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SomeModelPropertyProperty =
            DependencyProperty.Register("SomeModelProperty", typeof(TestModel), typeof(TestControlView), new PropertyMetadata(null,OnTestModelPropertyChanged));

        private static void OnTestModelPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Console.WriteLine($"View PropertyChanged, New Value : {e.NewValue}, Old Value : {e.OldValue}, Prop. Name : {e.Property.Name}");
        }
    }
}
