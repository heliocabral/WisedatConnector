Public Class MainClass
    Friend Shared ViewList As New List(Of UserControl)

    Public Sub New()
        ' Initialization
        ' ViewListInit()
    End Sub

#Region "Class initialization"
    ' Initialization of Views
    'Friend Sub ViewListInit()
    '    With ViewList
    '        .Add(New WelcomeView)
    '        .Add(New OdbcView)
    '        .Add(New ExportView)
    '        .Add(New ResumeView)
    '    End With
    'End Sub

#End Region

#Region "Public Methods"
    'Returns a specific View
    Friend Shared Function getView(ByVal index As Integer) As UserControl
        Try
            Return ViewList(index)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Friend Shared Function getTotalViewsCount() As Integer
        Return ViewList.Count
    End Function

    ' Validate if the currentView index
    Friend Shared Function CurrentViewValidation(ByVal nextStep As Integer) As Boolean
        Try
            If nextStep >= 0 AndAlso nextStep < getTotalViewsCount() Then
                Return True
            End If

            Return False

        Catch ex As Exception
            Throw
        End Try
    End Function

    Friend Shared Function TestOdbcConnection() As Boolean
        Try
            Dim CRUD As New CRUD
            Return CRUD.TestDbConn
        Catch ex As Exception
            Return False
        End Try
    End Function


#End Region


End Class
