<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBookingDetails
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
        Dim BookingIdLabel As System.Windows.Forms.Label
        Dim ArtistNameLabel As System.Windows.Forms.Label
        Dim GenreCodeLabel As System.Windows.Forms.Label
        Dim NumberOfMembersLabel As System.Windows.Forms.Label
        Dim YearsActiveLabel As System.Windows.Forms.Label
        Dim MonthlyListenersLabel As System.Windows.Forms.Label
        Dim VenueCodeLabel As System.Windows.Forms.Label
        Dim SetStartDtLabel As System.Windows.Forms.Label
        Dim DurationLabel As System.Windows.Forms.Label
        Dim PayoutLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBookingDetails))
        Me._0000_DUPAGEDataSet = New Umashankar_Karthik_40_Project02._0000_DUPAGEDataSet()
        Me.Mod40BookingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mod40BookingsTableAdapter = New Umashankar_Karthik_40_Project02._0000_DUPAGEDataSetTableAdapters.mod40BookingsTableAdapter()
        Me.TableAdapterManager = New Umashankar_Karthik_40_Project02._0000_DUPAGEDataSetTableAdapters.TableAdapterManager()
        Me.btnAddSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.erpBooking = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Mod40GenresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mod40GenresTableAdapter = New Umashankar_Karthik_40_Project02._0000_DUPAGEDataSetTableAdapters.mod40GenresTableAdapter()
        Me.Mod40VenuesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mod40VenuesTableAdapter = New Umashankar_Karthik_40_Project02._0000_DUPAGEDataSetTableAdapters.mod40VenuesTableAdapter()
        Me.GenreCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.NumberOfMembersNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.VenueCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.SetStartDtDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BookingIdTextBox = New System.Windows.Forms.TextBox()
        Me.YearsActiveTextBox = New System.Windows.Forms.TextBox()
        Me.MonthlyListenersTextBox = New System.Windows.Forms.TextBox()
        Me.DurationTextBox = New System.Windows.Forms.TextBox()
        Me.PayoutTextBox = New System.Windows.Forms.TextBox()
        Me.ArtistNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Mod40ArtistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mod40ArtistTableAdapter = New Umashankar_Karthik_40_Project02._0000_DUPAGEDataSetTableAdapters.mod40ArtistTableAdapter()
        BookingIdLabel = New System.Windows.Forms.Label()
        ArtistNameLabel = New System.Windows.Forms.Label()
        GenreCodeLabel = New System.Windows.Forms.Label()
        NumberOfMembersLabel = New System.Windows.Forms.Label()
        YearsActiveLabel = New System.Windows.Forms.Label()
        MonthlyListenersLabel = New System.Windows.Forms.Label()
        VenueCodeLabel = New System.Windows.Forms.Label()
        SetStartDtLabel = New System.Windows.Forms.Label()
        DurationLabel = New System.Windows.Forms.Label()
        PayoutLabel = New System.Windows.Forms.Label()
        CType(Me._0000_DUPAGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mod40BookingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mod40GenresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mod40VenuesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumberOfMembersNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mod40ArtistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookingIdLabel
        '
        BookingIdLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        BookingIdLabel.AutoSize = True
        BookingIdLabel.Location = New System.Drawing.Point(106, 42)
        BookingIdLabel.Name = "BookingIdLabel"
        BookingIdLabel.Size = New System.Drawing.Size(80, 17)
        BookingIdLabel.TabIndex = 0
        BookingIdLabel.Text = "Booking ID:"
        '
        'ArtistNameLabel
        '
        ArtistNameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ArtistNameLabel.AutoSize = True
        ArtistNameLabel.Location = New System.Drawing.Point(99, 87)
        ArtistNameLabel.Name = "ArtistNameLabel"
        ArtistNameLabel.Size = New System.Drawing.Size(85, 17)
        ArtistNameLabel.TabIndex = 0
        ArtistNameLabel.Text = "Artist Name:"
        '
        'GenreCodeLabel
        '
        GenreCodeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GenreCodeLabel.AutoSize = True
        GenreCodeLabel.Location = New System.Drawing.Point(132, 132)
        GenreCodeLabel.Name = "GenreCodeLabel"
        GenreCodeLabel.Size = New System.Drawing.Size(52, 17)
        GenreCodeLabel.TabIndex = 26
        GenreCodeLabel.Text = "Genre:"
        '
        'NumberOfMembersLabel
        '
        NumberOfMembersLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NumberOfMembersLabel.AutoSize = True
        NumberOfMembersLabel.Location = New System.Drawing.Point(41, 177)
        NumberOfMembersLabel.Name = "NumberOfMembersLabel"
        NumberOfMembersLabel.Size = New System.Drawing.Size(143, 17)
        NumberOfMembersLabel.TabIndex = 28
        NumberOfMembersLabel.Text = "Number Of Members:"
        '
        'YearsActiveLabel
        '
        YearsActiveLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        YearsActiveLabel.AutoSize = True
        YearsActiveLabel.Location = New System.Drawing.Point(93, 222)
        YearsActiveLabel.Name = "YearsActiveLabel"
        YearsActiveLabel.Size = New System.Drawing.Size(91, 17)
        YearsActiveLabel.TabIndex = 30
        YearsActiveLabel.Text = "Years Active:"
        '
        'MonthlyListenersLabel
        '
        MonthlyListenersLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        MonthlyListenersLabel.AutoSize = True
        MonthlyListenersLabel.Location = New System.Drawing.Point(61, 267)
        MonthlyListenersLabel.Name = "MonthlyListenersLabel"
        MonthlyListenersLabel.Size = New System.Drawing.Size(123, 17)
        MonthlyListenersLabel.TabIndex = 32
        MonthlyListenersLabel.Text = "Monthly Listeners:"
        '
        'VenueCodeLabel
        '
        VenueCodeLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        VenueCodeLabel.AutoSize = True
        VenueCodeLabel.Location = New System.Drawing.Point(131, 312)
        VenueCodeLabel.Name = "VenueCodeLabel"
        VenueCodeLabel.Size = New System.Drawing.Size(53, 17)
        VenueCodeLabel.TabIndex = 34
        VenueCodeLabel.Text = "Venue:"
        '
        'SetStartDtLabel
        '
        SetStartDtLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        SetStartDtLabel.AutoSize = True
        SetStartDtLabel.Location = New System.Drawing.Point(54, 357)
        SetStartDtLabel.Name = "SetStartDtLabel"
        SetStartDtLabel.Size = New System.Drawing.Size(130, 17)
        SetStartDtLabel.TabIndex = 36
        SetStartDtLabel.Text = "Set Date and Time:"
        '
        'DurationLabel
        '
        DurationLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DurationLabel.AutoSize = True
        DurationLabel.Location = New System.Drawing.Point(118, 402)
        DurationLabel.Name = "DurationLabel"
        DurationLabel.Size = New System.Drawing.Size(66, 17)
        DurationLabel.TabIndex = 38
        DurationLabel.Text = "Duration:"
        '
        'PayoutLabel
        '
        PayoutLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PayoutLabel.AutoSize = True
        PayoutLabel.Location = New System.Drawing.Point(128, 447)
        PayoutLabel.Name = "PayoutLabel"
        PayoutLabel.Size = New System.Drawing.Size(56, 17)
        PayoutLabel.TabIndex = 40
        PayoutLabel.Text = "Payout:"
        '
        '_0000_DUPAGEDataSet
        '
        Me._0000_DUPAGEDataSet.DataSetName = "_0000_DUPAGEDataSet"
        Me._0000_DUPAGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Mod40BookingsBindingSource
        '
        Me.Mod40BookingsBindingSource.DataMember = "mod40Bookings"
        Me.Mod40BookingsBindingSource.DataSource = Me._0000_DUPAGEDataSet
        '
        'Mod40BookingsTableAdapter
        '
        Me.Mod40BookingsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mod40ArtistTableAdapter = Nothing
        Me.TableAdapterManager.mod40BookingsTableAdapter = Me.Mod40BookingsTableAdapter
        Me.TableAdapterManager.mod40GenresTableAdapter = Nothing
        Me.TableAdapterManager.mod40InstrumentsTableAdapter = Nothing
        Me.TableAdapterManager.mod40VenuesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Umashankar_Karthik_40_Project02._0000_DUPAGEDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnAddSave
        '
        Me.btnAddSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAddSave.Location = New System.Drawing.Point(196, 530)
        Me.btnAddSave.Name = "btnAddSave"
        Me.btnAddSave.Size = New System.Drawing.Size(89, 30)
        Me.btnAddSave.TabIndex = 11
        Me.btnAddSave.Text = "&Add"
        Me.btnAddSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(334, 530)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(89, 30)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'erpBooking
        '
        Me.erpBooking.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.erpBooking.ContainerControl = Me
        '
        'Mod40GenresBindingSource
        '
        Me.Mod40GenresBindingSource.DataMember = "mod40Genres"
        Me.Mod40GenresBindingSource.DataSource = Me._0000_DUPAGEDataSet
        '
        'Mod40GenresTableAdapter
        '
        Me.Mod40GenresTableAdapter.ClearBeforeFill = True
        '
        'Mod40VenuesBindingSource
        '
        Me.Mod40VenuesBindingSource.DataMember = "mod40Venues"
        Me.Mod40VenuesBindingSource.DataSource = Me._0000_DUPAGEDataSet
        '
        'Mod40VenuesTableAdapter
        '
        Me.Mod40VenuesTableAdapter.ClearBeforeFill = True
        '
        'GenreCodeComboBox
        '
        Me.GenreCodeComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenreCodeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Mod40BookingsBindingSource, "GenreCode", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.GenreCodeComboBox.DataSource = Me.Mod40GenresBindingSource
        Me.GenreCodeComboBox.DisplayMember = "GenreName"
        Me.GenreCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenreCodeComboBox.FormattingEnabled = True
        Me.GenreCodeComboBox.Location = New System.Drawing.Point(211, 129)
        Me.GenreCodeComboBox.Name = "GenreCodeComboBox"
        Me.GenreCodeComboBox.Size = New System.Drawing.Size(238, 24)
        Me.GenreCodeComboBox.TabIndex = 3
        Me.GenreCodeComboBox.ValueMember = "GenreCode"
        '
        'NumberOfMembersNumericUpDown
        '
        Me.NumberOfMembersNumericUpDown.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberOfMembersNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Mod40BookingsBindingSource, "NumberOfMembers", True))
        Me.NumberOfMembersNumericUpDown.Location = New System.Drawing.Point(211, 175)
        Me.NumberOfMembersNumericUpDown.Name = "NumberOfMembersNumericUpDown"
        Me.NumberOfMembersNumericUpDown.Size = New System.Drawing.Size(59, 22)
        Me.NumberOfMembersNumericUpDown.TabIndex = 4
        '
        'VenueCodeComboBox
        '
        Me.VenueCodeComboBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VenueCodeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Mod40BookingsBindingSource, "VenueCode", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.VenueCodeComboBox.DataSource = Me.Mod40VenuesBindingSource
        Me.VenueCodeComboBox.DisplayMember = "VenueName"
        Me.VenueCodeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.VenueCodeComboBox.FormattingEnabled = True
        Me.VenueCodeComboBox.Location = New System.Drawing.Point(211, 309)
        Me.VenueCodeComboBox.Name = "VenueCodeComboBox"
        Me.VenueCodeComboBox.Size = New System.Drawing.Size(238, 24)
        Me.VenueCodeComboBox.TabIndex = 7
        Me.VenueCodeComboBox.ValueMember = "VenueCode"
        '
        'SetStartDtDateTimePicker
        '
        Me.SetStartDtDateTimePicker.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SetStartDtDateTimePicker.CustomFormat = "MM/dd/yyyy  hh:mm:ss tt  "
        Me.SetStartDtDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Mod40BookingsBindingSource, "SetStartDt", True))
        Me.SetStartDtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.SetStartDtDateTimePicker.Location = New System.Drawing.Point(211, 356)
        Me.SetStartDtDateTimePicker.Name = "SetStartDtDateTimePicker"
        Me.SetStartDtDateTimePicker.Size = New System.Drawing.Size(238, 22)
        Me.SetStartDtDateTimePicker.TabIndex = 8
        '
        'BookingIdTextBox
        '
        Me.BookingIdTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BookingIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40BookingsBindingSource, "BookingId", True))
        Me.BookingIdTextBox.Location = New System.Drawing.Point(211, 39)
        Me.BookingIdTextBox.MaxLength = 6
        Me.BookingIdTextBox.Name = "BookingIdTextBox"
        Me.BookingIdTextBox.Size = New System.Drawing.Size(109, 22)
        Me.BookingIdTextBox.TabIndex = 1
        '
        'YearsActiveTextBox
        '
        Me.YearsActiveTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YearsActiveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40BookingsBindingSource, "YearsActive", True))
        Me.YearsActiveTextBox.Location = New System.Drawing.Point(211, 219)
        Me.YearsActiveTextBox.MaxLength = 3
        Me.YearsActiveTextBox.Name = "YearsActiveTextBox"
        Me.YearsActiveTextBox.Size = New System.Drawing.Size(67, 22)
        Me.YearsActiveTextBox.TabIndex = 5
        '
        'MonthlyListenersTextBox
        '
        Me.MonthlyListenersTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthlyListenersTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40BookingsBindingSource, "MonthlyListeners", True))
        Me.MonthlyListenersTextBox.Location = New System.Drawing.Point(211, 264)
        Me.MonthlyListenersTextBox.MaxLength = 10
        Me.MonthlyListenersTextBox.Name = "MonthlyListenersTextBox"
        Me.MonthlyListenersTextBox.Size = New System.Drawing.Size(102, 22)
        Me.MonthlyListenersTextBox.TabIndex = 6
        '
        'DurationTextBox
        '
        Me.DurationTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DurationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40BookingsBindingSource, "Duration", True))
        Me.DurationTextBox.Location = New System.Drawing.Point(211, 399)
        Me.DurationTextBox.MaxLength = 4
        Me.DurationTextBox.Name = "DurationTextBox"
        Me.DurationTextBox.Size = New System.Drawing.Size(67, 22)
        Me.DurationTextBox.TabIndex = 9
        '
        'PayoutTextBox
        '
        Me.PayoutTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40BookingsBindingSource, "Payout", True))
        Me.PayoutTextBox.Location = New System.Drawing.Point(211, 444)
        Me.PayoutTextBox.MaxLength = 10
        Me.PayoutTextBox.Name = "PayoutTextBox"
        Me.PayoutTextBox.Size = New System.Drawing.Size(107, 22)
        Me.PayoutTextBox.TabIndex = 10
        '
        'ArtistNameComboBox
        '
        Me.ArtistNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Mod40BookingsBindingSource, "ArtistName", True))
        Me.ArtistNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ArtistNameComboBox.FormattingEnabled = True
        Me.ArtistNameComboBox.Location = New System.Drawing.Point(211, 84)
        Me.ArtistNameComboBox.Name = "ArtistNameComboBox"
        Me.ArtistNameComboBox.Size = New System.Drawing.Size(238, 24)
        Me.ArtistNameComboBox.TabIndex = 2
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
        'frmBookingDetails
        '
        Me.AcceptButton = Me.btnAddSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(619, 591)
        Me.Controls.Add(Me.ArtistNameComboBox)
        Me.Controls.Add(Me.PayoutTextBox)
        Me.Controls.Add(Me.DurationTextBox)
        Me.Controls.Add(Me.MonthlyListenersTextBox)
        Me.Controls.Add(Me.YearsActiveTextBox)
        Me.Controls.Add(Me.BookingIdTextBox)
        Me.Controls.Add(BookingIdLabel)
        Me.Controls.Add(ArtistNameLabel)
        Me.Controls.Add(GenreCodeLabel)
        Me.Controls.Add(Me.GenreCodeComboBox)
        Me.Controls.Add(NumberOfMembersLabel)
        Me.Controls.Add(Me.NumberOfMembersNumericUpDown)
        Me.Controls.Add(YearsActiveLabel)
        Me.Controls.Add(MonthlyListenersLabel)
        Me.Controls.Add(VenueCodeLabel)
        Me.Controls.Add(Me.VenueCodeComboBox)
        Me.Controls.Add(SetStartDtLabel)
        Me.Controls.Add(Me.SetStartDtDateTimePicker)
        Me.Controls.Add(DurationLabel)
        Me.Controls.Add(PayoutLabel)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(637, 638)
        Me.Name = "frmBookingDetails"
        Me.Text = "Edit Booking (Karthik #40)"
        CType(Me._0000_DUPAGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mod40BookingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mod40GenresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mod40VenuesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumberOfMembersNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mod40ArtistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _0000_DUPAGEDataSet As _0000_DUPAGEDataSet
    Friend WithEvents Mod40BookingsBindingSource As BindingSource
    Friend WithEvents Mod40BookingsTableAdapter As _0000_DUPAGEDataSetTableAdapters.mod40BookingsTableAdapter
    Friend WithEvents TableAdapterManager As _0000_DUPAGEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnAddSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents erpBooking As ErrorProvider
    Friend WithEvents Mod40GenresBindingSource As BindingSource
    Friend WithEvents Mod40GenresTableAdapter As _0000_DUPAGEDataSetTableAdapters.mod40GenresTableAdapter
    Friend WithEvents Mod40VenuesBindingSource As BindingSource
    Friend WithEvents Mod40VenuesTableAdapter As _0000_DUPAGEDataSetTableAdapters.mod40VenuesTableAdapter
    Friend WithEvents GenreCodeComboBox As ComboBox
    Friend WithEvents NumberOfMembersNumericUpDown As NumericUpDown
    Friend WithEvents VenueCodeComboBox As ComboBox
    Friend WithEvents SetStartDtDateTimePicker As DateTimePicker
    Friend WithEvents BookingIdTextBox As TextBox
    Friend WithEvents DurationTextBox As TextBox
    Friend WithEvents MonthlyListenersTextBox As TextBox
    Friend WithEvents YearsActiveTextBox As TextBox
    Friend WithEvents PayoutTextBox As TextBox
    Friend WithEvents ArtistNameComboBox As ComboBox
    Friend WithEvents Mod40ArtistBindingSource As BindingSource
    Friend WithEvents Mod40ArtistTableAdapter As _0000_DUPAGEDataSetTableAdapters.mod40ArtistTableAdapter
End Class
