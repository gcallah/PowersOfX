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
        Me.xBox = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.powerBox = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ResultBox = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CalcButton = New System.Windows.Forms.Button()
        CType(Me.xBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.powerBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xBox
        '
        Me.xBox.Location = New System.Drawing.Point(285, 37)
        Me.xBox.Name = "xBox"
        Me.xBox.Size = New System.Drawing.Size(120, 20)
        Me.xBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X:"
        '
        'powerBox
        '
        Me.powerBox.Location = New System.Drawing.Point(285, 96)
        Me.powerBox.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.powerBox.Name = "powerBox"
        Me.powerBox.Size = New System.Drawing.Size(120, 20)
        Me.powerBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Power:"
        '
        'ResultBox
        '
        Me.ResultBox.Location = New System.Drawing.Point(285, 197)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.ReadOnly = True
        Me.ResultBox.Size = New System.Drawing.Size(177, 129)
        Me.ResultBox.TabIndex = 4
        Me.ResultBox.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Powers of X:"
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(255, 147)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(75, 23)
        Me.CalcButton.TabIndex = 6
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 355)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.powerBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.xBox)
        Me.Name = "Form1"
        Me.Text = "Powers of X"
        CType(Me.xBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.powerBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents xBox As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents powerBox As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents ResultBox As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CalcButton As Button
End Class
