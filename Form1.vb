
Imports System.ComponentModel

Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Windows应用通知制作器 1.0.0.0" & vbCrLf & "Bilibili UP主 Microhard_1724 制作" & vbCrLf & "单击标题栏上的?按钮可以访问作者主页", vbInformation, "关于此应用")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("必须输入标题和文本才能显示通知！", vbCritical, "没有好果子吃")
        Else
            NotifyIcon1.ShowBalloonTip(3, TextBox1.Text, TextBox2.Text, ToolTipIcon.None)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("必须输入标题和文本才能显示通知！", vbCritical, "没有好果子吃")
        Else
            NotifyIcon1.ShowBalloonTip(3, TextBox1.Text, TextBox2.Text, ToolTipIcon.Info)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("必须输入标题和文本才能显示通知！", vbCritical, "没有好果子吃")
        Else
            NotifyIcon1.ShowBalloonTip(3, TextBox1.Text, TextBox2.Text, ToolTipIcon.Error)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form1_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked
        Shell("explorer.exe https://space.bilibili.com/1684665013")
    End Sub
End Class
