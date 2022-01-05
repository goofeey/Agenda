Imports System.Data
Imports System.Data.SqlClient



Public Class SQLCommands
    Dim adaptor As New SqlDataAdapter
    Dim conn As String = "Data Source=DESKTOP-F11C4OS\SQLEXPRESS;Database=Agenda;Trusted_Connection=True;"

    Public Sub Fill(ByRef dtAgenda As DataTable)

        Dim cmdString As String = "SELECT * from Agenda"
        Using cnn As New SqlConnection(conn)
            dtAgenda.Clear()
            adaptor.SelectCommand = New SqlCommand(cmdString, cnn)
            adaptor.Fill(dtAgenda)
            dtAgenda.PrimaryKey = {dtAgenda.Columns("ID")}
        End Using

    End Sub

    Public Sub Add(ByVal AgendaString As String, ByRef dtAgenda As DataTable)
        Dim ID As Integer
        If dtAgenda.Rows.Count = 0 Then
            ID = 1
        Else
            ID = dtAgenda.Compute("max(ID)", "") + 1
        End If
        Dim cmdString As String = " INSERT INTO Agenda Values (" & ID & ",'" & AgendaString & ")"

        Using cnn As New SqlConnection(conn)
            adaptor.InsertCommand = New SqlCommand(cmdString, cnn)
            cnn.Open()
            adaptor.InsertCommand.ExecuteNonQuery()
            cnn.Close()
        End Using


    End Sub

    Public Sub Edit(ByVal AgendaString As String, ByVal ID As Integer)

        Dim cmdString As String = "UPDATE Agenda SET " & AgendaString & " WHERE ID =" & ID
        Using cnn As New SqlConnection(conn)
            adaptor.UpdateCommand = New SqlCommand(cmdString, cnn)
            cnn.Open()
            adaptor.UpdateCommand.ExecuteNonQuery()
            cnn.Close()
        End Using

    End Sub
    Public Sub Delete(ByVal ID As Integer)

        Dim cmdString As String = " DELETE FROM Agenda WHERE ID = " & ID
        Using cnn As New SqlConnection(conn)
            adaptor.DeleteCommand = New SqlCommand(cmdString, cnn)
            cnn.Open()
            adaptor.DeleteCommand.ExecuteNonQuery()
            cnn.Close()

        End Using
    End Sub
End Class
