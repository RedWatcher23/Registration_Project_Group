<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Page2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page2))
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Btn2 = New System.Windows.Forms.Button()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn1
        '
        Me.Btn1.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn1.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn1.Location = New System.Drawing.Point(524, 288)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(227, 45)
        Me.Btn1.TabIndex = 3
        Me.Btn1.Text = "NEW"
        Me.Btn1.UseVisualStyleBackColor = False
        '
        'Btn2
        '
        Me.Btn2.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn2.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn2.Location = New System.Drawing.Point(524, 339)
        Me.Btn2.Name = "Btn2"
        Me.Btn2.Size = New System.Drawing.Size(227, 45)
        Me.Btn2.TabIndex = 4
        Me.Btn2.Text = "OLD"
        Me.Btn2.UseVisualStyleBackColor = False
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn3.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn3.Location = New System.Drawing.Point(524, 390)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(227, 45)
        Me.Btn3.TabIndex = 5
        Me.Btn3.Text = "MAIN MENU"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'Page2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.Btn2)
        Me.Controls.Add(Me.Btn1)
        Me.Name = "Page2"
        Me.Text = "Page2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
End Class
