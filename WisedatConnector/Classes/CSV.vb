Imports System.IO
Imports System.Text

Public Class CSV
    Public Shared Sub ExportToCSV(filePath As String, fileName As String, dataGridView As DataGridView)
        Dim fullPath As String = Path.Combine(filePath, fileName)

        Try
            Using sw As New StreamWriter(fullPath, False, Encoding.UTF8)
                ' Escreve o cabeçalho
                For Each column As DataGridViewColumn In dataGridView.Columns
                    sw.Write(column.HeaderText + ";")
                Next
                sw.WriteLine()

                ' Escreve os dados
                For Each row As DataGridViewRow In dataGridView.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        If cell.Value IsNot Nothing Then
                            sw.Write(cell.Value.ToString() + ";")
                        Else
                            sw.Write(";")
                        End If
                    Next
                    sw.WriteLine()
                Next
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Sub
End Class