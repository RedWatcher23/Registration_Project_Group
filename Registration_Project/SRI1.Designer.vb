<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SRI1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextSurName = New System.Windows.Forms.TextBox()
        Me.TextName = New System.Windows.Forms.TextBox()
        Me.TextMidName = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextDateBirth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextAge = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextContact1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextPlaceOfBirth = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextNationality = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextHomeAdd = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextFarthersName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextFathersBirth = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextFathersContact = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextFathersOccu = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextFathersEmail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextMotherEmail = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextMothersContact = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextMotherOccu = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextMothersBirth = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextMothersName = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Btn3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StudentRegistrationWalkinDataSet = New Registration_Project.StudentRegistrationWalkinDataSet()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Table1TableAdapter = New Registration_Project.StudentRegistrationWalkinDataSetTableAdapters.Table1TableAdapter()
        CType(Me.StudentRegistrationWalkinDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Bk", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(362, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STUDENT REGISTRATION INFORMATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'TextSurName
        '
        Me.TextSurName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "SurName", True))
        Me.TextSurName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSurName.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextSurName.Location = New System.Drawing.Point(56, 96)
        Me.TextSurName.Name = "TextSurName"
        Me.TextSurName.Size = New System.Drawing.Size(197, 22)
        Me.TextSurName.TabIndex = 2
        '
        'TextName
        '
        Me.TextName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "FirstName", True))
        Me.TextName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextName.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextName.Location = New System.Drawing.Point(259, 96)
        Me.TextName.Name = "TextName"
        Me.TextName.Size = New System.Drawing.Size(197, 22)
        Me.TextName.TabIndex = 4
        '
        'TextMidName
        '
        Me.TextMidName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "MiddleName", True))
        Me.TextMidName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMidName.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextMidName.Location = New System.Drawing.Point(462, 96)
        Me.TextMidName.Name = "TextMidName"
        Me.TextMidName.Size = New System.Drawing.Size(197, 22)
        Me.TextMidName.TabIndex = 6
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(677, 100)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(55, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "MALE"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(738, 100)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(68, 17)
        Me.CheckBox2.TabIndex = 8
        Me.CheckBox2.Text = "FEMALE"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(673, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Gender"
        '
        'TextDateBirth
        '
        Me.TextDateBirth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Date Of Birth", True))
        Me.TextDateBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDateBirth.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextDateBirth.Location = New System.Drawing.Point(815, 96)
        Me.TextDateBirth.Name = "TextDateBirth"
        Me.TextDateBirth.Size = New System.Drawing.Size(197, 22)
        Me.TextDateBirth.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(811, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Date of Birth"
        '
        'TextAge
        '
        Me.TextAge.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Age", True))
        Me.TextAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAge.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextAge.Location = New System.Drawing.Point(56, 145)
        Me.TextAge.Name = "TextAge"
        Me.TextAge.Size = New System.Drawing.Size(141, 22)
        Me.TextAge.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 21)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Age"
        '
        'TextContact1
        '
        Me.TextContact1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Contract No", True))
        Me.TextContact1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextContact1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextContact1.Location = New System.Drawing.Point(203, 145)
        Me.TextContact1.Name = "TextContact1"
        Me.TextContact1.Size = New System.Drawing.Size(253, 22)
        Me.TextContact1.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(199, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 21)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Contact No."
        '
        'TextPlaceOfBirth
        '
        Me.TextPlaceOfBirth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Place of Birth", True))
        Me.TextPlaceOfBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPlaceOfBirth.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextPlaceOfBirth.Location = New System.Drawing.Point(462, 145)
        Me.TextPlaceOfBirth.Name = "TextPlaceOfBirth"
        Me.TextPlaceOfBirth.Size = New System.Drawing.Size(344, 22)
        Me.TextPlaceOfBirth.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(458, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Place of Birth"
        '
        'TextNationality
        '
        Me.TextNationality.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Nationality", True))
        Me.TextNationality.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNationality.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextNationality.Location = New System.Drawing.Point(815, 145)
        Me.TextNationality.Name = "TextNationality"
        Me.TextNationality.Size = New System.Drawing.Size(197, 22)
        Me.TextNationality.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(811, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Nationality"
        '
        'TextHomeAdd
        '
        Me.TextHomeAdd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Home Address", True))
        Me.TextHomeAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextHomeAdd.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextHomeAdd.Location = New System.Drawing.Point(56, 204)
        Me.TextHomeAdd.Name = "TextHomeAdd"
        Me.TextHomeAdd.Size = New System.Drawing.Size(956, 22)
        Me.TextHomeAdd.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(52, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 21)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Home Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Roboto Bk", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(52, 245)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(213, 23)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "PARENT INFORMATION"
        '
        'TextFarthersName
        '
        Me.TextFarthersName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Fathers Name", True))
        Me.TextFarthersName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFarthersName.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextFarthersName.Location = New System.Drawing.Point(177, 288)
        Me.TextFarthersName.Name = "TextFarthersName"
        Me.TextFarthersName.Size = New System.Drawing.Size(333, 22)
        Me.TextFarthersName.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(52, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 21)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Father's Name"
        '
        'TextFathersBirth
        '
        Me.TextFathersBirth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Father Birthday", True))
        Me.TextFathersBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFathersBirth.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextFathersBirth.Location = New System.Drawing.Point(177, 316)
        Me.TextFathersBirth.Name = "TextFathersBirth"
        Me.TextFathersBirth.Size = New System.Drawing.Size(333, 22)
        Me.TextFathersBirth.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(52, 317)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 21)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Birthday"
        '
        'TextFathersContact
        '
        Me.TextFathersContact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Fathers Contact No", True))
        Me.TextFathersContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFathersContact.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextFathersContact.Location = New System.Drawing.Point(177, 372)
        Me.TextFathersContact.Name = "TextFathersContact"
        Me.TextFathersContact.Size = New System.Drawing.Size(333, 22)
        Me.TextFathersContact.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(52, 373)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 21)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Contact No."
        '
        'TextFathersOccu
        '
        Me.TextFathersOccu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Fathers Contact No", True))
        Me.TextFathersOccu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFathersOccu.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextFathersOccu.Location = New System.Drawing.Point(177, 344)
        Me.TextFathersOccu.Name = "TextFathersOccu"
        Me.TextFathersOccu.Size = New System.Drawing.Size(333, 22)
        Me.TextFathersOccu.TabIndex = 28
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(52, 345)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 21)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Occupation"
        '
        'TextFathersEmail
        '
        Me.TextFathersEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Father Email Add", True))
        Me.TextFathersEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextFathersEmail.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextFathersEmail.Location = New System.Drawing.Point(177, 400)
        Me.TextFathersEmail.Name = "TextFathersEmail"
        Me.TextFathersEmail.Size = New System.Drawing.Size(333, 22)
        Me.TextFathersEmail.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(52, 401)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 21)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "Email Add."
        '
        'TextMotherEmail
        '
        Me.TextMotherEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Mothers Email Add", True))
        Me.TextMotherEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMotherEmail.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextMotherEmail.Location = New System.Drawing.Point(677, 400)
        Me.TextMotherEmail.Name = "TextMotherEmail"
        Me.TextMotherEmail.Size = New System.Drawing.Size(333, 22)
        Me.TextMotherEmail.TabIndex = 42
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(552, 401)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 21)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "Email Add."
        '
        'TextMothersContact
        '
        Me.TextMothersContact.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Mothers Contact No", True))
        Me.TextMothersContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMothersContact.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextMothersContact.Location = New System.Drawing.Point(677, 372)
        Me.TextMothersContact.Name = "TextMothersContact"
        Me.TextMothersContact.Size = New System.Drawing.Size(333, 22)
        Me.TextMothersContact.TabIndex = 40
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(552, 373)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 21)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "Contact No."
        '
        'TextMotherOccu
        '
        Me.TextMotherOccu.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Mothers Occupation", True))
        Me.TextMotherOccu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMotherOccu.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextMotherOccu.Location = New System.Drawing.Point(677, 344)
        Me.TextMotherOccu.Name = "TextMotherOccu"
        Me.TextMotherOccu.Size = New System.Drawing.Size(333, 22)
        Me.TextMotherOccu.TabIndex = 38
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(552, 345)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 21)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Occupation"
        '
        'TextMothersBirth
        '
        Me.TextMothersBirth.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Mothers Birthday", True))
        Me.TextMothersBirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMothersBirth.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextMothersBirth.Location = New System.Drawing.Point(677, 316)
        Me.TextMothersBirth.Name = "TextMothersBirth"
        Me.TextMothersBirth.Size = New System.Drawing.Size(333, 22)
        Me.TextMothersBirth.TabIndex = 36
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(552, 317)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 21)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Birthday"
        '
        'TextMothersName
        '
        Me.TextMothersName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Mothers Name", True))
        Me.TextMothersName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextMothersName.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextMothersName.Location = New System.Drawing.Point(677, 288)
        Me.TextMothersName.Name = "TextMothersName"
        Me.TextMothersName.Size = New System.Drawing.Size(333, 22)
        Me.TextMothersName.TabIndex = 34
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Roboto Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(552, 289)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 21)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "Mother's Name"
        '
        'Btn3
        '
        Me.Btn3.BackColor = System.Drawing.Color.SteelBlue
        Me.Btn3.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn3.Location = New System.Drawing.Point(892, 458)
        Me.Btn3.Name = "Btn3"
        Me.Btn3.Size = New System.Drawing.Size(118, 36)
        Me.Btn3.TabIndex = 43
        Me.Btn3.Text = "MAIN MENU"
        Me.Btn3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(768, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 36)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "SUBMIT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'StudentRegistrationWalkinDataSet
        '
        Me.StudentRegistrationWalkinDataSet.DataSetName = "StudentRegistrationWalkinDataSet"
        Me.StudentRegistrationWalkinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.StudentRegistrationWalkinDataSet
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'SRI1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(1055, 541)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn3)
        Me.Controls.Add(Me.TextMotherEmail)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextMothersContact)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TextMotherOccu)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextMothersBirth)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TextMothersName)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.TextFathersEmail)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextFathersContact)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextFathersOccu)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextFathersBirth)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextFarthersName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextHomeAdd)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextNationality)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextPlaceOfBirth)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextContact1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextAge)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextDateBirth)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextMidName)
        Me.Controls.Add(Me.TextName)
        Me.Controls.Add(Me.TextSurName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SRI1"
        Me.Text = "SRI1"
        CType(Me.StudentRegistrationWalkinDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextSurName As TextBox
    Friend WithEvents TextName As TextBox
    Friend WithEvents TextMidName As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextDateBirth As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextAge As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextContact1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextPlaceOfBirth As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextNationality As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextHomeAdd As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextFarthersName As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextFathersBirth As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextFathersContact As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextFathersOccu As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextFathersEmail As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextMotherEmail As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TextMothersContact As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextMotherOccu As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextMothersBirth As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextMothersName As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Btn3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents StudentRegistrationWalkinDataSet As StudentRegistrationWalkinDataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As StudentRegistrationWalkinDataSetTableAdapters.Table1TableAdapter
End Class
