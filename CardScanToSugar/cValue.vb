Public Class cValue
    Private sDisplay As String
    Private sValue As String
    Public Property Display() As String
        Get
            Return Me.sDisplay
        End Get
        Set(ByVal value As String)
            Me.sDisplay = value
        End Set
    End Property
    Public Property Value() As String
        Get
            Return Me.sValue
        End Get
        Set(ByVal value As String)
            Me.sValue = value
        End Set
    End Property

    Public Sub New(ByVal sDisplay As String, ByVal sValue As String)
        Me.Display = sDisplay
        Me.Value = sValue
    End Sub

    Public Overrides Function ToString() As String
        Return Display
    End Function
End Class