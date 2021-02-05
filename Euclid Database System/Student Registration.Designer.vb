<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Registration
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
        Dim AddressLabel As System.Windows.Forms.Label
        Dim DayLabel As System.Windows.Forms.Label
        Dim YearLabel As System.Windows.Forms.Label
        Dim CourseLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim Grade_YearLabel As System.Windows.Forms.Label
        Dim Civil_StatusLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Student_NumberLabel As System.Windows.Forms.Label
        Dim Contact_NumberLabel As System.Windows.Forms.Label
        Dim MonthLabel As System.Windows.Forms.Label
        Dim Parent_NameLabel As System.Windows.Forms.Label
        Dim RelationshipLabel As System.Windows.Forms.Label
        Dim Parent_Contact_NumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student_Registration))
        Me.Student_RecordsDataSet = New Euclid_Database_System.Student_RecordsDataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New Euclid_Database_System.Student_RecordsDataSetTableAdapters.Table1TableAdapter()
        Me.TableAdapterManager = New Euclid_Database_System.Student_RecordsDataSetTableAdapters.TableAdapterManager()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.DayComboBox = New System.Windows.Forms.ComboBox()
        Me.YearComboBox = New System.Windows.Forms.ComboBox()
        Me.CourseComboBox = New System.Windows.Forms.ComboBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.AgeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Grade_YearComboBox = New System.Windows.Forms.ComboBox()
        Me.Civil_StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.CountryComboBox = New System.Windows.Forms.ComboBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Student_NumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Contact_NumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.MonthComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Parent_NameTextBox = New System.Windows.Forms.TextBox()
        Me.RelationshipComboBox = New System.Windows.Forms.ComboBox()
        Me.Parent_Contact_NumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        DayLabel = New System.Windows.Forms.Label()
        YearLabel = New System.Windows.Forms.Label()
        CourseLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        Grade_YearLabel = New System.Windows.Forms.Label()
        Civil_StatusLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Student_NumberLabel = New System.Windows.Forms.Label()
        Contact_NumberLabel = New System.Windows.Forms.Label()
        MonthLabel = New System.Windows.Forms.Label()
        Parent_NameLabel = New System.Windows.Forms.Label()
        RelationshipLabel = New System.Windows.Forms.Label()
        Parent_Contact_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.Student_RecordsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.White
        AddressLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(25, 166)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(98, 23)
        AddressLabel.TabIndex = 1
        AddressLabel.Text = "Address:"
        '
        'DayLabel
        '
        DayLabel.AutoSize = True
        DayLabel.BackColor = System.Drawing.Color.White
        DayLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DayLabel.Location = New System.Drawing.Point(25, 327)
        DayLabel.Name = "DayLabel"
        DayLabel.Size = New System.Drawing.Size(54, 23)
        DayLabel.TabIndex = 2
        DayLabel.Text = "Day:"
        '
        'YearLabel
        '
        YearLabel.AutoSize = True
        YearLabel.BackColor = System.Drawing.Color.White
        YearLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        YearLabel.Location = New System.Drawing.Point(25, 395)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New System.Drawing.Size(62, 23)
        YearLabel.TabIndex = 6
        YearLabel.Text = "Year:"
        '
        'CourseLabel
        '
        CourseLabel.AutoSize = True
        CourseLabel.BackColor = System.Drawing.Color.White
        CourseLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CourseLabel.Location = New System.Drawing.Point(25, 472)
        CourseLabel.Name = "CourseLabel"
        CourseLabel.Size = New System.Drawing.Size(87, 23)
        CourseLabel.TabIndex = 8
        CourseLabel.Text = "Course:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.Color.White
        GenderLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(368, 66)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(91, 23)
        GenderLabel.TabIndex = 10
        GenderLabel.Text = "Gender:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.BackColor = System.Drawing.Color.White
        AgeLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(368, 101)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(56, 23)
        AgeLabel.TabIndex = 12
        AgeLabel.Text = "Age:"
        '
        'Grade_YearLabel
        '
        Grade_YearLabel.AutoSize = True
        Grade_YearLabel.BackColor = System.Drawing.Color.White
        Grade_YearLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Grade_YearLabel.Location = New System.Drawing.Point(368, 168)
        Grade_YearLabel.Name = "Grade_YearLabel"
        Grade_YearLabel.Size = New System.Drawing.Size(133, 23)
        Grade_YearLabel.TabIndex = 14
        Grade_YearLabel.Text = "Grade/Year:"
        '
        'Civil_StatusLabel
        '
        Civil_StatusLabel.AutoSize = True
        Civil_StatusLabel.BackColor = System.Drawing.Color.White
        Civil_StatusLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Civil_StatusLabel.Location = New System.Drawing.Point(370, 237)
        Civil_StatusLabel.Name = "Civil_StatusLabel"
        Civil_StatusLabel.Size = New System.Drawing.Size(122, 23)
        Civil_StatusLabel.TabIndex = 16
        Civil_StatusLabel.Text = "Civil Status:"
        Civil_StatusLabel.Visible = False
        AddHandler Civil_StatusLabel.Click, AddressOf Me.Civil_StatusLabel_Click
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.BackColor = System.Drawing.Color.White
        CountryLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryLabel.Location = New System.Drawing.Point(368, 202)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(95, 23)
        CountryLabel.TabIndex = 18
        CountryLabel.Text = "Country:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.BackColor = System.Drawing.Color.White
        First_NameLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(25, 64)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(120, 23)
        First_NameLabel.TabIndex = 20
        First_NameLabel.Text = "First Name:"
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.BackColor = System.Drawing.Color.White
        Middle_NameLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Middle_NameLabel.Location = New System.Drawing.Point(25, 98)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(145, 23)
        Middle_NameLabel.TabIndex = 22
        Middle_NameLabel.Text = "Middle Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.BackColor = System.Drawing.Color.White
        Last_NameLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(25, 132)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(115, 23)
        Last_NameLabel.TabIndex = 24
        Last_NameLabel.Text = "Last Name:"
        '
        'Student_NumberLabel
        '
        Student_NumberLabel.AutoSize = True
        Student_NumberLabel.BackColor = System.Drawing.Color.White
        Student_NumberLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_NumberLabel.Location = New System.Drawing.Point(25, 434)
        Student_NumberLabel.Name = "Student_NumberLabel"
        Student_NumberLabel.Size = New System.Drawing.Size(172, 23)
        Student_NumberLabel.TabIndex = 26
        Student_NumberLabel.Text = "Student Number:"
        '
        'Contact_NumberLabel
        '
        Contact_NumberLabel.AutoSize = True
        Contact_NumberLabel.BackColor = System.Drawing.Color.White
        Contact_NumberLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contact_NumberLabel.Location = New System.Drawing.Point(368, 138)
        Contact_NumberLabel.Name = "Contact_NumberLabel"
        Contact_NumberLabel.Size = New System.Drawing.Size(174, 23)
        Contact_NumberLabel.TabIndex = 28
        Contact_NumberLabel.Text = "Contact Number:"
        '
        'MonthLabel
        '
        MonthLabel.AutoSize = True
        MonthLabel.BackColor = System.Drawing.Color.White
        MonthLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MonthLabel.Location = New System.Drawing.Point(25, 361)
        MonthLabel.Name = "MonthLabel"
        MonthLabel.Size = New System.Drawing.Size(76, 23)
        MonthLabel.TabIndex = 29
        MonthLabel.Text = "Month:"
        '
        'Parent_NameLabel
        '
        Parent_NameLabel.AutoSize = True
        Parent_NameLabel.BackColor = System.Drawing.Color.White
        Parent_NameLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Parent_NameLabel.Location = New System.Drawing.Point(370, 328)
        Parent_NameLabel.Name = "Parent_NameLabel"
        Parent_NameLabel.Size = New System.Drawing.Size(72, 23)
        Parent_NameLabel.TabIndex = 36
        Parent_NameLabel.Text = "Name:"
        '
        'RelationshipLabel
        '
        RelationshipLabel.AutoSize = True
        RelationshipLabel.BackColor = System.Drawing.Color.White
        RelationshipLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RelationshipLabel.Location = New System.Drawing.Point(368, 365)
        RelationshipLabel.Name = "RelationshipLabel"
        RelationshipLabel.Size = New System.Drawing.Size(135, 23)
        RelationshipLabel.TabIndex = 37
        RelationshipLabel.Text = "Relationship:"
        '
        'Parent_Contact_NumberLabel
        '
        Parent_Contact_NumberLabel.AutoSize = True
        Parent_Contact_NumberLabel.BackColor = System.Drawing.Color.White
        Parent_Contact_NumberLabel.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Parent_Contact_NumberLabel.Location = New System.Drawing.Point(368, 402)
        Parent_Contact_NumberLabel.Name = "Parent_Contact_NumberLabel"
        Parent_Contact_NumberLabel.Size = New System.Drawing.Size(174, 23)
        Parent_Contact_NumberLabel.TabIndex = 38
        Parent_Contact_NumberLabel.Text = "Contact Number:"
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
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.Color.White
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(203, 157)
        Me.AddressTextBox.MaxLength = 100
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(136, 127)
        Me.AddressTextBox.TabIndex = 3
        '
        'DayComboBox
        '
        Me.DayComboBox.BackColor = System.Drawing.Color.White
        Me.DayComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Day", True))
        Me.DayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DayComboBox.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DayComboBox.FormattingEnabled = True
        Me.DayComboBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.DayComboBox.Location = New System.Drawing.Point(203, 323)
        Me.DayComboBox.Name = "DayComboBox"
        Me.DayComboBox.Size = New System.Drawing.Size(136, 31)
        Me.DayComboBox.TabIndex = 4
        '
        'YearComboBox
        '
        Me.YearComboBox.BackColor = System.Drawing.Color.White
        Me.YearComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Year", True))
        Me.YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearComboBox.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YearComboBox.FormattingEnabled = True
        Me.YearComboBox.Items.AddRange(New Object() {"1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016"})
        Me.YearComboBox.Location = New System.Drawing.Point(203, 393)
        Me.YearComboBox.Name = "YearComboBox"
        Me.YearComboBox.Size = New System.Drawing.Size(136, 31)
        Me.YearComboBox.TabIndex = 6
        '
        'CourseComboBox
        '
        Me.CourseComboBox.BackColor = System.Drawing.Color.White
        Me.CourseComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Course", True))
        Me.CourseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CourseComboBox.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CourseComboBox.FormattingEnabled = True
        Me.CourseComboBox.Items.AddRange(New Object() {"Math", "Filipino", "English", "Science", "History", "Technical Education"})
        Me.CourseComboBox.Location = New System.Drawing.Point(203, 467)
        Me.CourseComboBox.Name = "CourseComboBox"
        Me.CourseComboBox.Size = New System.Drawing.Size(136, 27)
        Me.CourseComboBox.TabIndex = 8
        '
        'GenderComboBox
        '
        Me.GenderComboBox.BackColor = System.Drawing.Color.White
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Gender", True))
        Me.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderComboBox.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(622, 56)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(130, 31)
        Me.GenderComboBox.TabIndex = 9
        '
        'AgeMaskedTextBox
        '
        Me.AgeMaskedTextBox.BackColor = System.Drawing.Color.White
        Me.AgeMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Age", True))
        Me.AgeMaskedTextBox.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeMaskedTextBox.Location = New System.Drawing.Point(622, 92)
        Me.AgeMaskedTextBox.Mask = "00"
        Me.AgeMaskedTextBox.Name = "AgeMaskedTextBox"
        Me.AgeMaskedTextBox.Size = New System.Drawing.Size(130, 32)
        Me.AgeMaskedTextBox.TabIndex = 10
        '
        'Grade_YearComboBox
        '
        Me.Grade_YearComboBox.BackColor = System.Drawing.Color.White
        Me.Grade_YearComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Grade/Year", True))
        Me.Grade_YearComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Grade_YearComboBox.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grade_YearComboBox.FormattingEnabled = True
        Me.Grade_YearComboBox.Items.AddRange(New Object() {"Nursery", "Kindergarten", "Pre-School", "Grade 1", "Grade 2", "Grade 3", "Grade 4", "Grade 5", "Grade 6", "Grade 7", "Grade 8 ", "Grade 9 ", "Grade 10", "Grade 11 (Senior Year)", "Grade 12 (Senior Year)"})
        Me.Grade_YearComboBox.Location = New System.Drawing.Point(622, 165)
        Me.Grade_YearComboBox.Name = "Grade_YearComboBox"
        Me.Grade_YearComboBox.Size = New System.Drawing.Size(130, 27)
        Me.Grade_YearComboBox.TabIndex = 12
        '
        'Civil_StatusComboBox
        '
        Me.Civil_StatusComboBox.BackColor = System.Drawing.Color.White
        Me.Civil_StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Civil Status", True))
        Me.Civil_StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Civil_StatusComboBox.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Civil_StatusComboBox.FormattingEnabled = True
        Me.Civil_StatusComboBox.Items.AddRange(New Object() {"Single", "Married"})
        Me.Civil_StatusComboBox.Location = New System.Drawing.Point(622, 234)
        Me.Civil_StatusComboBox.Name = "Civil_StatusComboBox"
        Me.Civil_StatusComboBox.Size = New System.Drawing.Size(130, 31)
        Me.Civil_StatusComboBox.TabIndex = 13
        Me.Civil_StatusComboBox.Visible = False
        '
        'CountryComboBox
        '
        Me.CountryComboBox.BackColor = System.Drawing.Color.White
        Me.CountryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Country", True))
        Me.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CountryComboBox.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryComboBox.FormattingEnabled = True
        Me.CountryComboBox.Items.AddRange(New Object() {"AFGHANISTAN", "ÅLAND ISLANDS", "ALBANIA", "ALGERIA", "AMERICAN SAMOA", "ANDORRA", "ANGOLA", "ANGUILLA", "ANTARCTICA", "ANTIGUA AND BARBUDA", "ARGENTINA", "ARMENIA", "ARUBA", "AUSTRALIA", "AUSTRIA", "AZERBAIJAN", "BAHAMAS", "BAHRAIN", "BANGLADESH", "BARBADOS", "BELARUS", "BELGIUM", "BELIZE", "BENIN", "BERMUDA", "BHUTAN", "BOLIVIA", "BOSNIA AND HERZEGOVINA", "BOTSWANA", "BOUVET ISLAND", "BRAZIL", "BRITISH INDIAN OCEAN TERRITORY", "BRUNEI DARUSSALAM", "BULGARIA", "BURKINA FASO", "BURUNDI", "CAMBODIA", "CAMEROON", "CANADA", "CAPE VERDE", "CAYMAN ISLANDS", "CENTRAL AFRICAN REPUBLIC", "CHAD", "CHILE", "CHINA", "CHRISTMAS ISLAND", "COCOS (KEELING) ISLANDS", "COLOMBIA", "COMOROS", "CONGO", "CONGO, THE DEMOCRATIC REPUBLIC OF THE", "COOK ISLANDS", "COSTA RICA", "CÔTE D'IVOIRE", "CROATIA", "CUBA", "CYPRUS", "CZECH REPUBLIC", "DENMARK", "DJIBOUTI", "DOMINICA", "DOMINICAN REPUBLIC", "ECUADOR", "EGYPT", "EL SALVADOR", "EQUATORIAL GUINEA", "ERITREA", "ESTONIA", "ETHIOPIA", "FALKLAND ISLANDS (MALVINAS)", "FAROE ISLANDS", "FIJI", "FINLAND", "FRANCE", "FRENCH GUIANA", "FRENCH POLYNESIA", "FRENCH SOUTHERN TERRITORIES", "GABON", "GAMBIA", "GEORGIA", "GERMANY", "GHANA", "GIBRALTAR", "GREECE", "GREENLAND", "GRENADA", "GUADELOUPE", "GUAM", "GUATEMALA", "GUERNSEY", "GUINEA", "GUINEA-BISSAU", "GUYANA", "HAITI", "HEARD ISLAND AND MCDONALD ISLANDS", "HOLY SEE (VATICAN CITY STATE)", "HONDURAS", "HONG KONG", "HUNGARY", "ICELAND", "INDIA", "INDONESIA", "IRAN, ISLAMIC REPUBLIC OF", "IRAQ", "IRELAND", "ISLE OF MAN", "ISRAEL", "ITALY", "JAMAICA", "JAPAN", "JERSEY", "JORDAN", "KAZAKHSTAN", "KENYA", "KIRIBATI", "KOREA, DEMOCRATIC PEOPLE'S REPUBLIC OF", "KOREA, REPUBLIC OF", "KUWAIT", "KYRGYZSTAN", "LAO PEOPLE'S DEMOCRATIC REPUBLIC", "LATVIA", "LEBANON", "LESOTHO", "LIBERIA", "LIBYAN ARAB JAMAHIRIYA", "LIECHTENSTEIN", "LITHUANIA", "LUXEMBOURG", "MACAO", "MACEDONIA, THE FORMER YUGOSLAV REPUBLIC OF", "MADAGASCAR", "MALAWI", "MALAYSIA", "MALDIVES", "MALI", "MALTA", "MARSHALL ISLANDS", "MARTINIQUE", "MAURITANIA", "MAURITIUS", "MAYOTTE", "MEXICO", "MICRONESIA, FEDERATED STATES OF", "MOLDOVA, REPUBLIC OF", "MONACO", "MONGOLIA", "MONTENEGRO", "MONTSERRAT", "MOROCCO", "MOZAMBIQUE", "MYANMAR", "NAMIBIA", "NAURU", "NEPAL", "NETHERLANDS", "NETHERLANDS ANTILLES", "NEW CALEDONIA", "NEW ZEALAND", "NICARAGUA", "NIGER", "NIGERIA", "NIUE", "NORFOLK ISLAND", "NORTHERN MARIANA ISLANDS", "NORWAY", "OMAN", "PAKISTAN", "PALAU", "PALESTINIAN TERRITORY, OCCUPIED", "PANAMA", "PAPUA NEW GUINEA", "PARAGUAY", "PERU", "PHILIPPINES", "PITCAIRN", "POLAND", "PORTUGAL", "PUERTO RICO", "QATAR", "REUNION", "ROMANIA", "RUSSIAN FEDERATION", "RWANDA", "SAINT BARTHÉLEMY", "SAINT HELENA", "SAINT KITTS AND NEVIS", "SAINT LUCIA", "SAINT MARTIN", "SAINT PIERRE AND MIQUELON", "SAINT VINCENT AND THE GRENADINES", "SAMOA", "SAN MARINO", "SAO TOME AND PRINCIPE", "SAUDI ARABIA", "SENEGAL", "SERBIA", "SEYCHELLES", "SIERRA LEONE", "SINGAPORE", "SLOVAKIA", "SLOVENIA", "SOLOMON ISLANDS", "SOMALIA", "SOUTH AFRICA", "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS", "SPAIN", "SRI LANKA", "SUDAN", "SURINAME", "SVALBARD AND JAN MAYEN", "SWAZILAND", "SWEDEN", "SWITZERLAND", "SYRIAN ARAB REPUBLIC", "TAIWAN, PROVINCE OF CHINA", "TAJIKISTAN", "TANZANIA, UNITED REPUBLIC OF", "THAILAND", "TIMOR-LESTE", "TOGO", "TOKELAU", "TONGA", "TRINIDAD AND TOBAGO", "TUNISIA", "TURKEY", "TURKMENISTAN", "TURKS AND CAICOS ISLANDS", "TUVALU", "UGANDA", "UKRAINE", "UNITED ARAB EMIRATES", "UNITED KINGDOM", "UNITED STATES", "UNITED STATES MINOR OUTLYING ISLANDS", "URUGUAY", "UZBEKISTAN", "VANUATU", "VENEZUELA", "VIET NAM", "VIRGIN ISLANDS, BRITISH", "VIRGIN ISLANDS, U.S.", "WALLIS AND FUTUNA", "WESTERN SAHARA", "YEMEN", "ZAMBIA", "ZIMBABWE"})
        Me.CountryComboBox.Location = New System.Drawing.Point(622, 199)
        Me.CountryComboBox.Name = "CountryComboBox"
        Me.CountryComboBox.Size = New System.Drawing.Size(130, 27)
        Me.CountryComboBox.TabIndex = 14
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.BackColor = System.Drawing.Color.White
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "First_Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(203, 55)
        Me.First_NameTextBox.MaxLength = 15
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(136, 32)
        Me.First_NameTextBox.TabIndex = 0
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.BackColor = System.Drawing.Color.White
        Me.Middle_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Middle_Name", True))
        Me.Middle_NameTextBox.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(203, 89)
        Me.Middle_NameTextBox.MaxLength = 15
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(136, 32)
        Me.Middle_NameTextBox.TabIndex = 1
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.BackColor = System.Drawing.Color.White
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(203, 123)
        Me.Last_NameTextBox.MaxLength = 15
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(136, 32)
        Me.Last_NameTextBox.TabIndex = 2
        '
        'Student_NumberMaskedTextBox
        '
        Me.Student_NumberMaskedTextBox.BackColor = System.Drawing.Color.White
        Me.Student_NumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Student_Number", True))
        Me.Student_NumberMaskedTextBox.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_NumberMaskedTextBox.Location = New System.Drawing.Point(203, 430)
        Me.Student_NumberMaskedTextBox.Mask = "0000"
        Me.Student_NumberMaskedTextBox.Name = "Student_NumberMaskedTextBox"
        Me.Student_NumberMaskedTextBox.Size = New System.Drawing.Size(136, 32)
        Me.Student_NumberMaskedTextBox.TabIndex = 7
        '
        'Contact_NumberMaskedTextBox
        '
        Me.Contact_NumberMaskedTextBox.BackColor = System.Drawing.Color.White
        Me.Contact_NumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Contact_Number", True))
        Me.Contact_NumberMaskedTextBox.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact_NumberMaskedTextBox.Location = New System.Drawing.Point(622, 129)
        Me.Contact_NumberMaskedTextBox.Mask = "00000000000"
        Me.Contact_NumberMaskedTextBox.Name = "Contact_NumberMaskedTextBox"
        Me.Contact_NumberMaskedTextBox.Size = New System.Drawing.Size(130, 32)
        Me.Contact_NumberMaskedTextBox.TabIndex = 11
        '
        'MonthComboBox
        '
        Me.MonthComboBox.BackColor = System.Drawing.Color.White
        Me.MonthComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Month", True))
        Me.MonthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MonthComboBox.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthComboBox.FormattingEnabled = True
        Me.MonthComboBox.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.MonthComboBox.Location = New System.Drawing.Point(203, 358)
        Me.MonthComboBox.Name = "MonthComboBox"
        Me.MonthComboBox.Size = New System.Drawing.Size(136, 31)
        Me.MonthComboBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Birth Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 23)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Student Registration:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(372, 442)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 56)
        Me.Button3.TabIndex = 35
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(667, 442)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 56)
        Me.Button4.TabIndex = 36
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Parent_NameTextBox
        '
        Me.Parent_NameTextBox.BackColor = System.Drawing.Color.White
        Me.Parent_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Parent_Name", True))
        Me.Parent_NameTextBox.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parent_NameTextBox.Location = New System.Drawing.Point(622, 325)
        Me.Parent_NameTextBox.MaxLength = 15
        Me.Parent_NameTextBox.Name = "Parent_NameTextBox"
        Me.Parent_NameTextBox.Size = New System.Drawing.Size(130, 32)
        Me.Parent_NameTextBox.TabIndex = 15
        '
        'RelationshipComboBox
        '
        Me.RelationshipComboBox.BackColor = System.Drawing.Color.White
        Me.RelationshipComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Relationship", True))
        Me.RelationshipComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RelationshipComboBox.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RelationshipComboBox.FormattingEnabled = True
        Me.RelationshipComboBox.Items.AddRange(New Object() {"Mother", "Father", "Brother", "Sister", "Grandmother", "Grandfather", "Aunt", "Uncle", "Guardian", "Mother-in-Law", "Father-in-Law", "Friend", "Guardian"})
        Me.RelationshipComboBox.Location = New System.Drawing.Point(622, 362)
        Me.RelationshipComboBox.Name = "RelationshipComboBox"
        Me.RelationshipComboBox.Size = New System.Drawing.Size(130, 27)
        Me.RelationshipComboBox.TabIndex = 16
        '
        'Parent_Contact_NumberMaskedTextBox
        '
        Me.Parent_Contact_NumberMaskedTextBox.BackColor = System.Drawing.Color.White
        Me.Parent_Contact_NumberMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Parent_Contact_Number", True))
        Me.Parent_Contact_NumberMaskedTextBox.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parent_Contact_NumberMaskedTextBox.Location = New System.Drawing.Point(622, 399)
        Me.Parent_Contact_NumberMaskedTextBox.Mask = "00000000000"
        Me.Parent_Contact_NumberMaskedTextBox.Name = "Parent_Contact_NumberMaskedTextBox"
        Me.Parent_Contact_NumberMaskedTextBox.Size = New System.Drawing.Size(130, 32)
        Me.Parent_Contact_NumberMaskedTextBox.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(369, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 23)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "IN CASE OF EMERGENCY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 501)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "BACK"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(647, 501)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "REGISTER STUDENT"
        '
        'Student_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(767, 517)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Parent_Contact_NumberLabel)
        Me.Controls.Add(Me.Parent_Contact_NumberMaskedTextBox)
        Me.Controls.Add(RelationshipLabel)
        Me.Controls.Add(Me.RelationshipComboBox)
        Me.Controls.Add(Parent_NameLabel)
        Me.Controls.Add(Me.Parent_NameTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(MonthLabel)
        Me.Controls.Add(Me.MonthComboBox)
        Me.Controls.Add(Contact_NumberLabel)
        Me.Controls.Add(Me.Contact_NumberMaskedTextBox)
        Me.Controls.Add(Student_NumberLabel)
        Me.Controls.Add(Me.Student_NumberMaskedTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Middle_NameLabel)
        Me.Controls.Add(Me.Middle_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryComboBox)
        Me.Controls.Add(Civil_StatusLabel)
        Me.Controls.Add(Me.Civil_StatusComboBox)
        Me.Controls.Add(Grade_YearLabel)
        Me.Controls.Add(Me.Grade_YearComboBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeMaskedTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(CourseLabel)
        Me.Controls.Add(Me.CourseComboBox)
        Me.Controls.Add(YearLabel)
        Me.Controls.Add(Me.YearComboBox)
        Me.Controls.Add(DayLabel)
        Me.Controls.Add(Me.DayComboBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Student_Registration"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENT REGISTRATION"
        CType(Me.Student_RecordsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Student_RecordsDataSet As Euclid_Database_System.Student_RecordsDataSet
    Friend WithEvents Table1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Table1TableAdapter As Euclid_Database_System.Student_RecordsDataSetTableAdapters.Table1TableAdapter
    Friend WithEvents TableAdapterManager As Euclid_Database_System.Student_RecordsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DayComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents YearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CourseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AgeMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Grade_YearComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Civil_StatusComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CountryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents First_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Middle_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Last_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Student_NumberMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Contact_NumberMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MonthComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Parent_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RelationshipComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Parent_Contact_NumberMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
