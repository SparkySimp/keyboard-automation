<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAutoKey
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
        Me.btnNoteC = New System.Windows.Forms.Button()
        Me.btnNoteD = New System.Windows.Forms.Button()
        Me.btnNoteE = New System.Windows.Forms.Button()
        Me.btnNoteF = New System.Windows.Forms.Button()
        Me.btnNoteG = New System.Windows.Forms.Button()
        Me.btnNoteA = New System.Windows.Forms.Button()
        Me.btnNoteB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNoteC
        '
        Me.btnNoteC.Location = New System.Drawing.Point(12, 34)
        Me.btnNoteC.Name = "btnNoteC"
        Me.btnNoteC.Size = New System.Drawing.Size(75, 77)
        Me.btnNoteC.TabIndex = 0
        Me.btnNoteC.Tag = "C"
        Me.btnNoteC.Text = "&Q"
        Me.btnNoteC.UseVisualStyleBackColor = True
        '
        'btnNoteD
        '
        Me.btnNoteD.Location = New System.Drawing.Point(93, 34)
        Me.btnNoteD.Name = "btnNoteD"
        Me.btnNoteD.Size = New System.Drawing.Size(75, 77)
        Me.btnNoteD.TabIndex = 1
        Me.btnNoteD.Tag = "D"
        Me.btnNoteD.Text = "&W"
        Me.btnNoteD.UseVisualStyleBackColor = True
        '
        'btnNoteE
        '
        Me.btnNoteE.Location = New System.Drawing.Point(174, 34)
        Me.btnNoteE.Name = "btnNoteE"
        Me.btnNoteE.Size = New System.Drawing.Size(75, 77)
        Me.btnNoteE.TabIndex = 2
        Me.btnNoteE.Tag = "E"
        Me.btnNoteE.Text = "&E"
        Me.btnNoteE.UseVisualStyleBackColor = True
        '
        'btnNoteF
        '
        Me.btnNoteF.Location = New System.Drawing.Point(255, 34)
        Me.btnNoteF.Name = "btnNoteF"
        Me.btnNoteF.Size = New System.Drawing.Size(75, 77)
        Me.btnNoteF.TabIndex = 3
        Me.btnNoteF.Tag = "F"
        Me.btnNoteF.Text = "&R"
        Me.btnNoteF.UseVisualStyleBackColor = True
        '
        'btnNoteG
        '
        Me.btnNoteG.Location = New System.Drawing.Point(336, 34)
        Me.btnNoteG.Name = "btnNoteG"
        Me.btnNoteG.Size = New System.Drawing.Size(75, 77)
        Me.btnNoteG.TabIndex = 4
        Me.btnNoteG.Tag = "G"
        Me.btnNoteG.Text = "&T"
        Me.btnNoteG.UseVisualStyleBackColor = True
        '
        'btnNoteA
        '
        Me.btnNoteA.Location = New System.Drawing.Point(417, 34)
        Me.btnNoteA.Name = "btnNoteA"
        Me.btnNoteA.Size = New System.Drawing.Size(75, 77)
        Me.btnNoteA.TabIndex = 5
        Me.btnNoteA.Tag = "A"
        Me.btnNoteA.Text = "&Y"
        Me.btnNoteA.UseVisualStyleBackColor = True
        '
        'btnNoteB
        '
        Me.btnNoteB.Location = New System.Drawing.Point(498, 34)
        Me.btnNoteB.Name = "btnNoteB"
        Me.btnNoteB.Size = New System.Drawing.Size(75, 77)
        Me.btnNoteB.TabIndex = 6
        Me.btnNoteB.Tag = "B"
        Me.btnNoteB.Text = "&U"
        Me.btnNoteB.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 136)
        Me.Controls.Add(Me.btnNoteB)
        Me.Controls.Add(Me.btnNoteA)
        Me.Controls.Add(Me.btnNoteG)
        Me.Controls.Add(Me.btnNoteF)
        Me.Controls.Add(Me.btnNoteE)
        Me.Controls.Add(Me.btnNoteD)
        Me.Controls.Add(Me.btnNoteC)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNoteC As Button
    Friend WithEvents btnNoteD As Button
    Friend WithEvents btnNoteE As Button
    Friend WithEvents btnNoteF As Button
    Friend WithEvents btnNoteG As Button
    Friend WithEvents btnNoteA As Button
    Friend WithEvents btnNoteB As Button
End Class
