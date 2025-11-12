<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPoint
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
        Me.lblPoint = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.BtnSubtract = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Player ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPoint
        '
        Me.lblPoint.AutoSize = True
        Me.lblPoint.BackColor = System.Drawing.Color.Crimson
        Me.lblPoint.Font = New System.Drawing.Font("Microsoft Sans Serif", 80.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoint.Location = New System.Drawing.Point(240, 245)
        Me.lblPoint.Name = "lblPoint"
        Me.lblPoint.Size = New System.Drawing.Size(166, 181)
        Me.lblPoint.TabIndex = 1
        Me.lblPoint.Text = "0"
        Me.lblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(648, 146)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(117, 71)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = ">>"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'BtnSubtract
        '
        Me.BtnSubtract.Location = New System.Drawing.Point(648, 223)
        Me.BtnSubtract.Name = "BtnSubtract"
        Me.BtnSubtract.Size = New System.Drawing.Size(125, 74)
        Me.BtnSubtract.TabIndex = 3
        Me.BtnSubtract.Text = "<<"
        Me.BtnSubtract.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(647, 303)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 74)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(200, 108)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(352, 26)
        Me.TextBox1.TabIndex = 5
        '
        'FormPoint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 500)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblPoint)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPoint"
        Me.Text = "FormPoint"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblPoint As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents BtnSubtract As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
