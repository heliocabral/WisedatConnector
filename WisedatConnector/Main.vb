Public Class Main
    Private MainClass As New MainClass

    ' Controls the Wizard current step
    Private WizardCurrentStep As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Load WelcomeView
        loadWelcomeView()
    End Sub

    Private Sub loadWelcomeView()
        Try
            addView(WizardCurrentStep)
        Catch ex As Exception
            MsgBox("Não foi possível carregar a view!" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            End
        End Try
    End Sub

#Region "Private Methods"
    Private Sub addView(ByVal index As Integer)
        Try
            clearViews()
            Dim control As New UserControl
            control = Me.MainClass.getView(index)
            With control
                .Dock = DockStyle.Fill
                Me.panelMain.Controls.Add(control)
            End With
        Catch ex As Exception
            Throw
        End Try
    End Sub
    ' Clear the current view
    Private Sub clearViews()
        panelMain.Controls.Clear()
    End Sub

    ' Validate if the currentView index
    Private Function CurrentViewValidation(ByVal nextStep As Integer) As Boolean
        Try
            If nextStep >= 0 AndAlso nextStep < MainClass.getTotalViewsCount Then
                Return True
            End If

            Return False

        Catch ex As Exception
            Throw
        End Try
    End Function
#End Region
    Private Sub btCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        If MsgBox("Deseja realmente cancelar o assistente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar operação") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub btNext_Click(sender As Object, e As EventArgs) Handles btNext.Click
        Try
            If CurrentViewValidation(WizardCurrentStep + 1) Then
                WizardCurrentStep += 1
                addView(WizardCurrentStep)
            End If
        Catch ex As Exception
            MsgBox("Não foi possível carregar a view!" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            End
        End Try


    End Sub

    Private Sub btPrevious_Click(sender As Object, e As EventArgs) Handles btPrevious.Click
        Try
            If CurrentViewValidation(WizardCurrentStep - 1) Then
                WizardCurrentStep -= 1
                addView(WizardCurrentStep)
            End If
        Catch ex As Exception
            MsgBox("Não foi possível carregar a view!" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            End
        End Try

    End Sub
End Class
