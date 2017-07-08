using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace IPrompt
{
    public enum MessageBoxType
    {
        MessageBox = 0,
        InputBox = 1,
        PasswordBox = 2
    }

    public partial class Prompt : Window
    {
        public string prompt = "";
        public string title = "";
        public MessageBoxButton button = MessageBoxButton.OK;
        public MessageBoxImage icon = MessageBoxImage.None;
        public MessageBoxType type = 0;
        public string defaultResponse = "";

        public MessageBoxResult messageboxResult;

        public Prompt()
        {
            InitializeComponent();
        }

        private void Promt_Loaded(object sender, RoutedEventArgs e)
        {
            btnOK.Visibility = Visibility.Collapsed;
            btnYes.Visibility = Visibility.Collapsed;
            btnNo.Visibility = Visibility.Collapsed;
            btnCancel.Visibility = Visibility.Collapsed;

            tbInput.Visibility = Visibility.Collapsed;
            btnGenerate.Visibility = Visibility.Collapsed;
            
            Title = string.IsNullOrEmpty(title) ? "" : title;
            tbContent.Text = string.IsNullOrEmpty(prompt) ? "" : prompt;
            
            switch (button)
            {
                case MessageBoxButton.OK:
                    btnOK.Visibility = Visibility.Visible;
                    break;
                case MessageBoxButton.OKCancel:
                    btnOK.Visibility = Visibility.Visible;
                    btnCancel.Visibility = Visibility.Visible;
                    break;
                case MessageBoxButton.YesNo:
                    btnYes.Visibility = Visibility.Visible;
                    btnNo.Visibility = Visibility.Visible;
                    break;
                case MessageBoxButton.YesNoCancel:
                    btnYes.Visibility = Visibility.Visible;
                    btnNo.Visibility = Visibility.Visible;
                    btnCancel.Visibility = Visibility.Visible;
                    break;
            }

            switch (icon)
            {
                case MessageBoxImage.Information:
                    imgIcon.Source = new BitmapImage(new Uri("img/information.png", UriKind.Relative));
                    break;
                case MessageBoxImage.Error:
                    imgIcon.Source = new BitmapImage(new Uri("img/critical.png", UriKind.Relative));
                    break;
                case MessageBoxImage.Exclamation:
                    imgIcon.Source = new BitmapImage(new Uri("img/exclamation.png", UriKind.Relative));
                    break;
                case MessageBoxImage.Question:
                    imgIcon.Source = new BitmapImage(new Uri("img/question.png", UriKind.Relative));
                    break;
            }

            switch (type)
            {
                case MessageBoxType.MessageBox:

                    break;
                case MessageBoxType.InputBox:
                    tbInput.Visibility = Visibility.Visible;
                    tbInput.Text = string.IsNullOrEmpty(defaultResponse) ? "" : defaultResponse;
                    tbInput.SelectAll();
                    tbInput.Focus();
                    break;
                case MessageBoxType.PasswordBox:
                    tbInput.Visibility = Visibility.Visible;
                    btnGenerate.Visibility = Visibility.Visible;
                    tbInput.Text = string.IsNullOrEmpty(defaultResponse) ? IPasswordGenerator.Generate(20) : defaultResponse;
                    tbInput.SelectAll();
                    tbInput.Focus();
                    break;
            }

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            messageboxResult = MessageBoxResult.Cancel;
            DialogResult = true;
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            messageboxResult = MessageBoxResult.No;
            DialogResult = true;
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            messageboxResult = MessageBoxResult.Yes;
            DialogResult = true;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            messageboxResult = MessageBoxResult.OK;
            DialogResult = true;
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            tbInput.Text = IPasswordGenerator.Generate(20);
            tbInput.SelectAll();
            tbInput.Focus();
        }
    }
}
