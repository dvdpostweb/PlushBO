<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class errorList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListError = New System.Windows.Forms.ListBox
        Me.ButSave = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ListError
        '
        Me.ListError.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListError.FormattingEnabled = True
        Me.ListError.HorizontalScrollbar = True
        Me.ListError.Location = New System.Drawing.Point(13, 41)
        Me.ListError.Name = "ListError"
        Me.ListError.Size = New System.Drawing.Size(273, 56)
        Me.ListError.TabIndex = 0
        '
        'ButSave
        '
        Me.ButSave.Location = New System.Drawing.Point(12, 12)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(75, 23)
        Me.ButSave.TabIndex = 1
        Me.ButSave.Text = "Save"
        Me.ButSave.UseVisualStyleBackColor = True
        '
        'errorList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 129)
        Me.Controls.Add(Me.ButSave)
        Me.Controls.Add(Me.ListError)
        Me.Name = "errorList"
        Me.Text = "errorList"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListError As System.Windows.Forms.ListBox
    Friend WithEvents ButSave As System.Windows.Forms.Button
End Class
