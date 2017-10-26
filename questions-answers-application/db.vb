Imports System.Data.SqlClient

Public Class db
    Protected connection As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283-2017fa;Trusted_Connection=yes;"}
    Protected command As New SqlCommand With {.Connection = connection}

    Public Property sql() As String
        Get
            Return command.CommandText
        End Get

        Set(value As String)
            command.CommandText = value
        End Set
    End Property

    'ability to set give sql command
    Public Sub fill(ByRef dgv As DataGridView)
        Dim adapter As SqlDataAdapter
        Dim dataset As DataSet

        Try
            connection.Open()
            adapter = New SqlDataAdapter(command)
            dataset = New DataSet
            adapter.Fill(dataset)
            If dataset.Tables.Count > 0 Then
                dgv.Refresh()
                dgv.DataSource = dataset.Tables(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
End Class
