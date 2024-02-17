Imports System.Data.SqlClient

Public Class OdbcClass
    Friend Shared Function TestConnection(ByVal Server As String, ByVal Db As String,
                                          ByVal User As String, ByVal Password As String,
                                          ByVal Odbc_AuthType As Boolean)

        Try
            Dim CRUD As New CRUD(Trim(Server), Trim(Db), User, Password, Odbc_AuthType)
            Dim SqlCmd As New SqlCommand

            SqlCmd.CommandText = "SELECT TOP 1 * FROM Parametros"

            CRUD.ReadDb(SqlCmd)

            MsgBox("Ligação à Base de Dados efetuada com sucesso!", MsgBoxStyle.Information)

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function

    Friend Shared Sub SaveCredentials(ByVal ODBC_Server As String, ByVal ODBC_Db As String,
                                      ByVal ODBC_User As String, ByVal ODBC_Password As String,
                                      ByVal ODBC_AuthType As Boolean)
        Try
            With My.Settings
                .ODBC_Server = Trim(ODBC_Server)
                .ODBC_DB = Trim(ODBC_Db)
                .ODBC_User = Trim(ODBC_User)
                .ODBC_Password = Trim(ODBC_Password)
                .ODBC_AuthType = ODBC_AuthType
                .Save()
            End With

        Catch ex As Exception
            Throw
        End Try
    End Sub

End Class
