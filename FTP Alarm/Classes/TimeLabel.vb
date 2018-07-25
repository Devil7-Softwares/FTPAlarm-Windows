Public Class TimeLabel : Inherits Label
    Sub New()
        Me.Text = "0000:00:00"
    End Sub
    Private value_ As Long = 0

    Dim Caption_ As String = ""
    Property Caption As String
        Get
            Return Caption_
        End Get
        Set(ByVal value As String)
            Caption_ = value
            RefreshText()
        End Set
    End Property
    Property Value As Long
        Get
            Return value_
        End Get
        Set(ByVal value As Long)
            value_ = value
            RefreshText()
        End Set
    End Property
    Sub RefreshText()
        Dim hp As Integer = 2
        If Value > 356400 Then
            hp = 3
        ElseIf Value > 3596400 Then
            hp = 4
        End If
        Dim iSecond As Double = Value
        Dim iSpan As TimeSpan = TimeSpan.FromSeconds(iSecond)
        Me.Text = Caption_ & " : " & iSpan.Hours.ToString.PadLeft(hp, "0"c) & ":" & _
                                iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & _
                                iSpan.Seconds.ToString.PadLeft(2, "0"c)
    End Sub
End Class
