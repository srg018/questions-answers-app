Imports System.Data.SqlClient

Public Class welcome
    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        Dim sqlcon As New SqlConnection With {.ConnectionString = "Server=essql1.walton.uark.edu;Database=isys4283-2017fa;Trusted_Connection=yes;"}
        Dim sqlcmd As SqlCommand
        Dim sqlda As SqlDataAdapter
        Dim sqldataset As DataSet

        Dim query As String
        query = "SELECT * FROM questions ORDER BY created_at DESC;"

        Try
            sqlcon.Open()
            sqlcmd = New SqlCommand(query, sqlcon)
            sqlda = New SqlDataAdapter(sqlcmd)
            sqldataset = New DataSet
            sqlda.Fill(sqldataset)
            If sqldataset.Tables.Count > 0 Then
                dgvQuestions.Refresh()
                dgvQuestions.DataSource = sqldataset.Tables(0)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Throw ex
        Finally
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()
            End If
        End Try
    End Sub
End Class
