<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class auth
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(auth))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.authkey_input = New System.Windows.Forms.TextBox()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.authkey_send = New System.Windows.Forms.Button()
        Me.authkey_input_2 = New System.Windows.Forms.TextBox()
        Me.authkey_input_4 = New System.Windows.Forms.TextBox()
        Me.authkey_input_3 = New System.Windows.Forms.TextBox()
        Me.freeauth = New System.Windows.Forms.Button()
        Me.ad = New System.Windows.Forms.MenuStrip()
        Me.JoinDiscordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ad.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Your Klystron Auth Key."
        '
        'authkey_input
        '
        Me.authkey_input.Location = New System.Drawing.Point(2, 338)
        Me.authkey_input.Name = "authkey_input"
        Me.authkey_input.Size = New System.Drawing.Size(58, 20)
        Me.authkey_input.TabIndex = 1
        '
        'logo
        '
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(69, 66)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(258, 240)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 2
        Me.logo.TabStop = False
        '
        'authkey_send
        '
        Me.authkey_send.Location = New System.Drawing.Point(253, 337)
        Me.authkey_send.Name = "authkey_send"
        Me.authkey_send.Size = New System.Drawing.Size(58, 23)
        Me.authkey_send.TabIndex = 3
        Me.authkey_send.Text = "Submit"
        Me.authkey_send.UseVisualStyleBackColor = True
        '
        'authkey_input_2
        '
        Me.authkey_input_2.Location = New System.Drawing.Point(64, 338)
        Me.authkey_input_2.Name = "authkey_input_2"
        Me.authkey_input_2.Size = New System.Drawing.Size(58, 20)
        Me.authkey_input_2.TabIndex = 5
        '
        'authkey_input_4
        '
        Me.authkey_input_4.Location = New System.Drawing.Point(189, 338)
        Me.authkey_input_4.Name = "authkey_input_4"
        Me.authkey_input_4.Size = New System.Drawing.Size(58, 20)
        Me.authkey_input_4.TabIndex = 7
        '
        'authkey_input_3
        '
        Me.authkey_input_3.Location = New System.Drawing.Point(126, 338)
        Me.authkey_input_3.Name = "authkey_input_3"
        Me.authkey_input_3.Size = New System.Drawing.Size(58, 20)
        Me.authkey_input_3.TabIndex = 6
        '
        'freeauth
        '
        Me.freeauth.Location = New System.Drawing.Point(317, 338)
        Me.freeauth.Name = "freeauth"
        Me.freeauth.Size = New System.Drawing.Size(75, 23)
        Me.freeauth.TabIndex = 8
        Me.freeauth.Text = "Free Version"
        Me.freeauth.UseVisualStyleBackColor = True
        '
        'ad
        '
        Me.ad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JoinDiscordToolStripMenuItem})
        Me.ad.Location = New System.Drawing.Point(0, 0)
        Me.ad.Name = "ad"
        Me.ad.Size = New System.Drawing.Size(393, 24)
        Me.ad.TabIndex = 9
        Me.ad.Text = "MenuStrip1"
        '
        'JoinDiscordToolStripMenuItem
        '
        Me.JoinDiscordToolStripMenuItem.Name = "JoinDiscordToolStripMenuItem"
        Me.JoinDiscordToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.JoinDiscordToolStripMenuItem.Text = "Join Discord"
        '
        'auth
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 362)
        Me.Controls.Add(Me.freeauth)
        Me.Controls.Add(Me.authkey_input_4)
        Me.Controls.Add(Me.authkey_input_3)
        Me.Controls.Add(Me.authkey_input_2)
        Me.Controls.Add(Me.authkey_send)
        Me.Controls.Add(Me.logo)
        Me.Controls.Add(Me.authkey_input)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.ad
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(409, 401)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(409, 401)
        Me.Name = "auth"
        Me.Text = "Klystron Auth"
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ad.ResumeLayout(False)
        Me.ad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents authkey_input As TextBox
    Friend WithEvents logo As PictureBox
    Friend WithEvents authkey_send As Button
    Friend WithEvents authkey_input_2 As TextBox
    Friend WithEvents authkey_input_4 As TextBox
    Friend WithEvents authkey_input_3 As TextBox
    Friend WithEvents freeauth As Button
    Friend WithEvents ad As MenuStrip
    Friend WithEvents JoinDiscordToolStripMenuItem As ToolStripMenuItem
End Class
