Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility
Module Main_Program
    '
    '   sdkdemo.bas
    '
    '   Copyright (c) 1997-2007, CardScan, Cambridge, MA
    '   All rights reserved


    '   Windows API declarations

    Public Declare Function IsWindowEnabled Lib "user32" (ByVal hWnd As Integer) As Integer

    '   Project global variables

    Public frmMain As frmMain ' the main form
    Public ProgressCanceled As Boolean 'user clicked cancel button in progress window
    Public fAutoScanEnabled As Boolean
    Public fImageType As Short

    Public Const MAX_FIELDS As Short = 22
    Public fFields(MAX_FIELDS) As String

    '   Global Constants

    Public Const AUTO_SCAN_INTERVAL As Short = 1000
    Public Const IMAGE_TYPE_UNKNOWN As Short = 0 ' image type unknown
    Public Const IMAGE_TYPE_BW As Short = 1 ' black & white (1-bit) image
    Public Const IMAGE_TYPE_GRAY As Short = 2 ' color or grayscale image

    '   Module constants

    Const strSDKImageFileFilter As String = "CardScan Images (*.csi)|*.csi|All Files (*.*)|*.*"
    Const strBMPImageFileFilter As String = "Windows Bitmnap (*.bmp)|*.bmp|All Files (*.*)|*.*"
    Const strImportImageFilter As String = "Bitmnap Files (*.bmp)|*.bmp|All Files (*.*)|*.*"

    '   Main entry point

    Public Sub Main()

        '   Initialize the SDK and show the main form

        If (InitLibrary()) Then
            frmMain = New frmMain
            System.Windows.Forms.Application.Run(frmMain)
        End If

    End Sub

    '   Initialize the main form

    Sub OnInit(ByVal fm As frmMain)
        frmMain = fm


        '   Initialize the timer and the global flag for "Detect cards automatically"

        fAutoScanEnabled = False

        '   Initialize image type

        fImageType = IMAGE_TYPE_UNKNOWN

        '   Initialize array of card fields

        fFields(1) = CRTK_FIELD_NAME
        fFields(2) = CRTK_FIELD_NAME_PREFIX
        fFields(3) = CRTK_FIELD_FIRST_NAME
        fFields(4) = CRTK_FIELD_MIDDLE_NAME
        fFields(5) = CRTK_FIELD_LAST_NAME
        fFields(6) = CRTK_FIELD_NAME_SUFFIX
        fFields(7) = CRTK_FIELD_TITLE
        fFields(8) = CRTK_FIELD_COMPANY
        fFields(9) = CRTK_FIELD_ADDRESS
        fFields(10) = CRTK_FIELD_STREET
        fFields(11) = CRTK_FIELD_ADDR1
        fFields(12) = CRTK_FIELD_ADDR2
        fFields(13) = CRTK_FIELD_ADDR3
        fFields(14) = CRTK_FIELD_CITY
        fFields(15) = CRTK_FIELD_STATE
        fFields(16) = CRTK_FIELD_POSTAL_CODE
        fFields(17) = CRTK_FIELD_PHONE
        fFields(18) = CRTK_FIELD_FAX
        fFields(19) = CRTK_FIELD_EMAIL
        fFields(20) = CRTK_FIELD_WEB_SITE
        fFields(21) = CRTK_FIELD_OTHER
        fFields(22) = CRTK_FIELD_2ND_ADDRESS
        fFields(23) = CRTK_PHONE_DIRECT
        fFields(24) = CRTK_PHONE_MOBILE

    End Sub

    '   Check for a card in the scanner

    Function OnCheckForCard() As Boolean
        Dim hasCard As Boolean

        If (CheckForCard(hasCard)) Then
            If (hasCard) Then
                Return True
            Else
                Return False
            End If
        End If

    End Function

    '   Calibrate and configure the scanner

    Sub OnConfigure()
        Call ConfigureScanner()
    End Sub

    '   Display custom scanner setup dialog

    Sub OnCustom()
        '     CustomDialog.DefInstance.ShowDialog()
    End Sub

    '   Scan a business card

    Sub OnAcquireImage()

        If (AcquireImage()) Then
            fImageType = IMAGE_TYPE_UNKNOWN
            '           Call DisplayImage()
            Call ClearResults()
            Call OnConvertImage()
        End If

    End Sub

    '   Prepare the image in memory for OCR

    Sub OnConvertImage()

        If (ConvertImage()) Then
            fImageType = IMAGE_TYPE_BW
            Call OnRecognize()
        End If

    End Sub

    '   Save the image in memory to a public-domain file format


    '   Discard the image in memory

    Sub OnDestroyImage()

        If (DestroyImage()) Then
            fImageType = IMAGE_TYPE_UNKNOWN
            Call DisplayImage()
            Call ClearResults()
        End If

    End Sub

    '   Perform OCR on the image in memory

    Sub OnRecognize()
        Dim result As Integer
        'AddHandler a, AddressOf ShowProgress


        ProgressCanceled = False
        result = CRTK_Recognize(hRTK, AddressOf ShowProgress, 0) 'Recognize the text
        If (CheckStatus(result, "CRTK_Recognize")) Then
            '            Call DisplayImage() ' show the final image
            Call DisplayResults()

        End If
        '        frmMain.SSTabImageNotes.Enabled = True
    End Sub

    '   Display the image in memory and update the menus to
    '   reflects the state of affairs.

    Sub DisplayImage()
        Dim tempFile As String
        Dim fs As System.IO.FileStream

        '       frmMain.SSTabImageNotes.Enabled = False
        With frmMain
            '   Export the image to a .BMP file
            tempFile = "~display.bmp"
            If (ExportImage(tempFile)) Then

  
  
                '   Discard the temporary file

                Call Kill(tempFile)

                '   Check for a monochrome image and enable/disable the
                '   Convert and Recognize functions

  
            Else

            End If

        End With

    End Sub

    '   Display the OCR results

    Sub DisplayResults()

        With frmMain

            '   Populate the text fields with the OCR results

            .txtFirstName.Text = GetText(CRTK_FIELD_FIRST_NAME)
            .txtLastName.Text = GetText(CRTK_FIELD_LAST_NAME)
            .txtAddress1.Text = GetText(CRTK_FIELD_ADDR1)
            .txtAddress2.Text = GetText(CRTK_FIELD_ADDR2)
            .txtCity.Text = GetText(CRTK_FIELD_CITY)
            .txtState.Text = GetText(CRTK_FIELD_STATE)
            .txtPostal.Text = GetText(CRTK_FIELD_POSTAL_CODE)
            .txtOther.Text = GetText(CRTK_FIELD_OTHER)
            .txtTitle.Text = GetText(CRTK_FIELD_TITLE)
            .txtCompany.Text = GetText(CRTK_FIELD_COMPANY)
            .txtPhone.Text = GetText(CRTK_FIELD_PHONE)
            .txtDirect.Text = GetText(CRTK_PHONE_DIRECT)
            .txtMobile.Text = GetText(CRTK_PHONE_MOBILE)
            .txtFax.Text = GetText(CRTK_FIELD_FAX)
            .txtEmail.Text = GetText(CRTK_FIELD_EMAIL)
            .txtWWW.Text = GetText(CRTK_FIELD_WEB_SITE)
            .txt2ndAddr.Text = GetText(CRTK_FIELD_2ND_ADDRESS)

            '   Enable the Results tab a bring it to the front

  
        End With

    End Sub

    '   Clear the OCR results

    Sub ClearResults()
        Dim i As Short

        '   Clear all the text fields on the form

        For i = 0 To frmMain.Controls.Count() - 1
            If TypeOf frmMain.Controls(i) Is System.Windows.Forms.TextBox Then
                frmMain.Controls(i).Text = ""
            End If
        Next

        '   Disable the Results tab

  
    End Sub

    '   Display OCR progress

    Function ShowProgress(ByVal percent As Short, ByRef data As Integer) As Integer 'Short sbh
        '   Update progress bar

        With ProgressDialog
            .Show()
            .ProgressBar1.Visible = True
            .ProgressBar1.Value = percent
            .lblPercent.Text = "Reading image ... " & percent & "%"
            .Refresh()
        End With

        '   Process events so user can click Cancel

        System.Windows.Forms.Application.DoEvents()

        '   Last time through, hide the dialog. Otherwise,
        '   check if the user canceled the dialog.

        If percent = 100 Then
            ProgressDialog.Hide()
        ElseIf ProgressCanceled Then
            ProgressDialog.Hide()
            ' return non-zero to abort operation
            ShowProgress = 1
        Else
            ' return zero to continue operation
            ShowProgress = 0
        End If

    End Function

    '   Test whether a card image is monochrome (gray-scale) or binary

    Function IsMonochromeImage() As Boolean

        Dim result As Short
        Dim tempFile As String

        '   If image type is not known, try to convert the image. If the convert
        '   fails, assume it's a monochrome image

        If fImageType = IMAGE_TYPE_UNKNOWN Then

            '   Save the image to a temporay file

            tempFile = "~temp.csi"
            If SaveImage(tempFile) Then

                '   Convert the image. If the convert fails, assume
                '   it's a monochrome image

                result = CRTK_ImageConvert(hRTK, 0, 0)
                If result <> CRTK_SUCCESS Then
                    fImageType = IMAGE_TYPE_BW
                Else
                    fImageType = IMAGE_TYPE_GRAY
                    '   Restore the orginal image
                    Call LoadImage(tempFile)
                End If

                '   Discard the temporary file

                Call Kill(tempFile)
            End If
        End If

        If fImageType = IMAGE_TYPE_BW Then
            IsMonochromeImage = True
        Else
            IsMonochromeImage = False
        End If

    End Function

    '   Right justify number using Format()

    Function rFormat(ByRef value As Object, ByRef fmt As String) As Object
        rFormat = VB6.Format(VB6.Format(value, fmt), New String("@", Len(fmt)))
    End Function

    '   Exit the main form

    Function OnExit() As Boolean

        '   Terminate the library

        Call TermLibrary()
        OnExit = True

    End Function
End Module