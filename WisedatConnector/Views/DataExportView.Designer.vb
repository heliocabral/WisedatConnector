<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataExportView
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ProgressBar1 = New ProgressBar()
        ProgressBar2 = New ProgressBar()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(14, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 21)
        Label1.TabIndex = 0
        Label1.Text = "Exportação de dados"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(173, 15)
        Label2.TabIndex = 1
        Label2.Text = "Exportando tabela de ""Recibos"""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(82, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 1
        Label3.Text = "Passo atual:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(82, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 15)
        Label4.TabIndex = 1
        Label4.Text = "Total concluído:"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(82, 108)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(465, 23)
        ProgressBar1.TabIndex = 2
        ' 
        ' ProgressBar2
        ' 
        ProgressBar2.Location = New Point(82, 177)
        ProgressBar2.Name = "ProgressBar2"
        ProgressBar2.Size = New Size(465, 23)
        ProgressBar2.TabIndex = 2
        ' 
        ' DataExportView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(ProgressBar2)
        Controls.Add(ProgressBar1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "DataExportView"
        Size = New Size(572, 239)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
End Class
