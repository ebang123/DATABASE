Public Class Main_Menu_Interface

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Student_Main_Interface.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        Admin_Edit.Show()

    End Sub

 
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        DescrpTxt.Text = "STUDENT RECORDS: Add/Edit/Delete Student Records"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Grading.Show()

    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        DescrpTxt.Text = "GRADING SYSTEM: Contains all the grade recordings of students"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Select Case MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo, "LOGOUT")
            Case MsgBoxResult.Yes
                Me.Close()
                Form1.Show()
            Case MsgBoxResult.No
                Return
        End Select

    End Sub


    Private Sub Button1_MouseHover(sender As Object, e As EventArgs)
        DescrpTxt.Text = "Add/Edit/Delete Student's Parent record"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Schedule.Show()

    End Sub

    Private Sub Button6_MouseHover(sender As Object, e As EventArgs) Handles Button6.MouseHover
        DescrpTxt.Text = "SCHEDULE RECORDS: Contains all the attendance records of students"
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover

            DescrpTxt.Text = "Edit/Update Admin account"
    End Sub


    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        DescrpTxt.Text = "Logs out from your information system"
    End Sub

    Private Sub DescrpTxt_TextChanged(sender As Object, e As EventArgs) Handles DescrpTxt.TextChanged

    End Sub
End Class