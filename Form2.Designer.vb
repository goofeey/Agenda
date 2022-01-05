<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.txtNume = New System.Windows.Forms.TextBox()
        Me.txtNumar_de_Telefon = New System.Windows.Forms.TextBox()
        Me.txtVarsta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(127, 332)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(99, 42)
        Me.BtnOK.TabIndex = 0
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'txtNume
        '
        Me.txtNume.Location = New System.Drawing.Point(206, 72)
        Me.txtNume.Name = "txtNume"
        Me.txtNume.Size = New System.Drawing.Size(100, 20)
        Me.txtNume.TabIndex = 1
        '
        'txtNumar_de_Telefon
        '
        Me.txtNumar_de_Telefon.Location = New System.Drawing.Point(206, 132)
        Me.txtNumar_de_Telefon.Name = "txtNumar_de_Telefon"
        Me.txtNumar_de_Telefon.Size = New System.Drawing.Size(100, 20)
        Me.txtNumar_de_Telefon.TabIndex = 2
        '
        'txtVarsta
        '
        Me.txtVarsta.Location = New System.Drawing.Point(206, 191)
        Me.txtVarsta.Name = "txtVarsta"
        Me.txtVarsta.Size = New System.Drawing.Size(100, 20)
        Me.txtVarsta.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nume:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Numar de Telefon:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(64, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Varsta:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(308, 332)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(103, 42)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 443)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVarsta)
        Me.Controls.Add(Me.txtNumar_de_Telefon)
        Me.Controls.Add(Me.txtNume)
        Me.Controls.Add(Me.BtnOK)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnOK As Button
    Friend WithEvents txtNume As TextBox
    Friend WithEvents txtNumar_de_Telefon As TextBox
    Friend WithEvents txtVarsta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCancel As Button
End Class
