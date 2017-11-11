Public Class CreateAnswer
    Protected db As db = New db

    Private Sub btnAnswerSubmit_Click(sender As Object, e As EventArgs) Handles btnAnswerSubmit.Click
        
        db.sql = "INSERT INTO answers (question_id, answer) VALUES (@question_id, @answer)"
        db.bind("@answer", tbCreateAnswer.Text)
        db.bind("@question_id", welcome.getQuestionId)
        db.execute()
        Me.Dispose()
    End Sub
End Class