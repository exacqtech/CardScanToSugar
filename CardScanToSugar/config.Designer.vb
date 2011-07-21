<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class config
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
        Me.lblSugarURL = New System.Windows.Forms.Label
        Me.lblUsername = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.btnSaveConfig = New System.Windows.Forms.Button
        Me.lblScanner = New System.Windows.Forms.Label
        Me.cmbScanner = New System.Windows.Forms.ComboBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.txtSugarURL = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'lblSugarURL
        '
        Me.lblSugarURL.AutoSize = True
        Me.lblSugarURL.Location = New System.Drawing.Point(16, 13)
        Me.lblSugarURL.Name = "lblSugarURL"
        Me.lblSugarURL.Size = New System.Drawing.Size(88, 13)
        Me.lblSugarURL.TabIndex = 0
        Me.lblSugarURL.Text = "Sugar Soap URL"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(18, 31)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(86, 13)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "Sugar Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(20, 51)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(84, 13)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Sugar Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(108, 51)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(352, 20)
        Me.txtPassword.TabIndex = 5
        '
        'btnSaveConfig
        '
        Me.btnSaveConfig.Location = New System.Drawing.Point(190, 104)
        Me.btnSaveConfig.Name = "btnSaveConfig"
        Me.btnSaveConfig.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveConfig.TabIndex = 6
        Me.btnSaveConfig.Text = "Save"
        Me.btnSaveConfig.UseVisualStyleBackColor = True
        '
        'lblScanner
        '
        Me.lblScanner.AutoSize = True
        Me.lblScanner.Location = New System.Drawing.Point(57, 70)
        Me.lblScanner.Name = "lblScanner"
        Me.lblScanner.Size = New System.Drawing.Size(47, 13)
        Me.lblScanner.TabIndex = 7
        Me.lblScanner.Text = "Scanner"
        '
        'cmbScanner
        '
        Me.cmbScanner.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CardScanToSugar.My.MySettings.Default, "ScannerType", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbScanner.FormattingEnabled = True
        Me.cmbScanner.Items.AddRange(New Object() {"CardScan 800c", "CardScan 700c", "CardScan 60", "CardScan 600cx", "CardScan 600c", "CardScan 500"})
        Me.cmbScanner.Location = New System.Drawing.Point(108, 70)
        Me.cmbScanner.Name = "cmbScanner"
        Me.cmbScanner.Size = New System.Drawing.Size(349, 21)
        Me.cmbScanner.TabIndex = 8
        Me.cmbScanner.Text = Global.CardScanToSugar.My.MySettings.Default.ScannerType
        '
        'txtUserName
        '
        Me.txtUserName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CardScanToSugar.My.MySettings.Default, "SugarUserName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtUserName.Location = New System.Drawing.Point(108, 31)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(352, 20)
        Me.txtUserName.TabIndex = 3
        Me.txtUserName.Text = Global.CardScanToSugar.My.MySettings.Default.SugarUserName
        '
        'txtSugarURL
        '
        Me.txtSugarURL.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.CardScanToSugar.My.MySettings.Default, "SugarURL", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtSugarURL.Location = New System.Drawing.Point(108, 13)
        Me.txtSugarURL.Name = "txtSugarURL"
        Me.txtSugarURL.Size = New System.Drawing.Size(352, 20)
        Me.txtSugarURL.TabIndex = 1
        Me.txtSugarURL.Tag = "http://server/soap.php"
        Me.txtSugarURL.Text = Global.CardScanToSugar.My.MySettings.Default.SugarURL
        '
        'config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(472, 137)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbScanner)
        Me.Controls.Add(Me.lblScanner)
        Me.Controls.Add(Me.btnSaveConfig)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtSugarURL)
        Me.Controls.Add(Me.lblSugarURL)
        Me.Name = "config"
        Me.Text = "config"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSugarURL As System.Windows.Forms.Label
    Friend WithEvents txtSugarURL As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveConfig As System.Windows.Forms.Button
    Friend WithEvents lblScanner As System.Windows.Forms.Label
    Friend WithEvents cmbScanner As System.Windows.Forms.ComboBox
End Class
