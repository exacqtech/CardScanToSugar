Module CSSDK_API_ReturnCodes

    ' File: CSSdkErr.vb
    '
    ' Generated: 5/21/2004 11:05 AM
    '
    ' Copyright (c) 2004 Corex Technologies Corp., Cambridge, MA
    ' All rights reserved.

    Public Const CRTK_ERR_READ_ONLY_PARAM As Integer = -13

    ' Message text:    the specified parameter cannot be modified

    Public Const CRTK_ERR_BUFFER_TOO_SMALL As Integer = -12

    ' Message text:    the buffer passed to an SDK function isn't
    '                  large enough to accommodate the data

    Public Const CRTK_ERR_OLD_FILE As Integer = -11

    ' Message text:    the file was created by an older version
    '                  of CardScan
    '
    ' Message remedy:  Open the file in CardScan to convert it to
    '                  the current file format.

    Public Const CRTK_ERR_BAD_PASSWORD As Integer = -10

    ' Message text:    you did not supply the correct password

    Public Const CRTK_ERR_CANCELED As Integer = -9

    ' Message text:    the operation was canceled

    Public Const CRTK_ERR_INVALID_HWND As Integer = -8

    ' Message text:    an invalid window handle was passed to an
    '                  SDK function
    '
    ' Message remedy:  Compare the description of the function's
    '                  parameters in the SDK Developer's Guide against
    '                  your program.

    Public Const CRTK_ERR_BAD_POINTER As Integer = -7

    ' Message text:    an invalid pointer was passed to an SDK function
    '
    ' Message remedy:  Compare the description of the function's
    '                  parameters in the SDK Developer's Guide against
    '                  your program.

    Public Const CRTK_ERR_BAD_ARGUMENT As Integer = -6

    ' Message text:    an invalid or unexpected argument was passed
    '                  to an SDK function
    '
    ' Message remedy:  Compare the description of the function's
    '                  parameters in the SDK Developer's Guide against
    '                  your program.

    Public Const CRTK_ERR_EXPIRED As Integer = -5

    ' Message text:    the CardScan SDK license has expired
    '
    ' Message remedy:  Pre-release and beta versions of the CardScan
    '                  SDK are time-stamped to expired 60 days from
    '                  the release date. Contact Corex Technologies
    '                  to get a updated version of the CardScan
    '                  SDK.

    Public Const CRTK_ERR_BAD_FORMAT As Integer = -4

    ' Message text:    the image format passed to CRTK_ImageExport
    '                  is not recognized or not supported

    Public Const CRTK_ERR_NO_IMAGE As Integer = -3

    ' Message text:    there is no image in memory

    Public Const CRTK_ERR_BAD_HANDLE As Integer = -2

    ' Message text:    the RTK handle is not valid
    '
    ' Message remedy:  Verify that the call to CRTK_Init succeeded
    '                  and that you saved the correct handle.

    Public Const CRTK_SUCCESS As Integer = 1

    ' Message text:    the function completed successfully

    Public Const CRTK_YES As Integer = 2

    ' Message text:    the function completed successfully with
    '                  an affirmative result

    Public Const CRTK_NO As Integer = 3

    ' Message text:    the function completed successfully with
    '                  a negative result

    Public Const CRTK_NO_MORE_ITEMS As Integer = 4

    ' Message text:    there are no more values to enumerate

    Public Const CRTK_NO_TEXT As Integer = 5

    ' Message text:    there is no text for the specified field

    Public Const CRTK_NOT_FOUND As Integer = 6

    ' Message text:    the specified card or category was not found

    Public Const CRTK_ERR_ASSERT_FAILED As Integer = -1008

    ' Message text:    !AssertFailed

    Public Const CRTK_ERR_NOT_IMPLEMENTED As Integer = -1009

    ' Message text:    !NotImplemented

    Public Const CRTK_ERR_PURE_VIRTUAL_CALLED As Integer = -1010

    ' Message text:    !PureVirtualCalled

    Public Const CRTK_ERR_SYNTAX_ERROR As Integer = -1011

    ' Message text:    !SyntaxError

    Public Const CRTK_ERR_USER_CANCELED As Integer = -1012

    ' Message text:    the user canceled the operation

    Public Const CRTK_ERR_OBJECT_NOT_REGISTERED As Integer = -1013

    ' Message text:    !ObjectNotRegistered

    Public Const CRTK_ERR_OBJECT_REGISTRY_FULL As Integer = -1014

    ' Message text:    !ObjectRegistryFull

    Public Const CRTK_ERR_END_OF_STREAM As Integer = -1015

    ' Message text:    the input file ends unexpectedly

    Public Const CRTK_ERR_TOO_MANY_TASKS As Integer = -1016

    ' Message text:    !TooManyTasks

    Public Const CRTK_ERR_TASK_NOT_FOUND As Integer = -1017

    ' Message text:    !TaskNotFound

    Public Const CRTK_ERR_STRING_TOO_LONG As Integer = -1018

    ' Message text:    !StringTooLong

    Public Const CRTK_ERR_EX_NOT_ON_STACK As Integer = -1040

    ' Message text:    !ExNotOnStack

    Public Const CRTK_ERR_EX_OBJECT_TOO_LARGE As Integer = -1041

    ' Message text:    !ExObjectTooLarge

    Public Const CRTK_ERR_EX_OBJECT_NOT_FOUND As Integer = -1042

    ' Message text:    !ExObjectNotFound

    Public Const CRTK_ERR_EX_NOT_INITIALIZED As Integer = -1043

    ' Message text:    !ExNotInitialized

    Public Const CRTK_ERR_MEM_INVALID_PTR As Integer = -1056

    ' Message text:    !MemInvalidPtr

    Public Const CRTK_ERR_MEM_INVALID_HANDLE As Integer = -1057

    ' Message text:    !MemInvalidHandle

    Public Const CRTK_ERR_MEM_ALLOC_FAILED As Integer = -1058

    ' Message text:    there is insufficient memory
    '
    ' Message remedy:  Verify that you have sufficient disk space.

    Public Const CRTK_ERR_MEM_FREE_FAILED As Integer = -1059

    ' Message text:    !MemFreeFailed

    Public Const CRTK_ERR_MEM_RESIZE_FAILED As Integer = -1060

    ' Message text:    !MemResizeFailed

    Public Const CRTK_ERR_MEM_MOVE_FAILED As Integer = -1061

    ' Message text:    !MemMoveFailed

    Public Const CRTK_ERR_MEM_GET_SIZE_FAILED As Integer = -1062

    ' Message text:    !MemGetSizeFailed

    Public Const CRTK_ERR_MEM_BAD_HEAP_PTR As Integer = -1063

    ' Message text:    !MemBadHeapPtr

    Public Const CRTK_ERR_MEM_MULTIPLE_FREE As Integer = -1064

    ' Message text:    !MemMultipleFree

    Public Const CRTK_ERR_MEM_CANNOT_RESIZE As Integer = -1065

    ' Message text:    !MemCannotResize

    Public Const CRTK_ERR_MEM_INVALID_MOVE As Integer = -1066

    ' Message text:    !MemInvalidMove

    Public Const CRTK_ERR_MEM_VALIDATE_FAILED As Integer = -1067

    ' Message text:    !MemValidateFailed

    Public Const CRTK_ERR_MEM_GLOBAL_LOCK_FAILED As Integer = -1068

    ' Message text:    !MemGlobalLockFailed

    Public Const CRTK_ERR_MEM_TOO_BIG As Integer = -1069

    ' Message text:    the required block of memory exceeds 64K
    '                  bytes

    Public Const CRTK_ERR_FORMAT_INVALID_DEST As Integer = -1072

    ' Message text:    !FormatInvalidDest

    Public Const CRTK_ERR_FORMAT_INVALID_FMT As Integer = -1073

    ' Message text:    !FormatInvalidFmt

    Public Const CRTK_ERR_FORMAT_BUFFER_OVERFLOW As Integer = -1074

    ' Message text:    there is insufficient internal buffer space

    Public Const CRTK_ERR_FORMAT_ARG_OVERFLOW As Integer = -1075

    ' Message text:    !FormatArgOverflow

    Public Const CRTK_ERR_FILE_OPEN_FAILED As Integer = -1088

    ' Message text:    !FileOpenFailed

    Public Const CRTK_ERR_FILE_CLOSE_FAILED As Integer = -1089

    ' Message text:    !FileCloseFailed

    Public Const CRTK_ERR_FILE_SEEK_FAILED As Integer = -1090

    ' Message text:    !FileSeekFailed

    Public Const CRTK_ERR_FILE_RESIZE_FAILED As Integer = -1091

    ' Message text:    !FileResizeFailed

    Public Const CRTK_ERR_FILE_READ_FAILED As Integer = -1092

    ' Message text:    an error occurred while reading from the
    '                  file

    Public Const CRTK_ERR_FILE_WRITE_FAILED As Integer = -1093

    ' Message text:    an error occurred while writing to the file

    Public Const CRTK_ERR_FILE_LOCK_FAILED As Integer = -1094

    ' Message text:    !FileLockFailed

    Public Const CRTK_ERR_FILE_UNLOCK_FAILED As Integer = -1095

    ' Message text:    !FileUnlockFailed

    Public Const CRTK_ERR_FILE_TYPE_UNKNOWN As Integer = -1096

    ' Message text:    the file does not match any recognized formats

    Public Const CRTK_ERR_FILE_NOT_DIRECTORY As Integer = -1097

    ' Message text:    the directory does not exist

    Public Const CRTK_ERR_FILE_UNIQUE_FAILED As Integer = -1098

    ' Message text:    a unique file name could not be generated

    Public Const CRTK_ERR_FILE_NO_SUCH_VOLUME As Integer = -1099

    ' Message text:    the device does not exist

    Public Const CRTK_ERR_FILE_CREATE_DIR_FAILED As Integer = -1100

    ' Message text:    the directory could not be created

    Public Const CRTK_ERR_FILE_RENAME_FAILED As Integer = -1101

    ' Message text:    the file cannot be renamed to a different
    '                  device

    Public Const CRTK_ERR_FILE_DELETE_FAILED As Integer = -1102

    ' Message text:    the file could not be deleted

    Public Const CRTK_ERR_FILE_DELETE_DIR_FAILED As Integer = -1103

    ' Message text:    the directory could not be deleted

    Public Const CRTK_ERR_FILE_INVALID_NAME As Integer = -1104

    ' Message text:    the file name is not valid

    Public Const CRTK_ERR_FILE_NAME_TOO_LONG As Integer = -1105

    ' Message text:    the file name or path is too long

    Public Const CRTK_ERR_FILE_ACCESS_DENIED As Integer = -1106

    ' Message text:    the file is locked or otherwise inaccessible
    '
    ' Message remedy:  Either you don't have permission to modify
    '                  this file, another person is using the file,
    '                  or the device is not ready.

    Public Const CRTK_ERR_FILE_DEADLOCK As Integer = -1108

    ' Message text:    the file cannot be locked

    Public Const CRTK_ERR_FILE_ALREADY_EXISTS As Integer = -1109

    ' Message text:    the file already exists

    Public Const CRTK_ERR_FILE_TOO_MANY_OPEN As Integer = -1111

    ' Message text:    no more file handles are available
    '
    ' Message remedy:  Restart <*appname>, close some applications
    '                  and try again

    Public Const CRTK_ERR_FILE_DOES_NOT_EXIST As Integer = -1112

    ' Message text:    the specified file cannot be found

    Public Const CRTK_ERR_FILE_DEVICE_FULL As Integer = -1113

    ' Message text:    there is insufficient free space on the device

    Public Const CRTK_ERR_FILE_UNKNOWN_ERROR As Integer = -1114

    ' Message text:    an unrecognized file error occurred

    Public Const CRTK_ERR_FILE_FIND_FIRST_FAILED As Integer = -1115

    ' Message text:    an error occurred while trying to retrieve
    '                  information about the file

    Public Const CRTK_ERR_ARCHIVE_BAD_STREAM As Integer = -1120

    ' Message text:    !ArchiveBadStream

    Public Const CRTK_ERR_ARCHIVE_WRONG_VERSION As Integer = -1121

    ' Message text:    !ArchiveWrongVersion

    Public Const CRTK_ERR_FILE_SET_NOT_VALID As Integer = -1122

    ' Message text:    the file is not a <*appname> backup file

    Public Const CRTK_ERR_FILE_SET_WRONG_VERSION As Integer = -1123

    ' Message text:    the file was created by an incompatible version
    '                  of <*appname>

    Public Const CRTK_ERR_FILE_SET_WRONG_FILE As Integer = -1124

    ' Message text:    the wrong file was found

    Public Const CRTK_ERR_RESOURCE_NOT_FOUND As Integer = -1136

    ' Message text:    a required resource was not found
    '
    ' Message remedy:  The system may be low on memory. Close some
    '                  applications and try again.

    Public Const CRTK_ERR_RESOURCE_LOAD_FAILED As Integer = -1137

    ' Message text:    a required resource could not be loaded
    '
    ' Message remedy:  The system may be low on memory. Close some
    '                  applications and try again.

    Public Const CRTK_ERR_RESOURCE_LOCK_FAILED As Integer = -1138

    ' Message text:    a required resource could not be locked
    '
    ' Message remedy:  The system may be low on memory. Close some
    '                  applications and try again.

    Public Const CRTK_ERR_RESOURCE_FREE_FAILED As Integer = -1139

    ' Message text:    !ResourceFreeFailed

    Public Const CRTK_ERR_LIB_LOAD_FAILED As Integer = -1152

    ' Message text:    a required library file could not be loaded

    Public Const CRTK_ERR_LIB_FILE_NOT_FOUND As Integer = -1153

    ' Message text:    a required library file was not found

    Public Const CRTK_ERR_LIB_NO_MEMORY As Integer = -1155

    ' Message text:    there is insufficient memory to load a required
    '                  library file
    '
    ' Message remedy:  Verify that you have sufficient disk space.

    Public Const CRTK_ERR_LIB_BUSY As Integer = -1156

    ' Message text:    a required library file could not be loaded
    '                  due to a sharing or network protection error

    Public Const CRTK_ERR_LIBOS_MISMATCH As Integer = -1157

    ' Message text:    a required library file was designed for
    '                  a different operating system

    Public Const CRTK_ERR_LIB_VERSION_MISMATCH As Integer = -1158

    ' Message text:    a required library file was designed for
    '                  a different operating system version

    Public Const CRTK_ERR_LIB_INCOMPATIBLE As Integer = -1159

    ' Message text:    a required library file is corrupt or invalid

    Public Const CRTK_ERR_LIB_LAUNCH_FAILED As Integer = -1160

    ' Message text:    the program could not be started

    Public Const CRTK_ERR_LIB_NO_PROGRAM As Integer = -1161

    ' Message text:    an associated program could not be located

    Public Const CRTK_ERR_LIB_PROCEDURE_NOT_FOUND As Integer = -1162

    ' Message text:    !LibProcedureNotFound

    Public Const CRTK_ERR_COMM_NO_SUCH_DEVICE As Integer = -1168

    ' Message text:    the communications port does not exist

    Public Const CRTK_ERR_COMM_BAUD_RATE As Integer = -1169

    ' Message text:    the comm device's baud rate is not supported

    Public Const CRTK_ERR_COMM_BYTE_SIZE As Integer = -1170

    ' Message text:    !CommByteSize

    Public Const CRTK_ERR_COMM_DEVICE_IN_USE As Integer = -1171

    ' Message text:    the communications port is not available
    '                  or in use
    '
    ' Message remedy:  Check that the correct communications port
    '                  is selected and close any applications using
    '                  the same device.

    Public Const CRTK_ERR_COMM_NO_MEMORY As Integer = -1172

    ' Message text:    there is insufficient memory
    '
    ' Message remedy:  Verify that you have sufficient disk space.

    Public Const CRTK_ERR_COMM_NOT_OPEN As Integer = -1173

    ' Message text:    !CommNotOpen

    Public Const CRTK_ERR_COMM_ALREADY_OPEN As Integer = -1174

    ' Message text:    the communications port is not available
    '                  or in use
    '
    ' Message remedy:  Check that the correct communications port
    '                  is selected and close any applications using
    '                  the same device.

    Public Const CRTK_ERR_COMM_TIME_OUT As Integer = -1175

    ' Message text:    the communications driver has timed out

    Public Const CRTK_ERR_COMM_INTERNAL_ERROR As Integer = -1176

    ' Message text:    !CommInternalError

    Public Const CRTK_ERR_PROCESS_CREATE_THREAD_FAILED As Integer = -1184

    ' Message text:    !ProcessCreateThreadFailed

    Public Const CRTK_ERR_PROCESS_GET_THREAD_CONTEXT_FAILED As Integer = -1185

    ' Message text:    !ProcessGetThreadContextFailed

    Public Const CRTK_ERR_PROCESS_VIRTUAL_QUERY_FAILED As Integer = -1186

    ' Message text:    !ProcessVirtualQueryFailed

    Public Const CRTK_ERR_PROCESS_WRITE_MEMORY_FAILED As Integer = -1187

    ' Message text:    !ProcessWriteMemoryFailed

    Public Const CRTK_ERR_PROCESS_READ_MEMORY_FAILED As Integer = -1188

    ' Message text:    !ProcessReadMemoryFailed

    Public Const CRTK_ERR_PROCESS_RESUME_THREAD_FAILED As Integer = -1189

    ' Message text:    !ProcessResumeThreadFailed

    Public Const CRTK_ERR_PROCESS_VIRTUAL_PROTECT_FAILED As Integer = -1190

    ' Message text:    !ProcessVirtualProtectFailed

    Public Const CRTK_ERR_THREAD_CREATE_FAILED As Integer = -1191

    ' Message text:    !ThreadCreateFailed

    Public Const CRTK_ERR_THREAD_SUSPEND_FAILED As Integer = -1192

    ' Message text:    !ThreadSuspendFailed

    Public Const CRTK_ERR_THREAD_RESUME_FAILED As Integer = -1193

    ' Message text:    !ThreadResumeFailed

    Public Const CRTK_ERR_EVENT_CREATE_FAILED As Integer = -1194

    ' Message text:    !EventCreateFailed

    Public Const CRTK_ERR_IMPORT_BINARY_FILE As Integer = -1195

    ' Message text:    the file is not a text file
    '
    ' Message remedy:  <*appname> can only import cards from a comma
    '                  or tab-delimited text file.

    Public Const CRTK_ERR_DB_ENTITY_NOT_FOUND As Integer = -2000

    ' Message text:    !DBEntityNotFound

    Public Const CRTK_ERR_DB_ENTITY_LOCKED As Integer = -2001

    ' Message text:    !DBEntityLocked

    Public Const CRTK_ERR_DB_LOCK_MISMATCH As Integer = -2002

    ' Message text:    !DBLockMismatch

    Public Const CRTK_ERR_DB_DUPLICATEEID As Integer = -2003

    ' Message text:    !DBDuplicateEID

    Public Const CRTK_ERR_DB_BAD_SIGNATURE As Integer = -2004

    ' Message text:    the file is corrupt or invalid

    Public Const CRTK_ERR_DB_VERSION_MISMATCH As Integer = -2005

    ' Message text:    the file contains information created by
    '                  a newer, incompatible version of <*appname>

    Public Const CRTK_ERR_DB_DUPLICATE_KEY As Integer = -2006

    ' Message text:    !DBDuplicateKey

    Public Const CRTK_ERR_DB_PAGE_NOT_FOUND As Integer = -2007

    ' Message text:    !DBPageNotFound

    Public Const CRTK_ERR_DB_PAGE_FREED As Integer = -2008

    ' Message text:    !DBPageFreed

    Public Const CRTK_ERR_DB_NOTA_DATABASE As Integer = -2009

    ' Message text:    the file is not a <*appname> file

    Public Const CRTK_ERR_DB_OVERFLOW_EXHAUSTED As Integer = -2010

    ' Message text:    the temporary file <*appname> must create
    '                  is too large
    '
    ' Message remedy:  Select fewer cards and try again.

    Public Const CRTK_ERR_DB_FILE_LOCKED As Integer = -2011

    ' Message text:    another user is updating the file
    '
    ' Message remedy:  Try again in a few minutes.

    Public Const CRTK_ERR_DB_FILE_CHANGED As Integer = -2012

    ' Message text:    !DBFileChanged

    Public Const CRTK_ERR_DB_CANT_REOPEN_LOCKED_FILE As Integer = -2013

    ' Message text:    !DBCantReopenLockedFile

    Public Const CRTK_ERR_DB_WRONG_ENTITY_TYPE As Integer = -2014

    ' Message text:    !DBWrongEntityType

    Public Const CRTK_ERR_STG_NO_MORE_FILES As Integer = -2128

    ' Message text:    too many files are already open

    Public Const CRTK_ERR_STG_DISK_IS_WRITE_PROTECTED As Integer = -2129

    ' Message text:    the disk is write protected

    Public Const CRTK_ERR_STG_LOCK_VIOLATION As Integer = -2130

    ' Message text:    the file is locked by another user or application

    Public Const CRTK_ERR_STG_ABNORMAL_API_EXIT As Integer = -2131

    ' Message text:    !StgAbnormalApiExit

    Public Const CRTK_ERR_STG_INVALID_HEADER As Integer = -2132

    ' Message text:    !StgInvalidHeader

    Public Const CRTK_ERR_STG_UNIMPLEMENTED_FUNCTION As Integer = -2133

    ' Message text:    !StgUnimplementedFunction

    Public Const CRTK_ERR_STG_IN_USE As Integer = -2134

    ' Message text:    !StgInUse

    Public Const CRTK_ERR_STG_NOT_CURRENT As Integer = -2135

    ' Message text:    the file has been changed by another user
    '                  or application

    Public Const CRTK_ERR_STG_REVERTED As Integer = -2136

    ' Message text:    !StgReverted

    Public Const CRTK_ERR_STG_CANT_SAVE As Integer = -2137

    ' Message text:    the data can't be saved for unknown reasons
    '                  other than insufficient access or space

    Public Const CRTK_ERR_STG_OLD_FORMAT As Integer = -2138

    ' Message text:    !StgOldFormat

    Public Const CRTK_ERR_STG_OLDDLL As Integer = -2139

    ' Message text:    !StgOldDLL

    Public Const CRTK_ERR_STG_SHARE_REQUIRED As Integer = -2140

    ' Message text:    !StgShareRequired

    Public Const CRTK_ERR_STG_INTERNAL_ERROR As Integer = -2141

    ' Message text:    !StgInternalError

    Public Const CRTK_ERR_STG_UNKNOWN_ERROR As Integer = -2142

    ' Message text:    !StgUnknownError

    Public Const CRTK_ERR_MENU_DUPLICATE_CMD As Integer = -3000

    ' Message text:    !MenuDuplicateCmd

    Public Const CRTK_ERR_MENU_CREATE_FAILED As Integer = -3001

    ' Message text:    Windows failed to create a popup menu

    Public Const CRTK_ERR_CO_VERSION_MISMATCH As Integer = -3002

    ' Message text:    incompatible versions of the OLE library
    '                  files are installed

    Public Const CRTK_ERR_CO_INIT_FAILED As Integer = -3003

    ' Message text:    the OLE component object library could not
    '                  be initialized

    Public Const CRTK_ERR_VIEW_NOT_FOUND As Integer = -3010

    ' Message text:    !ViewNotFound

    Public Const CRTK_ERR_VIEW_CONSTRUCTOR_TABLE_FULL As Integer = -3011

    ' Message text:    !ViewConstructorTableFull

    Public Const CRTK_ERR_VIEW_CONSTRUCTOR_NOT_FOUND As Integer = -3012

    ' Message text:    !ViewConstructorNotFound

    Public Const CRTK_ERR_VIEW_PARAMS_NOT_FOUND As Integer = -3013

    ' Message text:    !ViewParamsNotFound

    Public Const CRTK_ERR_VIEW_WRONG_VIEW_TYPE As Integer = -3014

    ' Message text:    !ViewWrongViewType

    Public Const CRTK_ERR_WINDOW_REGISTER_FAILED As Integer = -3020

    ' Message text:    a error occurred registering the window class

    Public Const CRTK_ERR_WINDOW_CREATE_FAILED As Integer = -3021

    ' Message text:    the window could not be created

    Public Const CRTK_ERR_GDI_FAILED As Integer = -3030

    ' Message text:    Windows is low on memory for shared application
    '                  resources

    Public Const CRTK_ERR_DLG_UNKNOWN_BUTTON_STYLE As Integer = -3040

    ' Message text:    !DlgUnknownButtonStyle

    Public Const CRTK_ERR_DLG_UNKNOWN_CONTROL_CLASS As Integer = -3041

    ' Message text:    !DlgUnknownControlClass

    Public Const CRTK_ERR_PRINT_INIT_FAILED As Integer = -3050

    ' Message text:    an error occurred initializing the printer
    '                  driver

    Public Const CRTK_ERR_PRINT_NO_DEFAULT As Integer = -3051

    ' Message text:    there is no default printer

    Public Const CRTK_ERR_PRINT_INTERNAL_ERROR As Integer = -3052

    ' Message text:    !PrintInternalError

    Public Const CRTK_ERR_PRINT_NO_DEVICES As Integer = -3053

    ' Message text:    no printer devices were found

    Public Const CRTK_ERR_PRINT_PARSE_FAILED As Integer = -3054

    ' Message text:    Windows cannot parse the strings in the [devices]
    '                  section of the WIN.INI file

    Public Const CRTK_ERR_PRINT_DEVICE_NOT_FOUND As Integer = -3055

    ' Message text:    the [devices] section of the WIN.INI file
    '                  does not contain an entry for the requested
    '                  printer

    Public Const CRTK_ERR_PRINT_NOT_DEFAULT As Integer = -3056

    ' Message text:    !PrintNotDefault

    Public Const CRTK_ERR_PRINT_CREATEDC_FAILED As Integer = -3057

    ' Message text:    the printer device context cannot be created

    Public Const CRTK_ERR_PRINT_CREATEIC_FAILED As Integer = -3058

    ' Message text:    the printer information context cannot be
    '                  created

    Public Const CRTK_ERR_PRINT_LOAD_FAILED As Integer = -3059

    ' Message text:    the device driver for the specified printer
    '                  could not be loaded

    Public Const CRTK_ERR_COMM_DLG_LOAD_FAILED As Integer = -3060

    ' Message text:    the Windows common dialog could not be loaded

    Public Const CRTK_ERR_COMM_DLG_INIT_FAILED As Integer = -3061

    ' Message text:    an error occurred initializing the Windows
    '                  common dialog

    Public Const CRTK_ERR_COMM_DLG_INTERNAL_ERROR As Integer = -3062

    ' Message text:    !CommDlgInternalError

    Public Const CRTK_ERR_COMM_DLG_UNKNOWN_ERROR As Integer = -3063

    ' Message text:    an unexpected error occurred communicating
    '                  with the Windows common dialog

    Public Const CRTK_ERR_HELP_LOAD_FAILED As Integer = -3070

    ' Message text:    the Windows help program failed to launch
    '
    ' Message remedy:  Windows may be low on memory. Quit one or
    '                  more applications to increase available memory,
    '                  and then try again.

    Public Const CRTK_ERR_HELP_FILE_NOT_FOUND As Integer = -3071

    ' Message text:    the help file could not be found
    '
    ' Message remedy:  Reinstall <*appname> and try again.

    Public Const CRTK_ERR_LB_INSERT_FAILED As Integer = -3072

    ' Message text:    there are more items than can be displayed
    '                  in the list box

    Public Const CRTK_ERR_CLIPBOARD_BUSY As Integer = -3073

    ' Message text:    another application or window has the clipboard
    '                  open

    Public Const CRTK_ERR_CLIPBOARD_SET_DATA_FAILED As Integer = -3074

    ' Message text:    an error occurred copying data to the clipboard
    '
    ' Message remedy:  Windows may be low on memory. Quit one or
    '                  more applications to increase available memory,
    '                  and then try again.

    Public Const CRTK_ERR_CLIPBOARD_REGISTER_FAILED As Integer = -3075

    ' Message text:    !ClipboardRegisterFailed

    Public Const CRTK_ERR_TIME_LOCK_FILE_NOT_FOUND As Integer = -3080

    ' Message text:    the Trial session file cannot be found
    '
    ' Message remedy:  Reinstall <*appname> from the original media
    '                  and try again.

    Public Const CRTK_ERR_TIME_LOCK_FILE_READ_FAILED As Integer = -3082

    ' Message text:    an error occurred while reading the Trial
    '                  session file
    '
    ' Message remedy:  The Trial session file may have corrupted
    '                  or damaged. Reinstall <*appname> from the
    '                  original media and try again.

    Public Const CRTK_ERR_TIME_LOCK_NO_ACCESS_YET As Integer = -3083

    ' Message text:    !TimeLockNoAccessYet

    Public Const CRTK_ERR_TIME_LOCK_WRONG_VERSION As Integer = -3084

    ' Message text:    !TimeLockWrongVersion

    Public Const CRTK_ERR_TIME_LOCK_UNKNOWN_ERROR As Integer = -3085

    ' Message text:    an unexpected error has occurred while validating
    '                  the Trial license

    Public Const CRTK_ERR_ENUM_FORMATS_FAILED As Integer = -3087

    ' Message text:    !EnumFormatsFailed

    Public Const CRTK_ERR_BROWSE_NO_WEB_BROWSER As Integer = -3088

    ' Message text:    there is no browser registered with Windows

    Public Const CRTK_ERR_BROWSEURL_TOO_LONG As Integer = -3089

    ' Message text:    the Web page address is too long

    Public Const CRTK_ERR_TAPI_NO_DEVICES As Integer = -4000

    ' Message text:    there are no telephony devices installed
    '
    ' Message remedy:  Check the settings in the Modem control panel
    '                  and try again.

    Public Const CRTK_ERR_TAPI_MULTIPLE_DRIVERS As Integer = -4001

    ' Message text:    there are multiple drivers for the specified
    '                  device (remove one)

    Public Const CRTK_ERR_TAPI_NO_MEM As Integer = -4002

    ' Message text:    there is not enough memory

    Public Const CRTK_ERR_TAPI_IN_USE As Integer = -4003

    ' Message text:    a call is already being handled

    Public Const CRTK_ERR_TAPI_NO_PHONE_NUMBER As Integer = -4004

    ' Message text:    there is no phone number specified

    Public Const CRTK_ERR_TAPI_BAD_INI_FILE As Integer = -4005

    ' Message text:    some settings are invalid
    '
    ' Message remedy:  Check the settings in Dial Properties and
    '                  try again.

    Public Const CRTK_ERR_TAPI_LINE_IN_USE As Integer = -4006

    ' Message text:    the line is already in use by a non-TAPI
    '                  application or another TAPI Service Provider

    Public Const CRTK_ERR_TAPI_CANNOT_CALL As Integer = -4007

    ' Message text:    the phone line is not available
    '
    ' Message remedy:  Make sure the phone line and modem are connected,
    '                  and are not being used by another application,
    '                  and that the modem is turned on.

    Public Const CRTK_ERR_TAPI_DEVICE_UNAVAILABLE As Integer = -4008

    ' Message text:    the specified device is not available
    '
    ' Message remedy:  Make sure the phone line and modem are connected,
    '                  and are not being used by another application,
    '                  and that the modem is turned on.

    Public Const CRTK_ERR_TAPI_BAD_ADDRESS As Integer = -4009

    ' Message text:    the phone number format is invalid

    Public Const CRTK_ERR_TAPI_FAILED As Integer = -4010

    ' Message text:    TAPI reported a fatal error
    '
    ' Message remedy:  Make sure the phone line and modem are connected,
    '                  and are not being used by another application,
    '                  and that the modem is turned on.

    Public Const CRTK_ERR_TAPI_UNKNOWN_ERROR As Integer = -4011

    ' Message text:    TAPI reported an unknown error

    Public Const CRTK_ERR_TAPI_NOT_INSTALLED As Integer = -4012

    ' Message text:    the Telephony API library (TAPI32.DLL) is
    '                  not installed

    Public Const CRTK_ERR_REMOTE_CONTROL_INVALID_COMMAND As Integer = -4013

    ' Message text:    !RemoteControlInvalidCommand

    Public Const CRTK_ERR_REMOTE_CONTROL_INVALID_URL As Integer = -4014

    ' Message text:    !RemoteControlInvalidUrl

    Public Const CRTK_ERR_PLUG_IN_NOT_FOUND As Integer = -4500

    ' Message text:    <*appname> could not find the plug-in module

    Public Const CRTK_ERR_PLUG_IN_WRONG_VERSION As Integer = -4501

    ' Message text:    the plug-in module is not compatible with
    '                  this version of <*appname>

    Public Const CRTK_ERR_PLUG_IN_NOT_ENABLED As Integer = -4502

    ' Message text:    the plug-in module is not enabled

    Public Const CRTK_ERR_PLUG_IN_MISMATCH As Integer = -4503

    ' Message text:    !PlugInMismatch

    Public Const CRTK_ERR_PLUG_IN_NOT_VALID As Integer = -4504

    ' Message text:    the library is not a <*appname> plug-in

    Public Const CRTK_ERR_PROXY_NOT_IMPLEMENTED As Integer = -4505

    ' Message text:    <*appname> could not find the requested application's
    '                  installation
    '
    ' Message remedy:  Reinstall the requested application and try
    '                  again.

    Public Const CRTK_ERR_PROXY_NO_DESCRIPTOR As Integer = -4506

    ' Message text:    the requested library information could not
    '                  be found

    Public Const CRTK_ERR_SCAN_INTERNAL_ERROR As Integer = -5000

    ' Message text:    !ScanInternalError

    Public Const CRTK_ERR_SCAN_TIMEOUT As Integer = -5001

    ' Message text:    communication with the scanner timed out
    '
    ' Message remedy:  Either you did not insert a card or there
    '                  is a hardware conflict.

    Public Const CRTK_ERR_SCAN_UNKNOWN_ERROR As Integer = -5002

    ' Message text:    the scanner's driver returned an unexpected
    '                  error

    Public Const CRTK_ERR_SCAN_NO_SOURCES As Integer = -5003

    ' Message text:    no scanner drivers are installed
    '
    ' Message remedy:  Check that you selected the correct scanner
    '                  and that the scanner's hardware and software
    '                  are properly installed.

    Public Const CRTK_ERR_SCAN_SOURCE_NOT_FOUND As Integer = -5004

    ' Message text:    the scanner's driver could not be located
    '
    ' Message remedy:  Check that you selected the correct scanner
    '                  and that the scanner's hardware and software
    '                  are properly installed.

    Public Const CRTK_ERR_BCR_NOT_FOUND As Integer = -5005

    ' Message text:    the scanner is not responding
    '
    ' Message remedy:  Check that the correct port is selected and
    '                  the scanner's cable and power supply are
    '                  properly installed.

    Public Const CRTK_ERR_BCR_NO_DATA As Integer = -5006

    ' Message text:    communication with the scanner timed out
    '
    ' Message remedy:  Remove the card and try a different one.
    '                  If the problem persists, check that you selected
    '                  the correct scanner.

    Public Const CRTK_ERR_BCR_NO_CARD As Integer = -5007

    ' Message text:    you did not insert a card into the scanner

    Public Const CRTK_ERR_BCR_CARD_STUCK As Integer = -5008

    ' Message text:    the card hasn't passed through the scanner

    Public Const CRTK_ERR_LPT_DRIVER_OPEN_FAILED As Integer = -5009

    ' Message text:    the scanner's device driver cannot be located
    '
    ' Message remedy:  Reinstall the driver from the <*appname>
    '                  diskettes and try again.

    Public Const CRTK_ERR_LPT_VXD_NOT_FOUND As Integer = -5012

    ' Message text:    a required device driver VxD file cannot
    '                  be located
    '
    ' Message remedy:  Reinstall the driver from the <*appname>
    '                  diskettes and try again.

    Public Const CRTK_ERR_LPT_PORT_IN_USE As Integer = -5013

    ' Message text:    the printer port is in use by another process
    '
    ' Message remedy:  Close any other programs that might be using
    '                  the printer port and try again.

    Public Const CRTK_ERR_LPT_PORT_NOT_FOUND As Integer = -5014

    ' Message text:    <*appname> could not locate the printer port
    '
    ' Message remedy:  Check that you selected the correct printer
    '                  port and that the port is installed and configured
    '                  correctly.

    Public Const CRTK_ERR_LPT_PORT_OPEN_FAILED As Integer = -5015

    ' Message text:    <*appname> could not open the printer port
    '
    ' Message remedy:  Check that you selected the correct printer
    '                  port and that the port is installed and configured
    '                  correctly.

    Public Const CRTK_ERR_LPT_HARDWARE_ERROR As Integer = -5016

    ' Message text:    an error occurred while communicating with
    '                  the printer port
    '
    ' Message remedy:  Check that you selected the correct printer
    '                  port and that the port is installed and configured
    '                  correctly.

    Public Const CRTK_ERR_LPT_INVALID_PORT_MODE As Integer = -5017

    ' Message text:    !LPTInvalidPortMode

    Public Const CRTK_ERR_IMG_TOO_MANY_COLORS As Integer = -7000

    ' Message text:    the image contains too many colors
    '
    ' Message remedy:  Set your scanner to scan 256-grayscale or
    '                  black and white (also called line-art) images.

    Public Const CRTK_ERR_IMG_TOO_FEW_COLORS As Integer = -7001

    ' Message text:    the image must be black and white or 256-level
    '                  grayscale
    '
    ' Message remedy:  Set your scanner to scan 256-grayscale or
    '                  black and white (also called line-art) images.

    Public Const CRTK_ERR_IMG_NOT_GRAY_SCALE As Integer = -7002

    ' Message text:    the image does not contain a monochrome palette
    '
    ' Message remedy:  Set your scanner to scan 256-grayscale or
    '                  black and white (also called line-art) images.

    Public Const CRTK_ERR_IMG_INVALID_BITMAP As Integer = -7003

    ' Message text:    the image contains an invalid header

    Public Const CRTK_ERR_IMG_INVALIDPCX As Integer = -7004

    ' Message text:    the PCX image header is not valid

    Public Const CRTK_ERR_IMGPCX_NOTBW As Integer = -7005

    ' Message text:    only black and white PCX images are supported

    Public Const CRTK_ERR_IMG_NOTPICT As Integer = -7006

    ' Message text:    only PICT images are supported

    Public Const CRTK_ERR_IMG_TOO_BIG As Integer = -7007

    ' Message text:    the image is too large or too complex
    '
    ' Message remedy:  Select a smaller image or lower the scanner
    '                  resolution (dpi).

    Public Const CRTK_ERR_IMG_CROP_FAILED As Integer = -7008

    ' Message text:    the text cannot be distinguished from the
    '                  background of this card. This image will
    '                  be discarded. Continuing with other images
    '                  (if any)

    Public Const CRTK_ERR_IMG_INVALIDJPEG_QUALITY_FACTOR As Integer = -7009

    ' Message text:    !IMGInvalidJPEGQualityFactor

    Public Const CRTK_ERR_IMG_TOO_FEW_COLORS_FORJPEG As Integer = -7010

    ' Message text:    !IMGTooFewColorsForJPEG

    Public Const CRTK_ERR_IMG_REQUIRESLEAD_TOOLS As Integer = -7014

    ' Message text:    the LEADTools image processing software is
    '                  not installed

    Public Const CRTK_ERR_IMG_UNSUPPORTED_FORMAT As Integer = -7015

    ' Message text:    the image format is not supported

    Public Const CRTK_ERR_OCR_ERROR As Integer = -7500

    ' Message text:    an error occurred inside the character recognition
    '                  library

    Public Const CRTK_ERR_OCR_NO_MEMORY As Integer = -7501

    ' Message text:    there is not enough memory to run character
    '                  recognition
    '
    ' Message remedy:  <*appname> requires 1Mb for character recognition.
    '                  Close some applications and try again.

    Public Const CRTK_ERR_OCR_IMAGE_TOO_LARGE As Integer = -7502

    ' Message text:    the image is too large or too complicated
    '
    ' Message remedy:  Try recognizing a smaller part of the image.

    Public Const CRTK_ERR_OCR_BAD_IMAGE As Integer = -7503

    ' Message text:    the image is damaged

    Public Const CRTK_ERR_OCR_EMPTY_PAGE As Integer = -7504

    ' Message text:    the page is blank or contains too few letters

    Public Const CRTK_ERR_OCR_ENGINE_ERROR As Integer = -7505

    ' Message text:    an error occurred inside the character recognition
    '                  engine

    Public Const CRTK_ERR_OCR_FILE_WRITE_ERROR As Integer = -7506

    ' Message text:    an error occurred writing the temporary file
    '
    ' Message remedy:  Check your hard disk for available space
    '                  and the absence of defects.

    Public Const CRTK_ERR_OCR_FILE_READ_ERROR As Integer = -7507

    ' Message text:    an error occurred reading the temporary file
    '
    ' Message remedy:  Check your hard disk for available space
    '                  and the absence of defects.

    Public Const CRTK_ERR_OCR_PATH_TOO_LONG As Integer = -7508

    ' Message text:    the path to the OCR engine files is too long

    Public Const CRTK_ERR_OCR_LOAD_FAILED As Integer = -7509

    ' Message text:    an error occurred loading the OCR interface
    '                  library

    Public Const CRTK_ERR_OCR_PARSE_FAILED As Integer = -7510

    ' Message text:    the image is too large or too complicated
    '
    ' Message remedy:  Try scanning the image again. If this problem
    '                  persists contact Technical Support.

    Public Const CRTK_ERR_OCR_WRONG_VERSION As Integer = -7512

    ' Message text:    an incompatible version of the OCR engine
    '                  is installed

    Public Const CRTK_ERR_OCR_TERM_NOT_CALLED As Integer = -7513

    ' Message text:    the OCR engine failed to initialize
    '
    ' Message remedy:  <*appname> probably exited abnormally. Shutdown
    '                  and restart Windows then try again.

    Public Const CRTK_ERR_CDB_NOTA_DATABASE As Integer = -8000

    ' Message text:    the file is not a <*appname> file

    Public Const CRTK_ERR_CDB_WRONG_VERSION As Integer = -8001

    ' Message text:    the file was created or modified by a newer
    '                  version of <*appname>

    Public Const CRTK_ERR_CDB_CAT_FAILED As Integer = -8002

    ' Message text:    !CDBCatFailed

    Public Const CRTK_ERR_CDB_CARD_NOT_FOUND As Integer = -8003

    ' Message text:    one or more of the selected cards was deleted
    '                  by another user

    Public Const CRTK_ERR_CDB_IMAGE_NOT_FOUND As Integer = -8004

    ' Message text:    one or more of the selected images was deleted
    '                  by another user

    Public Const CRTK_ERR_CDB_TOO_MANY_LABELS As Integer = -8005

    ' Message text:    there are too many custom labels in the file
    '
    ' Message remedy:  To define a new phone or email label, you
    '                  must delete an existing one first.

    Public Const CRTK_ERR_CDB_LABEL_RESERVED As Integer = -8006

    ' Message text:    you cannot create a phone or email label
    '                  with the same name as one of <*appname>'s
    '                  pre-defined fields

    Public Const CRTK_ERR_CDB_CANT_SET_LABEL As Integer = -8007

    ' Message text:    you cannot change the label for <*appname>'s
    '                  pre-defined fields

    Public Const CRTK_ERR_CDB_INVALID_LABEL_NAME As Integer = -8008

    ' Message text:    a label name cannot include any of these
    '                  special characters: - ; . , [ ] _ $ or "

    Public Const CRTK_ERR_CDB_INVALID_GROUP_NAME As Integer = -8009

    ' Message text:    a category name cannot include any of these
    '                  special characters: , or "

    Public Const CRTK_ERR_CDB_CANT_SET_READ_ONLY_FIELD As Integer = -8010

    ' Message text:    the specified field cannot be modified

    Public Const CRTK_ERR_CDB_DESCRIPTOR_UNRESOLVED As Integer = -8011

    ' Message text:    !CDBDescriptorUnresolved

    Public Const CRTK_ERR_CDB_GROUP_NOT_FOUND As Integer = -8012

    ' Message text:    one or more of the selected categories was
    '                  deleted by another user

    Public Const CRTK_ERR_CDB_GROUP_ALREADY_EXISTS As Integer = -8013

    ' Message text:    a category with the same name already exists

End Module