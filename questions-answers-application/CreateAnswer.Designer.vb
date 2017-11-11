<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAnswer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbCreateAnswer = New System.Windows.Forms.TextBox()
        Me.btnAnswerSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbCreateAnswer
        '
        Me.tbCreateAnswer.Location = New System.Drawing.Point(33, 35)
        Me.tbCreateAnswer.Multiline = True
        Me.tbCreateAnswer.Name = "tbCreateAnswer"
        Me.tbCreateAnswer.Size = New System.Drawing.Size(504, 270)
        Me.tbCreateAnswer.TabIndex = 0
        '
        'btnAnswerSubmit
        '
        Me.btnAnswerSubmit.Location = New System.Drawing.Point(241, 346)
        Me.btnAnswerSubmit.Name = "btnAnswerSubmit"
        Me.btnAnswerSubmit.Size = New System.Drawing.Size(117, 43)
        Me.btnAnswerSubmit.TabIndex = 1
        Me.btnAnswerSubmit.Text = "Submit"
        Me.btnAnswerSubmit.UseVisualStyleBackColor = True
        '
        'CreateAnswer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 423)
        Me.Controls.Add(Me.btnAnswerSubmit)
        Me.Controls.Add(Me.tbCreateAnswer)
        Me.Name = "CreateAnswer"
        Me.Text = "CreateAnswer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbCreateAnswer As TextBox
    Friend WithEvents btnAnswerSubmit As Button
End Class
