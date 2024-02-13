Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class CRUD
    Public sqlConn As New SqlConnection("Data Source=" &
        My.Settings.ODBC_Server & ";Initial Catalog=" & My.Settings.ODBC_DB &
        ";User Id=" & My.Settings.ODBC_User & ";Password=" &
        My.Settings.ODBC_Password & ";Integrated Security=False;")

    Public Sub TestDbConn()
        ' Testa a ligação à base de dados
        Dim testConn As New SqlConnection

        Try
            With testConn
                .ConnectionString = sqlConn.ConnectionString
                .Open()
                If .State = ConnectionState.Open Then
                    MsgBox("Teste de ligação à base de dados realizado com sucesso!", MsgBoxStyle.Information)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Public Function ExecQuerryTransaction(ByVal SQL() As SqlClient.SqlCommand)

        Dim sqlCmd As New SqlClient.SqlCommand
        sqlCmd.Connection = sqlConn
        sqlCmd.Connection.Open()

        Dim sqlTrans As SqlClient.SqlTransaction
        sqlTrans = sqlConn.BeginTransaction()
        sqlCmd.Transaction = sqlTrans

        Try
            For Each sqlline As SqlClient.SqlCommand In SQL
                sqlCmd.Parameters.Clear()
                For Each param As SqlParameter In sqlline.Parameters
                    sqlCmd.Parameters.Add(param.ParameterName, param.SqlDbType).Value = param.Value
                Next
                sqlCmd.CommandText = sqlline.CommandText
                sqlCmd.ExecuteNonQuery()
            Next

            sqlTrans.Commit()
        Catch ex As Exception
            sqlTrans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return 1
        End Try

        Return 0
    End Function
    Public Sub InsertDB(ByVal SqlCmd As SqlClient.SqlCommand)
        Dim SqlConn As New SqlClient.SqlConnection

        Try
            With SqlConn
                .ConnectionString = Me.sqlConn.ConnectionString
                .Open()
            End With

            SqlCmd.Connection = SqlConn

            SqlCmd = SqlConn.CreateCommand

            Dim transaction As SqlClient.SqlTransaction

            transaction = SqlConn.BeginTransaction

            SqlCmd.Transaction = transaction


        Catch ex As Exception

        End Try
    End Sub

    Public Function ReadDb(ByVal SqlCmd As SqlClient.SqlCommand) As SqlClient.SqlDataReader

        Dim sqlConn As New SqlClient.SqlConnection
        Dim sqlDr As SqlClient.SqlDataReader = Nothing

        Try

            With sqlConn
                .ConnectionString = Me.sqlConn.ConnectionString
                .Open()
            End With

            SqlCmd.Connection = sqlConn

            sqlDr = SqlCmd.ExecuteReader

            If sqlDr.HasRows Then
                Return sqlDr
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return sqlDr

    End Function
    Public Function HasResults(ByVal SqlCmd As SqlClient.SqlCommand) As Boolean

        Dim sqlConn As New SqlClient.SqlConnection
        Dim sqlDr As SqlClient.SqlDataReader = Nothing

        Try

            With sqlConn
                .ConnectionString = Me.sqlConn.ConnectionString
                .Open()
            End With

            SqlCmd.Connection = sqlConn

            sqlDr = SqlCmd.ExecuteReader

            If sqlDr.HasRows Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return False

    End Function
End Class
