<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArtistDetails
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
        Dim ArtistIdLabel As System.Windows.Forms.Label
        Dim ArtistNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim BirthDateLabel As System.Windows.Forms.Label
        Dim WorkPhoneLabel As System.Windows.Forms.Label
        Dim CellPhoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StatesLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim InstrumentCodeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArtistDetails))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnAddSave = New System.Windows.Forms.Button()
        Me.erpArtist = New System.Windows.Forms.ErrorProvider(Me.components)
        Me._0000_DUPAGEDataSet = New Umashankar_Karthik_40_Project02._0000_DUPAGEDataSet()
        Me.Mod40ArtistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mod40ArtistTableAdapter = New Umashankar_Karthik_40_Project02._0000_DUPAGEDataSetTableAdapters.mod40ArtistTableAdapter()
        Me.TableAdapterManager = New Umashankar_Karthik_40_Project02._0000_DUPAGEDataSetTableAdapters.TableAdapterManager()
        Me.Mod40InstrumentsTableAdapter = New Umashankar_Karthik_40_Project02._0000_DUPAGEDataSetTableAdapters.mod40InstrumentsTableAdapter()
        Me.ArtistIdTextBox = New System.Windows.Forms.TextBox()
        Me.ArtistNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.BirthDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WorkPhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CellPhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StatesTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.InstrumentCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.Mod40InstrumentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mod40InstrumentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        ArtistIdLabel = New System.Windows.Forms.Label()
        ArtistNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        BirthDateLabel = New System.Windows.Forms.Label()
        WorkPhoneLabel = New System.Windows.Forms.Label()
        CellPhoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StatesLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        InstrumentCodeLabel = New System.Windows.Forms.Label()
        CType(Me.erpArtist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._0000_DUPAGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mod40ArtistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mod40InstrumentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mod40InstrumentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ArtistIdLabel
        '
        ArtistIdLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ArtistIdLabel.AutoSize = True
        ArtistIdLabel.Location = New System.Drawing.Point(135, 37)
        ArtistIdLabel.Name = "ArtistIdLabel"
        ArtistIdLabel.Size = New System.Drawing.Size(59, 17)
        ArtistIdLabel.TabIndex = 15
        ArtistIdLabel.Text = "Artist Id:"
        '
        'ArtistNameLabel
        '
        ArtistNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ArtistNameLabel.AutoSize = True
        ArtistNameLabel.Location = New System.Drawing.Point(109, 81)
        ArtistNameLabel.Name = "ArtistNameLabel"
        ArtistNameLabel.Size = New System.Drawing.Size(85, 17)
        ArtistNameLabel.TabIndex = 17
        ArtistNameLabel.Text = "Artist Name:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(114, 125)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(80, 17)
        FirstNameLabel.TabIndex = 19
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(114, 169)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(80, 17)
        LastNameLabel.TabIndex = 21
        LastNameLabel.Text = "Last Name:"
        '
        'BirthDateLabel
        '
        BirthDateLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BirthDateLabel.AutoSize = True
        BirthDateLabel.Location = New System.Drawing.Point(119, 214)
        BirthDateLabel.Name = "BirthDateLabel"
        BirthDateLabel.Size = New System.Drawing.Size(75, 17)
        BirthDateLabel.TabIndex = 23
        BirthDateLabel.Text = "Birth Date:"
        '
        'WorkPhoneLabel
        '
        WorkPhoneLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        WorkPhoneLabel.AutoSize = True
        WorkPhoneLabel.Location = New System.Drawing.Point(104, 257)
        WorkPhoneLabel.Name = "WorkPhoneLabel"
        WorkPhoneLabel.Size = New System.Drawing.Size(90, 17)
        WorkPhoneLabel.TabIndex = 25
        WorkPhoneLabel.Text = "Work Phone:"
        '
        'CellPhoneLabel
        '
        CellPhoneLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CellPhoneLabel.AutoSize = True
        CellPhoneLabel.Location = New System.Drawing.Point(114, 301)
        CellPhoneLabel.Name = "CellPhoneLabel"
        CellPhoneLabel.Size = New System.Drawing.Size(80, 17)
        CellPhoneLabel.TabIndex = 27
        CellPhoneLabel.Text = "Cell Phone:"
        '
        'EmailLabel
        '
        EmailLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(148, 345)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(46, 17)
        EmailLabel.TabIndex = 29
        EmailLabel.Text = "Email:"
        '
        'CityLabel
        '
        CityLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(159, 389)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(35, 17)
        CityLabel.TabIndex = 31
        CityLabel.Text = "City:"
        '
        'StatesLabel
        '
        StatesLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        StatesLabel.AutoSize = True
        StatesLabel.Location = New System.Drawing.Point(142, 433)
        StatesLabel.Name = "StatesLabel"
        StatesLabel.Size = New System.Drawing.Size(45, 17)
        StatesLabel.TabIndex = 33
        StatesLabel.Text = "State:"
        '
        'CountryLabel
        '
        CountryLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(133, 477)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(61, 17)
        CountryLabel.TabIndex = 35
        CountryLabel.Text = "Country:"
        '
        'InstrumentCodeLabel
        '
        InstrumentCodeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        InstrumentCodeLabel.AutoSize = True
        InstrumentCodeLabel.Location = New System.Drawing.Point(79, 521)
        InstrumentCodeLabel.Name = "InstrumentCodeLabel"
        InstrumentCodeLabel.Size = New System.Drawing.Size(115, 17)
        InstrumentCodeLabel.TabIndex = 37
        InstrumentCodeLabel.Text = "Instrument Code:"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(327, 570)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 30)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnAddSave
        '
        Me.btnAddSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAddSave.Location = New System.Drawing.Point(189, 570)
        Me.btnAddSave.Name = "btnAddSave"
        Me.btnAddSave.Size = New System.Drawing.Size(89, 30)
        Me.btnAddSave.TabIndex = 13
        Me.btnAddSave.Text = "&Add"
        Me.btnAddSave.UseVisualStyleBackColor = True
        '
        'erpArtist
        '
        Me.erpArtist.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.erpArtist.ContainerControl = Me
        '
        '_0000_DUPAGEDataSet
        '
        Me._0000_DUPAGEDataSet.DataSetName = "_0000_DUPAGEDataSet"
        Me._0000_DUPAGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mod40ArtistBindingSource
        '
        Me.Mod40ArtistBindingSource.DataMember = "mod40Artist"
        Me.Mod40ArtistBindingSource.DataSource = Me._0000_DUPAGEDataSet
        '
        'Mod40ArtistTableAdapter
        '
        Me.Mod40ArtistTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mod40ArtistTableAdapter = Me.Mod40ArtistTableAdapter
        Me.TableAdapterManager.mod40BookingsTableAdapter = Nothing
        Me.TableAdapterManager.mod40GenresTableAdapter = Nothing
        Me.TableAdapterManager.mod40InstrumentsTableAdapter = Me.Mod40InstrumentsTableAdapter
        Me.TableAdapterManager.mod40VenuesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Umashankar_Karthik_40_Project02._0000_DUPAGEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Mod40InstrumentsTableAdapter
        '
        Me.Mod40InstrumentsTableAdapter.ClearBeforeFill = True
        '
        'ArtistIdTextBox
        '
        Me.ArtistIdTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ArtistIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40ArtistBindingSource, "ArtistId", True))
        Me.ArtistIdTextBox.Location = New System.Drawing.Point(241, 34)
        Me.ArtistIdTextBox.Name = "ArtistIdTextBox"
        Me.ArtistIdTextBox.Size = New System.Drawing.Size(89, 22)
        Me.ArtistIdTextBox.TabIndex = 1
        '
        'ArtistNameTextBox
        '
        Me.ArtistNameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ArtistNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40ArtistBindingSource, "ArtistName", True))
        Me.ArtistNameTextBox.Location = New System.Drawing.Point(241, 78)
        Me.ArtistNameTextBox.Name = "ArtistNameTextBox"
        Me.ArtistNameTextBox.Size = New System.Drawing.Size(190, 22)
        Me.ArtistNameTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40ArtistBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(241, 122)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(190, 22)
        Me.FirstNameTextBox.TabIndex = 3
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40ArtistBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(241, 166)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(190, 22)
        Me.LastNameTextBox.TabIndex = 4
        '
        'BirthDateDateTimePicker
        '
        Me.BirthDateDateTimePicker.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BirthDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Mod40ArtistBindingSource, "BirthDate", True))
        Me.BirthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BirthDateDateTimePicker.Location = New System.Drawing.Point(241, 210)
        Me.BirthDateDateTimePicker.Name = "BirthDateDateTimePicker"
        Me.BirthDateDateTimePicker.Size = New System.Drawing.Size(127, 22)
        Me.BirthDateDateTimePicker.TabIndex = 5
        '
        'WorkPhoneMaskedTextBox
        '
        Me.WorkPhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40ArtistBindingSource, "WorkPhone", True))
        Me.WorkPhoneMaskedTextBox.Location = New System.Drawing.Point(241, 254)
        Me.WorkPhoneMaskedTextBox.Mask = "999-000-0000"
        Me.WorkPhoneMaskedTextBox.Name = "WorkPhoneMaskedTextBox"
        Me.WorkPhoneMaskedTextBox.Size = New System.Drawing.Size(127, 22)
        Me.WorkPhoneMaskedTextBox.TabIndex = 6
        '
        'CellPhoneMaskedTextBox
        '
        Me.CellPhoneMaskedTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CellPhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40ArtistBindingSource, "CellPhone", True))
        Me.CellPhoneMaskedTextBox.Location = New System.Drawing.Point(241, 298)
        Me.CellPhoneMaskedTextBox.Mask = "999-000-0000"
        Me.CellPhoneMaskedTextBox.Name = "CellPhoneMaskedTextBox"
        Me.CellPhoneMaskedTextBox.Size = New System.Drawing.Size(127, 22)
        Me.CellPhoneMaskedTextBox.TabIndex = 7
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40ArtistBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(241, 342)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(190, 22)
        Me.EmailTextBox.TabIndex = 8
        '
        'CityTextBox
        '
        Me.CityTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40ArtistBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(241, 386)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(151, 22)
        Me.CityTextBox.TabIndex = 9
        '
        'StatesTextBox
        '
        Me.StatesTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40ArtistBindingSource, "States", True))
        Me.StatesTextBox.Location = New System.Drawing.Point(241, 430)
        Me.StatesTextBox.Name = "StatesTextBox"
        Me.StatesTextBox.Size = New System.Drawing.Size(151, 22)
        Me.StatesTextBox.TabIndex = 10
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40ArtistBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(241, 474)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(151, 22)
        Me.CountryTextBox.TabIndex = 11
        '
        'InstrumentCodeComboBox
        '
        Me.InstrumentCodeComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InstrumentCodeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Mod40ArtistBindingSource, "InstrumentCode", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.InstrumentCodeComboBox.DataSource = Me.Mod40InstrumentsBindingSource1
        Me.InstrumentCodeComboBox.DisplayMember = "InstrumentName"
        Me.InstrumentCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.InstrumentCodeComboBox.FormattingEnabled = True
        Me.InstrumentCodeComboBox.Location = New System.Drawing.Point(241, 518)
        Me.InstrumentCodeComboBox.Name = "InstrumentCodeComboBox"
        Me.InstrumentCodeComboBox.Size = New System.Drawing.Size(151, 24)
        Me.InstrumentCodeComboBox.TabIndex = 12
        Me.InstrumentCodeComboBox.ValueMember = "InstrumentCode"
        '
        'Mod40InstrumentsBindingSource
        '
        Me.Mod40InstrumentsBindingSource.DataMember = "mod40Instruments"
        Me.Mod40InstrumentsBindingSource.DataSource = Me._0000_DUPAGEDataSet
        '
        'Mod40InstrumentsBindingSource1
        '
        Me.Mod40InstrumentsBindingSource1.DataMember = "mod40Instruments"
        Me.Mod40InstrumentsBindingSource1.DataSource = Me._0000_DUPAGEDataSet
        '
        'frmArtistDetails
        '
        Me.AcceptButton = Me.btnAddSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(604, 625)
        Me.Controls.Add(ArtistIdLabel)
        Me.Controls.Add(Me.ArtistIdTextBox)
        Me.Controls.Add(ArtistNameLabel)
        Me.Controls.Add(Me.ArtistNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(BirthDateLabel)
        Me.Controls.Add(Me.BirthDateDateTimePicker)
        Me.Controls.Add(WorkPhoneLabel)
        Me.Controls.Add(Me.WorkPhoneMaskedTextBox)
        Me.Controls.Add(CellPhoneLabel)
        Me.Controls.Add(Me.CellPhoneMaskedTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(StatesLabel)
        Me.Controls.Add(Me.StatesTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(InstrumentCodeLabel)
        Me.Controls.Add(Me.InstrumentCodeComboBox)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(622, 672)
        Me.Name = "frmArtistDetails"
        Me.Text = "Edit Artist (Karthik #40)"
        CType(Me.erpArtist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._0000_DUPAGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mod40ArtistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mod40InstrumentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mod40InstrumentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAddSave As Button
    Friend WithEvents erpArtist As ErrorProvider
    Friend WithEvents Mod40ArtistBindingSource As BindingSource
    Friend WithEvents _0000_DUPAGEDataSet As _0000_DUPAGEDataSet
    Friend WithEvents Mod40ArtistTableAdapter As _0000_DUPAGEDataSetTableAdapters.mod40ArtistTableAdapter
    Friend WithEvents TableAdapterManager As _0000_DUPAGEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ArtistIdTextBox As TextBox
    Friend WithEvents ArtistNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents BirthDateDateTimePicker As DateTimePicker
    Friend WithEvents WorkPhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents CellPhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StatesTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents InstrumentCodeComboBox As ComboBox
    Friend WithEvents Mod40InstrumentsTableAdapter As _0000_DUPAGEDataSetTableAdapters.mod40InstrumentsTableAdapter
    Friend WithEvents Mod40InstrumentsBindingSource As BindingSource
    Friend WithEvents Mod40InstrumentsBindingSource1 As BindingSource
End Class
