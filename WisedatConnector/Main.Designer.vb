﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        BtnCancelar = New Button()
        BtnProximo = New Button()
        BtnAnterior = New Button()
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
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(572, 63)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(Label1)
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(292, 63)
        Panel4.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(25, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(224, 19)
        Label2.TabIndex = 1
        Label2.Text = "Assistente de exportação de dados"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(10, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 25)
        Label1.TabIndex = 0
        Label1.Text = "WISEDAT Connector"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.Controls.Add(BtnCancelar)
        Panel3.Controls.Add(BtnProximo)
        Panel3.Controls.Add(BtnAnterior)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 302)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(572, 36)
        Panel3.TabIndex = 2
        ' 
        ' BtnCancelar
        ' 
        BtnCancelar.FlatStyle = FlatStyle.Flat
        BtnCancelar.Location = New Point(485, 7)
        BtnCancelar.Name = "BtnCancelar"
        BtnCancelar.Size = New Size(75, 23)
        BtnCancelar.TabIndex = 998
        BtnCancelar.Text = "&Cancelar"
        BtnCancelar.UseVisualStyleBackColor = True
        ' 
        ' BtnProximo
        ' 
        BtnProximo.FlatStyle = FlatStyle.Flat
        BtnProximo.Location = New Point(404, 7)
        BtnProximo.Name = "BtnProximo"
        BtnProximo.Size = New Size(75, 23)
        BtnProximo.TabIndex = 1
        BtnProximo.Tag = "0"
        BtnProximo.Text = "&Próximo >"
        BtnProximo.UseVisualStyleBackColor = True
        ' 
        ' BtnAnterior
        ' 
        BtnAnterior.FlatStyle = FlatStyle.Flat
        BtnAnterior.Location = New Point(327, 7)
        BtnAnterior.Name = "BtnAnterior"
        BtnAnterior.Size = New Size(75, 23)
        BtnAnterior.TabIndex = 999
        BtnAnterior.Text = "< &Anterior"
        BtnAnterior.UseVisualStyleBackColor = True
        ' 
        ' panelMain
        ' 
        panelMain.Dock = DockStyle.Fill
        panelMain.Location = New Point(0, 63)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(572, 239)
        panelMain.TabIndex = 3
        ' 
        ' Main
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.White
        ClientSize = New Size(572, 338)
        Controls.Add(panelMain)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(3, 2, 3, 2)
        MaximizeBox = False
        Name = "Main"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Assistente de exportação de dados WISEDAT (01.240216)"
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
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnProximo As Button
    Friend WithEvents BtnAnterior As Button
    Friend WithEvents panelMain As Panel
End Class
