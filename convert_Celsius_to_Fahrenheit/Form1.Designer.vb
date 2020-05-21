<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCOne = New System.Windows.Forms.TextBox()
        Me.txtCTwo = New System.Windows.Forms.TextBox()
        Me.txtCThree = New System.Windows.Forms.TextBox()
        Me.lblFOne = New System.Windows.Forms.Label()
        Me.lblFTwo = New System.Windows.Forms.Label()
        Me.lblFThree = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Celsius"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(407, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fahrenheit"
        '
        'txtCOne
        '
        Me.txtCOne.Location = New System.Drawing.Point(286, 170)
        Me.txtCOne.Name = "txtCOne"
        Me.txtCOne.Size = New System.Drawing.Size(35, 20)
        Me.txtCOne.TabIndex = 2
        '
        'txtCTwo
        '
        Me.txtCTwo.Location = New System.Drawing.Point(286, 196)
        Me.txtCTwo.Name = "txtCTwo"
        Me.txtCTwo.Size = New System.Drawing.Size(36, 20)
        Me.txtCTwo.TabIndex = 3
        '
        'txtCThree
        '
        Me.txtCThree.Location = New System.Drawing.Point(286, 222)
        Me.txtCThree.Name = "txtCThree"
        Me.txtCThree.Size = New System.Drawing.Size(36, 20)
        Me.txtCThree.TabIndex = 4
        '
        'lblFOne
        '
        Me.lblFOne.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblFOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFOne.Location = New System.Drawing.Point(393, 167)
        Me.lblFOne.Name = "lblFOne"
        Me.lblFOne.Size = New System.Drawing.Size(100, 23)
        Me.lblFOne.TabIndex = 5
        Me.lblFOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFTwo
        '
        Me.lblFTwo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblFTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFTwo.Location = New System.Drawing.Point(393, 193)
        Me.lblFTwo.Name = "lblFTwo"
        Me.lblFTwo.Size = New System.Drawing.Size(100, 23)
        Me.lblFTwo.TabIndex = 6
        Me.lblFTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFThree
        '
        Me.lblFThree.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblFThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFThree.Location = New System.Drawing.Point(393, 219)
        Me.lblFThree.Name = "lblFThree"
        Me.lblFThree.Size = New System.Drawing.Size(100, 23)
        Me.lblFThree.TabIndex = 7
        Me.lblFThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(260, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Convert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(355, 274)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(456, 274)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblFThree)
        Me.Controls.Add(Me.lblFTwo)
        Me.Controls.Add(Me.lblFOne)
        Me.Controls.Add(Me.txtCThree)
        Me.Controls.Add(Me.txtCTwo)
        Me.Controls.Add(Me.txtCOne)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCOne As TextBox
    Friend WithEvents txtCTwo As TextBox
    Friend WithEvents txtCThree As TextBox
    Friend WithEvents lblFOne As Label
    Friend WithEvents lblFTwo As Label
    Friend WithEvents lblFThree As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
