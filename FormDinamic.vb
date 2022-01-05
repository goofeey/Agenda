Public Class FormDinamic
    Inherits Form
    Friend WithEvents btnFereastra As New Button

    Public Sub New(ByVal arr As ArrayList)

        Dim Lbl As New Label
        Dim txtFereastra As New TextBox
        Dim int As Integer = 0
        Dim txtleft As Integer = 0
        For Each str As String In arr
            Lbl = New Label
            txtFereastra = New TextBox
            Lbl.Text = str
            txtFereastra.Name = str
            Lbl.Left = 10
            Lbl.Top = 20 + int
            Lbl.AutoSize = True

            If txtleft < Lbl.Width Then
                txtleft = Lbl.Width
            End If
            txtFereastra.Left = txtleft + 5
            txtFereastra.Top = Lbl.Top
            txtFereastra.Size = New Size(100, 20)
            Controls.Add(txtFereastra)
            Controls.Add(Lbl)
            int = int + Lbl.Height + 10
        Next

        btnFereastra.Location = New Point(txtFereastra.Left + 10, txtFereastra.Top + txtFereastra.Height + 10)
        btnFereastra.Size = New Size(75, 20)
        btnFereastra.Text = "OK"
        Controls.Add(btnFereastra)
        Me.Size = New Size(btnFereastra.Left + btnFereastra.Width + 50, btnFereastra.Top + btnFereastra.Height + 50)
        Me.StartPosition = FormStartPosition.CenterParent
    End Sub

    Dim arl As ArrayList
    Dim obj As Validation


    Private Sub btnFereastra_Click(sender As Object, e As EventArgs) Handles btnFereastra.Click
        arl = New ArrayList
        If errorString() = "" Then
            For Each txtbox As TextBox In Controls.OfType(Of TextBox)
                arl.Add(txtbox.Text)

            Next
            ReturnArl()
            DialogResult = DialogResult.OK
        Else
            Dim errMsg As New ErrorDetails("Format Error", errorString, errorType.Errors)
            errMsg.ShowDialog()
        End If

    End Sub

    Public Function checkValidation(ByVal textbox As TextBox)
        Dim str As String = ""
        obj = New Validation
        Dim int As Integer = obj.getValidationType(textbox.Name)
        Select Case int
            Case obj.tipValidare.nume
                If obj.CheckName(textbox.Text) <> "" Then
                    str = obj.CheckName(textbox.Text)
                End If
            Case obj.tipValidare.numar_de_telefon
                If obj.CheckNumarDeTel(textbox.Text) <> "" Then
                    str = obj.CheckNumarDeTel(textbox.Text)
                End If

        End Select
        Return str
    End Function

    Public Function errorString()
        Dim str As String
        For Each textbox As TextBox In Controls.OfType(Of TextBox)
            str = str & checkValidation(textbox)
        Next
        Return str
    End Function


    Public Function ReturnArl() As ArrayList
        Return arl
    End Function


End Class


Public Class ErrorDetails
    Inherits Form
    Friend WithEvents btnOK As New Button
    Friend WithEvents btnDetails As New Button
    Dim rtb As New RichTextBox
    Dim pctBox As New PictureBox

    Public Sub New(title As String, details As String, int As Integer)
        Dim lblTitle As New Label
        Me.Size = New Size(538, 321)
        lblTitle.Location = New Point(80, 20)
        lblTitle.AutoSize = True
        lblTitle.Text = title
        rtb.Location = New Point(60, 70)
        rtb.Size = New Size(400, 150)
        rtb.Text = details
        rtb.ReadOnly = True
        rtb.Visible = False
        rtb.BorderStyle = BorderStyle.FixedSingle
        btnOK.Size = New Size(75, 25)
        btnDetails.Size = New Size(75, 25)
        btnOK.Location = New Point(320, 230)
        btnDetails.Location = New Point(400, 230)
        pctBox.Size = New Size(50, 50)
        pctBox.Location = New Point(20, 20)
        If int = errorType.Message Then
            pctBox.Image = Image.FromFile(Application.StartupPath & "\My Project\Resources\delete_message_26px.png")
        ElseIf int = errorType.Warning Then
            pctBox.Image = Image.FromFile(Application.StartupPath & "\My Project\Resources\error_40px.png")
        ElseIf int = errorType.Errors Then
            pctBox.Image = Image.FromFile("C:\Users\Saphir\source\repos\Agenda\Agenda\My Project\Resources\error_24px.png")
        End If

        btnOK.Text = "OK"
        btnDetails.Text = "Details"

        Controls.Add(rtb)
        Controls.Add(btnOK)
        Controls.Add(btnDetails)
        Controls.Add(pctBox)
        Controls.Add(lblTitle)

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        rtb.Visible = True
    End Sub


End Class
Enum errorType
    Message = 1
    Warning = 2
    Errors = 3
End Enum



