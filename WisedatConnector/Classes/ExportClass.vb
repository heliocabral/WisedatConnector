Public Class ExportClass
    Public Shared Function ObtemAnos(
            Optional ByVal AnoInicial As Integer = Nothing,
            Optional ByVal AnoFinal As Integer = Nothing) As List(Of Integer)
        Try
            If AnoInicial = Nothing Then
                AnoInicial = 2023
                AnoFinal = Now.Year + 1
            End If

            If AnoFinal = Nothing Then AnoFinal = AnoInicial

            Dim ListaAnos As New List(Of Integer)

            For i = AnoInicial To AnoFinal
                ListaAnos.Add(i)
            Next

            Return ListaAnos

        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
