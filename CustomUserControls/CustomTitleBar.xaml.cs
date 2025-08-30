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

namespace CustomUserControls
{
    /// <summary>
    /// Interação lógica para CustomTitleBar.xam
    /// </summary>
    public partial class CustomTitleBar : UserControl
    {
        public CustomTitleBar()
        {
            InitializeComponent();
        }
        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }
        private void Maximze_Click(object sender, RoutedEventArgs e)
        {
            if(Window.GetWindow(this).WindowState == WindowState.Maximized)
            {
                Window.GetWindow(this).WindowState = WindowState.Normal;
            }
            else
            {
                Window.GetWindow(this).WindowState = WindowState.Maximized;
            }

            
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this)?.Close();
        }
        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                Window.GetWindow(this)?.DragMove();
        }

        public void SetTitle(string title)
        {
            TitleTextBlock.Text = title;
        }

        public Color TitleBarColor
        {
            get 
            { 
                return ((SolidColorBrush)TitleBorder.Background).Color; 
            }
            set 
            { 
                BtnClose.Background = new SolidColorBrush(value);
                BtnRestaureMaximize.Background = new SolidColorBrush(value);
                BtnMinimize.Background = new SolidColorBrush(value);
                TitleBorder.Background = new SolidColorBrush(value); 
            }
        }

    }
}
