# IPrompt
Adds MessageBox, InputBox, PasswordBox functionality to your WPF project (+password generator)

Repo contains three projects:
* **IPrompt** - Class library.
* **IPromptTest** - C# Sample Project, examine IPrompt class library usage.
* **IPromptTestVB** - VB.NET Sample Project, examine IPrompt class library usage.

### IPromt class library usage:
#### C#

```C#
using IPrompt;

MessageBoxResult result = IMessageBox.Show();   // shows default-like WPF-style MessageBox
string result = IInputBox.Show();               // shows WPF-style InputBox
string result = IPasswordBox.Show();            // shows WPF-style PasswordBox
string result = IPasswordGenerator.Generate();  // generates random password
```

#### VB.NET

```VB
' Imports IPrompt - you'll get IInputBox and IPasswordBox collision between IPrompt and IPrompt.VisualBasic
Imports IPrompt.VisualBasic

Dim result As MsgBoxResult = IMsgBox();                        ' shows default-like WPF-style MessageBox
Dim result As String = IInputBox();                            ' shows WPF-style InputBox
Dim result As String = IPasswordBox();                         ' shows WPF-style PasswordBox
Dim result As String = IPrompt.IPasswordGenerator.Generate();  ' generates random password
```

### Parameters:

* **prompt** - The text to display in the message box
* **title** - The text to display in the title bar of the message box
* **button** - One of the MessageBoxButtons values that specifies which buttons to display in the message box
* **icon** - One of the MessageBoxIcon values that specifies which icon to display in the message box
* **defaultResponse** - The text to display in TextBox by default (IInputBox, IPasswordBox only)
* **owner** - An implementation of IWin32Window that will own the modal dialog box
* **minlenght** - Minimum lenght of generated password (IPasswordGenerator)

### Localization:

```C#
using IPrompt;

Prompt.OKText = "OK";
Prompt.CancelText = "Отмена";
Prompt.YesText = "Oui";
Prompt.NoText = "Nein";
```

### Style:

```XAML
<Application x:Class="Application"
    xmlns:iprompt="clr-namespace:IPrompt;assembly=IPrompt"
>

    <Application.Resources>
        <Style TargetType="{x:Type iprompt:Prompt}" BasedOn="{StaticResource {x:Type Window}}"/>
    </Application.Resources>
</Application>
```
