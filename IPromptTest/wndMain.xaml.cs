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
            tblckResponse.Text = IMessageBox.Show("Optional messagebox text", "Optional IMessageBox Title", MessageBoxButton.YesNoCancel, MessageBoxImage.Information, this).ToString();
        }

        private void btnIInputBox_Click(object sender, RoutedEventArgs e)
        {
            tblckResponse.Text = IInputBox.Show("Optional IInputBox text", "IInputBox Title", MessageBoxImage.Question, "default response").ToString();
        }

        private void btnIPasswordBox_Click(object sender, RoutedEventArgs e)
        {
            tblckResponse.Text = IPasswordBox.Show("Optional IPasswordBox text", "IPasswordBox Title", MessageBoxImage.Exclamation, "defaultpassword").ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Prompt.OKText = "OK";
            Prompt.CancelText = "Отмена";
            Prompt.YesText = "Oui";
            Prompt.NoText = "Nein";
        }
    }
}
