using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WinRT.Interop;



// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace _2603RSP_Win
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private AppWindow m_AppWindow;
        public MainWindow()
        {
            this.InitializeComponent();
            //addressBar.Text = MyWebView.Source.OriginalString;
            ExtendsContentIntoTitleBar = true;//title bar
            m_AppWindow = GetAppWindowForCurrentWindow();
            m_AppWindow.Title = "Ëæ»úÑ¡ÈË£¨PWA£©";
        }
        string str = AppDomain.CurrentDomain.BaseDirectory + "/Assets/rsp.html";
        string readme_str = AppDomain.CurrentDomain.BaseDirectory + "/Assets/rsp-readme.html";

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            MyWebView.Source = MyWebView.Source;
            //addressBar.Text = MyWebView.Source.OriginalString;
        }

        private void local_Click(object sender, RoutedEventArgs e)
        {
            MyWebView.Source = new Uri(str);
            //addressBar.Text = MyWebView.Source.OriginalString;
        }
        private AppWindow GetAppWindowForCurrentWindow()
        {
            IntPtr hWnd = WindowNative.GetWindowHandle(this);
            WindowId wndId = Win32Interop.GetWindowIdFromWindow(hWnd);
            return AppWindow.GetFromWindowId(wndId);
        }

        private void online_Click(object sender, RoutedEventArgs e)
        {
            MyWebView.Source = new Uri("https://xuanxuan1231-class-html.netlify.app/rsp.html");
            //addressBar.Text = MyWebView.Source.OriginalString;
        }

        private void Readme_click(object sender, RoutedEventArgs e)
        {
            MyWebView.Source = new Uri(readme_str);
            //addressBar.Text = MyWebView.Source.OriginalString;
        }

    }
}
