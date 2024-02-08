﻿Public Class MainClass
    Private ViewList As New List(Of UserControl)

    Public Sub New()
        ' Initialization
        ViewListInit()
    End Sub

#Region "Class initialization"
    ' Initialization of Views
    Private Sub ViewListInit()
        With Me.ViewList
            .Add(New WelcomeView)
            .Add(New OdbcView)
        End With
    End Sub

#End Region

#Region "Public Methods"
    'Returns a specific View
    Public Function getView(ByVal index As Integer) As UserControl
        Try
            Return Me.ViewList(index)
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function getTotalViewsCount() As Integer
        Return Me.ViewList.Count
    End Function
#End Region


End Class
