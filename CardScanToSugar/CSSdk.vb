Option Strict Off
Option Explicit On
Module SDK_API_Declarations
    '
    '   CSSdk.bas
    '
    '   Copyright (c) 1997-2007 CardScan, Cambridge, MA
    '   All rights reserved

    ' -----------Constants--------------------------------------

    ' The API version described by this file

    Public Const CRTK_API_MAJOR_VERSION As Integer = 1
    Public Const CRTK_API_MINOR_VERSION As Integer = 7

    ' The maximum length of export format names, card field names, and device parameters

    Public Const CRTK_MAX_FORMAT_NAME As Integer = 64
    Public Const CRTK_MAX_FIELD_NAME As Integer = 64
    Public Const CRTK_MAX_PARAM_NAME As Integer = 64

    ' Device parameters for CRTK_{Get,Set}DeviceParam
    ' When a parameter is not supported by the current device, CRTK_{Get,Set}DeviceParam
    ' returns CRTK_ERR_NOT_IMPLEMENTED. Some parameters are read-only (e.g., serial number).
    ' If you attempt to set a read-only parameter, the function returns
    ' CRTK_ERR_READ_ONLY_PARAM

    Public Const CRTK_PARAM_SCANNER_MODEL As String = "Model" ' Same as scanner name (e.g., "CardScan 600c")
    Public Const CRTK_PARAM_SERIAL_NUMBER As String = "Serial Number" ' Read only
    Public Const CRTK_PARAM_FIRMWARE_VERSION As String = "Firmware Version" ' Read only

    Public Const CRTK_PARAM_CARD_PLACEMENT As String = "Card Placement" ' Read only. How to place the card in the scanner;
    Public Const CRTK_VALUE_CARD_PLACEMENT_FACEUP As String = "Face Up" ' Face up or,
    Public Const CRTK_VALUE_CARD_PLACEMENT_FACEDOWN As String = "Face Down" ' Face down

    Public Const CRTK_PARAM_PORT_TYPE As String = "Port Type" ' How the device is connected to the PC;
    Public Const CRTK_VALUE_PORT_TYPE_USB As String = "USB" ' USB port or,
    Public Const CRTK_VALUE_PORT_TYPE_LPT As String = "LPT" ' LPT port

    Public Const CRTK_PARAM_PORT_NUMBER As String = "Port Number" ' Which port the scanner is connected to;
    Public Const CRTK_VALUE_PORT_NUMBER_LPT1 As String = "0" ' LPT1 or,
    Public Const CRTK_VALUE_PORT_NUMBER_LPT2 As String = "1" ' LPT2

    Public Const CRTK_PARAM_CALIBRATED As String = "Calibrated" ' Read only. Is the scanner calibrated? One of,
    Public Const CRTK_VALUE_CALIBRATED_TRUE As String = "1" ' Yes, or
    Public Const CRTK_VALUE_CALIBRATED_FALSE As String = "0" ' No

    Public Const CRTK_PARAM_COLOR_MODE As String = "Color Mode" ' How the scanner is capturing images. Either in,
    Public Const CRTK_VALUE_COLOR_MODE_COLOR As String = "COLOR" ' 24-bit color or,
    Public Const CRTK_VALUE_COLOR_MODE_MONOCHROME As String = "MONOCHROME" ' 8-bit grayscale

    Public Const CRTK_PARAM_ASK_CALIBRATE As String = "Ask Calibrate" ' Ask the user to calibrate the scanner?
    Public Const CRTK_VALUE_ASK_CALIBRATE_ON As String = "1" ' Yes, or
    Public Const CRTK_VALUE_ASK_CALIBRATE_OFF As String = "0" ' No

    ' Export formats (for CRTK_ImageExport)

    Public Const CRTK_FORMAT_BMP As String = "BMP"

    ' Flags for CRTK_RecognizeEx

    Public Const CRTK_RECOGNIZE_RAW_TEXT As Integer = 1 ' Don't convert text to mixed case
    Public Const CRTK_RECOGNIZE_NO_ROTATE As Integer = 2 ' Assume the image has the correct orientation

    ' Flags for CRTK_ImageConvertEx

    Public Const CRTK_CONVERT_NO_ROTATE As Integer = 1 ' Don't change the image orientation

    ' Opcodes for CRTK_DBEnumChanges

    Public Const CRTK_CHANGE_NULL As Integer = 0
    Public Const CRTK_CHANGE_MODIFY As Integer = 1
    Public Const CRTK_CHANGE_ADD As Integer = 2
    Public Const CRTK_CHANGE_DELETE As Integer = 3

    ' Card fields for CRTK_GetText.
    ' Do NOT use these for CRTK_DB{Get,Put}Value; the field
    ' names are not identical.

    Public Const CRTK_FIELD_NAME As String = "Name"
    Public Const CRTK_FIELD_NAME_PREFIX As String = "Name Prefix"
    Public Const CRTK_FIELD_FIRST_NAME As String = "First Name"
    Public Const CRTK_FIELD_MIDDLE_NAME As String = "Middle Name"
    Public Const CRTK_FIELD_LAST_NAME As String = "Last Name"
    Public Const CRTK_FIELD_NAME_SUFFIX As String = "Name Suffix"

    Public Const CRTK_FIELD_TITLE As String = "Title"
    Public Const CRTK_FIELD_COMPANY As String = "Company"

    Public Const CRTK_FIELD_ADDRESS As String = "Address"
    Public Const CRTK_FIELD_STREET As String = "Street Address"
    Public Const CRTK_FIELD_ADDR1 As String = "Address Line 1"
    Public Const CRTK_FIELD_ADDR2 As String = "Address Line 2"
    Public Const CRTK_FIELD_ADDR3 As String = "Address Line 3"
    Public Const CRTK_FIELD_CITY As String = "City"
    Public Const CRTK_FIELD_STATE As String = "State"
    Public Const CRTK_FIELD_POSTAL_CODE As String = "Postal Code"
    Public Const CRTK_FIELD_COUNTRY As String = "Country"

    Public Const CRTK_FIELD_2ND_ADDRESS As String = "2nd Address"
    Public Const CRTK_FIELD_2ND_STREET As String = "2nd Street Address"
    Public Const CRTK_FIELD_2ND_ADDR1 As String = "2nd Address Line 1"
    Public Const CRTK_FIELD_2ND_ADDR2 As String = "2nd Address Line 2"
    Public Const CRTK_FIELD_2ND_ADDR3 As String = "2nd Address Line 3"
    Public Const CRTK_FIELD_2ND_CITY As String = "2nd City"
    Public Const CRTK_FIELD_2ND_STATE As String = "2nd State"
    Public Const CRTK_FIELD_2ND_POSTAL_CODE As String = "2nd Postal Code"
    Public Const CRTK_FIELD_2ND_COUNTRY As String = "2nd Country"

    Public Const CRTK_FIELD_PHONE As String = "Phone"
    Public Const CRTK_FIELD_FAX As String = "Fax"
    Public Const CRTK_FIELD_EMAIL As String = "E-mail"
    Public Const CRTK_FIELD_WEB_SITE As String = "Web site"
    Public Const CRTK_FIELD_OTHER As String = "Other"

    ' Field types for CRTK_EnumLabels

    Public Const CRTK_FIELD_TYPE_PHONE As String = "Phone"
    Public Const CRTK_FIELD_TYPE_EMAIL As String = "E-mail"
    Public Const CRTK_FIELD_TYPE_CUSTOM As String = "Custom"

    ' Phone number and Email types for CRTK_EnumText

    Public Const CRTK_PHONE_MAIN As String = "Main"
    Public Const CRTK_PHONE_HOME As String = "Home"
    Public Const CRTK_PHONE_DIRECT As String = "Direct"
    Public Const CRTK_PHONE_MOBILE As String = "Mobile"
    Public Const CRTK_PHONE_PAGER As String = "Pager"
    Public Const CRTK_PHONE_OTHER As String = "Other Phone"
    Public Const CRTK_PHONE_VOICEMAIL As String = "Voice Mail"
    Public Const CRTK_PHONE_OTHER_FAX As String = "Other Fax"

    Public Const CRTK_EMAIL_AOL As String = "AOL"
    Public Const CRTK_EMAIL_APPLELINK As String = "Applelink"
    Public Const CRTK_EMAIL_COMPUSERVE As String = "Compuserve"
    Public Const CRTK_EMAIL_MCIMAIL As String = "MCI Mail"
    Public Const CRTK_EMAIL_TELEX As String = "Telex"
    Public Const CRTK_EMAIL_OTHER As String = "Other E-mail"

    ' Status codes for CRTK_DB{Get,Set,Enum}AccuCardStatus

    Public Const CRTK_ACCUCARD_NOTPRESENT As Integer = 0
    Public Const CRTK_ACCUCARD_OK As Integer = 1
    Public Const CRTK_ACCUCARD_OUTOFDATE As Integer = 2
    Public Const CRTK_ACCUCARD_UNREACHABLE As Integer = 3

    ' Custom field types

    Public Const CRTK_FIELD_TYPE_TEXT As Integer = 1
    Public Const CRTK_FIELD_TYPE_IMAGE As Integer = 2
    Public Const CRTK_FIELD_TYPE_NUMBER As Integer = 3
    Public Const CRTK_FIELD_TYPE_MEMO As Integer = 4
    Public Const CRTK_FIELD_TYPE_POINTER As Integer = 5
    Public Const CRTK_FIELD_TYPE_DATETIME As Integer = 6
    Public Const CRTK_FIELD_TYPE_BOOLEAN As Integer = 7

    ' Custom field flags

    Public Const CRTK_FIELD_FLAG_HIDDEN As Integer = 1
    Public Const CRTK_FIELD_FLAG_READONLY As Integer = 2
    Public Const CRTK_FIELD_FLAG_RESTRICTED As Integer = 4

    ' Custom field attributes

    Public Const CRTK_PARAM_NAME As String = "Name"
    Public Const CRTK_PARAM_RECORD_GUID As String = "Record GUID"
    Public Const CRTK_PARAM_GROUPING As String = "Grouping"
    Public Const CRTK_PARAM_LABEL As String = "Label"
    Public Const CRTK_PARAM_TYPE As String = "Type"
    Public Const CRTK_PARAM_FLAGS As String = "Flags"
    Public Const CRTK_PARAM_SEQUENCE_NUMBER As String = "Sequence Number"
    Public Const CRTK_PARAM_SOURCE_IMAGE As String = "Source Image"
    Public Const CRTK_PARAM_VALUE_LIST As String = "Value List"
    Public Const CRTK_PARAM_MODIFIED_DATE As String = "Modified Date"

    ' --------Initialization functions--------------------------

    '   Initialize the library and register the client application

    Declare Function CRTK_Init Lib "cssdk32.dll" (ByRef lphRTK As Integer) As Integer
    ' lphRTK - address to receive RTK handle


    '   Unregister the client application and close the library

    Declare Function CRTK_Term Lib "cssdk32.dll" (ByVal hRTK As Integer) As Integer
    ' hRTK - valid RTK handle

    ' --------Scanner functions---------------------------------

    '   Check for a card in the scanner

    Declare Function CRTK_ScanCheckForCard Lib "cssdk32.dll" (ByVal hRTK As Integer) As Integer
    ' hRTK - valid RTK handle

    '   Calibrate and configure the business card scanner

    Declare Function CRTK_ScanConfigure Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal hWndOwner As Integer) As Integer
    ' hRTK - valid RTK handle
    ' hWindOwner - Owner window for Scanner Setup dialog

    '   Scan a business card

    Declare Function CRTK_ScanAcquire Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal dwTimeout As Integer) As Integer
    ' hRTK - valid RTK handle
    ' dwTimeout - time in 1/10th of sec to wait for user to insert card

    Declare Function CRTK_ScanAcquireEx Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal dwTimeout As Integer, ByVal lpfnCallback As Integer, ByVal lpData As Integer) As Integer
    ' hRTK - valid RTK handle
    ' dwTimeout - time in 1/10th of sec to wait for user to insert card
    ' lpfnCallback - Optional callback function
    ' lpData - Optional value to pass to callback function

    Declare Function CRTK_ScanGetDeviceParam Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpszParamName As String, ByVal lpszBuf As String, ByRef lpcbBuf As Integer) As Integer
    ' hRTK - valid RTK handle
    ' lpszParamName - Name of parameter to retrieve
    ' lpszBuf - Buffer to receive device information
    ' lpcbBuf - [in/out] Max number of characters [to copy/copied] to the buffer

    Declare Function CRTK_ScanSetDeviceParam Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpszParamName As String, ByVal lpszValue As String) As Integer
    ' hRTK - valid RTK handle
    ' lpszParamName - Name of parameter to set
    ' lpszValue - Value for parameter

    Declare Function CRTK_ScanCalibrate Lib "cssdk32.dll" (ByVal hRTK As Integer) As Integer
    ' hRTK - valid RTK handle

    ' ----------Image functions---------------------------------

    '   Save the card image in memory to a file

    Declare Function CRTK_ImageSave Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpszFilename As String) As Integer
    ' hRTK - valid RTK handle
    ' lpszFilename - path and name of the file to create

    '   Load a card image from a file into memory

    Declare Function CRTK_ImageLoad Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpszFilename As String) As Integer
    ' hRTK - valid RTK handle
    ' lpszFilename - path and name of the file to read

    '   Save the card image in memory to a file using a
    '   public-domain graphics format

    Declare Function CRTK_ImageExport Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpszFormat As String, ByVal lpszFilename As String) As Integer
    ' hRTK - valid RTK handle
    ' lpszFormat - image file format to use (see above for list)
    ' lpszFilename - path and name of the file to read

    '   Prepare the card image in memory for optical
    '   character recognition (OCR)

    Declare Function CRTK_ImageConvert Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpfnCallback As Integer, ByVal lpData As Integer) As Integer
    ' hRTK - valid RTK handle
    ' lpfnCallback - address of the callback function
    ' lpData - value to pass to callback function

    Declare Function CRTK_ImageConvertEx Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpfnCallback As Integer, ByVal lpData As Integer, ByVal dwFlags As Integer) As Integer
    ' hRTK - valid RTK handle
    ' lpfnCallback - address of the callback function
    ' lpData - value to pass to callback function
    ' dwFlags - Optional flags to control conversion process

    '   Discard the card image in memory

    Declare Function CRTK_ImageDestroy Lib "cssdk32.dll" (ByVal hRTK As Integer) As Integer
    ' hRTK - valid RTK handle

    '   Replace the card image in memory. Use with extreme caution.

    Declare Function CRTK_ImageSet Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal hDib As Integer) As Integer
    ' hRTK - valid RTK handle
    ' hDIB - handle to device-independent bitmap

    Declare Function CRTK_ImageGet Lib "cssdk32.dll" (ByVal hRTK As Integer, ByRef hGlobal As Integer) As Integer
    ' hRTK - valid RTK handle
    ' lphDIB - buffer to receive handle to Windows' device-independent bitmap

    '   Retrieve the coordinates of the black & white OCR image
    '   relative to the original color or grayscale image

    Declare Function CRTK_GetCropRectangle Lib "cssdk32.dll" (ByVal hRTK As Integer, ByRef lpdwLeft As Integer, ByRef lpdwTop As Integer, ByRef lpdwRight As Integer, ByRef lpdwBottom As Integer) As Integer
    ' hRTK - valid RTK handle
    ' lpdwLeft - Left coordinate of rectangle (in pixels)
    ' lpdwTop - Top coodinate of rectangle
    ' lpdwRight - Right coordinate of rectangle
    ' lpdwBottom - Bottom coordinate of rectangle

    Declare Function CRTK_GetSkewAngle Lib "cssdk32.dll" (ByVal hRTK As Integer, ByRef lpdwSkewAngle As Integer) As Integer
    ' hRTK - valid RTK handle
    ' lpdwSkewAngle - Skew angle (in hundredths of degrees), positive for clockwise,
    '                                 negative for counter-clockwise.

    Declare Function CRTK_GetRotateAngle Lib "cssdk32.dll" (ByVal hRTK As Integer, ByRef lpdwRotateAngle As Integer) As Integer
    ' hRTK - valid RTK handle
    ' lpdwRotateAngle - Buffer to receive # of degrees to rotate original image to
    '                                       orient the text correctly

    ' -------Recognition/Extraction functions-------------------

    '   Read and identity the text on the card image in memory

    Delegate Function CRTK_RecognizeDelegate(ByVal percent As Short, ByRef data As Integer) As Integer
    Declare Function CRTK_Recognize Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpfnCallback As CRTK_RecognizeDelegate, ByVal lpData As Integer) As Integer

    'Declare Function CRTK_Recognize Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpfnCallback As Integer, ByVal lpData As Integer) As Integer
    ' hRTK - valid RTK handle
    ' lpfnCallback - address of the callback function
    ' lpData - value to pass to callback function

    Declare Function CRTK_RecognizeEx Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpfnCallback As Integer, ByVal lpData As Integer, ByVal dwFlags As Integer) As Integer
    ' hRTK - valid RTK handle
    ' lpfnCallback - address of the callback function
    ' lpData - value to pass to callback function
    ' dwFlags - Optional flags to control recognition process

    '   Retrieve the text read from the card image

    Declare Function CRTK_GetText Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpszFieldName As String, ByVal lpszBuf As String, ByRef lpcbBuf As Integer) As Integer
    ' hRTK - valid RTK handle
    ' lpszFieldname - name of field to retreive
    ' lpszBuf - buffer to receive card information
    ' lpcbBuf - maximum number of characters to copy to the buffer

    Declare Function CRTK_GetTextEx Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpszFieldName As String, ByVal lpszBuf As String, ByRef lpcbBuf As Integer, ByRef lpdwOCRIndex As Integer) As Integer
    ' hRTK - valid RTK handle
    ' lpszFieldname - name of field to retreive
    ' lpszBuf - buffer to receive card information
    ' lpcbBuf - maximum number of characters to copy to the buffer
    ' lpdwOCRIndex - buffer to receive index of corresponding OCR line

    '   Retrieve the text in multiple-value fields (e.g., phone
    '   numbers or e-mail addresses)

    Declare Function CRTK_EnumText Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpszFieldName As String, ByVal dwIndex As Integer, ByVal lpszBuf As String, ByRef lpcbBuf As Integer, ByVal lpszType As String, ByRef lpcbType As Integer) As Integer
    ' hRTK - valid RTK handle
    ' lpszFieldName - name of field to enumerate (e.g., CRTK_FIELD_PHONE)
    ' dwIndex - index of value to retrieve (initialize to zero and increment by one)
    ' lpszBuf - buffer to receive field value
    ' lpcbBuf - size of buffer specified in lpszBuf
    ' lpszType - buffer to receive field value's type
    ' lpcbType - size of buffer specified in lpszType

    Declare Function CRTK_EnumTextEx Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpszFieldName As String, ByVal dwIndex As Integer, ByVal lpszBuf As String, ByRef lpcbBuf As Integer, ByVal lpszType As String, ByRef lpcbType As Integer, ByRef lpdwOCRIndex As Integer) As Integer
    ' hRTK - valid RTK handle
    ' lpszFieldName - name of field to enumerate (e.g., CRTK_FIELD_PHONE)
    ' dwIndex - index of value to retrieve (initialize to zero and increment by one)
    ' lpszBuf - buffer to receive field value
    ' lpcbBuf - size of buffer specified in lpszBuf
    ' lpszType - buffer to receive field value's type
    ' lpcbType - size of buffer specified in lpszType
    ' lpdwOCRIndex - buffer to receive index of corresponding OCR line

    Declare Function CRTK_EnumOCRText Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal dwIndex As Integer, ByVal lpszBuf As String, ByRef lpcbBuf As Integer, ByRef lpdwLeft As Integer, ByRef lpdwTop As Integer, ByRef lpdwRight As Integer, ByRef lpdwBottom As Integer, ByRef lpdwFont As Integer, ByRef lpdwPointSize As Integer) As Integer
    ' hRTK - valid RTK handle
    ' dwIndex - Index of text (initialize to zero and increment by one)
    ' lpszBuf - Buffer to receive text
    ' lpcbBuf - [in/out] Max number of characters [to copy/copied] to the buffer
    ' lpdwLeft - Left coordinate of left (in pixels)
    ' lpdwTop - Top coodinate of text
    ' lpdwRight - Right coordinate of text
    ' lpdwBottom - Bottom coordinate of text
    ' lpdwFont - Typeface style of text
    ' lpdwPointSize - Point size of text

    ' --------Database functions--------------------------------

    '   Create a new, empty database

    Declare Function CRTK_DBCreate Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpszFilename As String, ByRef lphRTKDB As Integer) As Integer
    ' hRTK - a valid RTK handle
    ' lpszFilename - path and name of the file to create
    ' lphRTKDB -  buffer to receive database handle

    '   Open a database

    Declare Function CRTK_DBOpen Lib "cssdk32.dll" (ByVal hRTK As Integer, ByVal lpszFilename As String, ByVal lpszPassword As String, ByRef lphRTKDB As Integer) As Integer
    ' hRTK - a valid RTK handle
    ' lpszFilename - path and name of the file to open
    ' lpszPassword - the password required to access the file
    ' lphRTKDB - buffer to receive database handle

    '   Close a database

    Declare Function CRTK_DBClose Lib "cssdk32.dll" (ByVal hRTKDB As Integer) As Integer
    ' hRTKDB - a valid database handle

    '   Check if a database is read-only

    Declare Function CRTK_DBIsReadOnly Lib "cssdk32.dll" (ByVal hRTKDB As Integer) As Integer
    ' hRTKDB - a valid database handle

    ' --------Database update functions-------------------------

    '   Begin a new transaction to manage changes to the database.

    Declare Function CRTK_DBBeginUpdate Lib "cssdk32.dll" (ByVal hRTKDB As Integer) As Integer
    ' hRTKDB - a valid database handle

    '   Save the changes to the database

    Declare Function CRTK_DBCommitUpdate Lib "cssdk32.dll" (ByVal hRTKDB As Integer) As Integer
    ' hRTKDB - a valid database handle

    '   Save the changes to the database and return the current
    '   revision number.

    Declare Function CRTK_DBCommitUpdateEx Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByRef lpdwRevNumber As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' lpdwRevNumber - buffer to receive the new revision number

    '   Discard changes to the database

    Declare Function CRTK_DBAbortUpdate Lib "cssdk32.dll" (ByVal hRTKDB As Integer) As Integer
    ' hRTKDB - a valid database handle

    ' --------Database inquiry functions------------------------

    '   Retrieve the revision number for the database.

    Declare Function CRTK_DBGetRevisionNumber Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByRef lpdwRevNumber As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' lpdwRevNumber - A pointer to DWORD buffer to receive revision number

    '   Retrieve the unique GUID for the database.

    Declare Function CRTK_DBGetGUID Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal lpszBuf As String, ByRef lpcbBuf As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' lpszBuf - Buffer to receive database GUID
    ' lpcbBuf - [in/out] Max number of characters [to copy/copied] to the buffer

    '   Retrieve the categories in the database

    Declare Function CRTK_DBEnumCategories Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwIndex As Integer, ByVal lpszBuf As String, ByRef lpcbBuf As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwIndex - the index of the category to retrieve
    ' lpszBuf - buffer to receive the category name
    ' lpcbBuf - size of the buffer specified in lpszBuf

    '   Retrieve the phone and email labels in the database

    Declare Function CRTK_DBEnumLabels Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal lpszFieldName As String, ByVal dwIndex As Integer, ByVal lpszBuf As String, ByRef lpcbBuf As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' lpszFieldName - the type of labels to retrieve (e.g., "Phone" or "Email")
    ' dwIndex - the index of the label to retrieve
    ' lpszBuf - buffer to receive the label
    ' lpcbBuf - size of the buffer specified in lpszBuf

    '   Enumerate the changes made to a database

    Declare Function CRTK_DBEnumChanges Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwStartRevision As Integer, ByVal dwIndex As Integer, ByRef lpdwRevision As Integer, ByRef lpdwID As Integer, ByRef lpdwChangeType As Integer, ByVal lpszChangeInfo As String, ByRef lpcbChangeInfo As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwStartRevision - Revision at which to begin enumeration
    ' dwIndex - Index of change information (initialize to zero and increment by one)
    ' lpdwRevision - Buffer to receive change revision number
    ' lpdwID - Buffer to receive change card ID
    ' lpdwChangeType - Buffer to receive change type (code)
    ' lpszChangeInfo - Buffer to receive other change data
    ' lpcbChangeInfo - [in/out] Max number of characters [to copy/copied] to the buffer

    ' --------Card functions------------------------------------

    '   Retrieve the total number of cards in the database

    Declare Function CRTK_DBGetNumberOfCards Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByRef lpdwCount As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' lpdwCount - buffer to receive the number of cards

    '   Retrieve the identifier for the card

    Declare Function CRTK_DBGetCard Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwIndex As Integer, ByRef lpdwID As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwIndex - the index of the card to identify
    ' lpdwID - buffer to receive the card's unique ID

    '   Retrieve the identifier for the card, given its GUID

    Declare Function CRTK_DBGetCardByGUID Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal lpszGUID As String, ByRef lpdwID As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' lpszGUID - GUID of card
    ' lpdwID - buffer to receive the card's unique ID

    '   Retrieve the GUID for a card

    Declare Function CRTK_DBGetCardGUID Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpszBuf As String, ByRef lpcbBuf As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwID - the identifier of the card
    ' lpszBuf - buffer to receive the card GUID
    ' lpcbBuf - max number of characters to copy/copied to the buffer

    '   Retrieve information from the card

    Declare Function CRTK_DBGetValue Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpszFieldName As String, ByVal lpszBuf As String, ByRef lpcbBuf As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwId - the identifier of the card
    ' lpszFieldName - the name of the field to retrieve
    ' lpszBuf - buffer to recieve the card information
    ' lpcbBuf - max number of characters to copy/copied to the buffer

    '   Enumerate the the phone numbers and email address on card

    Declare Function CRTK_DBEnumValue Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpszFieldName As String, ByVal dwIndex As Integer, ByVal lpszBuf As String, ByRef lpcbBuf As Integer, ByVal lpszLabel As String, ByRef lpcbLabel As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwID - the identifier of the card to query
    ' lpszFieldName - the field to enumerate (e.g., "Phone" or "Email"
    ' dwIndex - index of card information (initialize to zero and increment by one)
    ' lpszBuf - buffer to receive the card information
    ' lpcbBuf - max number of characters to copy/copied to the buffer
    ' lpszLabel - buffer to receive the label for the value
    ' lpcbLabel - max number of characters to copy/copied to the label buffer

    '   Modify a card

    Declare Function CRTK_DBPutValue Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpszFieldName As String, ByVal lpszValue As String) As Integer
    ' hRTKDB - a valid database handle
    ' dwID - the identifier of the card to modify
    ' lpszFieldName - the field to modify
    ' lpszValue - the new value for the field

    '   Retrieve the image of a card

    Declare Function CRTK_DBGetImage Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByRef lphdib As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwID - the identifier of the card
    ' lphDIB - buffer to receive the card image as a windows device independent bitmap (DIB)

    '   Retrieve the front or back image of a card

    Declare Function CRTK_DBGetImageEx Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal dwIndex As Integer, ByRef lphdib As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwID - the identifier of the card
    ' dwIndex - the index of the image to retrieve; 0 = front, 1 = back
    ' lphDIB - buffer to receive the card image as a windows device independent bitmap (DIB)

    '   Set the image of a card

    Declare Function CRTK_DBPutImage Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal dwIndex As Integer, ByVal hDib As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwID - Unique id of card
    ' dwIndex - Index of Image (0 for front, 1 for back)
    ' hDIB - Handle to Windows device-independent bitmap (DIB). Pass NULL to delete the image

    '   Test whether a card exists

    Declare Function CRTK_DBQueryExists Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByRef lpdwIndex As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwID - the identifier of the card to locate
    ' lpdwIndex - buffer to receive the card's position in the database

    '   Test whether a card's image exists

    Declare Function CRTK_DBQueryHasImage Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer) As Integer
    'hRTKDB - A valid database handle
    'dwID - the identifier of the card to query

    '   Test whether a card's image exists

    Declare Function CRTK_DBQueryHasImageEx Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal dwIndex As Integer) As Integer
    'hRTKDB - A valid database handle
    'dwID - the identifier of the card to query
    'dwIndex - Index of Image (0 for front, 1 for back)

    '   Create a new, empty card

    Declare Function CRTK_DBCreateCard Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByRef lpdwID As Integer, ByRef lpdwIndex As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' lpdwID - buffer to receive the new card's unique ID
    ' lpdwIndex - buffer to receive the new card's position in the database

    '   Create a new, empty card

    Declare Function CRTK_DBCreateCardEx Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal lpszGUID As String, ByRef lpdwID As Integer, ByRef lpdwIndex As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' lpszGUID - GUID for card
    ' lpdwID - buffer to receive the new card's unique ID
    ' lpdwIndex - buffer to receive the new card's position in the database

    '   Delete a card

    Declare Function CRTK_DBDeleteCard Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer) As Integer
    'hRTKDB - a valid database handle
    'dwID - the identifier of the card to delete

    ' --------Category functions--------------------------------

    '   Retrieve the total number of categories in a file

    Declare Function CRTK_DBGetNumberOfCategories Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByRef lpdwCount As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' lpdwCount - Buffer to receive the number of categories

    '   Retrieve the identifier for a category

    Declare Function CRTK_DBGetCategory Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwIndex As Integer, ByRef lpdwID As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwIndex - Index of category
    ' lpdwID - Buffer to receive the category's unique ID

    '   Retrieve the name of a category

    Declare Function CRTK_DBGetCategoryName Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpszBuf As String, ByRef lpcbBuf As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwID - the identifier of the category
    ' lpszBuf - Buffer to receive the category name
    ' lpcbBuf - [in/out] Max number of characters [to copy/copied] to the buffer

    '   Retrieve the GUID for a category

    Declare Function CRTK_DBGetCategoryGUID Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpszBuf As String, ByRef lpcbBuf As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwID - Unique id of category
    ' lpszBuf - Buffer to receive the category GUID
    ' lpcbBuf - [in/out] Max number of characters [to copy/copied] to the buffer

    '   Set the GUID for a category

    Declare Function CRTK_DBSetCategoryGUID Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpszGUID As String) As Integer
    ' hRTKDB - a valid database handle
    ' dwID - Unique id of category
    ' lpszGUID - GUID for category

    '   Find the category with a given name

    Declare Function CRTK_DBGetCategoryByName Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal lpszName As String, ByRef lpdwID As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' lpszName - Name of category
    ' lpdwID - Buffer to receive the category's unique ID

    '   Find the category with a given GUID

    Declare Function CRTK_DBGetCategoryByGUID Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal lpszGUID As String, ByRef lpdwID As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' lpszGUID - GUID of catgeory
    ' lpdwID - Buffer to receive the category's unique ID

    '   Create a new category

    Declare Function CRTK_DBCreateCategory Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal lpszName As String, ByVal lpszGUID As String, ByRef lpdwID As Integer, ByRef lpdwIndex As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' lpszName - Name for category
    ' lpszGUID - GUID for category
    ' lpdwID - Buffer to receive category's unique ID
    ' lpdwIndex - Buffer to receive index of catagory

    '   Delete a category

    Declare Function CRTK_DBDeleteCategory Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwID - Unique id of category to delete

    '   Rename a category

    Declare Function CRTK_DBRenameCategory Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpszName As String) As Integer
    ' hRTKDB - a valid database handle
    ' dwID - Unique id of category to rename
    ' lpszName - Name for category

    ' --------AccuCard functions--------------------------------

    '   Retrieve the AccuCard status for a card

    Declare Function CRTK_DBGetAccuCardStatus Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByRef lpdwStatus As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwID - Unique id of card
    ' lpdwStatus - Status code (CRTK_ACCUCARD_xx)

    '   Set the AccuCard status for a card

    Declare Function CRTK_DBSetAccuCardStatus Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal dwStatus As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwID - Unique id of card
    ' dwStatus - Status code (CRTK_ACCUCARD_xx)

    '   Retrieve the AccuCard status for all cards

    Declare Function CRTK_DBEnumAccuCardStatus Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwIndex As Integer, ByRef lpdwID As Integer, ByRef lpdwStatus As Integer) As Integer
    ' hRTKDB - a valid database handle
    ' dwIndex - index of AccuCard status (initialize to zero and increment by one)
    ' lpdwID - buffer to receive card id
    ' lpdwStatus - buffer to receive AccuCard status

    ' --------Data object functions-----------------------------

    '   Retrieve the total number of data objects in a file

    Declare Function CRTK_DBGetNumberOfDataObjs Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByRef lpdwResult As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' lpdwResult - Buffer to receive the number of data objects

    '   Retrieve the identifier for a data object

    Declare Function CRTK_DBGetDataObj Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwIndex As Integer, ByRef lpdwID As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' dwIndex - Index of data object
    ' lpdwID - Buffer to receive the data object's unique ID

    '   Retrieve the name for a data object

    Declare Function CRTK_DBGetDataObjName Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpszBuf As String, ByRef lpcbBuf As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' dwID - Unique id of card
    ' lpszBuf - Buffer to receive the data object name
    ' lpcbBuf - [in/out] Max number of characters [to copy/copied] to the buffer

    '   Retrieve the GUID for a data object

    Declare Function CRTK_DBGetDataObjGUID Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpszBuf As String, ByRef lpcbBuf As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' dwID - Unique id of data object
    ' lpszBuf - Buffer to receive the data object GUID
    ' lpcbBuf - [in/out] Max number of characters [to copy/copied] to the buffer

    '   Set the GUID for a data object

    Declare Function CRTK_DBSetDataObjGUID Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpszGUID As String) As Integer
    ' hRTKDB - a Valid database handle
    ' dwID - Unique id of data object
    ' lpszGUID - GUID for data object

    '   Retrieve the contents for a data object

    Declare Function CRTK_DBGetDataObjData Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpBuf As String, ByRef lpcbBuf As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' dwID - Unique id of data object
    ' lpBuf - Buffer to receive the object's data
    ' lpcbBuf - [in/out] Max number of characters [to copy/copied] to the buffer

    '   Set the contents of a data object

    Declare Function CRTK_DBSetDataObjData Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpBuf As String, ByVal cbBuf As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' dwID - Unique id of data object
    ' lpBuf - Buffer containing data to store in the object
    ' cbBuf - Number of bytes in the object data

    '   Find the data object with a given name

    Declare Function CRTK_DBGetDataObjByName Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal lpszName As String, ByRef lpdwID As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' lpszName - Name of data object
    ' lpdwID - Buffer to receive the data object's unique ID

    '   Find the data object with a given GUID

    Declare Function CRTK_DBGetDataObjByGUID Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal lpszGUID As String, ByRef lpdwID As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' lpszGUID - GUID of catgeory
    ' lpdwID - Buffer to receive the data object's unique ID

    '   Create a new data object

    Declare Function CRTK_DBCreateDataObj Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal lpszName As String, ByVal lpszGUID As String, ByVal lpBuf As String, ByVal cbBuf As Integer, ByRef lpdwID As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' lpszName - Name for data object
    ' lpszGUID - GUID for data object
    ' lpBuf - Buffer containing data to store in the object
    ' cbBuf - Number of bytes in the object data
    ' lpdwID - Buffer to receive data object's unique ID

    '   Delete a data object

    Declare Function CRTK_DBDeleteDataObj Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' dwID - Unique id of data object to delete

    '   Rename a data object

    Declare Function CRTK_DBRenameDataObj Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpszName As String) As Integer
    ' hRTKDB - a Valid database handle
    ' dwID - Unique id of data object to rename
    ' lpszName - Name for data object

    ' --------Custom field functions----------------------------

    '   Retrieve the total number of custom fields in a file

    Declare Function CRTK_DBGetNumberOfFields Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByRef lpdwResult As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' lpdwResult - Buffer to receive the number of fields

    '   Retrieve the identifier for a custom field

    Declare Function CRTK_DBGetField Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwIndex As Integer, ByRef lpdwID As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' dwIndex - Index of field
    ' lpdwID - Buffer to receive the field's unique ID

    '   Retrieve the GUID for a custom field

    Declare Function CRTK_DBGetFieldGUID Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer, ByVal lpszBuf As String, ByRef lpcbBuf As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' dwID - Unique id of field
    ' lpszBuf - Buffer to receive the field GUID
    ' lpcbBuf - [in/out] Max number of characters [to copy/copied] to the buffer

    '   Find the custom field with a given name

    Declare Function CRTK_DBGetFieldByName Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal lpszName As String, ByRef lpdwID As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' lpszName - Name of the field
    ' lpdwID - Buffer to receive the field's unique ID

    '   Find the custom field with a given GUID

    Declare Function CRTK_DBGetFieldByGUID Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal lpszGUID As String, ByRef lpdwID As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' lpszGUID - GUID of catgeory
    ' lpdwID - Buffer to receive the field's unique ID

    '   Create a new custom field

    Declare Function CRTK_DBCreateField Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByRef lpdwID As Integer, ByVal lpszName As String, ByVal lpszGUID As String, ByVal lpszGroupName As String, ByVal lpszLabel As String, ByVal dwType As Integer, ByVal dwFlags As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' lpdwID - Buffer to receive field's unique id
    ' lpszName - Field name
    ' lpszGUID - Optional GUID for field
    ' lpszGroupName - Optional field group name
    ' lpszLabel - Optional field label (default = lpszName)
    ' dwType - Optional field type (see CRTK_FIELD_TYPE_xx)
    ' dwFlags - Optional flags to control how the field is treated (see CRTK_FIELD_FLAG_xx)

    '   Delete a custom field

    Declare Function CRTK_DBDeleteField Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwID As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' dwID - Unique id of field to delete

    '   Retrieve the custom fields in a file

    Declare Function CRTK_DBEnumFields Lib "cssdk32.dll" (ByVal hRTKDB As Integer, ByVal dwIndex As Integer, ByRef lpdwID As Integer, ByVal lpszName As String, ByRef lpcbName As Integer, ByVal lpszGroupName As String, ByRef lpcbGroupName As Integer, ByVal lpszLabel As String, ByRef lpcbLabel As Integer, ByRef lpdwType As Integer, ByRef lpdwFlags As Integer) As Integer
    ' hRTKDB - a Valid database handle
    ' dwIndex - Index of field (initialize to zero and increment by one)
    ' lpdwID - Buffer to receive field ID
    ' lpszName - Optional buffer to receive field name
    ' lpcbName - [in/out] Max number of characters [to copy/copied] to the buffer
    ' lpszGroupName - Optional buffer to receive field group name
    ' lpcbGroupName - [in/out] Max number of characters [to copy/copied] to the buffer
    ' lpszLabel - Optional buffer to receive field label
    ' lpcbLabel - [in/out] Max number of characters [to copy/copied] to the buffer
    ' lpdwType - Optional buffer to receive field type
    ' lpdwFlags - Optional buffer to receive field flags

    ' --------Miscellaneous functions---------------------------

    '   Get the SDK version number

    Declare Function CRTK_GetVersion Lib "cssdk32.dll" (ByRef lpdwMajor As Integer, ByRef lpdwMinor As Integer) As Integer
    ' lpdwMajor - buffer to receive major version number
    ' lpdwMinor - buffer to receive minor version number

    '   Translate an SDK error code into an error string

    Declare Function CRTK_GetErrorMessage Lib "cssdk32.dll" (ByVal dwErrorCode As Integer, ByVal lpszMsg As String, ByRef lpcbMsg As Integer, ByVal lpszRemedy As String, ByRef lpcbRemedy As Integer) As Integer
    ' dwErrorCode - the error code to decipher
    ' lpszMsg - buffer to receive the error message text
    ' lpcbMsg - size of buffer specified in lpszMsg
    ' lpszRemedy - buffer to recieve the suggested remedy text
    ' lpcbRemedy - size of buffer specified in lpszRemedy
End Module