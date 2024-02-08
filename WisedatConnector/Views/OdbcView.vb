Public Class OdbcView
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBox1.SelectedIndex = 0

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedIndex = 0 Then
            txtUser.Enabled = False
            txtPassword.Enabled = False
        Else
            txtUser.Enabled = True
            txtPassword.Enabled = True
        End If
    End Sub
End Class
