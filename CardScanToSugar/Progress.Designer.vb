<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressDialog
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
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.lblPercent = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCancel.Location = New System.Drawing.Point(108, 65)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(73, 26)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 33)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(255, 22)
        Me.ProgressBar1.TabIndex = 3
        '
        'lblPercent
        '
        Me.lblPercent.BackColor = System.Drawing.SystemColors.Control
        Me.lblPercent.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPercent.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPercent.Location = New System.Drawing.Point(12, 9)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPercent.Size = New System.Drawing.Size(225, 17)
        Me.lblPercent.TabIndex = 5
        Me.lblPercent.Text = "Reading image ... 0%"
        '
        'ProgressDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 124)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblPercent)
        Me.Name = "ProgressDialog"
        Me.Text = "Progress"
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdCancel As System.Windows.Forms.Button
    Public WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Public WithEvents lblPercent As System.Windows.Forms.Label
End Class
