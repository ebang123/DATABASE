Public Class Edit_Student

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Student_RecordsDataSet)

    End Sub

    Private Sub Edit_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_RecordsDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Student_RecordsDataSet.Table1)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select MsgBox("Do you really want to go back?", MsgBoxStyle.YesNo, "CHECK YOUR DATA FIRST PLEASE BEFORE GOING BACK")
            Case MsgBoxResult.Yes
                Me.Close()
                Student_Main_Interface.Show()
            Case MsgBoxResult.No
                Return
        End Select

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case MsgBox("Do you really want to delete this student?", MsgBoxStyle.YesNo, "DELETE")
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
         Try
            If Not IsDataComplete() Then
                Exit Sub
            Else
                Me.Validate()
                Me.Table1BindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Student_RecordsDataSet)
                MessageBox.Show("Record Saved!")
            End If
        Catch ex As Exception
            MessageBox.Show("Error! : " & ex.Message)
        End Try


    End Sub

    Private Sub DayLabel_Click(sender As Object, e As EventArgs)

    End Sub
    Private Function IsDataComplete() As Boolean

        Dim ErrMsg As String = ""
        If First_NameTextBox.Text = "" OrElse Middle_NameTextBox.Text = "" OrElse Last_NameTextBox.Text = "" _
            OrElse AddressTextBox.Text = "" OrElse DayComboBox.Text = "" OrElse MonthComboBox.Text = "" _
            OrElse YearComboBox.Text = "" OrElse Student_NumberMaskedTextBox.Text = "" OrElse CourseComboBox.Text = "" _
            OrElse GenderComboBox.Text = "" OrElse AgeMaskedTextBox.Text = "" OrElse Contact_NumberMaskedTextBox.Text = "" _
            OrElse Grade_YearComboBox.Text = "" OrElse CountryComboBox.Text = "" OrElse Parent_NameTextBox.Text = "" _
            OrElse RelationshipComboBox.Text = "" OrElse Parent_Contact_NumberMaskedTextBox.Text = "" Then
            ErrMsg = "Please Enter all the required fields."
        ElseIf Not Student_NumberMaskedTextBox.Text.Length = 10 Then
            ErrMsg = "Please enter 9 digits in STUDENT NUMBER Field."
        ElseIf Not AgeMaskedTextBox.Text.Length = 2 Then
            ErrMsg = "Please enter only 2 digits in AGE Field."
        ElseIf Not Contact_NumberMaskedTextBox.Text.Length = 11 Then
            ErrMsg = "Please enter only 11 digits in CONTACT NUMBER Field."
        ElseIf Not Parent_Contact_NumberMaskedTextBox.Text.Length = 11 Then
            ErrMsg = "Please enter only 11 digits in IN CASE OF EMERGENCY: CONTACT NUMBER Field."

        End If

        If ErrMsg <> "" Then
            MessageBox.Show(ErrMsg)
            Return False
        Else
            Return True
        End If
    End Function

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

    Private Sub First_NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles First_NameTextBox.KeyPress
        Select Case Convert.ToInt32(e.KeyChar)

            Case 65 To 122     'letters
            Case Keys.Back     'just in case they make a mistake
            Case Keys.Enter    'clicks a button if you want

            Case Keys.Space
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub First_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles First_NameTextBox.TextChanged

    End Sub

    Private Sub Middle_NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Middle_NameTextBox.KeyPress
        Select Case Convert.ToInt32(e.KeyChar)

            Case 65 To 122     'letters
            Case Keys.Back     'just in case they make a mistake
            Case Keys.Enter    'clicks a button if you want

            Case Keys.Space
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub Middle_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Middle_NameTextBox.TextChanged

    End Sub

    Private Sub Last_NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Last_NameTextBox.KeyPress
        Select Case Convert.ToInt32(e.KeyChar)

            Case 65 To 122     'letters
            Case Keys.Back     'just in case they make a mistake
            Case Keys.Enter    'clicks a button if you want

            Case Keys.Space
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub Last_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Last_NameTextBox.TextChanged

    End Sub

    Private Sub Parent_NameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Parent_NameTextBox.KeyPress
        Select Case Convert.ToInt32(e.KeyChar)

            Case 65 To 122     'letters
            Case Keys.Back     'just in case they make a mistake
            Case Keys.Enter    'clicks a button if you want

            Case Keys.Space
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub Parent_NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles Parent_NameTextBox.TextChanged

    End Sub
End Class
