Public Class ExportView
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Carrega Combobox Anos
        cblAno.DataSource = ExportClass.ObtemAnos
        If cblAno.Items.Contains(Now.Year) Then
            cblAno.SelectedItem = (Now.Year)
        Else
            cblAno.SelectedIndex = 0
        End If

        ' Carrega mês -1 por defeito
        If Now.Month = 1 Then
            cblMes.SelectedIndex = 0
        Else
            cblMes.SelectedIndex = (CType(Now.Month, Integer) - 2)
        End If

    End Sub

    Private Sub btnProcurar_Click(sender As Object, e As EventArgs) Handles btnProcurar.Click
        Dim folderBrowserDialog As New FolderBrowserDialog
        With folderBrowserDialog
            .Description = "Escolha uma pasta para salvar os arquivos"
        End With

        If folderBrowserDialog.ShowDialog() = DialogResult.OK Then
            txtFicheiro.Text = folderBrowserDialog.SelectedPath
        End If
    End Sub

    Public Function formValidation() As Boolean
        Try
            If Trim(txtFicheiro.Text = "") Then Throw New Exception("O campo ""Localização e nome do ficheiro"" não foi preenchido!")
            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function
End Class
