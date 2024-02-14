<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Panel4 = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Panel3 = New Panel()
        btnCancelar = New Button()
        btnProximo = New Button()
        btnAnterior = New Button()
        panelMain = New Panel()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.RoyalBlue
        Panel1.Controls.Add(Panel4)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(4, 2, 4, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(715, 79)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(Label1)
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
        Panel4.Margin = New Padding(4, 2, 4, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(365, 79)
        Panel4.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(31, 45)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(276, 23)
        Label2.TabIndex = 1
        Label2.Text = "Assistente de exportação de dados"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 8)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(230, 31)
        Label1.TabIndex = 0
        Label1.Text = "WISEDAT Connector"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.Controls.Add(btnCancelar)
        Panel3.Controls.Add(btnProximo)
        Panel3.Controls.Add(btnAnterior)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 377)
        Panel3.Margin = New Padding(4, 2, 4, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(715, 45)
        Panel3.TabIndex = 2
        ' 
        ' btnCancelar
        ' 
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.Location = New Point(606, 9)
        btnCancelar.Margin = New Padding(4)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(94, 29)
        btnCancelar.TabIndex = 998
        btnCancelar.Text = "&Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnProximo
        ' 
        btnProximo.FlatStyle = FlatStyle.Flat
        btnProximo.Location = New Point(505, 9)
        btnProximo.Margin = New Padding(4)
        btnProximo.Name = "btnProximo"
        btnProximo.Size = New Size(94, 29)
        btnProximo.TabIndex = 1
        btnProximo.Text = "&Próximo >"
        btnProximo.UseVisualStyleBackColor = True
        ' 
        ' btnAnterior
        ' 
        btnAnterior.FlatStyle = FlatStyle.Flat
        btnAnterior.Location = New Point(409, 9)
        btnAnterior.Margin = New Padding(4)
        btnAnterior.Name = "btnAnterior"
        btnAnterior.Size = New Size(94, 29)
        btnAnterior.TabIndex = 999
        btnAnterior.Text = "< &Anterior"
        btnAnterior.UseVisualStyleBackColor = True
        ' 
        ' panelMain
        ' 
        panelMain.Dock = DockStyle.Fill
        panelMain.Location = New Point(0, 79)
        panelMain.Margin = New Padding(4)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(715, 298)
        panelMain.TabIndex = 3
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(120F, 120F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.White
        ClientSize = New Size(715, 422)
        Controls.Add(panelMain)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 2, 4, 2)
        MaximizeBox = False
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Assistente de exportação de dados WISEDAT (01.240107.1349)"
        Panel1.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnProximo As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents panelMain As Panel
End Class
