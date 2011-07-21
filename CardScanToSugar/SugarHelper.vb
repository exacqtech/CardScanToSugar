Public Class SugarHelper

    ' set up variables 
    Public session As String
    Public contact As String
    Public account As String
    Public contact_id As String
    Public account_id As String
    Public sugarClient As New SugarCRM.sugarsoapPortTypeClient
    Public account_list As SugarCRM.get_entry_list_result
    Public contact_list As SugarCRM.get_entry_list_result
    Public currentImage As System.Drawing.Bitmap = My.Resources.sugar0
    ' Text Boxes
    Public company As String
    Public address1 As String
    Public address2 As String
    Public city As String
    Public state As String
    Public postal As String
    Public country As String
    Public WWW As String
    Public FirstName As String
    Public LastName As String
    Public Fax As String
    Public Phone As String
    Public Mobile As String
    Public Title As String
    Public Direct As String
    Public Email As String


    'Sub to set address for Service Reference
    Public Sub New()
        sugarClient.Endpoint.Address = New ServiceModel.EndpointAddress(My.Settings.SugarURL)
    End Sub

    ' Sub to login to sugar
    Public Sub doLogin()
        ' set up temporary variables
        Dim credentials As New SugarCRM.user_auth
        Dim newSession As New SugarCRM.set_entry_result
        ' set username and MD5 pass hash for user_auth
        credentials.user_name = My.Settings.SugarUserName
        credentials.password = My.Settings.PWHash
        credentials.version = "1"
        ' connect and attempt login
        newSession = sugarClient.login(credentials, "CardScan to Sugar")
        ' set session id, we check for -1 from the code calling doLogin()
        session = newSession.id
    End Sub

    Public Sub logout()
        sugarClient.logout(session)
    End Sub

    Public Sub getFromSugar()
        ' populate account_list with search results
        account_list = sugarClient.search_by_module(My.Settings.SugarUserName, My.Settings.PWHash, account, New String() {"Accounts"}, 0, 10)
        ' populate contact_list with search results (query from John Mertic example)
        contact_list = sugarClient.get_entry_list(session, "Contacts", "contacts.id in (Select eabr.bean_id FROM email_addr_bean_rel eabr JOIN email_addresses ea ON (ea.id = eabr.email_address_id) WHERE eabr.deleted=0 AND ea.email_address = '" & contact & "')", "", 0, New String() {"first_name", "last_name", "account_name"}, 1, 0)

    End Sub

    Public Sub sendToSugar()
        doLogin()
        If session <> "-1" Then
            ' We have a valid session number
            If account_id = "-1" Then
                ' Check if we should create or modify the account
                Dim accountInfo As New ArrayList
                Dim accountItem As SugarCRM.name_value
                accountItem = New SugarCRM.name_value
                accountItem.name = "name"
                accountItem.value = company
                accountInfo.Add(accountItem)
                accountItem = New SugarCRM.name_value
                accountItem.name = "billing_address_street"
                If address2.Trim.Length > 0 Then
                    accountItem.value = address1 & vbNewLine & address2
                Else
                    accountItem.value = address1
                End If
                accountInfo.Add(accountItem)
                accountItem = New SugarCRM.name_value
                accountItem.name = "billing_address_city"
                accountItem.value = city
                accountInfo.Add(accountItem)
                accountItem = New SugarCRM.name_value
                accountItem.name = "billing_address_state"
                accountItem.value = state
                accountInfo.Add(accountItem)
                accountItem = New SugarCRM.name_value
                accountItem.name = "billing_address_postalcode"
                accountItem.value = postal
                accountInfo.Add(accountItem)
                If country.Trim.Length > 1 Then
                    accountItem = New SugarCRM.name_value
                    accountItem.name = "billing_address_country"
                    accountItem.value = country
                    accountInfo.Add(accountItem)
                End If
                If WWW.Trim.Length > 1 Then
                    accountItem = New SugarCRM.name_value
                    accountItem.name = "website"
                    accountItem.value = WWW
                    accountInfo.Add(accountItem)
                End If
                Dim accountResult As SugarCRM.set_entry_result = sugarClient.set_entry(session, "Accounts", DirectCast(accountInfo.ToArray(GetType(SugarCRM.name_value)), SugarCRM.name_value()))
                If accountResult.id = "-1" Then
                    MessageBox.Show("Error Adding Account: " & accountResult.error.description)
                Else
                    account_id = accountResult.id
                End If

            End If



            ' Check if we should create or modify the contact

            If contact_id = "-1" Then
                Dim contactInfo As New ArrayList
                Dim contactItem As SugarCRM.name_value
                contactItem = New SugarCRM.name_value
                contactItem.name = "first_name"
                contactItem.value = FirstName
                contactInfo.Add(contactItem)
                contactItem = New SugarCRM.name_value
                contactItem.name = "last_name"
                contactItem.value = LastName
                contactInfo.Add(contactItem)
                contactItem = New SugarCRM.name_value
                contactItem.name = "primary_address_street"
                If address2.Trim.Length > 0 Then
                    contactItem.value = address1 & vbNewLine & address2
                Else
                    contactItem.value = address1
                End If
                contactInfo.Add(contactItem)
                contactItem = New SugarCRM.name_value
                contactItem.name = "primary_address_city"
                contactItem.value = city
                contactInfo.Add(contactItem)
                contactItem = New SugarCRM.name_value
                contactItem.name = "primary_address_state"
                contactItem.value = state
                contactInfo.Add(contactItem)
                contactItem = New SugarCRM.name_value
                contactItem.name = "primary_address_postalcode"
                contactItem.value = postal
                contactInfo.Add(contactItem)
                If country.Trim.Length > 1 Then
                    contactItem = New SugarCRM.name_value
                    contactItem.name = "billing_address_country"
                    contactItem.value = country
                    contactInfo.Add(contactItem)
                End If
                If Fax.Trim.Length > 1 Then
                    contactItem = New SugarCRM.name_value
                    contactItem.name = "phone_fax"
                    contactItem.value = Fax
                    contactInfo.Add(contactItem)
                End If
                If Phone.Trim.Length > 1 Then
                    contactItem = New SugarCRM.name_value
                    contactItem.name = "phone_work"
                    contactItem.value = Phone
                    contactInfo.Add(contactItem)
                End If
                If Mobile.Trim.Length > 1 Then
                    contactItem = New SugarCRM.name_value
                    contactItem.name = "phone_mobile"
                    contactItem.value = Mobile
                    contactInfo.Add(contactItem)
                End If
                If Direct.Trim.Length > 1 Then
                    contactItem = New SugarCRM.name_value
                    contactItem.name = "phone_other"
                    contactItem.value = Direct
                    contactInfo.Add(contactItem)
                End If
                If Email.Trim.Length > 1 Then
                    contactItem = New SugarCRM.name_value
                    contactItem.name = "email1"
                    contactItem.value = Email
                    contactInfo.Add(contactItem)
                End If
                If Title.Trim.Length > 1 Then
                    contactItem = New SugarCRM.name_value
                    contactItem.name = "title"
                    contactItem.value = Title
                    contactInfo.Add(contactItem)
                End If


                Dim contactResult As SugarCRM.set_entry_result = sugarClient.set_entry(session, "Accounts", DirectCast(contactInfo.ToArray(GetType(SugarCRM.name_value)), SugarCRM.name_value()))
                If contactResult.id = "-1" Then
                    MessageBox.Show("Error Adding Contact: " & contactResult.error.description)
                Else
                    contact_id = contactResult.id
                    MessageBox.Show("Record(s) Added")
                End If


            End If
            If account_id.Length > 1 And contact_id.Length > 1 Then
                Dim rv As New SugarCRM.set_relationship_value
                rv.module1 = "Accounts"
                rv.module1_id = account_id
                rv.module2 = "Contacts"
                rv.module2_id = contact_id
                sugarClient.set_relationship(session, rv)
            End If
        End If

        logout()
    End Sub

    Public Sub rotateLogo()
        While True

            If currentImage.Tag = "0" Or currentImage.Tag = "" Then
                currentImage = My.Resources.sugar90
                currentImage.Tag = "90"
            ElseIf currentImage.Tag = "90" Then
                currentImage = My.Resources.sugar180
                currentImage.Tag = "180"
            ElseIf currentImage.Tag = "180" Then
                currentImage = My.Resources.sugar270
                currentImage.Tag = "270"
            Else
                currentImage = My.Resources.sugar0
                currentImage.Tag = "0"
            End If
            Threading.Thread.Sleep(500)
        End While

    End Sub
End Class
