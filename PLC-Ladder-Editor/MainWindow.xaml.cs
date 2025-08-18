using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
          //  if(btnOK.IsEnabled == true)
         //   btnOK.IsEnabled = false;
         //   else
           //     btnOK.IsEnabled = true;
        }
        //  Image img = new Image
        //  {
        //      Width = 64,
        //       Height = 64,
        //      Source = new BitmapImage(new Uri("pack://application:,,,/CustomUserControls;component/Images/Img_OK.png"))
        //   };
        //imgtest.    //          imgtest. MyPanel.Children.Add(img); // Onde "MyPanel" é um StackPanel no seu XAML




        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        // ... código existente ...

        private void RightReSizeGrip_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle;// Obtém o handle da janela
                SendMessage(hwnd, 0x00A1, (IntPtr)11, IntPtr.Zero); // Envia mensagem para iniciar o redimensionamento pela borda direita
            }
        }

        private void LeftReSizeGrip_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle;// Obtém o handle da janela
                SendMessage(hwnd, 0x00A1, (IntPtr)10, IntPtr.Zero);// Envia mensagem para iniciar o redimensionamento pela borda direita
            }
        }

        private void BottomReSizeGrip_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle;  // Obtém o handle da janela
                SendMessage(hwnd, 0x00A1, (IntPtr)15, IntPtr.Zero); // Envia mensagem para iniciar o redimensionamento pela borda direita
            }
        }

        private void TopReSizeGrip_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle; // Obtém o handle da janela          
                SendMessage(hwnd, 0x00A1, (IntPtr)12, IntPtr.Zero);// Envia mensagem para iniciar o redimensionamento pela borda direita
            }
        }

        private void TopRightReSizeGrip_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Mouse.OverrideCursor = null;
            TopRightSizeGrip.ReleaseMouseCapture();
            // Repita para outros grips se necessário
        }

        private void TopLeftReSizeGrip_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Mouse.OverrideCursor = null;
            TopLeftSizeGrip.ReleaseMouseCapture();
            // Repita para outros grips se necessário
        }

        private void BottomLeftReSizeGrip_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Mouse.OverrideCursor = null;
            BottomLeftSizeGrip.ReleaseMouseCapture();
            // Repita para outros grips se necessário
        }

        private void BottomRightReSizeGrip_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Mouse.OverrideCursor = null;
            BottomRightSizeGrip.ReleaseMouseCapture();
            // Repita para outros grips se necessário
        }
        
        private void TopRightReSizeGrip_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.SizeNESW;
        }

        private void TopLeftReSizeGrip_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.SizeNWSE;
        }       

        private void BottomLeftReSizeGrip_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.SizeNESW;
        }       

        private void BottomRightReSizeGrip_MouseEnter(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.SizeNWSE;
        }

        private void TopRightReSizeGrip_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = null;
        }

        private void TopLeftReSizeGrip_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = null;
        }       

        private void BottomLeftReSizeGrip_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = null;
        }   

        private void BottomRightReSizeGrip_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = null;
        }   

        private void TopRightReSizeGrip_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle; // Obtém o handle da janela          
                SendMessage(hwnd, 0x00A1, (IntPtr)14, IntPtr.Zero);// Envia mensagem para iniciar o redimensionamento pela borda direita
            }
        }

        private void TopLeftReSizeGrip_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle; // Obtém o handle da janela          
                SendMessage(hwnd, 0x00A1, (IntPtr)13, IntPtr.Zero);// Envia mensagem para iniciar o redimensionamento pela borda direita
            }
        }

        private void BottomLeftReSizeGrip_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle; // Obtém o handle da janela          
                SendMessage(hwnd, 0x00A1, (IntPtr)16, IntPtr.Zero);// Envia mensagem para iniciar o redimensionamento pela borda direita
            }
        }

        private void BottomRightReSizeGrip_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                var hwnd = new System.Windows.Interop.WindowInteropHelper(this).Handle; // Obtém o handle da janela          
                SendMessage(hwnd, 0x00A1, (IntPtr)17, IntPtr.Zero);// Envia mensagem para iniciar o redimensionamento pela borda direita
            }
        }
    }
}
