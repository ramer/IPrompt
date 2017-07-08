using System.Windows;

namespace IPrompt
{
    public class IMessageBox
    {
        public static MessageBoxResult Show(string prompt = "", string title = "", MessageBoxButton button = MessageBoxButton.OK, MessageBoxImage icon = MessageBoxImage.Information, Window owner = null)
        {
            Prompt w = new Prompt();
            if (!(owner == null)) { w.Owner = owner; w.Icon = owner.Icon; }
            w.type = MessageBoxType.MessageBox;
            w.prompt = prompt;
            w.title = title;
            w.button = button;
            w.icon = icon;

            bool? dialogResult = w.ShowDialog();
            if (dialogResult == null)
            {
                return MessageBoxResult.None;
            }
            else if (dialogResult == true)
            {
                return w.messageboxResult;
            }
            else
            {
                return MessageBoxResult.None;
            }
        }
    }
}
