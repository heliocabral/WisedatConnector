Public Class Main
    'Private MainClass As New MainClass

    ' Controls the Wizard current step
    Private WizardCurrentStep As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        ' Load WelcomeView
        MainClass.ViewList.Add(New WelcomeView)
        CarregarView(0)

        ' Checks for ODBC config
        ' If True display ODBC_View
        If Not MainClass.TestOdbcConnection() Then MainClass.ViewList.Add(New WelcomeView)

        MainClass.ViewList.Add(New ExportView)
    End Sub
    Private Sub BtnAnterior_Click(sender As Object, e As EventArgs) Handles BtnAnterior.Click
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
    Private Sub BnProximo_Click(sender As Object, e As EventArgs) Handles BtnProximo.Click

        Try
            If BtnProximo.Tag = 0 Then
                ' Verifica Dependencias
                If Not VerificarDependencias() Then Exit Sub
                ' Verificar se é possível avançar um passo
                If MainClass.CurrentViewValidation(WizardCurrentStep + 1) Then
                    WizardCurrentStep += 1
                    CarregarView(WizardCurrentStep)
                End If
            Else
                Dim c As New DataExportView
                c = Me.panelMain.Controls(0)

                c.ExportarDados()
            End If
        Catch ex As Exception
            Throw
        End Try

    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        If MsgBox("Deseja realmente cancelar o assistente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar operação") = MsgBoxResult.Yes Then
            End
        End If
    End Sub
    Private Sub CarregarView(ByVal index As Integer)
        Try
            clearViews()
            Dim control As New UserControl
            control = MainClass.getView(index)
            With control
                .Dock = DockStyle.Fill
                Me.panelMain.Controls.Add(control)

                If control.GetType Is GetType(DataExportView) Then
                    BtnProximo.Text = "&Terminar"
                    BtnProximo.Tag = 1
                Else
                    BtnProximo.Text = "&Próximo >"
                    BtnProximo.Tag = 0
                End If
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
    Private Sub ClearViews()
        panelMain.Controls.Clear()
    End Sub
    Private Function VerificarDependencias() As Boolean
        Try
            Dim ct As New Control
            ct = panelMain.Controls(0)

            Select Case ct.Name

                Case "OdbcView"
                    ' Testa Ligação ODBC
                    Dim c As New OdbcView
                    c = panelMain.Controls(0)

                    Dim validatedForm As Boolean = c.formValidation

                    ' Save ODBC credentials
                    If validatedForm Then c.saveOdbcCredentials()

                    Return validatedForm

                Case "ExportView"
                    ' ExportView

                    ' Removes depricated views
                    If MainClass.getTotalViewsCount - 1 > WizardCurrentStep Then
                        MainClass.ViewList.RemoveRange(2, MainClass.getTotalViewsCount - 2)
                    End If

                    Dim c As New ExportView
                    c = panelMain.Controls(0)

                    Dim validation As Boolean = c.formValidation

                    If validation Then
                        If c.chkRecibos.Checked Then
                            MainClass.ViewList.Add(New ResumeView("Recibos", c.cblAno.SelectedValue, c.cblMes.SelectedIndex + 1))
                        End If

                        ' Tag the last ResumeView as last 
                        CType(MainClass.ViewList(MainClass.getTotalViewsCount - 1), ResumeView).UltmForm = True
                        MainClass.ViewList.Add(New DataExportView)
                    End If

                    Return validation

                Case "ResumeView"
                    Return True

                Case Else
                    Return True
            End Select
        Catch ex As Exception
            Throw
        End Try
    End Function


End Class
