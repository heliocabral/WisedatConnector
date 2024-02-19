Imports System.Data.SqlClient

Public Class ResumeView
    Private TableName As String
    Private Ano As Integer
    Private Mes As Integer

    Public Sub New(ByVal TableName As String, ByVal Ano As Integer, ByVal mes As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.TableName = TableName
        Me.Ano = Ano
        Me.Mes = mes

        SetLayout()

        LoadData()
    End Sub

    Private Sub SetLayout()
        Try
            Select Case TableName
                Case "Recibos"
                    LblTitle.Text = "Resumo | Recibos"
                    With DataGridView1.Columns
                        .Add("Documento", "Documento")
                        .Add("DataDocumento", "Data do documento")
                        .Add("Entidade", "Entidade")
                        .Add("NomeEntidade", "Nome da entidade")
                        .Add("NIF", "NIF")
                        .Add("DataMovimento", "Data Movimento")
                        .Add("ModoPagamento", "Modo de pagamento")
                        .Add("ValorRecebido", "Valor recebido")
                    End With

                    For Each c As DataGridViewColumn In DataGridView1.Columns
                        c.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    Next
                Case Else
                    Throw New Exception("Tabela não encontrada ou não suportada.")
            End Select
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub LoadData()
        Try
            Dim CRUD As New CRUD
            Dim SqlCmd As New SqlCommand
            Dim DR As SqlDataReader

            Select Case TableName
                Case "Recibos"
                    SqlCmd.CommandText = "
                    SELECT MasterDocumentosLiquidacoes.Documento, MasterDocumentosTesouraria.Serie, 
                    MasterDocumentosTesouraria.NumeroDocumento, DataDocumento, 
                    MasterDocumentosLiquidacoes.Entidade, Clientes.NomeEntidade, Clientes.NIF, 
                    DetailsDocumentosTesouraria.DataMovimento, MasterDocumentosLiquidacoes.ModoPagamento, 
                    ValorRecebido 
                    FROM MasterDocumentosLiquidacoes 
                    INNER JOIN MasterDocumentosTesouraria 
                    ON MasterDocumentosLiquidacoes.ID = MasterDocumentosTesouraria.IDDocumentoOrigem 
                    AND MasterDocumentosTesouraria.TipoEntidade = 0 
                    INNER JOIN Clientes 
                    ON MasterDocumentosTesouraria.Entidade = Clientes.CodigoEntidade 
                    INNER JOIN DetailsDocumentosTesouraria 
                    ON MasterDocumentosTesouraria.ID = DetailsDocumentosTesouraria.IDMaster 
                    WHERE YEAR(DataDocumento) = @ano and MONTH(DataDocumento) = @mes
                    "

                    SqlCmd.Parameters.Add("@ano", SqlDbType.Int).Value = Me.Ano
                    SqlCmd.Parameters.Add("@mes", SqlDbType.Int).Value = Me.Mes

                    DR = CRUD.ReadDb(SqlCmd)

                    If DR.HasRows Then
                        While DR.Read
                            DataGridView1.Rows.Add(DR(0) & " " & DR(1) & "/" & DR(2),
                                                   DR(3),
                                                   DR(4),
                                                   DR(5),
                                                   DR(6),
                                                   DR(7),
                                                   DR(8),
                                                   CType(DR(9), Double).ToString("N2"))
                        End While
                    End If

                Case Else
                    Throw New Exception("Tabela não encontrada ou não suportada.")
            End Select


        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
