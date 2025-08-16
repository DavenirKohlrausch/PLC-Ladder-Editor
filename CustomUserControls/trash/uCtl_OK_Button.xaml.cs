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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomUserControls
{
    /// <summary>
    /// Interação lógica para uCtl_OK_Button.xam
    /// </summary>
    /// 



    public enum CUSTOM__Images
        { 
            IMG__OK,
            IMG__CLOSE
        }


    public partial class uCtl_OK_Button : UserControl
    {
         
        public uCtl_OK_Button()
        {
            InitializeComponent();
         

        }
        // Evento de clique (reexpõe o do botão interno)
        public event RoutedEventHandler? Click;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Click?.Invoke(this, e);
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(uCtl_OK_Button), new PropertyMetadata("Btn"));

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly DependencyProperty ImageSourceProperty = DependencyProperty.Register(nameof(ImageSource), typeof(ImageSource), typeof(uCtl_OK_Button), new PropertyMetadata(null));

        public ImageSource ImageSource
        {
            get => (ImageSource)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }
    }
}
