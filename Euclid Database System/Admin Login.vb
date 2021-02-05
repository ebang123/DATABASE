Public Class Form1

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Login_SystemDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Login_SystemDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Login_SystemDataSet.Table1)

        Dim a As Control

        For Each a In Me.Controls

            If TypeOf a Is TextBox Then

                a.Text = Nothing

            End If

        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String

        username = UsernameTextBox.Text
        password = PasswordTextBox.Text

        If Me.Table1TableAdapter.ScalarQueryLogin(username, password) Then

            Progress_Bar.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid Account")
        End If

    End Sub



End Class