using System.Windows;

namespace IPrompt
{
    public static class VisualBasic
    {
        public const int MB_TYPEMASK = 0xf;
        public const int MB_ICONMASK = 0xf0;

        public static int IMsgBox(string prompt = "", int button = 0, string title = "", Window owner = null)
        {
            int buttonunmasked = button & MB_TYPEMASK;
            int iconunmasked = button & MB_ICONMASK;

            Prompt w = new Prompt();
            if (!(owner == null)) { w.Owner = owner; w.Icon = owner.Icon; }
            w.type = MessageBoxType.MessageBox;
            w.prompt = prompt;
            w.title = title;

            switch (buttonunmasked)
            {
                case 0:
                    w.button = MessageBoxButton.OK;
                    break;
                case 1:
                    w.button = MessageBoxButton.OKCancel;
                    break;
                case 3:
                    w.button = MessageBoxButton.YesNoCancel;
                    break;
                case 4:
                    w.button = MessageBoxButton.YesNo;
                    break;
                default:
                    w.button = MessageBoxButton.OK;
                    break;
            }

            switch (iconunmasked)
            {
                case 16:
                    w.icon = MessageBoxImage.Error;
                    break;
                case 32:
                    w.icon = MessageBoxImage.Question;
                    break;
                case 48:
                    w.icon = MessageBoxImage.Exclamation;
                    break;
                case 64:
                    w.icon = MessageBoxImage.Information;
                    break;
                default:
                    w.icon = MessageBoxImage.None;
                    break;
            }

            bool? dialogResult = w.ShowDialog();
            if (dialogResult == null)
            {
                return 2; //MsgBoxResult.Cancel
            }
            else if (dialogResult == true)
            {
                switch(w.messageboxResult)
                {
                    case MessageBoxResult.OK:
                        return 1; //MsgBoxResult.OK
                    case MessageBoxResult.Cancel:
                        return 2; //MsgBoxResult.Cancel
                    case MessageBoxResult.Yes:
                        return 6; //MsgBoxResult.Yes
                    case MessageBoxResult.No:
                        return 7; //MsgBoxResult.No
                    case MessageBoxResult.None:
                        return 2; //MsgBoxResult cannot be None, Cancel instead
                    default:
                        return 2; //MsgBoxResult.Cancel
                }
            }
            else
            {
                return 2; //MsgBoxResult.Cancel
            }
        }

        public static string IInputBox(string prompt = "", string title = "", string defaultResponse = "", int icon = 32, Window owner = null)
        {
            Prompt w = new Prompt();
            if (!(owner == null)) { w.Owner = owner; w.Icon = owner.Icon; }
            w.type = MessageBoxType.InputBox;
            w.prompt = prompt;
            w.title = title;
            w.button = MessageBoxButton.OKCancel;

            switch (icon)
            {
                case 16:
                    w.icon = MessageBoxImage.Error;
                    break;
                case 32:
                    w.icon = MessageBoxImage.Question;
                    break;
                case 48:
                    w.icon = MessageBoxImage.Exclamation;
                    break;
                case 64:
                    w.icon = MessageBoxImage.Information;
                    break;
                default:
                    w.icon = MessageBoxImage.None;
                    break;
            }

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

        public static string IPasswordBox(string prompt = "", string title = "", string defaultResponse = "", int icon = 32, Window owner = null)
        {
            Prompt w = new Prompt();
            if (!(owner == null)) { w.Owner = owner; w.Icon = owner.Icon; }
            w.type = MessageBoxType.PasswordBox;
            w.prompt = prompt;
            w.title = title;
            w.button = MessageBoxButton.OKCancel;

            switch (icon)
            {
                case 16:
                    w.icon = MessageBoxImage.Error;
                    break;
                case 32:
                    w.icon = MessageBoxImage.Question;
                    break;
                case 48:
                    w.icon = MessageBoxImage.Exclamation;
                    break;
                case 64:
                    w.icon = MessageBoxImage.Information;
                    break;
                default:
                    w.icon = MessageBoxImage.None;
                    break;
            }

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
