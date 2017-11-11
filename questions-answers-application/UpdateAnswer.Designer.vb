<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateAnswer
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
        Me.tbUpdateAnswer = New System.Windows.Forms.TextBox()
        Me.btnUpdateAnswer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbUpdateAnswer
        '
        Me.tbUpdateAnswer.Location = New System.Drawing.Point(21, 27)
        Me.tbUpdateAnswer.Multiline = True
        Me.tbUpdateAnswer.Name = "tbUpdateAnswer"
        Me.tbUpdateAnswer.Size = New System.Drawing.Size(248, 166)
        Me.tbUpdateAnswer.TabIndex = 0
        '
        'btnUpdateAnswer
        '
        Me.btnUpdateAnswer.Location = New System.Drawing.Point(106, 215)
        Me.btnUpdateAnswer.Name = "btnUpdateAnswer"
        Me.btnUpdateAnswer.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateAnswer.TabIndex = 1
        Me.btnUpdateAnswer.Text = "Submit"
        Me.btnUpdateAnswer.UseVisualStyleBackColor = True
        '
        'UpdateAnswer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnUpdateAnswer)
        Me.Controls.Add(Me.tbUpdateAnswer)
        Me.Name = "UpdateAnswer"
        Me.Text = "UpdateAnswer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbUpdateAnswer As TextBox
    Friend WithEvents btnUpdateAnswer As Button
End Class
