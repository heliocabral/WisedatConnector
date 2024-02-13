Public Class OdbcView
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Combo_Auth.SelectedIndex = 0

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Auth.SelectedIndexChanged

        If Combo_Auth.SelectedIndex = 0 Then
            Text_User.Enabled = False
            Text_Password.Enabled = False
        Else
            Text_User.Enabled = True
            Text_Password.Enabled = True
        End If
    End Sub
End Class
