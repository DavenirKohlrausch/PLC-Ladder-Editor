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

namespace PLC_Ladder_Editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UserControl1_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(btnOK.IsEnabled == true)
            btnOK.IsEnabled = false;
            else
                btnOK.IsEnabled = true;
        }
        //  Image img = new Image
        //  {
        //      Width = 64,
        //       Height = 64,
        //      Source = new BitmapImage(new Uri("pack://application:,,,/CustomUserControls;component/Images/Img_OK.png"))
        //   };
        //imgtest.    //          imgtest. MyPanel.Children.Add(img); // Onde "MyPanel" é um StackPanel no seu XAML
    }
}
