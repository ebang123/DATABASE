Public Class Edit_Grades
    Dim act1 As Double
    Dim act2 As Double
    Dim act3 As Double
    Dim act4 As Double
    Dim act5 As Double
    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Student_RecordsDataSet)

    End Sub
    Private Sub gradescmbobox()
        txtact1.ResetText()
        txtact2.ResetText()
        txtact3.ResetText()
        txtact4.ResetText()
        txtact5.ResetText()


    End Sub
    Private Sub rangecheck()
        act1 = Convert.ToDecimal(txtact1.Text)
        act2 = Convert.ToDecimal(txtact2.Text)
        act3 = Convert.ToDecimal(txtact3.Text)
        act4 = Convert.ToDecimal(txtact4.Text)
        act5 = Convert.ToDecimal(txtact5.Text)

        Select Case False
            Case (act1 <= 100 And act1 >= 65)
                MessageBox.Show("The grade range is only between 100 and 65")
            Case (act2 <= 100 And act2 >= 65)
                MessageBox.Show("The grade range is only between 100 and 65")
            Case (act3 <= 100 And act3 >= 65)
                MessageBox.Show("The grade range is only between 100 and 65")
            Case (act4 <= 100 And act4 >= 65)
                MessageBox.Show("The grade range is only between 100 and 65")
            Case (act5 <= 100 And act5 >= 65)
                MessageBox.Show("The grade range is only between 100 and 65")
            Case Else
                Return
        End Select
    End Sub


    Private Sub activity1()

        act1 = Convert.ToDecimal(txtact1.Text)
        Select Case True
            Case (act1 <= 100.0 And act1 >= 97.0)
                Activity_1TextBox.Text = "A+"
            Case (act1 <= 96.0 And act1 >= 93.0)
                Activity_1TextBox.Text = "A"
            Case (act1 <= 92.0 And act1 >= 89.0)
                Activity_1TextBox.Text = "A-"
            Case (act1 <= 88.0 And act1 >= 85.0)
                Activity_1TextBox.Text = "B+"
            Case (act1 <= 84.0 And act1 >= 81.0)
                Activity_1TextBox.Text = "B"
            Case (act1 <= 80.0 And act1 >= 77.0)
                Activity_1TextBox.Text = "B-"
            Case (act1 <= 76.0 And act1 >= 73.0)
                Activity_1TextBox.Text = "C+"
            Case (act1 <= 72.0 And act1 >= 69.0)
                Activity_1TextBox.Text = "C"
            Case (act1 <= 68.0 And act1 >= 65.0)
                Activity_1TextBox.Text = "C-"
            Case Else
                Return
        End Select


    End Sub
    Private Sub activity2()
        act2 = Convert.ToDecimal(txtact2.Text)
        Select Case True
            Case (act2 <= 100.0 And act2 >= 97.0)
                Activity_2TextBox.Text = "A+"
            Case (act2 <= 96.0 And act2 >= 93.0)
                Activity_2TextBox.Text = "A"
            Case (act2 <= 92.0 And act2 >= 89.0)
                Activity_2TextBox.Text = "A-"
            Case (act2 <= 88.0 And act2 >= 85.0)
                Activity_2TextBox.Text = "B+"
            Case (act2 <= 84.0 And act2 >= 81.0)
                Activity_2TextBox.Text = "B"
            Case (act2 <= 80.0 And act2 >= 77.0)
                Activity_2TextBox.Text = "B-"
            Case (act2 <= 76.0 And act2 >= 73.0)
                Activity_2TextBox.Text = "C+"
            Case (act2 <= 72.0 And act2 >= 69.0)
                Activity_2TextBox.Text = "C"
            Case (act2 <= 68.0 And act2 >= 65.0)
                Activity_2TextBox.Text = "C-"
            Case Else
                Return
        End Select

    End Sub
    Private Sub activity3()
        act3 = Convert.ToDecimal(txtact3.Text)
        Select Case True
            Case (act3 <= 100.0 And act3 >= 97.0)
                Activity_3TextBox.Text = "A+"
            Case (act3 <= 96.0 And act3 >= 93.0)
                Activity_3TextBox.Text = "A"
            Case (act3 <= 92.0 And act3 >= 89.0)
                Activity_3TextBox.Text = "A-"
            Case (act3 <= 88.0 And act3 >= 85.0)
                Activity_3TextBox.Text = "B+"
            Case (act3 <= 84.0 And act3 >= 81.0)
                Activity_3TextBox.Text = "B"
            Case (act3 <= 80.0 And act3 >= 77.0)
                Activity_3TextBox.Text = "B-"
            Case (act3 <= 76.0 And act3 >= 73.0)
                Activity_3TextBox.Text = "C+"
            Case (act3 <= 72.0 And act3 >= 69.0)
                Activity_3TextBox.Text = "C"
            Case (act3 <= 68.0 And act3 >= 65.0)
                Activity_3TextBox.Text = "C-"
            Case Else
                Return
        End Select
    End Sub
    Private Sub activity4()

        act4 = Convert.ToDecimal(txtact4.Text)
        Select Case True
            Case (act4 <= 100.0 And act4 >= 97.0)
                Activity_4TextBox.Text = "A+"
            Case (act4 <= 96.0 And act4 >= 93.0)
                Activity_4TextBox.Text = "A"
            Case (act4 <= 92.0 And act4 >= 89.0)
                Activity_4TextBox.Text = "A-"
            Case (act4 <= 88.0 And act4 >= 85.0)
                Activity_4TextBox.Text = "B+"
            Case (act4 <= 84.0 And act4 >= 81.0)
                Activity_4TextBox.Text = "B"
            Case (act4 <= 80.0 And act4 >= 77.0)
                Activity_4TextBox.Text = "B-"
            Case (act4 <= 76.0 And act4 >= 73.0)
                Activity_4TextBox.Text = "C+"
            Case (act4 <= 72.0 And act4 >= 69.0)
                Activity_4TextBox.Text = "C"
            Case (act4 <= 68.0 And act4 >= 65.0)
                Activity_4TextBox.Text = "C-"
            Case Else
                Return
        End Select
    End Sub
    Private Sub activity5()
        act5 = Convert.ToDecimal(txtact5.Text)
        Select Case True
            Case (act5 <= 100.0 And act5 >= 97.0)
                Activity_5TextBox.Text = "A+"
            Case (act5 <= 96.0 And act5 >= 93.0)
                Activity_5TextBox.Text = "A"
            Case (act5 <= 92.0 And act5 >= 89.0)
                Activity_5TextBox.Text = "A-"
            Case (act5 <= 88.0 And act5 >= 85.0)
                Activity_5TextBox.Text = "B+"
            Case (act5 <= 84.0 And act5 >= 81.0)
                Activity_5TextBox.Text = "B"
            Case (act5 <= 80.0 And act5 >= 77.0)
                Activity_5TextBox.Text = "B-"
            Case (act5 <= 76.0 And act5 >= 73.0)
                Activity_5TextBox.Text = "C+"
            Case (act5 <= 72.0 And act5 >= 69.0)
                Activity_5TextBox.Text = "C"
            Case (act5 <= 68.0 And act5 >= 65.0)
                Activity_5TextBox.Text = "C-"
            Case Else
                Return



        End Select
    End Sub
    Private Sub Edit_Grades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_RecordsDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Student_RecordsDataSet.Table1)
        Call gradescmbobox()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case MsgBox("Do you really want to go back? All unsaved data will be lost.", MsgBoxStyle.YesNo, "")
            Case MsgBoxResult.Yes
             
                Grading.Show()
            Case MsgBoxResult.No
                Return
        End Select
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtact1.Text = Nothing Then
            MessageBox.Show("Please fill in the missing fields")

        ElseIf txtact2.Text = Nothing Then
            MessageBox.Show("Please fill in the missing fields")

        ElseIf txtact3.Text = Nothing Then
            MessageBox.Show("Please fill in the missing fields")

        ElseIf txtact4.Text = Nothing Then
            MessageBox.Show("Please fill in the missing fields")

        ElseIf txtact5.Text = Nothing Then
            MessageBox.Show("Please fill in the missing fields")


        Else
            Me.Validate()
            Me.Table1BindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.Student_RecordsDataSet)
            Call gradescmbobox()

            MessageBox.Show("Record Saved!")
        End If
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

    Private Sub Activity_1ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtact1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtact1.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txtact1_TextChanged(sender As Object, e As EventArgs) Handles txtact1.TextChanged

    End Sub

    Private Sub txtact2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtact2.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txtact2_TextChanged(sender As Object, e As EventArgs) Handles txtact2.TextChanged

    End Sub

    Private Sub txtact3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtact3.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txtact3_TextChanged(sender As Object, e As EventArgs) Handles txtact3.TextChanged

    End Sub

    Private Sub txtact4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtact4.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txtact4_TextChanged(sender As Object, e As EventArgs) Handles txtact4.TextChanged

    End Sub

    Private Sub txtact5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtact5.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")
        End If
    End Sub

    Private Sub txtact5_TextChanged(sender As Object, e As EventArgs) Handles txtact5.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim answer As Double
        Dim addition As Double

        If txtact1.Text = Nothing Then
            MessageBox.Show("Please fill in the missing fields")
        ElseIf txtact2.Text = Nothing Then
            MessageBox.Show("Please fill in the missing fields")
        ElseIf txtact3.Text = Nothing Then
            MessageBox.Show("Please fill in the missing fields")
        ElseIf txtact4.Text = Nothing Then
            MessageBox.Show("Please fill in the missing fields")
        ElseIf txtact5.Text = Nothing Then
            MessageBox.Show("Please fill in the missing fields")
        Else

            Call rangecheck()
            Call activity1()
            Call activity2()
            Call activity3()
            Call activity4()
            Call activity5()

            addition = act1 + act2 + act3 + act4 + act5

            answer = addition / 5

            Dim aa As Double
            aa = answer
            Dim Final As String
            Select Case True
                Case (aa <= 100.0 And aa >= 97.0)
                    Final = "A+"
                Case (aa <= 96.0 And aa >= 93.0)
                    Final = "A"
                Case (aa <= 92.0 And aa >= 89.0)
                    Final = "A-"
                Case (aa <= 88.0 And aa >= 85.0)
                    Final = "B+"
                Case (aa <= 84.0 And aa >= 81.0)
                    Final = "B"
                Case (aa <= 80.0 And aa >= 77.0)
                    Final = "B-"
                Case (aa <= 76.0 And aa >= 73.0)
                    Final = "C+"
                Case (aa <= 72.0 And aa >= 69.0)
                    Final = "C"
                Case (aa <= 68.0 And aa >= 65.0)
                    Final = "C-"
                Case Else
                    Return
            End Select
            Final_GradeTextBox.Text = Final
            TextBox5.Text = answer



        End If
    End Sub
End Class