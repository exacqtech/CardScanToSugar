Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility
Module SDK_Utility_Functions
    '
    '   SdkUtil.bas
    '
    '   Copyright (c) 1997-2007, CardScan, Cambridge, MA
    '   All rights reserved


    '   Declare global variables for SDK handles

    Public hRTK As Integer
    Public hRTKDB As Integer

    '   Declare Windows API functions used to convert the
    '   device-independent bitmap to an Image

    Declare Function CloseClipboard Lib "user32" () As Integer
    Declare Function OpenClipboard Lib "user32" (ByVal hWnd As Integer) As Integer
    Declare Function SetClipboardData Lib "user32" (ByVal wFormat As Integer, ByVal hMem As Integer) As Integer
    Declare Function GetClipboardData Lib "user32" (ByVal wFormat As Integer) As Integer
    Public Const CF_DIB As Short = 8

    '
    '   INITIALIZATION FUNCTIONS
    '

    '   Initialize the SDK library and register the client application.

    Public Function InitLibrary() As Boolean
        Dim result As Integer

        result = CRTK_Init(hRTK)
        InitLibrary = CheckStatus(result, "CRTK_Init")

    End Function

    '   Unregister the client application and close the library

    Public Function TermLibrary() As Boolean
        Dim result As Integer

        result = CRTK_Term(hRTK)
        TermLibrary = CheckStatus(result, "CRTK_Term")

    End Function

    '
    '   SCANNER FUNCTIONS
    '

    '   Scan a business card

    Public Function AcquireImage() As Boolean
        Dim result As Integer

        result = CRTK_ScanAcquire(hRTK, 5)
        AcquireImage = CheckStatus(result, "CRTK_ScanAcquire")

    End Function

    '   Check for a card in the scanner

    Public Function CheckForCard(ByRef hasCard As Boolean) As Boolean
        Dim result As Integer

        result = CRTK_ScanCheckForCard(hRTK)
        If result = CRTK_YES Then
            CheckForCard = True
            hasCard = True
        ElseIf result = CRTK_NO Then
            CheckForCard = True
            hasCard = False
        Else
            CheckForCard = CheckStatus(result, "CRTK_ScanCheckForCard")
        End If

    End Function

    '   Calibrate and configure the business card scanner

    Public Function ConfigureScanner() As Boolean
        Dim result As Integer

        result = CRTK_ScanConfigure(hRTK, 0)
        ConfigureScanner = CheckStatus(result, "CRTK_ScanConfigure")

    End Function

    '   Calibrate the scanner without displaying the "Configure" dialog

    Public Function CalibrateScanner() As Integer
        CalibrateScanner = CRTK_ScanCalibrate(hRTK)
    End Function

    '   Get the Scanner parameter having the specified name

    Public Function GetScannerParam(ByVal param As String) As String

        Dim value As New VB6.FixedLengthString(256)
        Dim cbText, result As Integer

        cbText = 256

        result = CRTK_ScanGetDeviceParam(hRTK, param, value.Value, cbText)
        If result = CRTK_SUCCESS Then
            GetScannerParam = Left(value.Value, cbText)
        Else
            GetScannerParam = ""
        End If

    End Function

    '    Set the specified scanner parameter to the specified value

    Public Function SetScannerParam(ByVal param As String, ByVal value As String) As Integer

        SetScannerParam = CRTK_ScanSetDeviceParam(hRTK, param, value)

    End Function

    '
    '   IMAGE FUNCTIONS
    '

    '   Prepare the card image in memory for Optical Character Recognition

    Public Function ConvertImage() As Boolean
        Dim result As Integer

        result = CRTK_ImageConvert(hRTK, 0, 0)
        ConvertImage = CheckStatus(result, "CRTK_ImageConvert")

    End Function

    '   Discard the card image in memory

    Public Function DestroyImage() As Boolean
        Dim result As Integer

        result = CRTK_ImageDestroy(hRTK)
        DestroyImage = CheckStatus(result, "CRTK_ImageDestroy")

    End Function

    '   Save the card image in memory to a .BMP file

    Public Function ExportImage(ByRef filename As String) As Boolean
        Dim result As Integer

        result = CRTK_ImageExport(hRTK, CRTK_FORMAT_BMP, filename)
        ExportImage = CheckStatus(result, "CRTK_ImageExport")

    End Function

    '   Load a card image from a file into memory

    Public Function LoadImage(ByVal filename As String) As Boolean
        Dim result As Integer

        result = CRTK_ImageLoad(hRTK, filename)
        LoadImage = CheckStatus(result, "CRTK_ImageLoad")

    End Function

    '   Save the card image in memory to a file

    Public Function SaveImage(ByVal filename As String) As Boolean
        Dim result As Integer

        result = CRTK_ImageSave(hRTK, filename)
        SaveImage = CheckStatus(result, "CRTK_ImageSave")

    End Function

    '   Set the card image in memory from a file

    Public Function SetImage(ByVal filename As String) As Boolean
        Dim result As Integer
        Dim hDib As Integer

        '   Convert the file to a 24-bit device-indepentent bitmap via
        '   the Windows clipboard.

        Dim bmp As Drawing.Bitmap = New Drawing.Bitmap(filename)
        Dim bmp24bpp As Drawing.Bitmap = New Drawing.Bitmap(bmp.Size.Width, bmp.Size.Height, Drawing.Imaging.PixelFormat.Format24bppRgb)
        Dim g As Drawing.Graphics = Drawing.Graphics.FromImage(bmp24bpp)
        g.DrawImage(bmp, New Drawing.Point(0, 0))
        g.Dispose()

        Const OFFSET As Integer = 14
        Dim memStream As New IO.MemoryStream
        bmp24bpp.Save(memStream, Drawing.Imaging.ImageFormat.Bmp)
        memStream.Position = OFFSET

        Dim binImage(CType(memStream.Length, Integer) - OFFSET - 1) As Byte
        memStream.Read(binImage, 0, CType(memStream.Length, Integer) - OFFSET)

        Dim dataobject As New Windows.Forms.DataObject(Windows.Forms.DataFormats.Dib, New IO.MemoryStream(binImage, 0, binImage.Length, True, True))
        Windows.Forms.Clipboard.SetDataObject(dataobject, True)

        OpenClipboard(0)
        hDib = GetClipboardData(CF_DIB)
        result = CRTK_ImageSet(hRTK, hDib)
        CloseClipboard()

        SetImage = CheckStatus(result, "CRTK_ImageSet")

    End Function

    '   Retrieve the coordinates of the black & white OCR image relative to the original
    '   color or grayscale image

    Public Function GetCropRectangle(ByRef left_Renamed As Integer, ByRef top As Integer, ByRef right_Renamed As Integer, ByRef bottom As Integer) As Boolean
        Dim result As Integer

        result = CRTK_GetCropRectangle(hRTK, left_Renamed, top, right_Renamed, bottom)
        GetCropRectangle = CheckStatus(result, "CRTK_GetCropRectangle")

    End Function

    '   Retrieve the skew angle of the original color or grayscale image

    Public Function GetSkewAngle(ByRef angle As Integer) As Boolean
        Dim result As Integer

        result = CRTK_GetSkewAngle(hRTK, angle)
        GetSkewAngle = CheckStatus(result, "CRTK_GetSkewAngle")

    End Function

    '   Retrieve the orientation of the original color or grayscale image

    Public Function GetRotateAngle(ByRef angle As Integer) As Boolean
        Dim result As Integer

        result = CRTK_GetRotateAngle(hRTK, angle)
        GetRotateAngle = CheckStatus(result, "CRTK_GetRotateAngle")

    End Function

    '
    '   RECOGNITION FUNCTIONS
    '

    '   Retrieve the text that was read from a card image

    Public Function GetText(ByRef fieldname As Object) As String
        Dim text As New VB6.FixedLengthString(256)
        Dim cbText As Integer
        Dim result As Integer

        cbText = 256
        result = CRTK_GetText(hRTK, fieldname, text.Value, cbText)
        If (result <> CRTK_NO_TEXT) Then
            If (CheckStatus(result, "CRTK_GetText")) Then
                Return Left(text.Value, cbText)
            End If
        End If

        Return Nothing
    End Function

    '   Retrieve the text that was read from a card image along with OCR index

    Public Function GetTextEx(ByRef fieldname As Object, ByRef ocrIndex As Integer) As String
        Dim text As New VB6.FixedLengthString(256)
        Dim cbText As Integer
        Dim result As Integer

        cbText = 256
        result = CRTK_GetTextEx(hRTK, fieldname, text.Value, cbText, ocrIndex)
        If (result <> CRTK_NO_TEXT) Then
            If (CheckStatus(result, "CRTK_GetTextEx")) Then
                Return Left(text.Value, cbText)
            End If
        End If

        Return Nothing
    End Function

    '   Retrieves the raw OCR text and the corresponding coordinate/font information for the
    '   specified index.

    Public Function GetOCRText(ByVal index As Integer, ByRef left_Renamed As Integer, ByRef top As Integer, ByRef right_Renamed As Integer, ByRef bottom As Integer, ByRef font As Integer, ByRef size As Integer) As String
        Dim text As New VB6.FixedLengthString(256)
        Dim cbText As Integer
        Dim result As Integer

        cbText = 256
        result = CRTK_EnumOCRText(hRTK, index, text.Value, cbText, left_Renamed, top, right_Renamed, bottom, font, size)
        If (result = CRTK_SUCCESS) Then
            GetOCRText = Mid(text.Value, 1, cbText)
        Else
            GetOCRText = ""
        End If

    End Function

    '   DATABASE FUNCTIONS

    '   Create a new, empty database

    Public Function CreateDatabase(ByVal filename As String) As Boolean
        Dim result As Integer

        result = CRTK_DBCreate(hRTK, filename, hRTKDB)
        CreateDatabase = CheckStatus(result, "CRTK_DBCreate")

    End Function

    
    '
    '   CARD FUNCTIONS
    '

    '   Create a new, empty card

    Public Function CreateCard(ByRef cardID As Integer, ByRef cardIndex As Integer) As Integer
        Dim result As Integer

        result = CRTK_DBCreateCard(hRTKDB, cardID, cardIndex)
        If (CheckStatus(result, "CRTK_DBCreateCard")) Then
            CreateCard = (cardID)
        End If

    End Function

    '   Delete a card

    Public Function DeleteCard(ByRef cardID As Integer) As Boolean

        Dim result As Integer
        result = CRTK_DBDeleteCard(hRTKDB, cardID)
        DeleteCard = CheckStatus(result, "CRTK_DBDeleteCard")

    End Function

    '   Test whether a card exists and return it's position in the
    '   database

    Public Function QueryExists(ByRef cardID As Integer, ByRef cardIndex As Integer) As Boolean
        Dim result As Integer

        result = CRTK_DBQueryExists(hRTKDB, cardID, cardIndex)
        If (result = CRTK_YES) Then
            QueryExists = True
        ElseIf (result = CRTK_NO) Then
            QueryExists = False
        Else
            QueryExists = CheckStatus(result, "CRTK_DBQueryExists")
        End If

    End Function

    '   Test whether a card image exists

    Public Function QueryHasImage(ByRef cardID As Integer) As Boolean
        Dim result As Integer

        result = CRTK_DBQueryHasImage(hRTKDB, cardID)
        If (result = CRTK_YES) Then
            QueryHasImage = True
        ElseIf (result = CRTK_NO) Then
            QueryHasImage = False
        Else
            QueryHasImage = CheckStatus(result, "CRTK_DBQueryHasImage")
        End If

    End Function

    '   Retrieve the identifier for a card. You pass in the card's index
    '   and get back the unique, position-independent, identifier.

    Public Function GetCardID(ByRef cardIndex As Integer) As Integer
        Dim cardID As Integer
        Dim result As Integer

        result = CRTK_DBGetCard(hRTKDB, cardIndex, cardID)
        If (CheckStatus(result, "CRTK_DBGetCard")) Then
            GetCardID = cardID
        Else
            GetCardID = 0
        End If

    End Function

    '   Retrieve information from a card. All the card fields (except
    '   Notes) contain a maximum of 1024 characters. The Notes field
    '   contains a maximum of 4096 characters.

    Public Function GetValue(ByVal cardID As Integer, ByVal fieldname As String) As String
        Dim fieldText As New VB6.FixedLengthString(1024)
        Dim fieldSize As Integer
        Dim result As Integer

        fieldSize = 1024
        result = CRTK_DBGetValue(hRTKDB, cardID, fieldname, fieldText.Value, fieldSize)

        If CheckStatus(result, "CRTK_DBGetValue") Then
            GetValue = Left(fieldText.Value, fieldSize)
        Else
            GetValue = ""
        End If

    End Function

    '   Retrieve the image for a card into an Image control

    'Public Function GetCardImage(ByVal cardID As Integer, ByRef img As System.Windows.Forms.PictureBox) As Boolean
    Public Function GetCardImage(ByVal cardID As Integer, ByRef img As Image) As Boolean
        Dim result As Integer
        Dim DIB As Integer
        Dim iData As IDataObject

        result = CRTK_DBGetImage(hRTKDB, cardID, DIB)
        If (result = CRTK_SUCCESS) Then

            '   Convert the device-independent bitmap to an Image
            '   via the Windows clipboard.

            OpenClipboard(0)
            Call SetClipboardData(CF_DIB, DIB)
            CloseClipboard()
            iData = Clipboard.GetDataObject()
            If (iData.GetDataPresent(DataFormats.Dib)) Then
                img = CType(iData.GetData(GetType(System.Drawing.Bitmap)), Bitmap)
                Clipboard.SetDataObject("")
            End If
            GetCardImage = True

        Else
            img = Nothing
            GetCardImage = CheckStatus(result, "CRTK_DBGetImage")
        End If

    End Function

    '   Change the information on a card

    Public Function PutValue(ByVal cardID As Integer, ByVal fieldname As String, ByVal value As String) As Boolean
        Dim result As Integer

        If Len(value) = 0 Then
            value = ""
        End If

        result = CRTK_DBPutValue(hRTKDB, cardID, fieldname, value)
        PutValue = CheckStatus(result, "CRTK_DBPutValue")

    End Function

    '
    '   MISCELLANEOUS FUNCTIONS
    '

    '   Check for error return values from the SDK and display the
    '   appropriate message. The function returns False when the
    '   status code represents an error and True otherwise.

    Function CheckStatus(ByVal errorcode As Integer, ByVal functionName As String) As Boolean
        Dim message As New VB6.FixedLengthString(256)
        Dim remedy As New VB6.FixedLengthString(256)
        Dim cbMessage As Integer
        Dim cbRemedy As Integer
        Dim result As Integer
        Dim composedMsg As String

        'set maximum message/remedy length

        cbMessage = 256
        cbRemedy = 256

        If (errorcode = CRTK_ERR_CANCELED) Then
            CheckStatus = False
        ElseIf (errorcode = CRTK_NO_TEXT) Then
            CheckStatus = False
        ElseIf (errorcode = CRTK_ERR_NO_IMAGE) Then
            CheckStatus = False
        ElseIf (errorcode <> CRTK_SUCCESS) Then

            '   Translate error code into message and remedy. If the
            '   translation fails, print a generic message. Otherwise,
            '   explain the problem.

            result = CRTK_GetErrorMessage(errorcode, message.Value, cbMessage, remedy.Value, cbRemedy)
            If (result <> CRTK_SUCCESS) Then
                composedMsg = functionName & " failed because of an unexpected error: " & Str(errorcode)
            Else
                composedMsg = functionName & " failed because " & Left(message.Value, cbMessage) & ". " & Left(remedy.Value, cbRemedy)
            End If
            MsgBox(composedMsg, MsgBoxStyle.OKOnly, functionName)
            CheckStatus = False
        Else
            CheckStatus = True
        End If

    End Function
End Module