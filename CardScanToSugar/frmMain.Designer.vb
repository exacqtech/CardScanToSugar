<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblAddress1 = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblState = New System.Windows.Forms.Label
        Me.lblPostal = New System.Windows.Forms.Label
        Me.lblCountry = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblOther = New System.Windows.Forms.Label
        Me.lblCompany = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblFax = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblWWW = New System.Windows.Forms.Label
        Me.lbl2ndAddr = New System.Windows.Forms.Label
        Me.frmName = New System.Windows.Forms.GroupBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.lblFirst = New System.Windows.Forms.Label
        Me.lblLast = New System.Windows.Forms.Label
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtPostal = New System.Windows.Forms.TextBox
        Me.txtCountry = New System.Windows.Forms.TextBox
        Me.txtOther = New System.Windows.Forms.TextBox
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtWWW = New System.Windows.Forms.TextBox
        Me.txt2ndAddr = New System.Windows.Forms.TextBox
        Me.btnScanCard = New System.Windows.Forms.Button
        Me.lblMobile = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.lblDirect = New System.Windows.Forms.Label
        Me.txtDirect = New System.Windows.Forms.TextBox
        Me.btnSendToSugar = New System.Windows.Forms.Button
        Me.cmbSugarAccount = New System.Windows.Forms.ComboBox
        Me.btnCheckSugar = New System.Windows.Forms.Button
        Me.cmbSugarContact = New System.Windows.Forms.ComboBox
        Me.pboxSugarLogo = New System.Windows.Forms.PictureBox
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.frmName.SuspendLayout()
        CType(Me.pboxSugarLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAddress1
        '
        Me.lblAddress1.BackColor = System.Drawing.SystemColors.Control
        Me.lblAddress1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAddress1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAddress1.Location = New System.Drawing.Point(20, 76)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAddress1.Size = New System.Drawing.Size(49, 17)
        Me.lblAddress1.TabIndex = 50
        Me.lblAddress1.Text = "&Address:"
        '
        'lblCity
        '
        Me.lblCity.BackColor = System.Drawing.SystemColors.Control
        Me.lblCity.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCity.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCity.Location = New System.Drawing.Point(20, 124)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCity.Size = New System.Drawing.Size(41, 17)
        Me.lblCity.TabIndex = 51
        Me.lblCity.Text = "&City:"
        '
        'lblState
        '
        Me.lblState.BackColor = System.Drawing.SystemColors.Control
        Me.lblState.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblState.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblState.Location = New System.Drawing.Point(20, 148)
        Me.lblState.Name = "lblState"
        Me.lblState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblState.Size = New System.Drawing.Size(49, 17)
        Me.lblState.TabIndex = 52
        Me.lblState.Text = "&State:"
        '
        'lblPostal
        '
        Me.lblPostal.BackColor = System.Drawing.SystemColors.Control
        Me.lblPostal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPostal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPostal.Location = New System.Drawing.Point(20, 172)
        Me.lblPostal.Name = "lblPostal"
        Me.lblPostal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPostal.Size = New System.Drawing.Size(49, 17)
        Me.lblPostal.TabIndex = 53
        Me.lblPostal.Text = "&Postal:"
        '
        'lblCountry
        '
        Me.lblCountry.BackColor = System.Drawing.SystemColors.Control
        Me.lblCountry.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCountry.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCountry.Location = New System.Drawing.Point(20, 196)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCountry.Size = New System.Drawing.Size(48, 17)
        Me.lblCountry.TabIndex = 54
        Me.lblCountry.Text = "&Country:"
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.SystemColors.Control
        Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTitle.Location = New System.Drawing.Point(260, 76)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTitle.Size = New System.Drawing.Size(33, 17)
        Me.lblTitle.TabIndex = 55
        Me.lblTitle.Text = "T&itle:"
        '
        'lblOther
        '
        Me.lblOther.BackColor = System.Drawing.SystemColors.Control
        Me.lblOther.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblOther.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOther.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblOther.Location = New System.Drawing.Point(20, 284)
        Me.lblOther.Name = "lblOther"
        Me.lblOther.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblOther.Size = New System.Drawing.Size(42, 17)
        Me.lblOther.TabIndex = 56
        Me.lblOther.Text = "&Other:"
        '
        'lblCompany
        '
        Me.lblCompany.BackColor = System.Drawing.SystemColors.Control
        Me.lblCompany.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCompany.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblCompany.Location = New System.Drawing.Point(260, 100)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCompany.Size = New System.Drawing.Size(56, 17)
        Me.lblCompany.TabIndex = 57
        Me.lblCompany.Text = "Compa&ny:"
        '
        'lblPhone
        '
        Me.lblPhone.BackColor = System.Drawing.SystemColors.Control
        Me.lblPhone.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPhone.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPhone.Location = New System.Drawing.Point(260, 124)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPhone.Size = New System.Drawing.Size(40, 17)
        Me.lblPhone.TabIndex = 58
        Me.lblPhone.Text = "Office:"
        '
        'lblFax
        '
        Me.lblFax.BackColor = System.Drawing.SystemColors.Control
        Me.lblFax.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFax.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFax.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFax.Location = New System.Drawing.Point(260, 199)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFax.Size = New System.Drawing.Size(33, 17)
        Me.lblFax.TabIndex = 59
        Me.lblFax.Text = "Fa&x:"
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.SystemColors.Control
        Me.lblEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEmail.Location = New System.Drawing.Point(260, 236)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEmail.Size = New System.Drawing.Size(40, 17)
        Me.lblEmail.TabIndex = 60
        Me.lblEmail.Text = "&E-mail:"
        '
        'lblWWW
        '
        Me.lblWWW.BackColor = System.Drawing.SystemColors.Control
        Me.lblWWW.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWWW.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWWW.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWWW.Location = New System.Drawing.Point(260, 260)
        Me.lblWWW.Name = "lblWWW"
        Me.lblWWW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWWW.Size = New System.Drawing.Size(40, 17)
        Me.lblWWW.TabIndex = 61
        Me.lblWWW.Text = "&WWW:"
        '
        'lbl2ndAddr
        '
        Me.lbl2ndAddr.BackColor = System.Drawing.SystemColors.Control
        Me.lbl2ndAddr.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbl2ndAddr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2ndAddr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl2ndAddr.Location = New System.Drawing.Point(12, 340)
        Me.lbl2ndAddr.Name = "lbl2ndAddr"
        Me.lbl2ndAddr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbl2ndAddr.Size = New System.Drawing.Size(56, 17)
        Me.lbl2ndAddr.TabIndex = 62
        Me.lbl2ndAddr.Text = "&2nd Addr:"
        '
        'frmName
        '
        Me.frmName.BackColor = System.Drawing.SystemColors.Control
        Me.frmName.Controls.Add(Me.txtFirstName)
        Me.frmName.Controls.Add(Me.txtLastName)
        Me.frmName.Controls.Add(Me.lblFirst)
        Me.frmName.Controls.Add(Me.lblLast)
        Me.frmName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frmName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frmName.Location = New System.Drawing.Point(12, 24)
        Me.frmName.Name = "frmName"
        Me.frmName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.frmName.Size = New System.Drawing.Size(497, 48)
        Me.frmName.TabIndex = 36
        Me.frmName.TabStop = False
        Me.frmName.Text = "Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.AcceptsReturn = True
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFirstName.Location = New System.Drawing.Point(56, 16)
        Me.txtFirstName.MaxLength = 0
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFirstName.Size = New System.Drawing.Size(184, 20)
        Me.txtFirstName.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.AcceptsReturn = True
        Me.txtLastName.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLastName.Location = New System.Drawing.Point(304, 16)
        Me.txtLastName.MaxLength = 0
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLastName.Size = New System.Drawing.Size(189, 20)
        Me.txtLastName.TabIndex = 2
        '
        'lblFirst
        '
        Me.lblFirst.BackColor = System.Drawing.SystemColors.Control
        Me.lblFirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblFirst.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFirst.Location = New System.Drawing.Point(8, 16)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFirst.Size = New System.Drawing.Size(33, 17)
        Me.lblFirst.TabIndex = 7
        Me.lblFirst.Text = "&First:"
        '
        'lblLast
        '
        Me.lblLast.BackColor = System.Drawing.SystemColors.Control
        Me.lblLast.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblLast.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLast.Location = New System.Drawing.Point(248, 16)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblLast.Size = New System.Drawing.Size(32, 17)
        Me.lblLast.TabIndex = 5
        Me.lblLast.Text = "&Last:"
        '
        'txtAddress1
        '
        Me.txtAddress1.AcceptsReturn = True
        Me.txtAddress1.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddress1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddress1.Location = New System.Drawing.Point(68, 76)
        Me.txtAddress1.MaxLength = 0
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAddress1.Size = New System.Drawing.Size(184, 20)
        Me.txtAddress1.TabIndex = 37
        '
        'txtAddress2
        '
        Me.txtAddress2.AcceptsReturn = True
        Me.txtAddress2.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddress2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddress2.Location = New System.Drawing.Point(68, 100)
        Me.txtAddress2.MaxLength = 0
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAddress2.Size = New System.Drawing.Size(184, 20)
        Me.txtAddress2.TabIndex = 38
        '
        'txtCity
        '
        Me.txtCity.AcceptsReturn = True
        Me.txtCity.BackColor = System.Drawing.SystemColors.Window
        Me.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCity.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCity.Location = New System.Drawing.Point(68, 124)
        Me.txtCity.MaxLength = 0
        Me.txtCity.Name = "txtCity"
        Me.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCity.Size = New System.Drawing.Size(184, 20)
        Me.txtCity.TabIndex = 39
        '
        'txtState
        '
        Me.txtState.AcceptsReturn = True
        Me.txtState.BackColor = System.Drawing.SystemColors.Window
        Me.txtState.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtState.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtState.Location = New System.Drawing.Point(68, 148)
        Me.txtState.MaxLength = 0
        Me.txtState.Name = "txtState"
        Me.txtState.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtState.Size = New System.Drawing.Size(184, 20)
        Me.txtState.TabIndex = 40
        '
        'txtPostal
        '
        Me.txtPostal.AcceptsReturn = True
        Me.txtPostal.BackColor = System.Drawing.SystemColors.Window
        Me.txtPostal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPostal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPostal.Location = New System.Drawing.Point(68, 172)
        Me.txtPostal.MaxLength = 0
        Me.txtPostal.Name = "txtPostal"
        Me.txtPostal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPostal.Size = New System.Drawing.Size(184, 20)
        Me.txtPostal.TabIndex = 41
        '
        'txtCountry
        '
        Me.txtCountry.AcceptsReturn = True
        Me.txtCountry.BackColor = System.Drawing.SystemColors.Window
        Me.txtCountry.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCountry.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCountry.Location = New System.Drawing.Point(68, 196)
        Me.txtCountry.MaxLength = 0
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCountry.Size = New System.Drawing.Size(184, 20)
        Me.txtCountry.TabIndex = 42
        '
        'txtOther
        '
        Me.txtOther.AcceptsReturn = True
        Me.txtOther.BackColor = System.Drawing.SystemColors.Window
        Me.txtOther.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOther.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOther.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOther.Location = New System.Drawing.Point(68, 284)
        Me.txtOther.MaxLength = 0
        Me.txtOther.Multiline = True
        Me.txtOther.Name = "txtOther"
        Me.txtOther.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtOther.Size = New System.Drawing.Size(433, 49)
        Me.txtOther.TabIndex = 43
        '
        'txtTitle
        '
        Me.txtTitle.AcceptsReturn = True
        Me.txtTitle.BackColor = System.Drawing.SystemColors.Window
        Me.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTitle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTitle.Location = New System.Drawing.Point(316, 76)
        Me.txtTitle.MaxLength = 0
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTitle.Size = New System.Drawing.Size(189, 20)
        Me.txtTitle.TabIndex = 44
        '
        'txtCompany
        '
        Me.txtCompany.AcceptsReturn = True
        Me.txtCompany.BackColor = System.Drawing.SystemColors.Window
        Me.txtCompany.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCompany.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompany.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCompany.Location = New System.Drawing.Point(316, 100)
        Me.txtCompany.MaxLength = 0
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCompany.Size = New System.Drawing.Size(189, 20)
        Me.txtCompany.TabIndex = 45
        '
        'txtPhone
        '
        Me.txtPhone.AcceptsReturn = True
        Me.txtPhone.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPhone.Location = New System.Drawing.Point(316, 124)
        Me.txtPhone.MaxLength = 0
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPhone.Size = New System.Drawing.Size(189, 20)
        Me.txtPhone.TabIndex = 46
        '
        'txtFax
        '
        Me.txtFax.AcceptsReturn = True
        Me.txtFax.BackColor = System.Drawing.SystemColors.Window
        Me.txtFax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFax.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFax.Location = New System.Drawing.Point(316, 196)
        Me.txtFax.MaxLength = 0
        Me.txtFax.Name = "txtFax"
        Me.txtFax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFax.Size = New System.Drawing.Size(189, 20)
        Me.txtFax.TabIndex = 47
        '
        'txtEmail
        '
        Me.txtEmail.AcceptsReturn = True
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtEmail.Location = New System.Drawing.Point(316, 236)
        Me.txtEmail.MaxLength = 0
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtEmail.Size = New System.Drawing.Size(189, 20)
        Me.txtEmail.TabIndex = 48
        '
        'txtWWW
        '
        Me.txtWWW.AcceptsReturn = True
        Me.txtWWW.BackColor = System.Drawing.SystemColors.Window
        Me.txtWWW.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWWW.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWWW.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWWW.Location = New System.Drawing.Point(316, 260)
        Me.txtWWW.MaxLength = 0
        Me.txtWWW.Name = "txtWWW"
        Me.txtWWW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtWWW.Size = New System.Drawing.Size(189, 20)
        Me.txtWWW.TabIndex = 49
        '
        'txt2ndAddr
        '
        Me.txt2ndAddr.AcceptsReturn = True
        Me.txt2ndAddr.BackColor = System.Drawing.SystemColors.Window
        Me.txt2ndAddr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt2ndAddr.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2ndAddr.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt2ndAddr.Location = New System.Drawing.Point(68, 340)
        Me.txt2ndAddr.MaxLength = 0
        Me.txt2ndAddr.Multiline = True
        Me.txt2ndAddr.Name = "txt2ndAddr"
        Me.txt2ndAddr.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt2ndAddr.Size = New System.Drawing.Size(433, 49)
        Me.txt2ndAddr.TabIndex = 63
        '
        'btnScanCard
        '
        Me.btnScanCard.Location = New System.Drawing.Point(68, 395)
        Me.btnScanCard.Name = "btnScanCard"
        Me.btnScanCard.Size = New System.Drawing.Size(75, 23)
        Me.btnScanCard.TabIndex = 64
        Me.btnScanCard.Text = "Scan Card"
        Me.btnScanCard.UseVisualStyleBackColor = True
        '
        'lblMobile
        '
        Me.lblMobile.BackColor = System.Drawing.SystemColors.Control
        Me.lblMobile.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblMobile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMobile.Location = New System.Drawing.Point(260, 151)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblMobile.Size = New System.Drawing.Size(40, 17)
        Me.lblMobile.TabIndex = 66
        Me.lblMobile.Text = "Mobile:"
        '
        'txtMobile
        '
        Me.txtMobile.AcceptsReturn = True
        Me.txtMobile.BackColor = System.Drawing.SystemColors.Window
        Me.txtMobile.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMobile.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobile.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMobile.Location = New System.Drawing.Point(316, 151)
        Me.txtMobile.MaxLength = 0
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMobile.Size = New System.Drawing.Size(189, 20)
        Me.txtMobile.TabIndex = 65
        '
        'lblDirect
        '
        Me.lblDirect.BackColor = System.Drawing.SystemColors.Control
        Me.lblDirect.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDirect.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDirect.Location = New System.Drawing.Point(260, 172)
        Me.lblDirect.Name = "lblDirect"
        Me.lblDirect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDirect.Size = New System.Drawing.Size(40, 17)
        Me.lblDirect.TabIndex = 68
        Me.lblDirect.Text = "Direct:"
        '
        'txtDirect
        '
        Me.txtDirect.AcceptsReturn = True
        Me.txtDirect.BackColor = System.Drawing.SystemColors.Window
        Me.txtDirect.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDirect.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirect.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDirect.Location = New System.Drawing.Point(316, 172)
        Me.txtDirect.MaxLength = 0
        Me.txtDirect.Name = "txtDirect"
        Me.txtDirect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDirect.Size = New System.Drawing.Size(189, 20)
        Me.txtDirect.TabIndex = 67
        '
        'btnSendToSugar
        '
        Me.btnSendToSugar.Enabled = False
        Me.btnSendToSugar.Location = New System.Drawing.Point(287, 396)
        Me.btnSendToSugar.Name = "btnSendToSugar"
        Me.btnSendToSugar.Size = New System.Drawing.Size(88, 23)
        Me.btnSendToSugar.TabIndex = 69
        Me.btnSendToSugar.Text = "Send To Sugar"
        Me.btnSendToSugar.UseVisualStyleBackColor = True
        '
        'cmbSugarAccount
        '
        Me.cmbSugarAccount.FormattingEnabled = True
        Me.cmbSugarAccount.Location = New System.Drawing.Point(511, 100)
        Me.cmbSugarAccount.Name = "cmbSugarAccount"
        Me.cmbSugarAccount.Size = New System.Drawing.Size(177, 21)
        Me.cmbSugarAccount.TabIndex = 70
        '
        'btnCheckSugar
        '
        Me.btnCheckSugar.Location = New System.Drawing.Point(177, 395)
        Me.btnCheckSugar.Name = "btnCheckSugar"
        Me.btnCheckSugar.Size = New System.Drawing.Size(87, 23)
        Me.btnCheckSugar.TabIndex = 71
        Me.btnCheckSugar.Text = "Check Sugar"
        Me.btnCheckSugar.UseVisualStyleBackColor = True
        '
        'cmbSugarContact
        '
        Me.cmbSugarContact.FormattingEnabled = True
        Me.cmbSugarContact.Location = New System.Drawing.Point(515, 40)
        Me.cmbSugarContact.Name = "cmbSugarContact"
        Me.cmbSugarContact.Size = New System.Drawing.Size(177, 21)
        Me.cmbSugarContact.TabIndex = 72
        '
        'pboxSugarLogo
        '
        Me.pboxSugarLogo.Location = New System.Drawing.Point(551, 150)
        Me.pboxSugarLogo.Name = "pboxSugarLogo"
        Me.pboxSugarLogo.Size = New System.Drawing.Size(103, 103)
        Me.pboxSugarLogo.TabIndex = 73
        Me.pboxSugarLogo.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfigToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(709, 24)
        Me.MenuStrip1.TabIndex = 74
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConfigToolStripMenuItem
        '
        Me.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem"
        Me.ConfigToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ConfigToolStripMenuItem.Text = "Config"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 443)
        Me.Controls.Add(Me.pboxSugarLogo)
        Me.Controls.Add(Me.cmbSugarContact)
        Me.Controls.Add(Me.btnCheckSugar)
        Me.Controls.Add(Me.cmbSugarAccount)
        Me.Controls.Add(Me.btnSendToSugar)
        Me.Controls.Add(Me.lblDirect)
        Me.Controls.Add(Me.txtDirect)
        Me.Controls.Add(Me.lblMobile)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.btnScanCard)
        Me.Controls.Add(Me.lblAddress1)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.lblPostal)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblOther)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblFax)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblWWW)
        Me.Controls.Add(Me.lbl2ndAddr)
        Me.Controls.Add(Me.frmName)
        Me.Controls.Add(Me.txtAddress1)
        Me.Controls.Add(Me.txtAddress2)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtPostal)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.txtOther)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtWWW)
        Me.Controls.Add(Me.txt2ndAddr)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "CardScan to SugarCRM"
        Me.frmName.ResumeLayout(False)
        Me.frmName.PerformLayout()
        CType(Me.pboxSugarLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lblAddress1 As System.Windows.Forms.Label
    Public WithEvents lblCity As System.Windows.Forms.Label
    Public WithEvents lblState As System.Windows.Forms.Label
    Public WithEvents lblPostal As System.Windows.Forms.Label
    Public WithEvents lblCountry As System.Windows.Forms.Label
    Public WithEvents lblTitle As System.Windows.Forms.Label
    Public WithEvents lblOther As System.Windows.Forms.Label
    Public WithEvents lblCompany As System.Windows.Forms.Label
    Public WithEvents lblPhone As System.Windows.Forms.Label
    Public WithEvents lblFax As System.Windows.Forms.Label
    Public WithEvents lblEmail As System.Windows.Forms.Label
    Public WithEvents lblWWW As System.Windows.Forms.Label
    Public WithEvents lbl2ndAddr As System.Windows.Forms.Label
    Public WithEvents frmName As System.Windows.Forms.GroupBox
    Public WithEvents txtFirstName As System.Windows.Forms.TextBox
    Public WithEvents txtLastName As System.Windows.Forms.TextBox
    Public WithEvents lblFirst As System.Windows.Forms.Label
    Public WithEvents lblLast As System.Windows.Forms.Label
    Public WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Public WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Public WithEvents txtCity As System.Windows.Forms.TextBox
    Public WithEvents txtState As System.Windows.Forms.TextBox
    Public WithEvents txtPostal As System.Windows.Forms.TextBox
    Public WithEvents txtCountry As System.Windows.Forms.TextBox
    Public WithEvents txtOther As System.Windows.Forms.TextBox
    Public WithEvents txtTitle As System.Windows.Forms.TextBox
    Public WithEvents txtCompany As System.Windows.Forms.TextBox
    Public WithEvents txtPhone As System.Windows.Forms.TextBox
    Public WithEvents txtFax As System.Windows.Forms.TextBox
    Public WithEvents txtEmail As System.Windows.Forms.TextBox
    Public WithEvents txtWWW As System.Windows.Forms.TextBox
    Public WithEvents txt2ndAddr As System.Windows.Forms.TextBox
    Friend WithEvents btnScanCard As System.Windows.Forms.Button
    Public WithEvents lblMobile As System.Windows.Forms.Label
    Public WithEvents txtMobile As System.Windows.Forms.TextBox
    Public WithEvents lblDirect As System.Windows.Forms.Label
    Public WithEvents txtDirect As System.Windows.Forms.TextBox
    Friend WithEvents btnSendToSugar As System.Windows.Forms.Button
    Friend WithEvents cmbSugarAccount As System.Windows.Forms.ComboBox
    Friend WithEvents btnCheckSugar As System.Windows.Forms.Button
    Friend WithEvents cmbSugarContact As System.Windows.Forms.ComboBox
    Friend WithEvents pboxSugarLogo As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConfigToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
