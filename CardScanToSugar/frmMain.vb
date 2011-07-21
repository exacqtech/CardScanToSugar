

Public Class frmMain

    Private Sub FrmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.ScannerType.Length < 1 Then
            Dim c As New config
            c.ShowDialog()

        End If
        Dim result As Integer

        result = CRTK_Init(hRTK)
        CheckStatus(result, "CRTK_Init")
        Call OnInit(Me)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScanCard.Click
        
        SetScannerParam(CRTK_PARAM_SCANNER_MODEL, My.Settings.ScannerType)
        SetScannerParam(CRTK_PARAM_COLOR_MODE, CRTK_VALUE_COLOR_MODE_MONOCHROME)
        Call ClearResults()
        If OnCheckForCard() Then
            Call OnAcquireImage()
            btnCheckSugar.Enabled = True
            '      btnCheckSugar.PerformClick()
        Else
            MessageBox.Show("Please Insert A Card Into The Scanner and Try Again")
            btnSendToSugar.Enabled = False
            btnCheckSugar.Enabled = False
        End If

    End Sub
    Public Sub loadFromSugar(ByVal account_list As SugarCRM.get_entry_list_result, ByVal contact_list As SugarCRM.get_entry_list_result)
        Dim cbItems As New ArrayList()
        If account_list.result_count > 0 Then
            Dim recAccount As SugarCRM.entry_value
            cmbSugarAccount.DataSource = Nothing
            For Each recAccount In account_list.entry_list
                cbItems.Add(New cValue(recAccount.name_value_list(1).value, recAccount.id))

            Next
        End If

        cbItems.Add(New cValue("Create New Record", "-1"))
        cmbSugarAccount.DataSource = cbItems
        cmbSugarAccount.DisplayMember = "Display"
        cmbSugarAccount.ValueMember = "Value"


        ' Clean Up and start on contacts
        Dim cmbContactItems As New ArrayList()
        cmbSugarContact.DataSource = Nothing

        If contact_list.entry_list.Length > 0 Then
            Dim recContact As New SugarCRM.entry_value
            cmbSugarContact.DataSource = Nothing
            cmbSugarContact.Items.Clear()
            For Each recContact In contact_list.entry_list
                cmbContactItems.Add(New cValue(recContact.name_value_list(0).value & " " & recContact.name_value_list(1).value & " - " & recContact.name_value_list(2).value, recContact.id))
                Dim nameVal As New SugarCRM.name_value
            Next
        End If

        cmbContactItems.Add(New cValue("Create New Record", "-1"))
        cmbSugarContact.DataSource = cmbContactItems
        cmbSugarContact.DisplayMember = "Display"
        cmbSugarContact.ValueMember = "Value"
        btnSendToSugar.Enabled = True
    End Sub
    Private Sub btnSendToSugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendToSugar.Click
        Dim sh As New SugarHelper
        sh.contact_id = CType(cmbSugarContact.SelectedItem, cValue).Value
        sh.account_id = CType(cmbSugarAccount.SelectedItem, cValue).Value
        'Map TextBoxes to class variables
        sh.address1 = txtAddress1.Text
        sh.address2 = txtAddress2.Text
        sh.city = txtCity.Text
        sh.company = txtCompany.Text
        sh.country = txtCountry.Text
        sh.Direct = txtDirect.Text
        sh.Email = txtEmail.Text
        sh.Fax = txtFax.Text
        sh.FirstName = txtFirstName.Text
        sh.LastName = txtLastName.Text
        sh.Mobile = txtMobile.Text
        sh.Phone = txtPhone.Text
        sh.postal = txtPostal.Text
        sh.state = txtState.Text
        sh.Title = txtTitle.Text
        sh.WWW = txtWWW.Text

        Dim t As System.Threading.Thread
        t = New System.Threading.Thread(AddressOf sh.sendToSugar)
        t.Start()
        Dim spinnerThread As Threading.Thread
        spinnerThread = New Threading.Thread(AddressOf sh.rotateLogo)
        spinnerThread.Start()
        While t.IsAlive
            pboxSugarLogo.Image = sh.currentImage
            pboxSugarLogo.Refresh()
        End While
        spinnerThread.Abort()
        ' Return the sugar logo is set to its inital, unrotated state
        pboxSugarLogo.Image = My.Resources.sugar0
        pboxSugarLogo.Image.Tag = "0"
        pboxSugarLogo.Refresh()
    End Sub

    Function loginToSugar(ByVal uname As String, ByVal pwHash As String, ByVal sugarClient As SugarCRM.sugarsoapPortTypeClient) As String

        Dim credentials As New SugarCRM.user_auth
        Dim newSession As New SugarCRM.set_entry_result
        credentials.user_name = uname
        credentials.password = pwHash
        credentials.version = "1"
        newSession = sugarClient.login(credentials, "CardScan to Sugar")
        If newSession.id <> "-1" Then
            Return newSession.id
        Else
            MessageBox.Show("Sugar Login Failed")
            Return "-1"
        End If
    End Function


    


    Private Sub btnCheckSugar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckSugar.Click
  
        ' Set up new thread to make the SOAP request
        Dim t As Threading.Thread
        ' Set up a new instance of the SugarHelper Class
        Dim sh As New SugarHelper
        ' Make Sure the sugar logo is set to its inital, unrotated state
        pboxSugarLogo.Image = My.Resources.sugar0
        pboxSugarLogo.Image.Tag = "0"
        pboxSugarLogo.Refresh()
        ' Set thread to perform login
        t = New Threading.Thread(AddressOf sh.doLogin)
        ' Start thread
        t.Start()
        ' Rotate SugarCRM logo while thread is active
        Dim spinnerThread As Threading.Thread
        spinnerThread = New Threading.Thread(AddressOf sh.rotateLogo)
        spinnerThread.Start()
        While t.IsAlive
            pboxSugarLogo.Image = sh.currentImage
            pboxSugarLogo.Refresh()
        End While
        spinnerThread.Abort()
        ' Return the sugar logo is set to its inital, unrotated state
        pboxSugarLogo.Image = My.Resources.sugar0
        pboxSugarLogo.Image.Tag = "0"
        pboxSugarLogo.Refresh()
        ' Continue if session is not equal to -1
        If sh.session <> "-1" Then
            sh.contact = txtEmail.Text
            sh.account = txtCompany.Text
            ' re-initialize thread and tie to get function
            t = New Threading.Thread(AddressOf sh.getFromSugar)
            t.Start()
            spinnerThread = New Threading.Thread(AddressOf sh.rotateLogo)
            spinnerThread.Start()
            While t.IsAlive
                pboxSugarLogo.Image = sh.currentImage
                pboxSugarLogo.Refresh()
            End While
            spinnerThread.Abort()
            loadFromSugar(sh.account_list, sh.contact_list)
            ' re-initialize thread and tie to logout function
            t = New Threading.Thread(AddressOf sh.logout)
            t.Start()
            ' Return the sugar logo is set to its inital, unrotated state
            pboxSugarLogo.Image = My.Resources.sugar0
            pboxSugarLogo.Image.Tag = "0"
            btnSendToSugar.Enabled = True
        Else
            MessageBox.Show("Login failure, please check your user name and password")
            Dim cfg As New config
            cfg.ShowDialog()
        End If
    End Sub



    Private Sub ConfigToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigToolStripMenuItem.Click
        Dim cfg As New config
        config.ShowDialog()
    End Sub
End Class



