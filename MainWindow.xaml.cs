using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace Joshua_Gonzales___IST_311___LabControlsReseach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>


    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Set the default selected index
        }


        private void btnToBe_Click(object sender, RoutedEventArgs e)
        {
            imgAsusRog.SetCurrentValue(OpacityProperty, 1.0);

        }

        private void btnNotToBe_Click(object sender, RoutedEventArgs e)
        {
            imgAsusRog.SetCurrentValue(OpacityProperty, 0.0);

        }

        private void btnSmwtToBe_Click(object sender, RoutedEventArgs e)
        {
            imgAsusRog.SetCurrentValue(OpacityProperty,0.5);
        }
    }
}
