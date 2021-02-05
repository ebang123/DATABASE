Public Class Student_Main_Interface

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Student_RecordsDataSet)

    End Sub

    Private Sub Student_Main_Interface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_RecordsDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Student_RecordsDataSet.Table1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 
                Me.Close()
                Main_Menu_Interface.Show()
  
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case MsgBox("Do you really want to edit?", MsgBoxStyle.YesNo, "EDIT")
            Case MsgBoxResult.Yes
                If Table1DataGridView.Rows.Count = 0 Then
                    MessageBox.Show("The database is empty!")
                    Return
                Else
                    Edit_Student.Show()
                    Me.Close()
                End If
            Case MsgBoxResult.No
                Return
        End Select


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Select Case MsgBox("Do you really want to delete this record?", MsgBoxStyle.YesNo, "DELETE")
            Case MsgBoxResult.Yes
                If Table1DataGridView.Rows.Count = 0 Then
                    MessageBox.Show("The record is empty!")
                    Return
                Else
                    Table1BindingSource.RemoveCurrent()
                    Me.Validate()
                    Me.Table1BindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.Student_RecordsDataSet)
                End If
            Case MsgBoxResult.No
                Return
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Student_Registration.Show()
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Printing.Show()
        Me.Close()

    End Sub
End Class