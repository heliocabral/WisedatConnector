<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportView
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label2 = New Label()
        Label1 = New Label()
        txtFicheiro = New TextBox()
        btnProcurar = New Button()
        Label3 = New Label()
        Label4 = New Label()
        cblAno = New ComboBox()
        Label5 = New Label()
        cblMes = New ComboBox()
        Label6 = New Label()
        chkRecibos = New CheckBox()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(279, 15)
        Label2.TabIndex = 3
        Label2.Text = "Indique a localização e nome do ficheiro a exportar."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(14, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 21)
        Label1.TabIndex = 2
        Label1.Text = "Exportação de dados"
        ' 
        ' txtFicheiro
        ' 
        txtFicheiro.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFicheiro.Enabled = False
        txtFicheiro.Location = New Point(113, 74)
        txtFicheiro.Margin = New Padding(3, 2, 3, 2)
        txtFicheiro.Name = "txtFicheiro"
        txtFicheiro.Size = New Size(344, 23)
        txtFicheiro.TabIndex = 4
        ' 
        ' btnProcurar
        ' 
        btnProcurar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnProcurar.Location = New Point(458, 74)
        btnProcurar.Margin = New Padding(3, 2, 3, 2)
        btnProcurar.Name = "btnProcurar"
        btnProcurar.Size = New Size(24, 22)
        btnProcurar.TabIndex = 5
        btnProcurar.Text = "..."
        btnProcurar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(70, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(35, 15)
        Label3.TabIndex = 6
        Label3.Text = "Ano: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(267, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 7
        Label4.Text = "Mês: "
        ' 
        ' cblAno
        ' 
        cblAno.DropDownStyle = ComboBoxStyle.DropDownList
        cblAno.FormattingEnabled = True
        cblAno.Location = New Point(113, 106)
        cblAno.Margin = New Padding(3, 2, 3, 2)
        cblAno.Name = "cblAno"
        cblAno.Size = New Size(133, 23)
        cblAno.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(52, 80)
        Label5.Name = "Label5"
        Label5.Size = New Size(52, 15)
        Label5.TabIndex = 9
        Label5.Text = "Ficheiro:"
        ' 
        ' cblMes
        ' 
        cblMes.DropDownStyle = ComboBoxStyle.DropDownList
        cblMes.FormattingEnabled = True
        cblMes.Items.AddRange(New Object() {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"})
        cblMes.Location = New Point(315, 106)
        cblMes.Margin = New Padding(3, 2, 3, 2)
        cblMes.Name = "cblMes"
        cblMes.Size = New Size(133, 23)
        cblMes.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(27, 153)
        Label6.Name = "Label6"
        Label6.Size = New Size(221, 15)
        Label6.TabIndex = 3
        Label6.Text = "Indique as tabelas que pretende exportar"
        ' 
        ' chkRecibos
        ' 
        chkRecibos.AutoSize = True
        chkRecibos.Checked = True
        chkRecibos.CheckState = CheckState.Checked
        chkRecibos.Enabled = False
        chkRecibos.Location = New Point(70, 177)
        chkRecibos.Name = "chkRecibos"
        chkRecibos.Size = New Size(67, 19)
        chkRecibos.TabIndex = 11
        chkRecibos.Text = "Recibos"
        chkRecibos.UseVisualStyleBackColor = True
        ' 
        ' ExportView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(chkRecibos)
        Controls.Add(cblMes)
        Controls.Add(Label5)
        Controls.Add(cblAno)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnProcurar)
        Controls.Add(txtFicheiro)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "ExportView"
        Size = New Size(506, 209)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFicheiro As TextBox
    Friend WithEvents btnProcurar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cblAno As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cblMes As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents chkRecibos As CheckBox
End Class
