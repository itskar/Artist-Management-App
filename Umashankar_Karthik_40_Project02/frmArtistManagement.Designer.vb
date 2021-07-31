<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArtistManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArtistManagement))
        Me.tbcMain = New System.Windows.Forms.TabControl()
        Me.tpgBookings = New System.Windows.Forms.TabPage()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRefreshBookings = New System.Windows.Forms.Button()
        Me.dgvBookings = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mod40BookingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._0000_DUPAGEDataSet = New Umashankar_Karthik_40_Project02._0000_DUPAGEDataSet()
        Me.btnDeleteBooking = New System.Windows.Forms.Button()
        Me.btnNewBooking = New System.Windows.Forms.Button()
        Me.tpgArtists = New System.Windows.Forms.TabPage()
        Me.dgvArtists = New System.Windows.Forms.DataGridView()
        Me.Mod40ArtistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnExit2 = New System.Windows.Forms.Button()
        Me.btnRefreshArtists = New System.Windows.Forms.Button()
        Me.btnDeleteArtist = New System.Windows.Forms.Button()
        Me.btnNewArtist = New System.Windows.Forms.Button()
        Me.tpgInsight = New System.Windows.Forms.TabPage()
        Me.Mod40BookingsTableAdapter = New Umashankar_Karthik_40_Project02._0000_DUPAGEDataSetTableAdapters.mod40BookingsTableAdapter()
        Me.TableAdapterManager = New Umashankar_Karthik_40_Project02._0000_DUPAGEDataSetTableAdapters.TableAdapterManager()
        Me.Mod40ArtistTableAdapter = New Umashankar_Karthik_40_Project02._0000_DUPAGEDataSetTableAdapters.mod40ArtistTableAdapter()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chtMain = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ddlCharts = New System.Windows.Forms.ComboBox()
        Me.btnCharts = New System.Windows.Forms.Button()
        Me.tbcMain.SuspendLayout()
        Me.tpgBookings.SuspendLayout()
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mod40BookingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._0000_DUPAGEDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgArtists.SuspendLayout()
        CType(Me.dgvArtists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mod40ArtistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgInsight.SuspendLayout()
        CType(Me.chtMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbcMain
        '
        Me.tbcMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbcMain.Controls.Add(Me.tpgBookings)
        Me.tbcMain.Controls.Add(Me.tpgArtists)
        Me.tbcMain.Controls.Add(Me.tpgInsight)
        Me.tbcMain.Location = New System.Drawing.Point(12, 12)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(1058, 529)
        Me.tbcMain.TabIndex = 0
        '
        'tpgBookings
        '
        Me.tpgBookings.Controls.Add(Me.btnExit)
        Me.tpgBookings.Controls.Add(Me.btnRefreshBookings)
        Me.tpgBookings.Controls.Add(Me.dgvBookings)
        Me.tpgBookings.Controls.Add(Me.btnDeleteBooking)
        Me.tpgBookings.Controls.Add(Me.btnNewBooking)
        Me.tpgBookings.Location = New System.Drawing.Point(4, 25)
        Me.tpgBookings.Name = "tpgBookings"
        Me.tpgBookings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgBookings.Size = New System.Drawing.Size(1050, 500)
        Me.tpgBookings.TabIndex = 0
        Me.tpgBookings.Text = "Bookings"
        Me.tpgBookings.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Location = New System.Drawing.Point(691, 449)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 30)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRefreshBookings
        '
        Me.btnRefreshBookings.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRefreshBookings.Location = New System.Drawing.Point(550, 449)
        Me.btnRefreshBookings.Name = "btnRefreshBookings"
        Me.btnRefreshBookings.Size = New System.Drawing.Size(92, 30)
        Me.btnRefreshBookings.TabIndex = 21
        Me.btnRefreshBookings.Text = "&Refresh"
        Me.btnRefreshBookings.UseVisualStyleBackColor = True
        '
        'dgvBookings
        '
        Me.dgvBookings.AllowUserToAddRows = False
        Me.dgvBookings.AllowUserToResizeColumns = False
        Me.dgvBookings.AllowUserToResizeRows = False
        Me.dgvBookings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvBookings.AutoGenerateColumns = False
        Me.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBookings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgvBookings.DataSource = Me.Mod40BookingsBindingSource
        Me.dgvBookings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvBookings.Location = New System.Drawing.Point(6, 6)
        Me.dgvBookings.Name = "dgvBookings"
        Me.dgvBookings.RowHeadersVisible = False
        Me.dgvBookings.RowTemplate.Height = 24
        Me.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBookings.Size = New System.Drawing.Size(1038, 408)
        Me.dgvBookings.TabIndex = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BookingId"
        Me.DataGridViewTextBoxColumn1.HeaderText = "BookingId"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ArtistName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Artist Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GenreCode"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Genre Code"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "NumberOfMembers"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Member Count"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "YearsActive"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Years Active"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "MonthlyListeners"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn6.HeaderText = "Monthly Listeners"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "VenueCode"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Venue Code"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SetStartDt"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Set Date and Time"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 114
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Duration"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Duration"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Payout"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn10.HeaderText = "Payout"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Mod40BookingsBindingSource
        '
        Me.Mod40BookingsBindingSource.DataMember = "mod40Bookings"
        Me.Mod40BookingsBindingSource.DataSource = Me._0000_DUPAGEDataSet
        '
        '_0000_DUPAGEDataSet
        '
        Me._0000_DUPAGEDataSet.DataSetName = "_0000_DUPAGEDataSet"
        Me._0000_DUPAGEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnDeleteBooking
        '
        Me.btnDeleteBooking.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDeleteBooking.Location = New System.Drawing.Point(409, 449)
        Me.btnDeleteBooking.Name = "btnDeleteBooking"
        Me.btnDeleteBooking.Size = New System.Drawing.Size(92, 30)
        Me.btnDeleteBooking.TabIndex = 20
        Me.btnDeleteBooking.Text = "&Delete"
        Me.btnDeleteBooking.UseVisualStyleBackColor = True
        '
        'btnNewBooking
        '
        Me.btnNewBooking.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNewBooking.Location = New System.Drawing.Point(268, 449)
        Me.btnNewBooking.Name = "btnNewBooking"
        Me.btnNewBooking.Size = New System.Drawing.Size(92, 30)
        Me.btnNewBooking.TabIndex = 19
        Me.btnNewBooking.Text = "&New"
        Me.btnNewBooking.UseVisualStyleBackColor = True
        '
        'tpgArtists
        '
        Me.tpgArtists.Controls.Add(Me.dgvArtists)
        Me.tpgArtists.Controls.Add(Me.btnExit2)
        Me.tpgArtists.Controls.Add(Me.btnRefreshArtists)
        Me.tpgArtists.Controls.Add(Me.btnDeleteArtist)
        Me.tpgArtists.Controls.Add(Me.btnNewArtist)
        Me.tpgArtists.Location = New System.Drawing.Point(4, 25)
        Me.tpgArtists.Name = "tpgArtists"
        Me.tpgArtists.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgArtists.Size = New System.Drawing.Size(1050, 500)
        Me.tpgArtists.TabIndex = 1
        Me.tpgArtists.Text = "Artists"
        Me.tpgArtists.UseVisualStyleBackColor = True
        '
        'dgvArtists
        '
        Me.dgvArtists.AllowUserToAddRows = False
        Me.dgvArtists.AllowUserToResizeColumns = False
        Me.dgvArtists.AllowUserToResizeRows = False
        Me.dgvArtists.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvArtists.AutoGenerateColumns = False
        Me.dgvArtists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvArtists.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.dgvArtists.DataSource = Me.Mod40ArtistBindingSource
        Me.dgvArtists.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvArtists.Location = New System.Drawing.Point(6, 6)
        Me.dgvArtists.Name = "dgvArtists"
        Me.dgvArtists.RowHeadersVisible = False
        Me.dgvArtists.RowTemplate.Height = 24
        Me.dgvArtists.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvArtists.Size = New System.Drawing.Size(1038, 413)
        Me.dgvArtists.TabIndex = 26
        '
        'Mod40ArtistBindingSource
        '
        Me.Mod40ArtistBindingSource.DataMember = "mod40Artist"
        Me.Mod40ArtistBindingSource.DataSource = Me._0000_DUPAGEDataSet
        '
        'btnExit2
        '
        Me.btnExit2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit2.Location = New System.Drawing.Point(691, 449)
        Me.btnExit2.Name = "btnExit2"
        Me.btnExit2.Size = New System.Drawing.Size(92, 30)
        Me.btnExit2.TabIndex = 26
        Me.btnExit2.Text = "E&xit"
        Me.btnExit2.UseVisualStyleBackColor = True
        '
        'btnRefreshArtists
        '
        Me.btnRefreshArtists.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRefreshArtists.Location = New System.Drawing.Point(550, 449)
        Me.btnRefreshArtists.Name = "btnRefreshArtists"
        Me.btnRefreshArtists.Size = New System.Drawing.Size(92, 30)
        Me.btnRefreshArtists.TabIndex = 25
        Me.btnRefreshArtists.Text = "&Refresh"
        Me.btnRefreshArtists.UseVisualStyleBackColor = True
        '
        'btnDeleteArtist
        '
        Me.btnDeleteArtist.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDeleteArtist.Location = New System.Drawing.Point(409, 449)
        Me.btnDeleteArtist.Name = "btnDeleteArtist"
        Me.btnDeleteArtist.Size = New System.Drawing.Size(92, 30)
        Me.btnDeleteArtist.TabIndex = 24
        Me.btnDeleteArtist.Text = "&Delete"
        Me.btnDeleteArtist.UseVisualStyleBackColor = True
        '
        'btnNewArtist
        '
        Me.btnNewArtist.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNewArtist.Location = New System.Drawing.Point(268, 449)
        Me.btnNewArtist.Name = "btnNewArtist"
        Me.btnNewArtist.Size = New System.Drawing.Size(92, 30)
        Me.btnNewArtist.TabIndex = 23
        Me.btnNewArtist.Text = "&New"
        Me.btnNewArtist.UseVisualStyleBackColor = True
        '
        'tpgInsight
        '
        Me.tpgInsight.Controls.Add(Me.btnCharts)
        Me.tpgInsight.Controls.Add(Me.ddlCharts)
        Me.tpgInsight.Controls.Add(Me.chtMain)
        Me.tpgInsight.Location = New System.Drawing.Point(4, 25)
        Me.tpgInsight.Name = "tpgInsight"
        Me.tpgInsight.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgInsight.Size = New System.Drawing.Size(1050, 500)
        Me.tpgInsight.TabIndex = 2
        Me.tpgInsight.Text = "Insight"
        Me.tpgInsight.UseVisualStyleBackColor = True
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
        'Mod40ArtistTableAdapter
        '
        Me.Mod40ArtistTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "InstrumentCode"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Instrument Code"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 140
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 86
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "States"
        Me.DataGridViewTextBoxColumn20.HeaderText = "State"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 70
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn19.HeaderText = "City"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 60
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 71
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "CellPhone"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Cell Phone"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 105
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "WorkPhone"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Work Phone"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 115
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "BirthDate"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Birth Date"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 105
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn13.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 105
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ArtistName"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Artist Name"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 110
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ArtistId"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ArtistId"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'chtMain
        '
        Me.chtMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "ChartArea1"
        Me.chtMain.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtMain.Legends.Add(Legend1)
        Me.chtMain.Location = New System.Drawing.Point(24, 63)
        Me.chtMain.Name = "chtMain"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtMain.Series.Add(Series1)
        Me.chtMain.Size = New System.Drawing.Size(1000, 431)
        Me.chtMain.TabIndex = 0
        Me.chtMain.Text = "Chart1"
        '
        'ddlCharts
        '
        Me.ddlCharts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlCharts.FormattingEnabled = True
        Me.ddlCharts.Location = New System.Drawing.Point(24, 23)
        Me.ddlCharts.Name = "ddlCharts"
        Me.ddlCharts.Size = New System.Drawing.Size(187, 24)
        Me.ddlCharts.TabIndex = 1
        '
        'btnCharts
        '
        Me.btnCharts.Location = New System.Drawing.Point(239, 19)
        Me.btnCharts.Name = "btnCharts"
        Me.btnCharts.Size = New System.Drawing.Size(92, 30)
        Me.btnCharts.TabIndex = 2
        Me.btnCharts.Text = "&Generate"
        Me.btnCharts.UseVisualStyleBackColor = True
        '
        'frmArtistManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 553)
        Me.Controls.Add(Me.tbcMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1100, 600)
        Me.Name = "frmArtistManagement"
        Me.Text = "William Morris Endeavor (Karthik #40)"
        Me.tbcMain.ResumeLayout(False)
        Me.tpgBookings.ResumeLayout(False)
        CType(Me.dgvBookings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mod40BookingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._0000_DUPAGEDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgArtists.ResumeLayout(False)
        CType(Me.dgvArtists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mod40ArtistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgInsight.ResumeLayout(False)
        CType(Me.chtMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbcMain As TabControl
    Friend WithEvents tpgBookings As TabPage
    Friend WithEvents tpgArtists As TabPage
    Friend WithEvents tpgInsight As TabPage
    Friend WithEvents _0000_DUPAGEDataSet As _0000_DUPAGEDataSet
    Friend WithEvents btnDeleteBooking As Button
    Friend WithEvents btnNewBooking As Button
    Friend WithEvents Mod40BookingsBindingSource As BindingSource
    Friend WithEvents Mod40BookingsTableAdapter As _0000_DUPAGEDataSetTableAdapters.mod40BookingsTableAdapter
    Friend WithEvents TableAdapterManager As _0000_DUPAGEDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRefreshBookings As Button
    Friend WithEvents dgvBookings As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents btnExit2 As Button
    Friend WithEvents btnRefreshArtists As Button
    Friend WithEvents btnDeleteArtist As Button
    Friend WithEvents btnNewArtist As Button
    Friend WithEvents Mod40ArtistBindingSource As BindingSource
    Friend WithEvents Mod40ArtistTableAdapter As _0000_DUPAGEDataSetTableAdapters.mod40ArtistTableAdapter
    Friend WithEvents dgvArtists As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents btnCharts As Button
    Friend WithEvents ddlCharts As ComboBox
    Friend WithEvents chtMain As DataVisualization.Charting.Chart
End Class
