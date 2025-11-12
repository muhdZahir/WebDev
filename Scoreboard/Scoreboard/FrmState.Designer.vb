<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmState
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
        Me.lblStateName = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtICNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Location = New System.Drawing.Point(64, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IC Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "State Name"
        '
        'lblStateName
        '
        Me.lblStateName.BackColor = System.Drawing.Color.Turquoise
        Me.lblStateName.Location = New System.Drawing.Point(172, 102)
        Me.lblStateName.Name = "lblStateName"
        Me.lblStateName.Size = New System.Drawing.Size(329, 53)
        Me.lblStateName.TabIndex = 2
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(584, 66)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(132, 74)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtICNumber
        '
        Me.txtICNumber.Location = New System.Drawing.Point(176, 46)
        Me.txtICNumber.Name = "txtICNumber"
        Me.txtICNumber.Size = New System.Drawing.Size(344, 26)
        Me.txtICNumber.TabIndex = 4
        '
        'FrmState
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtICNumber)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblStateName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmState"
        Me.Text = "FrmState"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblStateName As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents txtICNumber As TextBox
End Class
