Imports System.IO

Public Class Form1

    Dim xamppvhostpath As String = "C:\xampp\apache\conf\extra\httpd-vhosts.conf"
    Dim hostspath As String = "C:\Windows\System32\drivers\etc\hosts"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (File.Exists(xamppvhostpath)) Then

            If (CheckBox1.Checked = True) Then
                TextBox2.Text = TextBox2.Text + Path.DirectorySeparatorChar + "public"
            End If

            File.AppendAllText(xamppvhostpath, Environment.NewLine + TextBox3.Text.Replace("%website_path%", TextBox2.Text).Replace("%website_alias%", TextBox1.Text) + Environment.NewLine)
            End If

            If (File.Exists(hostspath)) Then
            File.AppendAllText(hostspath, Environment.NewLine + "127.0.0.1" + "   " + TextBox1.Text + Environment.NewLine)
        End If

        MsgBox("Site created, please restart the apache service")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fbd As New FolderBrowserDialog

        If fbd.ShowDialog Then
            TextBox2.Text = fbd.SelectedPath
        End If
    End Sub
End Class
