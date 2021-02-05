<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit_Grades
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
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim CourseLabel As System.Windows.Forms.Label
        Dim Grade_YearLabel As System.Windows.Forms.Label
        Dim Activity_1Label As System.Windows.Forms.Label
        Dim Activity_2Label As System.Windows.Forms.Label
        Dim Activity_3Label As System.Windows.Forms.Label
        Dim Activity_4Label As System.Windows.Forms.Label
        Dim Activity_5Label As System.Windows.Forms.Label
        Dim Final_GradeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit_Grades))
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
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.CourseComboBox = New System.Windows.Forms.ComboBox()
        Me.Grade_YearComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Final_GradeTextBox = New System.Windows.Forms.TextBox()
        Me.Activity_5TextBox = New System.Windows.Forms.TextBox()
        Me.Activity_4TextBox = New System.Windows.Forms.TextBox()
        Me.Activity_3TextBox = New System.Windows.Forms.TextBox()
        Me.Activity_2TextBox = New System.Windows.Forms.TextBox()
        Me.Activity_1TextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtact5 = New System.Windows.Forms.TextBox()
        Me.txtact4 = New System.Windows.Forms.TextBox()
        Me.txtact3 = New System.Windows.Forms.TextBox()
        Me.txtact2 = New System.Windows.Forms.TextBox()
        Me.txtact1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Student_NumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        First_NameLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        CourseLabel = New System.Windows.Forms.Label()
        Grade_YearLabel = New System.Windows.Forms.Label()
        Activity_1Label = New System.Windows.Forms.Label()
        Activity_2Label = New System.Windows.Forms.Label()
        Activity_3Label = New System.Windows.Forms.Label()
        Activity_4Label = New System.Windows.Forms.Label()
        Activity_5Label = New System.Windows.Forms.Label()
        Final_GradeLabel = New System.Windows.Forms.Label()
        Student_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.Student_RecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(10, 103)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(120, 23)
        First_NameLabel.TabIndex = 3
        First_NameLabel.Text = "First Name:"
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Location = New System.Drawing.Point(10, 142)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(145, 23)
        Middle_NameLabel.TabIndex = 5
        Middle_NameLabel.Text = "Middle Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(10, 181)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(115, 23)
        Last_NameLabel.TabIndex = 7
        Last_NameLabel.Text = "Last Name:"
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.Location = New System.Drawing.Point(10, 219)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(87, 23)
        CourseLabel.TabIndex = 9
        CourseLabel.Text = "Course:"
        '
        'Grade_YearLabel
        '
        Grade_YearLabel.AutoSize = True
        Grade_YearLabel.Location = New System.Drawing.Point(10, 259)
        Grade_YearLabel.Name = "Grade_YearLabel"
        Grade_YearLabel.Size = New System.Drawing.Size(133, 23)
        Grade_YearLabel.TabIndex = 11
        Grade_YearLabel.Text = "Grade/Year:"
        '
        'Activity_1Label
        '
        Activity_1Label.AutoSize = True
        Activity_1Label.Location = New System.Drawing.Point(10, 58)
        Activity_1Label.Name = "Activity_1Label"
        Activity_1Label.Size = New System.Drawing.Size(105, 23)
        Activity_1Label.TabIndex = 44
        Activity_1Label.Text = "Activity 1:"
        '
        'Activity_2Label
        '
        Activity_2Label.AutoSize = True
        Activity_2Label.Location = New System.Drawing.Point(10, 96)
        Activity_2Label.Name = "Activity_2Label"
        Activity_2Label.Size = New System.Drawing.Size(105, 23)
        Activity_2Label.TabIndex = 45
        Activity_2Label.Text = "Activity 2:"
        '
        'Activity_3Label
        '
        Activity_3Label.AutoSize = True
        Activity_3Label.Location = New System.Drawing.Point(10, 134)
        Activity_3Label.Name = "Activity_3Label"
        Activity_3Label.Size = New System.Drawing.Size(105, 23)
        Activity_3Label.TabIndex = 46
        Activity_3Label.Text = "Activity 3:"
        '
        'Activity_4Label
        '
        Activity_4Label.AutoSize = True
        Activity_4Label.Location = New System.Drawing.Point(10, 172)
        Activity_4Label.Name = "Activity_4Label"
        Activity_4Label.Size = New System.Drawing.Size(105, 23)
        Activity_4Label.TabIndex = 47
        Activity_4Label.Text = "Activity 4:"
        '
        'Activity_5Label
        '
        Activity_5Label.AutoSize = True
        Activity_5Label.Location = New System.Drawing.Point(10, 210)
        Activity_5Label.Name = "Activity_5Label"
        Activity_5Label.Size = New System.Drawing.Size(105, 23)
        Activity_5Label.TabIndex = 48
        Activity_5Label.Text = "Activity 5:"
        '
        'Final_GradeLabel
        '
        Final_GradeLabel.AutoSize = True
        Final_GradeLabel.Location = New System.Drawing.Point(10, 244)
        Final_GradeLabel.Name = "Final_GradeLabel"
        Final_GradeLabel.Size = New System.Drawing.Size(130, 23)
        Final_GradeLabel.TabIndex = 49
        Final_GradeLabel.Text = "Final Grade:"
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
        Me.Table1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25})
        Me.Table1DataGridView.DataSource = Me.Table1BindingSource
        Me.Table1DataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Table1DataGridView.Location = New System.Drawing.Point(0, 483)
        Me.Table1DataGridView.Name = "Table1DataGridView"
        Me.Table1DataGridView.ReadOnly = True
        Me.Table1DataGridView.Size = New System.Drawing.Size(741, 163)
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
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Activity_1"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Activity_1"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Activity_2"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Activity_2"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Activity_3"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Activity_3"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Activity_4"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Activity_4"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Activity_5"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Activity_5"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "Final_Grade"
        Me.DataGridViewTextBoxColumn25.HeaderText = "Final_Grade"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "First_Name", True))
        Me.First_NameTextBox.Enabled = False
        Me.First_NameTextBox.Location = New System.Drawing.Point(188, 100)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.ReadOnly = True
        Me.First_NameTextBox.Size = New System.Drawing.Size(173, 32)
        Me.First_NameTextBox.TabIndex = 4
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Middle_Name", True))
        Me.Middle_NameTextBox.Enabled = False
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(188, 139)
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.ReadOnly = True
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(173, 32)
        Me.Middle_NameTextBox.TabIndex = 6
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Enabled = False
        Me.Last_NameTextBox.Location = New System.Drawing.Point(188, 178)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.ReadOnly = True
        Me.Last_NameTextBox.Size = New System.Drawing.Size(173, 32)
        Me.Last_NameTextBox.TabIndex = 8
        '
        'CourseComboBox
        '
        Me.CourseComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Course", True))
        Me.CourseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CourseComboBox.Enabled = False
        Me.CourseComboBox.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseComboBox.FormattingEnabled = True
        Me.CourseComboBox.Items.AddRange(New Object() {"Math", "Filipino", "English", "Science", "History", "Technical Education"})
        Me.CourseComboBox.Location = New System.Drawing.Point(188, 216)
        Me.CourseComboBox.Name = "CourseComboBox"
        Me.CourseComboBox.Size = New System.Drawing.Size(173, 27)
        Me.CourseComboBox.TabIndex = 10
        '
        'Grade_YearComboBox
        '
        Me.Grade_YearComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Grade/Year", True))
        Me.Grade_YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Grade_YearComboBox.Enabled = False
        Me.Grade_YearComboBox.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grade_YearComboBox.FormattingEnabled = True
        Me.Grade_YearComboBox.Items.AddRange(New Object() {"Nursery", "Kindergarten", "Pre-School", "Grade 1", "Grade 2", "Grade 3", "Grade 4", "Grade 5", "Grade 6", "Grade 7", "Grade 8 ", "Grade 9 ", "Grade 10", "Grade 11 (Senior Year)", "Grade 12 (Senior Year)"})
        Me.Grade_YearComboBox.Location = New System.Drawing.Point(188, 256)
        Me.Grade_YearComboBox.Name = "Grade_YearComboBox"
        Me.Grade_YearComboBox.Size = New System.Drawing.Size(173, 27)
        Me.Grade_YearComboBox.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Student_NumberLabel)
        Me.GroupBox1.Controls.Add(Me.Student_NumberMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.Last_NameTextBox)
        Me.GroupBox1.Controls.Add(Grade_YearLabel)
        Me.GroupBox1.Controls.Add(Me.Grade_YearComboBox)
        Me.GroupBox1.Controls.Add(CourseLabel)
        Me.GroupBox1.Controls.Add(Me.First_NameTextBox)
        Me.GroupBox1.Controls.Add(Me.CourseComboBox)
        Me.GroupBox1.Controls.Add(First_NameLabel)
        Me.GroupBox1.Controls.Add(Last_NameLabel)
        Me.GroupBox1.Controls.Add(Me.Middle_NameTextBox)
        Me.GroupBox1.Controls.Add(Middle_NameLabel)
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 303)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Final_GradeLabel)
        Me.GroupBox2.Controls.Add(Me.Final_GradeTextBox)
        Me.GroupBox2.Controls.Add(Activity_5Label)
        Me.GroupBox2.Controls.Add(Me.Activity_5TextBox)
        Me.GroupBox2.Controls.Add(Activity_4Label)
        Me.GroupBox2.Controls.Add(Me.Activity_4TextBox)
        Me.GroupBox2.Controls.Add(Activity_3Label)
        Me.GroupBox2.Controls.Add(Me.Activity_3TextBox)
        Me.GroupBox2.Controls.Add(Activity_2Label)
        Me.GroupBox2.Controls.Add(Me.Activity_2TextBox)
        Me.GroupBox2.Controls.Add(Activity_1Label)
        Me.GroupBox2.Controls.Add(Me.Activity_1TextBox)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtact5)
        Me.GroupBox2.Controls.Add(Me.txtact4)
        Me.GroupBox2.Controls.Add(Me.txtact3)
        Me.GroupBox2.Controls.Add(Me.txtact2)
        Me.GroupBox2.Controls.Add(Me.txtact1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(385, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 318)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grades"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(121, 269)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 32)
        Me.TextBox5.TabIndex = 51
        '
        'Final_GradeTextBox
        '
        Me.Final_GradeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Final_Grade", True))
        Me.Final_GradeTextBox.Location = New System.Drawing.Point(14, 270)
        Me.Final_GradeTextBox.Name = "Final_GradeTextBox"
        Me.Final_GradeTextBox.ReadOnly = True
        Me.Final_GradeTextBox.Size = New System.Drawing.Size(100, 32)
        Me.Final_GradeTextBox.TabIndex = 50
        '
        'Activity_5TextBox
        '
        Me.Activity_5TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Activity_5", True))
        Me.Activity_5TextBox.Location = New System.Drawing.Point(121, 207)
        Me.Activity_5TextBox.Name = "Activity_5TextBox"
        Me.Activity_5TextBox.ReadOnly = True
        Me.Activity_5TextBox.Size = New System.Drawing.Size(100, 32)
        Me.Activity_5TextBox.TabIndex = 49
        '
        'Activity_4TextBox
        '
        Me.Activity_4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Activity_4", True))
        Me.Activity_4TextBox.Location = New System.Drawing.Point(121, 169)
        Me.Activity_4TextBox.Name = "Activity_4TextBox"
        Me.Activity_4TextBox.ReadOnly = True
        Me.Activity_4TextBox.Size = New System.Drawing.Size(100, 32)
        Me.Activity_4TextBox.TabIndex = 48
        '
        'Activity_3TextBox
        '
        Me.Activity_3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Activity_3", True))
        Me.Activity_3TextBox.Location = New System.Drawing.Point(121, 131)
        Me.Activity_3TextBox.Name = "Activity_3TextBox"
        Me.Activity_3TextBox.ReadOnly = True
        Me.Activity_3TextBox.Size = New System.Drawing.Size(100, 32)
        Me.Activity_3TextBox.TabIndex = 47
        '
        'Activity_2TextBox
        '
        Me.Activity_2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Activity_2", True))
        Me.Activity_2TextBox.Location = New System.Drawing.Point(121, 93)
        Me.Activity_2TextBox.Name = "Activity_2TextBox"
        Me.Activity_2TextBox.ReadOnly = True
        Me.Activity_2TextBox.Size = New System.Drawing.Size(100, 32)
        Me.Activity_2TextBox.TabIndex = 46
        '
        'Activity_1TextBox
        '
        Me.Activity_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Activity_1", True))
        Me.Activity_1TextBox.Location = New System.Drawing.Point(121, 55)
        Me.Activity_1TextBox.Name = "Activity_1TextBox"
        Me.Activity_1TextBox.ReadOnly = True
        Me.Activity_1TextBox.Size = New System.Drawing.Size(100, 32)
        Me.Activity_1TextBox.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(109, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 23)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Equivalent"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(222, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 23)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Percentage"
        '
        'txtact5
        '
        Me.txtact5.Location = New System.Drawing.Point(226, 207)
        Me.txtact5.MaxLength = 5
        Me.txtact5.Name = "txtact5"
        Me.txtact5.Size = New System.Drawing.Size(100, 32)
        Me.txtact5.TabIndex = 42
        '
        'txtact4
        '
        Me.txtact4.Location = New System.Drawing.Point(227, 169)
        Me.txtact4.MaxLength = 5
        Me.txtact4.Name = "txtact4"
        Me.txtact4.Size = New System.Drawing.Size(100, 32)
        Me.txtact4.TabIndex = 41
        '
        'txtact3
        '
        Me.txtact3.Location = New System.Drawing.Point(227, 131)
        Me.txtact3.MaxLength = 5
        Me.txtact3.Name = "txtact3"
        Me.txtact3.Size = New System.Drawing.Size(100, 32)
        Me.txtact3.TabIndex = 40
        '
        'txtact2
        '
        Me.txtact2.Location = New System.Drawing.Point(227, 93)
        Me.txtact2.MaxLength = 5
        Me.txtact2.Name = "txtact2"
        Me.txtact2.Size = New System.Drawing.Size(100, 32)
        Me.txtact2.TabIndex = 39
        '
        'txtact1
        '
        Me.txtact1.Location = New System.Drawing.Point(227, 55)
        Me.txtact1.MaxLength = 5
        Me.txtact1.Name = "txtact1"
        Me.txtact1.Size = New System.Drawing.Size(100, 32)
        Me.txtact1.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(223, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "SHOW FINAL GRADE"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.Euclid_Database_System.My.Resources.Resources.equal
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(241, 248)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 53)
        Me.Button4.TabIndex = 35
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Font = New System.Drawing.Font("Mistral", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(612, 412)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 53)
        Me.Button3.TabIndex = 23
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Mistral", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(33, 412)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 56)
        Me.Button1.TabIndex = 21
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Mistral", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(325, 413)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 55)
        Me.Button2.TabIndex = 22
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(527, 31)
        Me.TextBox4.MaxLength = 10
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(138, 32)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Student_Number", True))
        Me.TextBox3.Location = New System.Drawing.Point(695, 100)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 32)
        Me.TextBox3.TabIndex = 7
        Me.TextBox3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(737, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Label4"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(326, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Student Number:"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Last_Name", True))
        Me.TextBox2.Location = New System.Drawing.Point(695, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 32)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(737, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(154, 36)
        Me.TextBox1.MaxLength = 15
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(138, 32)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Last Name:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.TextBox4)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TextBox1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(33, 328)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(671, 79)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search Students"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 468)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "ADD/EDIT GRADE/S"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(310, 468)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "DELETE GRADE/S"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(630, 468)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "BACK"
        '
        'Student_NumberLabel
        '
        Student_NumberLabel.AutoSize = True
        Student_NumberLabel.Location = New System.Drawing.Point(10, 65)
        Student_NumberLabel.Name = "Student_NumberLabel"
        Student_NumberLabel.Size = New System.Drawing.Size(172, 23)
        Student_NumberLabel.TabIndex = 12
        Student_NumberLabel.Text = "Student Number:"
        '
        'Student_NumberMaskedTextBox
        '
        Me.Student_NumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Student_Number", True))
        Me.Student_NumberMaskedTextBox.Location = New System.Drawing.Point(188, 62)
        Me.Student_NumberMaskedTextBox.Mask = "0000"
        Me.Student_NumberMaskedTextBox.Name = "Student_NumberMaskedTextBox"
        Me.Student_NumberMaskedTextBox.ReadOnly = True
        Me.Student_NumberMaskedTextBox.Size = New System.Drawing.Size(173, 32)
        Me.Student_NumberMaskedTextBox.TabIndex = 13
        '
        'Edit_Grades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(741, 646)
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
        Me.Name = "Edit_Grades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDIT GRADES"
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
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Middle_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CourseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Grade_YearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Final_GradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Activity_5TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Activity_4TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Activity_3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Activity_2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Activity_1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtact5 As System.Windows.Forms.TextBox
    Friend WithEvents txtact4 As System.Windows.Forms.TextBox
    Friend WithEvents txtact3 As System.Windows.Forms.TextBox
    Friend WithEvents txtact2 As System.Windows.Forms.TextBox
    Friend WithEvents txtact1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Student_NumberMaskedTextBox As System.Windows.Forms.MaskedTextBox
End Class
