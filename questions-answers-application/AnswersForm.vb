Public Class AnswersForm
    Protected db As New db
    Protected question_id As Integer

    Public Sub New(ByRef qid As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid
    End Sub

    Protected Sub LoadAnswers()
        db.sql = "SELECT * FROM answers WHERE question_id = @question_id"
        db.bind("@question_id", question_id)
        db.fill(dgvAnswers)
    End Sub

    Private Sub LoadAnswersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadAnswersToolStripMenuItem.Click
        LoadAnswers()
    End Sub
    Private Sub AnswersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAnswers()
    End Sub

End Class