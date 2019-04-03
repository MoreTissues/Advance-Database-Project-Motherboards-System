Public Class frm_splash_screen

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub frm_splash_screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            Beep()
            MsgBox("Please enter a username")
        Else

            MsgBox("Welcome " & TextBox1.Text & " To The Mother Of All MotherBoards")
            Beep()
            frm_main_menu.Show()
            Me.Hide()
        End If
    End Sub

   
End Class