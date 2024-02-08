Public Class Main
    Private MainClass As New MainClass
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Load WelcomeView
        LoadWelcomeView()
    End Sub

    Private Sub LoadWelcomeView()
        Dim control As New UserControl
        Try
            control = Me.MainClass.getView(0)
            With control
                .Dock = DockStyle.Fill
                Me.panelMain.Controls.Add(control)
            End With
        Catch ex As Exception
            MsgBox("Não foi possível carregar a view!" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            End
        End Try
    End Sub
End Class
