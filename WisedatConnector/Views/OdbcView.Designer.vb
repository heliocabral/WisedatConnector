<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OdbcView
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
        Label5 = New Label()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(14, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(244, 21)
        Label1.TabIndex = 0
        Label1.Text = "Configuração de ligação ODBC"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(228, 15)
        Label2.TabIndex = 1
        Label2.Text = "Configure os seus dados de acesso ODBC."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(246, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 15)
        Label3.TabIndex = 1
        Label3.Text = "Servidor:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(220, 116)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 15)
        Label4.TabIndex = 1
        Label4.Text = "Autenticação:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(239, 145)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 1
        Label5.Text = "Utilizador:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(257, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(43, 15)
        Label6.TabIndex = 1
        Label6.Text = "Senha:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Autenticação Windows", "Autenticação SQL Server"})
        ComboBox1.Location = New Point(306, 113)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(235, 23)
        ComboBox1.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(306, 83)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(235, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Enabled = False
        TextBox2.Location = New Point(306, 142)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(235, 23)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Enabled = False
        TextBox3.Location = New Point(306, 171)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(235, 23)
        TextBox3.TabIndex = 4
        TextBox3.UseSystemPasswordChar = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ODBC
        PictureBox1.Location = New Point(51, 83)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(132, 111)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' OdbcView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(PictureBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "OdbcView"
        Size = New Size(572, 239)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
