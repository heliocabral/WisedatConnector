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
        Combo_Auth = New ComboBox()
        Text_Server = New TextBox()
        Text_User = New TextBox()
        Text_Password = New TextBox()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Text_Db = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(16, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(302, 28)
        Label1.TabIndex = 0
        Label1.Text = "Configuração de ligação ODBC"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(286, 20)
        Label2.TabIndex = 1
        Label2.Text = "Configure os seus dados de acesso ODBC."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(275, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 1
        Label3.Text = "Servidor:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(246, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 20)
        Label4.TabIndex = 1
        Label4.Text = "Autenticação:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(267, 179)
        Label5.Name = "Label5"
        Label5.Size = New Size(81, 20)
        Label5.TabIndex = 1
        Label5.Text = "Utilizador:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(293, 218)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 20)
        Label6.TabIndex = 1
        Label6.Text = "Senha:"
        ' 
        ' Combo_Auth
        ' 
        Combo_Auth.DropDownStyle = ComboBoxStyle.DropDownList
        Combo_Auth.FormattingEnabled = True
        Combo_Auth.Items.AddRange(New Object() {"Autenticação Windows", "Autenticação SQL Server"})
        Combo_Auth.Location = New Point(351, 137)
        Combo_Auth.Margin = New Padding(3, 4, 3, 4)
        Combo_Auth.Name = "Combo_Auth"
        Combo_Auth.Size = New Size(268, 28)
        Combo_Auth.TabIndex = 2
        ' 
        ' Text_Server
        ' 
        Text_Server.Location = New Point(351, 97)
        Text_Server.Margin = New Padding(3, 4, 3, 4)
        Text_Server.Name = "Text_Server"
        Text_Server.Size = New Size(268, 27)
        Text_Server.TabIndex = 1
        ' 
        ' Text_User
        ' 
        Text_User.Enabled = False
        Text_User.Location = New Point(351, 175)
        Text_User.Margin = New Padding(3, 4, 3, 4)
        Text_User.Name = "Text_User"
        Text_User.Size = New Size(268, 27)
        Text_User.TabIndex = 3
        ' 
        ' Text_Password
        ' 
        Text_Password.Enabled = False
        Text_Password.Location = New Point(351, 214)
        Text_Password.Margin = New Padding(3, 4, 3, 4)
        Text_Password.Name = "Text_Password"
        Text_Password.Size = New Size(268, 27)
        Text_Password.TabIndex = 4
        Text_Password.UseSystemPasswordChar = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ODBC
        PictureBox1.Location = New Point(58, 111)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(151, 148)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(238, 253)
        Label7.Name = "Label7"
        Label7.Size = New Size(110, 20)
        Label7.TabIndex = 1
        Label7.Text = "Base de dados:"
        ' 
        ' Text_Db
        ' 
        Text_Db.Location = New Point(351, 249)
        Text_Db.Margin = New Padding(3, 4, 3, 4)
        Text_Db.Name = "Text_Db"
        Text_Db.Size = New Size(268, 27)
        Text_Db.TabIndex = 5
        Text_Db.UseSystemPasswordChar = True
        ' 
        ' OdbcView
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(PictureBox1)
        Controls.Add(Text_Db)
        Controls.Add(Text_Password)
        Controls.Add(Text_User)
        Controls.Add(Text_Server)
        Controls.Add(Label7)
        Controls.Add(Combo_Auth)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "OdbcView"
        Size = New Size(654, 319)
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
    Friend WithEvents Combo_Auth As ComboBox
    Friend WithEvents Text_Server As TextBox
    Friend WithEvents Text_User As TextBox
    Friend WithEvents Text_Password As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Text_Db As TextBox
End Class
