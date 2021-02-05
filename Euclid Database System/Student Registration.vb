Public Class Student_Registration

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Student_RecordsDataSet)

    End Sub

    Private Sub Student_Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_RecordsDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Student_RecordsDataSet.Table1)

        Call addNew()

    End Sub
    Private Sub addNew()
        Table1BindingSource.AddNew()
        DayComboBox.SelectedItem = Nothing
        MonthComboBox.SelectedItem = Nothing
        YearComboBox.SelectedItem = Nothing
        CourseComboBox.SelectedItem = Nothing
        GenderComboBox.SelectedItem = Nothing
        Grade_YearComboBox.SelectedItem = Nothing
        Civil_StatusComboBox.SelectedItem = Nothing
        CountryComboBox.SelectedItem = Nothing
        RelationshipComboBox.SelectedItem = Nothing

    End Sub
   

    Private Sub Civil_StatusLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Civil_StatusComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Civil_StatusComboBox.SelectedIndexChanged

    End Sub

    Private Sub MonthLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MonthComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If Not IsDataComplete() Then
                Exit Sub
            End If

            Me.Validate()

            Me.Table1BindingSource.EndEdit()

            Me.Table1TableAdapter.Update(Me.Student_RecordsDataSet)
            MessageBox.Show("Student Information created!")

            Call addNew()
        Catch ex As Exception
            MessageBox.Show("Error! : " & ex.Message)
        End Try



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Select Case MsgBox("Do you really want to go back? All unsaved data will be lost.", MsgBoxStyle.YesNo, "")
            Case MsgBoxResult.Yes
                Me.Close()
                Student_Main_Interface.Show()
            Case MsgBoxResult.No
                Return
        End Select

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
        ElseIf Not Student_NumberMaskedTextBox.Text.Length = 4 Then
            ErrMsg = "Please enter 4 digits in STUDENT NUMBER Field."
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