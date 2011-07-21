Public Class config

    Private Sub btnSaveConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveConfig.Click
        If txtPassword.Text.Trim.Length > 0 Then
            My.Settings.PWHash = MD5CalcString(txtPassword.Text)
        End If
        If txtUserName.Text.Trim.Length < 1 Then
            MessageBox.Show("Username required")
        ElseIf txtSugarURL.Text.Trim.Length < 1 Then
            MessageBox.Show("Sugar URL Required")
        Else
            Dim sh As New SugarHelper
            Try
                sh.doLogin()
                If (sh.session = "-1") Then
                    MessageBox.Show("Username/Password Error")
                Else
                    My.Settings.Save()
                    Me.Close()
                End If

            Catch ex As System.ServiceModel.EndpointNotFoundException
                MessageBox.Show("Sugar URL unreachable. Please check your settings")
            Catch ex As System.ServiceModel.ProtocolException
                MessageBox.Show("Invalid Sugar URL. Please check your settings")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try


        End If

    End Sub


    ' calculate the MD5 hash of a given string 
    ' the string is first converted to a byte array
    Public Function MD5CalcString(ByVal strData As String) As String

        Dim objMD5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim arrData() As Byte
        Dim arrHash() As Byte

        ' first convert the string to bytes (using UTF8 encoding for unicode characters)
        arrData = System.Text.Encoding.UTF8.GetBytes(strData)

        ' hash contents of this byte array
        arrHash = objMD5.ComputeHash(arrData)

        ' thanks objects
        objMD5 = Nothing

        ' return formatted hash
        Return ByteArrayToString(arrHash)

    End Function

    ' utility function to convert a byte array into a hex string
    Private Function ByteArrayToString(ByVal arrInput() As Byte) As String

        Dim strOutput As New System.Text.StringBuilder(arrInput.Length)

        For i As Integer = 0 To arrInput.Length - 1
            strOutput.Append(arrInput(i).ToString("X2"))
        Next

        Return strOutput.ToString().ToLower

    End Function


 
    Private Sub config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.ScannerType.Length < 1 Then
            cmbScanner.SelectedIndex = 0
        End If
    End Sub
End Class