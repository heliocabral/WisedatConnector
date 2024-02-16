Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports WisedatConnector.My

Public Class CRUD
    Public sqlConn As SqlConnection

    Public Sub New(Optional ByVal ODBC_Server As String = Nothing,
                   Optional ByVal ODBC_DB As String = Nothing,
                   Optional ByVal ODBC_User As String = Nothing,
                   Optional ByVal ODBC_Password As String = Nothing,
                   Optional ByVal ODBC_AuthType As Boolean = Nothing)

        Try
            ' Overwrite
            If ODBC_Server = Nothing Then
                With My.Settings
                    ODBC_Server = .ODBC_Server
                    ODBC_DB = .ODBC_DB
                    ODBC_User = .ODBC_User
                    ODBC_Password = .ODBC_Password
                    ODBC_AuthType = .ODBC_AuthType
                End With
            End If

            Dim StrConnection As String

            StrConnection = "Data Source=" & ODBC_Server & ";" &
                "Initial Catalog =" & ODBC_DB & ";"

            If Not ODBC_AuthType Then
                StrConnection += "User Id=" & ODBC_User & ";" &
                    "Password=" & ODBC_Password & ";"
            End If

            StrConnection += "Integrated Security=" & ODBC_AuthType & ";"

            Me.sqlConn = New SqlConnection(StrConnection)

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function TestDbConn() As Boolean
        ' Testa a ligação à base de dados
        Dim testConn As New SqlConnection

        Try
            With testConn
                .ConnectionString = sqlConn.ConnectionString
                .Open()
                If .State = ConnectionState.Open Then
                    MsgBox("Teste de ligação à base de dados realizado com sucesso!", MsgBoxStyle.Information)
                    Return True
                End If
            End With
            Return False
        Catch ex As Exception
            Throw
        End Try

    End Function
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
            Throw
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
