Public Class Main
    Private MainClass As New MainClass

    ' Controls the Wizard current step
    Private WizardCurrentStep As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Load WelcomeView
        carregarView(0)
    End Sub
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Try
            ' Verifica se é possível retroceder um passo
            If MainClass.CurrentViewValidation(WizardCurrentStep - 1) Then
                WizardCurrentStep -= 1
                CarregarView(WizardCurrentStep)
            End If
        Catch ex As Exception
            MsgBox("Não foi possível carregar a view!" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            End
        End Try

    End Sub
    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click


        Try
            ' Verifica Dependencias
            If Not VerificarDependencias() Then Exit Sub
            ' Verificar se é possível avançar um passo
            If MainClass.CurrentViewValidation(WizardCurrentStep + 1) Then
                WizardCurrentStep += 1
                CarregarView(WizardCurrentStep)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("Deseja realmente cancelar o assistente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar operação") = MsgBoxResult.Yes Then
            End
        End If
    End Sub
    Private Sub CarregarView(ByVal index As Integer)
        Try
            clearViews()
            Dim control As New UserControl
            control = Me.MainClass.getView(index)
            With control
                .Dock = DockStyle.Fill
                Me.panelMain.Controls.Add(control)

                ' Set focus on the control with the TabIndex 1
                For Each c As Control In control.Controls
                    If c.TabIndex = 1 Then
                        c.Focus()
                        Exit For
                    End If
                Next
            End With
        Catch ex As Exception
            Throw
        End Try
    End Sub
    ' Clear the current view
    Private Sub clearViews()
        panelMain.Controls.Clear()
    End Sub


    Private Function VerificarDependencias() As Boolean
        Try
            Select Case WizardCurrentStep
                Case 1
                    ' Testa Ligação ODBC
                    Dim c As New OdbcView
                    c = panelMain.Controls(0)

                    Dim validatedForm As Boolean = c.formValidation

                    ' Save ODBC credentials
                    If validatedForm Then c.saveOdbcCredentials()

                    Return validatedForm

                Case 2
                    ' ExportView
                    Dim c As New ExportView
                    c = panelMain.Controls(0)

                    Return c.formValidation
                Case Else
                    Return True
            End Select
        Catch ex As Exception
            Throw
        End Try
    End Function

End Class
