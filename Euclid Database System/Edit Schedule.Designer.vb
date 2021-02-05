<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Schedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CourseLabel As System.Windows.Forms.Label
        Dim Grade_YearLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim MondayLabel As System.Windows.Forms.Label
        Dim TuesdayLabel As System.Windows.Forms.Label
        Dim WednesdayLabel As System.Windows.Forms.Label
        Dim ThursdayLabel As System.Windows.Forms.Label
        Dim FridayLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Schedule))
        Dim Student_NumberLabel As System.Windows.Forms.Label
        Me.Student_RecordsDataSet = New Euclid_Database_System.Student_RecordsDataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New Euclid_Database_System.Student_RecordsDataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New Euclid_Database_System.Student_RecordsDataSetTableAdapters.TableAdapterManager()
        Me.Table1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseComboBox = New System.Windows.Forms.ComboBox()
        Me.Grade_YearComboBox = New System.Windows.Forms.ComboBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FridayComboBox = New System.Windows.Forms.ComboBox()
        Me.ThursdayComboBox = New System.Windows.Forms.ComboBox()
        Me.WednesdayComboBox = New System.Windows.Forms.ComboBox()
        Me.TuesdayComboBox = New System.Windows.Forms.ComboBox()
        Me.MondayComboBox = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Student_NumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        CourseLabel = New System.Windows.Forms.Label()
        Grade_YearLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        MondayLabel = New System.Windows.Forms.Label()
        TuesdayLabel = New System.Windows.Forms.Label()
        WednesdayLabel = New System.Windows.Forms.Label()
        ThursdayLabel = New System.Windows.Forms.Label()
        FridayLabel = New System.Windows.Forms.Label()
        Student_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.Student_RecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(6, 198)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(87, 23)
        CourseLabel.TabIndex = 1
        CourseLabel.Text = "Course:"
        '
        'Grade_YearLabel
        '
        Grade_YearLabel.AutoSize = True
        Grade_YearLabel.Location = New System.Drawing.Point(7, 238)
        Grade_YearLabel.Name = "Grade_YearLabel"
        Grade_YearLabel.Size = New System.Drawing.Size(133, 23)
        Grade_YearLabel.TabIndex = 3
        Grade_YearLabel.Text = "Grade/Year:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(6, 83)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(120, 23)
        First_NameLabel.TabIndex = 5
        First_NameLabel.Text = "First Name:"
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Location = New System.Drawing.Point(6, 120)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(145, 23)
        Middle_NameLabel.TabIndex = 7
        Middle_NameLabel.Text = "Middle Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(6, 159)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(115, 23)
        Last_NameLabel.TabIndex = 11
        Last_NameLabel.Text = "Last Name:"
        '
        'MondayLabel
        '
        MondayLabel.AutoSize = True
        MondayLabel.Location = New System.Drawing.Point(16, 48)
        MondayLabel.Name = "MondayLabel"
        MondayLabel.Size = New System.Drawing.Size(94, 23)
        MondayLabel.TabIndex = 0
        MondayLabel.Text = "Monday:"
        '
        'TuesdayLabel
        '
        TuesdayLabel.AutoSize = True
        TuesdayLabel.Location = New System.Drawing.Point(16, 83)
        TuesdayLabel.Name = "TuesdayLabel"
        TuesdayLabel.Size = New System.Drawing.Size(98, 23)
        TuesdayLabel.TabIndex = 2
        TuesdayLabel.Text = "Tuesday:"
        '
        'WednesdayLabel
        '
        WednesdayLabel.AutoSize = True
        WednesdayLabel.Location = New System.Drawing.Point(16, 117)
        WednesdayLabel.Name = "WednesdayLabel"
        WednesdayLabel.Size = New System.Drawing.Size(132, 23)
        WednesdayLabel.TabIndex = 4
        WednesdayLabel.Text = "Wednesday:"
        '
        'ThursdayLabel
        '
        ThursdayLabel.AutoSize = True
        ThursdayLabel.Location = New System.Drawing.Point(17, 153)
        ThursdayLabel.Name = "ThursdayLabel"
        ThursdayLabel.Size = New System.Drawing.Size(107, 23)
        ThursdayLabel.TabIndex = 6
        ThursdayLabel.Text = "Thursday:"
        '
        'FridayLabel
        '
        FridayLabel.AutoSize = True
        FridayLabel.Location = New System.Drawing.Point(17, 190)
        FridayLabel.Name = "FridayLabel"
        FridayLabel.Size = New System.Drawing.Size(79, 23)
        FridayLabel.TabIndex = 8
        FridayLabel.Text = "Friday:"
        '
        'Student_RecordsDataSet
        '
        Me.Student_RecordsDataSet.DataSetName = "Student_RecordsDataSet"
        Me.Student_RecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.Student_RecordsDataSet
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Table1TableAdapter = Me.Table1TableAdapter
        Me.TableAdapterManager.UpdateOrder = Euclid_Database_System.Student_RecordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Table1DataGridView
        '
        Me.Table1DataGridView.AllowUserToAddRows = False
        Me.Table1DataGridView.AllowUserToDeleteRows = False
        Me.Table1DataGridView.AutoGenerateColumns = False
        Me.Table1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30})
        Me.Table1DataGridView.DataSource = Me.Table1BindingSource
        Me.Table1DataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Table1DataGridView.Location = New System.Drawing.Point(0, 423)
        Me.Table1DataGridView.Name = "Table1DataGridView"
        Me.Table1DataGridView.ReadOnly = True
        Me.Table1DataGridView.Size = New System.Drawing.Size(761, 182)
        Me.Table1DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Student_Number"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Student_Number"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn12.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Middle_Name"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Middle_Name"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Course"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Course"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Grade/Year"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Grade/Year"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "Monday"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Monday"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Tuesday"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Tuesday"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "Wednesday"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Wednesday"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "Thursday"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Thursday"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "Friday"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Friday"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'CourseComboBox
        '
        Me.CourseComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Course", True))
        Me.CourseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CourseComboBox.Enabled = False
        Me.CourseComboBox.FormattingEnabled = True
        Me.CourseComboBox.Items.AddRange(New Object() {"Math", "Filipino", "English", "Science", "History", "Technical Education"})
        Me.CourseComboBox.Location = New System.Drawing.Point(180, 195)
        Me.CourseComboBox.Name = "CourseComboBox"
        Me.CourseComboBox.Size = New System.Drawing.Size(175, 31)
        Me.CourseComboBox.TabIndex = 2
        '
        'Grade_YearComboBox
        '
        Me.Grade_YearComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Grade/Year", True))
        Me.Grade_YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Grade_YearComboBox.Enabled = False
        Me.Grade_YearComboBox.FormattingEnabled = True
        Me.Grade_YearComboBox.Items.AddRange(New Object() {"Nursery", "Kindergarten", "Pre-School", "Grade 1", "Grade 2", "Grade 3", "Grade 4", "Grade 5", "Grade 6", "Grade 7", "Grade 8 ", "Grade 9 ", "Grade 10", "Grade 11 (Senior Year)", "Grade 12 (Senior Year)"})
        Me.Grade_YearComboBox.Location = New System.Drawing.Point(180, 235)
        Me.Grade_YearComboBox.Name = "Grade_YearComboBox"
        Me.Grade_YearComboBox.Size = New System.Drawing.Size(175, 31)
        Me.Grade_YearComboBox.TabIndex = 4
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "First_Name", True))
        Me.First_NameTextBox.Enabled = False
        Me.First_NameTextBox.Location = New System.Drawing.Point(180, 78)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.ReadOnly = True
        Me.First_NameTextBox.Size = New System.Drawing.Size(175, 32)
        Me.First_NameTextBox.TabIndex = 6
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Middle_Name", True))
        Me.Middle_NameTextBox.Enabled = False
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(180, 117)
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.ReadOnly = True
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(175, 32)
        Me.Middle_NameTextBox.TabIndex = 8
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Enabled = False
        Me.Last_NameTextBox.Location = New System.Drawing.Point(180, 156)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.ReadOnly = True
        Me.Last_NameTextBox.Size = New System.Drawing.Size(175, 32)
        Me.Last_NameTextBox.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Student_NumberLabel)
        Me.GroupBox1.Controls.Add(Me.Student_NumberMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.Last_NameTextBox)
        Me.GroupBox1.Controls.Add(Last_NameLabel)
        Me.GroupBox1.Controls.Add(Me.CourseComboBox)
        Me.GroupBox1.Controls.Add(CourseLabel)
        Me.GroupBox1.Controls.Add(Me.Grade_YearComboBox)
        Me.GroupBox1.Controls.Add(Grade_YearLabel)
        Me.GroupBox1.Controls.Add(Middle_NameLabel)
        Me.GroupBox1.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox1.Controls.Add(Me.Middle_NameTextBox)
        Me.GroupBox1.Controls.Add(First_NameLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(404, 286)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(FridayLabel)
        Me.GroupBox2.Controls.Add(Me.FridayComboBox)
        Me.GroupBox2.Controls.Add(ThursdayLabel)
        Me.GroupBox2.Controls.Add(Me.ThursdayComboBox)
        Me.GroupBox2.Controls.Add(WednesdayLabel)
        Me.GroupBox2.Controls.Add(Me.WednesdayComboBox)
        Me.GroupBox2.Controls.Add(TuesdayLabel)
        Me.GroupBox2.Controls.Add(Me.TuesdayComboBox)
        Me.GroupBox2.Controls.Add(MondayLabel)
        Me.GroupBox2.Controls.Add(Me.MondayComboBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(407, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 226)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Schedule"
        '
        'FridayComboBox
        '
        Me.FridayComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Friday", True))
        Me.FridayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FridayComboBox.FormattingEnabled = True
        Me.FridayComboBox.Items.AddRange(New Object() {"7:00 A.M. - 8:00 A.M.", "8:00 A.M. - 9:00 A.M.", "9:00 A.M. - 10:00 A.M.", "10:00 A.M. - 11:00 A.M.", "11:00 A.M. - 12:00 NN", "12:00 NN - 1:00 P.M.", "1:00 P.M. - 2:00 P.M.", "2:00 P.M. - 3:00 P.M.", "3:00 P.M. - 4:00 P.M.", "4:00 P.M. - 5:00 P.M.", "5:00 P.M. - 6:00 P.M."})
        Me.FridayComboBox.Location = New System.Drawing.Point(154, 187)
        Me.FridayComboBox.Name = "FridayComboBox"
        Me.FridayComboBox.Size = New System.Drawing.Size(175, 31)
        Me.FridayComboBox.TabIndex = 9
        '
        'ThursdayComboBox
        '
        Me.ThursdayComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Thursday", True))
        Me.ThursdayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ThursdayComboBox.FormattingEnabled = True
        Me.ThursdayComboBox.Items.AddRange(New Object() {"7:00 A.M. - 8:00 A.M.", "8:00 A.M. - 9:00 A.M.", "9:00 A.M. - 10:00 A.M.", "10:00 A.M. - 11:00 A.M.", "11:00 A.M. - 12:00 NN", "12:00 NN - 1:00 P.M.", "1:00 P.M. - 2:00 P.M.", "2:00 P.M. - 3:00 P.M.", "3:00 P.M. - 4:00 P.M.", "4:00 P.M. - 5:00 P.M.", "5:00 P.M. - 6:00 P.M."})
        Me.ThursdayComboBox.Location = New System.Drawing.Point(154, 150)
        Me.ThursdayComboBox.Name = "ThursdayComboBox"
        Me.ThursdayComboBox.Size = New System.Drawing.Size(175, 31)
        Me.ThursdayComboBox.TabIndex = 7
        '
        'WednesdayComboBox
        '
        Me.WednesdayComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Wednesday", True))
        Me.WednesdayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WednesdayComboBox.FormattingEnabled = True
        Me.WednesdayComboBox.Items.AddRange(New Object() {"7:00 A.M. - 8:00 A.M.", "8:00 A.M. - 9:00 A.M.", "9:00 A.M. - 10:00 A.M.", "10:00 A.M. - 11:00 A.M.", "11:00 A.M. - 12:00 NN", "12:00 NN - 1:00 P.M.", "1:00 P.M. - 2:00 P.M.", "2:00 P.M. - 3:00 P.M.", "3:00 P.M. - 4:00 P.M.", "4:00 P.M. - 5:00 P.M.", "5:00 P.M. - 6:00 P.M."})
        Me.WednesdayComboBox.Location = New System.Drawing.Point(154, 113)
        Me.WednesdayComboBox.Name = "WednesdayComboBox"
        Me.WednesdayComboBox.Size = New System.Drawing.Size(175, 31)
        Me.WednesdayComboBox.TabIndex = 5
        '
        'TuesdayComboBox
        '
        Me.TuesdayComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Tuesday", True))
        Me.TuesdayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TuesdayComboBox.FormattingEnabled = True
        Me.TuesdayComboBox.Items.AddRange(New Object() {"7:00 A.M. - 8:00 A.M.", "8:00 A.M. - 9:00 A.M.", "9:00 A.M. - 10:00 A.M.", "10:00 A.M. - 11:00 A.M.", "11:00 A.M. - 12:00 NN", "12:00 NN - 1:00 P.M.", "1:00 P.M. - 2:00 P.M.", "2:00 P.M. - 3:00 P.M.", "3:00 P.M. - 4:00 P.M.", "4:00 P.M. - 5:00 P.M.", "5:00 P.M. - 6:00 P.M."})
        Me.TuesdayComboBox.Location = New System.Drawing.Point(154, 76)
        Me.TuesdayComboBox.Name = "TuesdayComboBox"
        Me.TuesdayComboBox.Size = New System.Drawing.Size(175, 31)
        Me.TuesdayComboBox.TabIndex = 3
        '
        'MondayComboBox
        '
        Me.MondayComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Monday", True))
        Me.MondayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MondayComboBox.FormattingEnabled = True
        Me.MondayComboBox.Items.AddRange(New Object() {"7:00 A.M. - 8:00 A.M.", "8:00 A.M. - 9:00 A.M.", "9:00 A.M. - 10:00 A.M.", "10:00 A.M. - 11:00 A.M.", "11:00 A.M. - 12:00 NN", "12:00 NN - 1:00 P.M.", "1:00 P.M. - 2:00 P.M.", "2:00 P.M. - 3:00 P.M.", "3:00 P.M. - 4:00 P.M.", "4:00 P.M. - 5:00 P.M.", "5:00 P.M. - 6:00 P.M."})
        Me.MondayComboBox.Location = New System.Drawing.Point(154, 39)
        Me.MondayComboBox.Name = "MondayComboBox"
        Me.MondayComboBox.Size = New System.Drawing.Size(175, 31)
        Me.MondayComboBox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(407, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 56)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(542, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 56)
        Me.Button2.TabIndex = 15
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(677, 255)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 56)
        Me.Button3.TabIndex = 16
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(500, 33)
        Me.TextBox4.MaxLength = 10
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(121, 32)
        Me.TextBox4.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Student Number:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(169, 33)
        Me.TextBox1.MaxLength = 15
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 32)
        Me.TextBox1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 331)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(637, 86)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search Students"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Student_Number", True))
        Me.TextBox3.Location = New System.Drawing.Point(698, 43)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(10, 32)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(650, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(634, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Last_Name", True))
        Me.TextBox2.Location = New System.Drawing.Point(758, 33)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(10, 32)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(372, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "ADD/EDIT SCHEDULE/S"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(520, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "DELETE SCHEDULE/S"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(695, 314)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "BACK"
        '
        'Student_NumberLabel
        '
        Student_NumberLabel.AutoSize = True
        Student_NumberLabel.Location = New System.Drawing.Point(2, 43)
        Student_NumberLabel.Name = "Student_NumberLabel"
        Student_NumberLabel.Size = New System.Drawing.Size(172, 23)
        Student_NumberLabel.TabIndex = 12
        Student_NumberLabel.Text = "Student Number:"
        '
        'Student_NumberMaskedTextBox
        '
        Me.Student_NumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Student_Number", True))
        Me.Student_NumberMaskedTextBox.Location = New System.Drawing.Point(180, 40)
        Me.Student_NumberMaskedTextBox.Mask = "0000"
        Me.Student_NumberMaskedTextBox.Name = "Student_NumberMaskedTextBox"
        Me.Student_NumberMaskedTextBox.ReadOnly = True
        Me.Student_NumberMaskedTextBox.Size = New System.Drawing.Size(175, 32)
        Me.Student_NumberMaskedTextBox.TabIndex = 13
        '
        'Edit_Schedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(761, 605)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Table1DataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Edit_Schedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Schedule"
        CType(Me.Student_RecordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Student_RecordsDataSet As Euclid_Database_System.Student_RecordsDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As Euclid_Database_System.Student_RecordsDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As Euclid_Database_System.Student_RecordsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Table1DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents CourseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Grade_YearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Middle_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents FridayComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ThursdayComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents WednesdayComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TuesdayComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MondayComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Student_NumberMaskedTextBox As System.Windows.Forms.MaskedTextBox
End Class
