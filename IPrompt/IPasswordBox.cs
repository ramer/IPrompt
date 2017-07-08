using System.Windows;

namespace IPrompt
{
    public class IPasswordBox
    {
        public static string Show(string prompt = "", string title = "", MessageBoxImage icon = MessageBoxImage.Information, string defaultResponse = "", Window owner = null)
        {
            Prompt w = new Prompt();
            if (!(owner == null)) { w.Owner = owner; w.Icon = owner.Icon; }
            w.type = MessageBoxType.PasswordBox;
            w.prompt = prompt;
            w.title = title;
            w.button = MessageBoxButton.OKCancel;
            w.icon = icon;
            w.defaultResponse = defaultResponse;

            bool? dialogResult = w.ShowDialog();
            if (dialogResult == null)
            {
                return "";
            }
            else if (dialogResult == true)
            {
                if (w.messageboxResult == MessageBoxResult.OK)
                {
                    return w.tbInput.Text;
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
        }
    }
}
