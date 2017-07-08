using System.Windows;
using IPrompt;

namespace IPromptTest
{
    public partial class wndMain : Window
    {
        public wndMain()
        {
            InitializeComponent();
        }

        private void btnIMessageBox_Click(object sender, RoutedEventArgs e)
        {
            tblckResponse.Text = IMessageBox.Show("Optional messagebox text", "Optional IMessageBox Title", MessageBoxButton.OKCancel, MessageBoxImage.Information, this).ToString();
        }

        private void btnIInputBox_Click(object sender, RoutedEventArgs e)
        {
            tblckResponse.Text = IInputBox.Show("Optional IInputBox text", "IInputBox Title", MessageBoxImage.Question, "default response").ToString();
        }

        private void btnIPasswordBox_Click(object sender, RoutedEventArgs e)
        {
            tblckResponse.Text = IPasswordBox.Show("Optional IPasswordBox text", "IPasswordBox Title", MessageBoxImage.Exclamation, "defaultpassword").ToString();
        }
    }
}
