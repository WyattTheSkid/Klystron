'omegalul nice meme

Public Class auth 'I snipped the fuckin auth keys which were also IN the program lmfao
    'Authorization/Whitelist
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles authkey_send.Click
        If authkey_input.Text = "lol" Then
            MessageBox.Show("Auth Successful!")
            main.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        'Dim webAddress As String = "https: //www.youtube.com/user/FPSPRODUCTlONSDROID"
        'Process.Start(webAddress)
    End Sub

    Private Sub authkey_input_2_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged, MyBase.TextChanged, MyBase.TextChanged, MyBase.TextChanged

    End Sub

    Private Sub auth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub authkey_input_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged

    End Sub

    Private Sub authkey_input_TextChanged_1(sender As Object, e As EventArgs) Handles MyBase.TextChanged

    End Sub

    Private Sub JoinDiscordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JoinDiscordToolStripMenuItem.Click
        Dim webAddress As String = "https://discord.gg/Xvyp9Hf" 'lets not, ok??
        Process.Start(webAddress)
    End Sub

    Private Sub freeauth_Click(sender As Object, e As EventArgs) Handles freeauth.Click
        MessageBox.Show("Remember this version of klystron is highly limited! you can upgrade to the premium version for just $5.00 USD!") 'yeah limited is right... ITS LITERALLY AN AUTOCLICKER WITH A COMMAND BAR WHY DID I DO THIS AHGGIASGIUEWGFI
        klystronfree.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

    End Sub

    '   Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
    'Dim press As New KeyPressEventArgs(Convert.ToChar(13))
    '   OnKeyPress(press)
    ' End Sub

    ' old broken free_auth Private Sub authkey_send_free_Click(sender As Object, e As EventArgs) Handles MyBase.Click
    ' MessageBox.Show("Remember this version of klystron is highly limited! you can upgrade to the premium version for just $5.00 USD!")
    ' klystronfree.Show()
    'Me.Hide()
    'End Sub

End Class