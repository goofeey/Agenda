Public Class Validation
    Public Function CheckName(ByVal CheckString As String)
        Dim str As String = ""
        If CheckString.Contains(" ") = False Then
            str = str & "Nume si prenume invalide!"

        End If
        Dim bool As Boolean = True
        CheckString.ToCharArray()
        For Each chr As Char In CheckString
            If IsNumeric(chr) Then
                str = str & vbCrLf & "Caractere insuficiente!"
            End If
        Next
        CheckString.ToString()
        Return str
    End Function

    Public Function CheckNumarDeTel(ByVal CheckNumar As String) As String
        Dim bool As Boolean = True
        Dim str As String = ""
        CheckNumar.ToCharArray()
        For Each chr As Char In CheckNumar
            If IsNumeric(chr) = False Then
                str = str & "Numar de telefon invalid!"
            End If
        Next
        CheckNumar.ToString()
        If CheckNumar.StartsWith("0") And CheckNumar.Length = 10 Then
            Return str
        Else
            str = str & vbCrLf & "Caractere insuficiente!"
        End If
        Return str
    End Function

    Enum tipValidare
        nume = 1
        numar_de_telefon = 2

    End Enum

    Public Function getValidationType(ByVal s As String) As Integer
        Dim int As Integer
        If s = "Nume" Then
            int = tipValidare.nume
        ElseIf s = "NumarDeTelefon" Then
            int = tipValidare.numar_de_telefon
        End If
        Return int
    End Function



End Class
