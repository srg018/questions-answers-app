Public Class UpdateAnswer

    Protected id As Integer
    Protected db As New db

    Public Sub New(ByVal id As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        id = id


        tbUpdateAnswer.Text = welcome.getAnswerValue("answer").ToString()
    End Sub
    Private Sub btnUpdateAnswer_Click(sender As Object, e As EventArgs) Handles btnUpdateAnswer.Click
        db.sql = "UPDATE answerSET answer = @answer WHERE id = @id"
        db.bind("@id", id)
        db.bind("@answer", tbUpdateAnswer.Text)
        db.execute()
        Me.Dispose()
    End Sub

End Class