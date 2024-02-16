<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResumeView
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
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        col1 = New DataGridViewTextBoxColumn()
        col2 = New DataGridViewTextBoxColumn()
        col3 = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(14, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 21)
        Label1.TabIndex = 0
        Label1.Text = "Resumo"
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
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(572, 68)
        Panel1.TabIndex = 2
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {col1, col2, col3})
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(0, 68)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(572, 171)
        DataGridView1.TabIndex = 3
        ' 
        ' col1
        ' 
        col1.HeaderText = "Column1"
        col1.Name = "col1"
        col1.ReadOnly = True
        ' 
        ' col2
        ' 
        col2.HeaderText = "Column1"
        col2.Name = "col2"
        col2.ReadOnly = True
        ' 
        ' col3
        ' 
        col3.HeaderText = "Column1"
        col3.Name = "col3"
        col3.ReadOnly = True
        ' 
        ' ResumeView
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Name = "ResumeView"
        Size = New Size(572, 239)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents col1 As DataGridViewTextBoxColumn
    Friend WithEvents col2 As DataGridViewTextBoxColumn
    Friend WithEvents col3 As DataGridViewTextBoxColumn
End Class