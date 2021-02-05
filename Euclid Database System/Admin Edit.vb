Public Class Admin_Edit

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Login_SystemDataSet)

    End Sub

    Private Sub Admin_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Login_SystemDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Login_SystemDataSet.Table1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emptyTxt = From txt In Me.Controls.OfType(Of TextBox)()
                Where txt.Text.Length = 0
               Select txt.Name

        If emptyTxt.Any Then
            MessageBox.Show("Please fill in the blank textboxes")
            Return
        ElseIf PasswordTextBox.Text.Equals(verifyPass.Text) Then
            Me.Validate()
            Me.Table1BindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Login_SystemDataSet)

            MessageBox.Show("Account Created!")
            Me.Close()
            Form1.Show()

        Else
            MessageBox.Show("Password didn't match")
            Return
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case MsgBox("Do you really want to go back?", MsgBoxStyle.YesNo, "CHECK YOUR DATA FIRST PLEASE BEFORE GOING BACK")
            Case MsgBoxResult.Yes
                Me.Close()
                Main_Menu_Interface.Show()
            Case MsgBoxResult.No
                Return
        End Select

    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged
        If chkShowPass.Checked = True Then
            PasswordTextBox.PasswordChar = ControlChars.NullChar
            verifyPass.PasswordChar = ControlChars.NullChar
        Else
            PasswordTextBox.PasswordChar = "*"c
            verifyPass.PasswordChar = "*"c
        End If
    End Sub
End Class