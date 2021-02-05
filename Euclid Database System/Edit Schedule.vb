Public Class Edit_Schedule

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Student_RecordsDataSet)

    End Sub
    Private Sub schedulecmbobox()
        MondayComboBox.ResetText()
        TuesdayComboBox.ResetText()
        WednesdayComboBox.ResetText()
        ThursdayComboBox.ResetText()
        FridayComboBox.ResetText()


    End Sub
    Private Sub Edit_Schedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_RecordsDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Student_RecordsDataSet.Table1)

        Call schedulecmbobox()



    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MondayComboBox.SelectedItem = Nothing Then
            MessageBox.Show("Please fill in the missing fields")
        ElseIf TuesdayComboBox.SelectedItem = Nothing Then
            MessageBox.Show("Please fill in the missing fields")
        ElseIf WednesdayComboBox.SelectedItem = Nothing Then
            MessageBox.Show("Please fill in the missing fields")
        ElseIf ThursdayComboBox.SelectedItem = Nothing Then
            MessageBox.Show("Please fill in the missing fields")
        ElseIf FridayComboBox.SelectedItem = Nothing Then
            MessageBox.Show("Please fill in the missing fields")


        Else
            Me.Validate()
            Me.Table1BindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Student_RecordsDataSet)
            Call schedulecmbobox()
            MessageBox.Show("Record Saved!")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case MsgBox("Do you really want to go back? All unsaved data will be lost.", MsgBoxStyle.YesNo, "")
            Case MsgBoxResult.Yes
                Me.Validate()
                Me.Table1BindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Student_RecordsDataSet)
                Schedule.Show()
                Me.Close()
            Case MsgBoxResult.No
                Return
        End Select

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Me.Table1BindingSource.Filter = "Student_Number like '%" & TextBox4.Text & "%'"
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsLetter(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Me.Table1BindingSource.Filter = "Last_Name like '%" & TextBox1.Text & "%'"
    End Sub

    Private Sub Student_NumberMaskedTextBox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Table1DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table1DataGridView.CellContentClick

    End Sub
End Class