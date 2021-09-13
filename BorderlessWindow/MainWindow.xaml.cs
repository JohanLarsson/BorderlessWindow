namespace BorderlessWindow
{
    using System.Windows;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void OnClickMinimize(object sender, RoutedEventArgs e) => this.SetCurrentValue(WindowStateProperty, WindowState.Minimized);

        private void OnClickMaximizeRestore(object sender, RoutedEventArgs e) => this.SetCurrentValue(WindowStateProperty, this.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized);

        private void OnClickClose(object sender, RoutedEventArgs e) => this.Close();
    }
}
