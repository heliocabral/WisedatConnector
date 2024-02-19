Public Class DataExportView
    Friend Sub ExportarDados()
        Try
            For Each c As Control In MainClass.ViewList
                If c.GetType() Is GetType(ResumeView) Then
                    For Each d As Control In MainClass.ViewList
                        If d.GetType() Is GetType(ExportView) Then
                            CSV.ExportToCSV(CType(d, ExportView).txtFicheiro.Text, "teste.csv", CType(c, ResumeView).DataGridView1)
                            Exit For
                        End If
                    Next
                End If
            Next

            MsgBox("Registos exportados com sucesso!", MsgBoxStyle.Information)
            End
        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
