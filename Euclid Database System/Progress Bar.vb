Public Class Progress_Bar



    Private Sub Progress_Bar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Timer1.Start()

        Button1.Enabled = False
        Label1.Text = "Initializing"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 10 Then
            Label1.Text = "Loading Sources..."
        End If
        If ProgressBar1.Value = 20 Then
            Label1.Text = "Loading Components..."
        End If
        If ProgressBar1.Value = 40 Then
            Label1.Text = "Fetching Microsoft.Ace.OleDBProvider..."
        End If
        If ProgressBar1.Value = 60 Then
            Label1.Text = "Loading Data..."
        End If
        If ProgressBar1.Value = 75 Then
            Label1.Text = "Building Modules..."
        End If
        If ProgressBar1.Value = 90 Then
            Label1.Text = "Starting Database System..."
        End If
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()

            Label1.Text = "Completed"
            Button1.Enabled = True
            MessageBox.Show("Welcome Admin")
            Main_Menu_Interface.Show()
            Me.Close()

        End If
    End Sub
End Class