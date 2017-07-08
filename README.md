# IPrompt
Adds MessageBox, InputBox, PasswordBox functionality to your WPF project (+password generator)

Repo contains two projects:
* **IPrompt** - Class library.
* **IPromptTest** - Sample Project, examine IPrompt class library usage.

### IPromt class library usage:

```C#
using IPrompt;

MessageBoxResult result = IMessageBox.Show();   // shows default-like WPF-style MessageBox
string result = IInputBox.Show();               // shows WPF-style InputBox
string result = IPasswordBox.Show();            // shows WPF-style PasswordBox
string result = IPasswordGenerator.Generate();  // generates random password
```

### Parameters:

* prompt - The text to display in the message box
* title - The text to display in the title bar of the message box
* button - One of the MessageBoxButtons values that specifies which buttons to display in the message box
* icon - One of the MessageBoxIcon values that specifies which icon to display in the message box
* defaultResponse - The text to display in TextBox by default (IInputBox, IPasswordBox only)
* owner - An implementation of IWin32Window that will own the modal dialog box
* minlenght - Minimum lenght of generated password (IPasswordGenerator)
