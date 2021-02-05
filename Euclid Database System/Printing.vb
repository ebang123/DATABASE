Imports Microsoft.Office.Interop
Public Class Printing

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Student_RecordsDataSet)

    End Sub

    Private Sub Printing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_RecordsDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Student_RecordsDataSet.Table1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wd1 As Word.Application
        Dim wd1Doc As Word.Document
        wd1 = New Word.Application
        wd1.Visible = True

        wd1Doc = wd1.Documents.Add("C:\Users\Administrator\Desktop\final\Template1.dotx")

        With wd1Doc
            'Student Information'
            .FormFields("W_snum").Result = Student_NumberMaskedTextBox.Text
            .FormFields("W_fname").Result = First_NameTextBox.Text
            .FormFields("W_mname").Result = Middle_NameTextBox.Text
            .FormFields("W_lname").Result = Last_NameTextBox.Text
            .FormFields("W_address").Result = AddressTextBox.Text
            .FormFields("W_day").Result = DayTextBox.Text
            .FormFields("W_month").Result = MonthTextBox.Text
            .FormFields("W_year").Result = YearTextBox.Text
            .FormFields("W_course").Result = CourseTextBox.Text
            .FormFields("W_gender").Result = GenderTextBox.Text
            .FormFields("W_age").Result = AgeMaskedTextBox.Text
            .FormFields("W_gradeyr").Result = Grade_YearTextBox.Text
            .FormFields("W_country").Result = CountryTextBox.Text
            .FormFields("W_contactnum").Result = Contact_NumberMaskedTextBox.Text

            'Parent Information'
            .FormFields("W_pname").Result = Parent_NameTextBox.Text
            .FormFields("W_relationship").Result = RelationshipTextBox.Text
            .FormFields("W_pcontactnum").Result = Parent_Contact_NumberMaskedTextBox.Text

            'Grades'
            .FormFields("W_act1").Result = Activity_1TextBox.Text
            .FormFields("W_act2").Result = Activity_2TextBox.Text
            .FormFields("W_act3").Result = Activity_3TextBox.Text
            .FormFields("W_act4").Result = Activity_4TextBox.Text
            .FormFields("W_act5").Result = Activity_5TextBox.Text
            .FormFields("W_finalgrade").Result = Final_GradeTextBox.Text

            'Schedule'
            .FormFields("W_monday").Result = MondayTextBox.Text
            .FormFields("W_tuesday").Result = TuesdayTextBox.Text
            .FormFields("W_wednesday").Result = WednesdayTextBox.Text
            .FormFields("W_thursday").Result = ThursdayTextBox.Text
            .FormFields("W_friday").Result = FridayTextBox.Text

        End With
        wd1Doc.SaveAs("C:\Users\Administrator\Desktop\final\" & Student_NumberMaskedTextBox.Text & "" & Last_NameTextBox.Text & ".DOC")
        MessageBox.Show("Record exported as Word Document File")
        wd1.Application.Quit()
        wd1 = Nothing
        wd1Doc = Nothing

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Student_Main_Interface.Show()
        Me.Close()

    End Sub
End Class