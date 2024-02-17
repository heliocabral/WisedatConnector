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
    Public Function formValidation() As Boolean
        Try
            If Trim(Text_Server.Text = "") Then Throw New Exception("O campo ""Servidor"" não foi preenchido!")
            If Trim(Text_Db.Text = "") Then Throw New Exception("O campo ""Base de dados"" não foi preenchido!")
            If Not OdbcClass.TestConnection(Trim(Text_Server.Text),
                                            Trim(Text_Db.Text),
                                            Trim(Text_User.Text),
                                            Trim(Text_Password.Text),
                                            Not CType(Combo_Auth.SelectedIndex, Boolean)) Then Return False

            MsgBox("Teste de ligação à base de dados realizado com sucesso!", MsgBoxStyle.Information)

            Return True

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Sub saveOdbcCredentials()
        Try
            OdbcClass.SaveCredentials(Text_Server.Text, Text_Db.Text, Text_User.Text, Text_Password.Text, Not CType(Combo_Auth.SelectedIndex, Boolean))
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class
