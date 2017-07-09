Imports IPrompt.VisualBasic

Class wndMain

    Private Sub btnIMessageBox_Click(sender As Object, e As RoutedEventArgs) Handles btnIMessageBox.Click
        tblckResponse.Text = [Enum].GetName(GetType(MsgBoxResult), IMsgBox("Optional IMessageBox text", vbYesNoCancel + vbExclamation, "Optional IMessageBox Title", Me))
    End Sub

    Private Sub btnIInputBox_Click(sender As Object, e As RoutedEventArgs) Handles btnIInputBox.Click
        tblckResponse.Text = IInputBox("Optional IInputBox text", "IInputBox Title", "default response", vbQuestion).ToString
    End Sub

    Private Sub btnIPasswordBox_Click(sender As Object, e As RoutedEventArgs) Handles btnIPasswordBox.Click
        tblckResponse.Text = IPasswordBox("Optional IPasswordBox text", "IPasswordBox Title", "defaultpassword", vbCritical).ToString
    End Sub

    Private Sub wndMain_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        IPrompt.Prompt.OKText = "OK"
        IPrompt.Prompt.CancelText = "Отмена"
        IPrompt.Prompt.YesText = "Oui"
        IPrompt.Prompt.NoText = "Nein"
    End Sub

End Class
