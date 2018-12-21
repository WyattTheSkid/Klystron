<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class env
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(env))
        Me.execute = New System.Windows.Forms.Button()
        Me.scriptbox = New System.Windows.Forms.TextBox()
        Me.output = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'execute
        '
        Me.execute.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.execute.Location = New System.Drawing.Point(1, 349)
        Me.execute.Name = "execute"
        Me.execute.Size = New System.Drawing.Size(141, 30)
        Me.execute.TabIndex = 0
        Me.execute.Text = "EXECUTE"
        Me.execute.UseVisualStyleBackColor = True
        '
        'scriptbox
        '
        Me.scriptbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scriptbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.scriptbox.Location = New System.Drawing.Point(12, 23)
        Me.scriptbox.Multiline = True
        Me.scriptbox.Name = "scriptbox"
        Me.scriptbox.Size = New System.Drawing.Size(465, 237)
        Me.scriptbox.TabIndex = 1
        Me.scriptbox.Text = "Script Goes Here"
        '
        'output
        '
        Me.output.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.output.ForeColor = System.Drawing.Color.Blue
        Me.output.Location = New System.Drawing.Point(12, 266)
        Me.output.Multiline = True
        Me.output.Name = "output"
        Me.output.Size = New System.Drawing.Size(465, 77)
        Me.output.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(351, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'env
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 378)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.output)
        Me.Controls.Add(Me.scriptbox)
        Me.Controls.Add(Me.execute)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(505, 417)
        Me.MinimumSize = New System.Drawing.Size(505, 417)
        Me.Name = "env"
        Me.Text = "Klystron | Script Execution | Syntax:VBS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents execute As Button
    Friend WithEvents scriptbox As TextBox
    Friend WithEvents output As TextBox
    Friend WithEvents Button1 As Button
End Class
