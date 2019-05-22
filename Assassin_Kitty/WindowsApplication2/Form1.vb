Public Class Form1
    Private Sub Button1_Click() Handles Button1.Click
        MessageBox.Show("Press okay to pull the trigger", "Kitty")
        Shell("CMD.exe /C start chrome --new-window https://www.youtube.com/watch?v=hNEJfMnAoxo")
        MessageBox.Show("Mission Failure better luck next time", "Dead Kitty")
        Shell("CMD.exe /C start chrome --new-window https://www.youtube.com/watch?v=dwLCjZVEtpE")
    End Sub
End Class
