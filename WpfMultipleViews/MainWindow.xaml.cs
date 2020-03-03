using System;
using System.Windows;
using WpfMultipleViews.ViewModels;

namespace WpfMultipleViews
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RedViewModel redModel = new RedViewModel();

        private GreenViewModel greenModel = new GreenViewModel();

        private BlueViewModel blueModel = new BlueViewModel();

        private RandomViewModel randomModel = new RandomViewModel();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = redModel;

            var reader = new ProfileReader();

            var profiles = reader.GetProfiles();
        }

        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            DataContext = redModel;
        }

        private void btnGreen_Click(object sender, RoutedEventArgs e)
        {
            DataContext = greenModel;
        }

        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            DataContext = blueModel;
        }

        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            DataContext = randomModel;
        }

        private void btnInc_Click(object sender, RoutedEventArgs e)
        {
            int inc = 0;
            try
            {
                inc = int.Parse(edtValue.Text);
            }
            catch (Exception)
            {
                inc = 1;
            }
            finally
            {
                ((BaseViewModel)DataContext).IncValue(inc);
            }
        }

        private void btnDec_Click(object sender, RoutedEventArgs e)
        {
            int dec = 0;
            try
            {
                dec = int.Parse(edtValue.Text);
            }
            catch (Exception)
            {
                dec = 1;
            }
            finally
            {
                ((BaseViewModel)DataContext).DecValue(dec);
            }
        }
    }
}
