Imports System.Data
Imports System.Data.SqlClient





Public Class Form1
    Dim dtAgenda As DataTable
    Dim cmd As New SQLCommands
    Dim valid As New Validation

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtAgenda = New DataTable
        cmd.Fill(dtAgenda)
        dgvAgenda.DataSource = dtAgenda
        dgvAgenda.Columns("ID").Visible = False

    End Sub

    Public Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim arr As New ArrayList
        cmd.Fill(dtAgenda)
        For Each column As DataColumn In dtAgenda.Columns
            If column.ColumnName = "ID" Then
                Continue For
            End If
            arr.Add(column.ColumnName)
        Next
        Dim FormDinamic As New FormDinamic(arr)
        FormDinamic.ShowDialog()

        If FormDinamic.DialogResult = DialogResult.OK Then
            Dim AgendaString As String = ""
            Dim arlNou As New ArrayList
            arlNou = FormDinamic.ReturnArl
            For Each str As String In arlNou
                If AgendaString = "" Then
                    AgendaString = str & "'"
                Else
                    AgendaString = AgendaString & ",'" & str & "'"
                End If
            Next
            cmd.Add(AgendaString, dtAgenda)
            dgvAgenda.DataSource = Nothing
            cmd.Fill(dtAgenda)
            dgvAgenda.DataSource = dtAgenda
        Else
            Exit Sub
        End If

    End Sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim ID As Integer = dgvAgenda.CurrentRow.Cells("ID").Value
        cmd.Delete(ID)
        cmd.Fill(dtAgenda)

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Dim ID As Integer = dgvAgenda.CurrentRow.Cells("ID").Value
        Dim arr As New ArrayList
        cmd.Fill(dtAgenda)
        For Each column As DataColumn In dtAgenda.Columns
            If column.ColumnName = "ID" Then
                Continue For
            End If
            arr.Add(column.ColumnName)
        Next
        Dim FormDinamic As New FormDinamic(arr)
        FormDinamic.ShowDialog()
        Dim AgendaString As String = ""
        For Each textbox As TextBox In FormDinamic.Controls.OfType(Of TextBox)
            If AgendaString = "" Then
                AgendaString = AgendaString & textbox.Name & " = '" & textbox.Text & "'"
            Else
                AgendaString = AgendaString & ", " & textbox.Name & " = '" & textbox.Text & "'"
            End If
        Next
        cmd.Edit(AgendaString, ID)
        cmd.Fill(dtAgenda)
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If WindowState = WindowState.Maximized Then
            WindowState = WindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Close()
    End Sub


End Class



