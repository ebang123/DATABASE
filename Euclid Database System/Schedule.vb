Public Class Schedule

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Student_RecordsDataSet)

    End Sub

    Private Sub Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_RecordsDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Student_RecordsDataSet.Table1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click    
                Main_Menu_Interface.Show()
                Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Select Case Convert.ToInt32(e.KeyChar)

            Case 65 To 122     'letters
            Case Keys.Back     'just in case they make a mistake
            Case Keys.Enter    'clicks a button if you want

            Case Keys.Space
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.Table1BindingSource.Filter = "Last_Name like '%" & TextBox1.Text & "%'"
    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
         If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Me.Table1BindingSource.Filter = "Student_Number like '%" & TextBox4.Text & "%'"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case MsgBox("Do you really want to encode?", MsgBoxStyle.YesNo, "ENCODE")
            Case MsgBoxResult.Yes
                If Table1DataGridView.Rows.Count = 0 Then
                    MessageBox.Show("The record is empty!")
                    Return
                Else
                    Edit_Schedule.Show()
                    Me.Close()
                End If
            Case MsgBoxResult.No
                Return
        End Select

    End Sub
End Class