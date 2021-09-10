'******************************************************
'* Name:       Karthik Umashankar
'* Class:      CIS-2510
'* Assignment: Project 02 Spring '20
'* File:       frmArtistManagement.vb
'* Purpose:    Application for Artist Management
'******************************************************
Option Strict On
Option Explicit On
Option Infer Off
Option Compare Binary

Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms.DataVisualization.Charting

Public Class frmArtistManagement

    Private Sub frmArtistManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_0000_DUPAGEDataSet.mod40Artist' table. You can move, or remove it, as needed.
        Me.Mod40ArtistTableAdapter.Fill(Me._0000_DUPAGEDataSet.mod40Artist)
        'TODO: This line of code loads data into the '_0000_DUPAGEDataSet.mod40Bookings' table. You can move, or remove it, as needed.
        Me.Mod40BookingsTableAdapter.Fill(Me._0000_DUPAGEDataSet.mod40Bookings)
        ddlCharts.Items.Add("Artist Payouts")
        ddlCharts.Items.Add("Artist Monthly Listeners")
        ddlCharts.Items.Add("Venue Sizes")

        Dim cArea As ChartArea = chtMain.ChartAreas(0)
        With cArea
            .BackColor = Color.Azure
            .ShadowColor = Color.Red
            .BorderColor = Color.Black
            .Area3DStyle.Enable3D = True
        End With
        chtMain.Series.Clear()
    End Sub
    '-------------------------------------------------------------Bookings-------------------------------------------------------'
    Private Sub dgvBookings_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBookings.SelectionChanged
        If dgvBookings.SelectedRows.Count = 0 Then
            btnDeleteBooking.Enabled = False
        ElseIf dgvBookings.SelectedRows.Count > 0 Then
            btnDeleteBooking.Enabled = True
        End If
    End Sub
    Private Sub btnRefreshBookings_Click(sender As Object, e As EventArgs) Handles btnRefreshBookings.Click
        dgvBookings.ClearSelection()
        RefreshBookingsForm()
    End Sub

    Private Sub dgvBookings_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBookings.CellDoubleClick
        Dim bookingDetailsForm As frmBookingDetails
        Dim BookingId As Integer

        BookingId = Convert.ToInt16(dgvBookings.Rows(e.RowIndex).Cells(0).Value)
        bookingDetailsForm = New frmBookingDetails(BookingId)
        bookingDetailsForm.ShowDialog()
        RefreshBookingsForm()
    End Sub

    Private Sub dgvBookings_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvBookings.KeyDown
        If e.KeyCode = Keys.Delete Then
            btnDeleteBooking_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub btnNewBooking_Click(sender As Object, e As EventArgs) Handles btnNewBooking.Click
        Dim bookingDetailsForm As frmBookingDetails
        bookingDetailsForm = New frmBookingDetails()
        bookingDetailsForm.ShowDialog()
        RefreshBookingsForm()
    End Sub

    Private Sub btnDeleteBooking_Click(sender As Object, e As EventArgs) Handles btnDeleteBooking.Click
        Dim confirmResult As Integer

        If dgvBookings.SelectedRows.Count = 0 Then
            MsgBox("You must select a booking to delete", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        If dgvBookings.SelectedRows.Count = 1 Then
            Dim rowIndex As Integer = dgvBookings.SelectedRows(0).Index
            confirmResult = MsgBox("Are you sure you want to delete booking " _
                   & dgvBookings.Rows(rowIndex).Cells(1).Value.ToString() & "?", MsgBoxStyle.OkCancel, "Confirm Record Deletion")

        ElseIf dgvBookings.SelectedRows.Count = dgvBookings.Rows.Count Then
            confirmResult = MsgBox("Are you sure you want to delete ALL the bookings? " _
                    , MsgBoxStyle.OkCancel, "Confirm Record Deletion")
        Else
            confirmResult = MsgBox("Are you sure you want to delete the selected " & dgvBookings.SelectedRows.Count & " bookings? " _
                   , MsgBoxStyle.OkCancel, "Confirm Record Deletion")
        End If

        If confirmResult = DialogResult.Cancel Then
            Return
        End If

        DeleteBookings()
        RefreshBookingsForm()
        dgvBookings.ClearSelection()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub DeleteBookings()
        Dim connectionString As String = "Data Source=184.168.47.21;Initial Catalog=0000_DUPAGE;Persist Security Info=True;User ID=dupage;Password=dotnet4ever"
        Dim connection As New SqlConnection(connectionString)

        Dim deleteStatement As String = "DELETE FROM mod40Bookings WHERE BookingId = @BookingID"
        connection.Open()

        For counter As Integer = 0 To dgvBookings.SelectedRows.Count - 1
            Dim rowIndex As Integer = dgvBookings.SelectedRows(counter).Index
            Dim bookingId As Integer = Convert.ToInt32(dgvBookings.Rows(rowIndex).Cells(0).Value)

            Try
                Dim deleteCommand As SqlCommand = New SqlCommand(deleteStatement, connection)
                deleteCommand.Parameters.AddWithValue("@BookingID", bookingId)
                deleteCommand.ExecuteNonQuery()

            Catch ex As Exception
                connection.Close()
                MsgBox("Unable to perform the requested deletion(s). Please contact your administrator.", MsgBoxStyle.Critical, "Database Error")
                Return

            End Try
        Next

        connection.Close()

    End Sub

    Private Sub RefreshBookingsForm()
        Me.Mod40BookingsTableAdapter.Fill(Me._0000_DUPAGEDataSet.mod40Bookings)
    End Sub

    '---------------------------------------------------------------Artists---------------------------------------------------------
    Private Sub dgvArtists_SelectionChanged(sender As Object, e As EventArgs) Handles dgvArtists.SelectionChanged
        If dgvArtists.SelectedRows.Count = 0 Then
            btnDeleteArtist.Enabled = False
        ElseIf dgvArtists.SelectedRows.Count > 0 Then
            btnDeleteArtist.Enabled = True
        End If
    End Sub
    Private Sub btnRefreshArtists_Click(sender As Object, e As EventArgs) Handles btnRefreshArtists.Click
        dgvArtists.ClearSelection()
        RefreshArtistsForm()
    End Sub

    Private Sub dgvArtists_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvArtists.CellDoubleClick
        Dim artistDetailsForm As frmArtistDetails
        Dim ArtistId As Integer

        ArtistId = Convert.ToInt16(dgvArtists.Rows(e.RowIndex).Cells(0).Value)
        artistDetailsForm = New frmArtistDetails(ArtistId)
        artistDetailsForm.ShowDialog()
        RefreshArtistsForm()
    End Sub

    Private Sub dgvArtists_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvArtists.KeyDown
        If e.KeyCode = Keys.Delete Then
            btnDeleteArtist_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub btnNewArtist_Click(sender As Object, e As EventArgs) Handles btnNewArtist.Click
        Dim artistDetailsForm As frmArtistDetails
        artistDetailsForm = New frmArtistDetails()
        artistDetailsForm.ShowDialog()
        RefreshArtistsForm()
    End Sub

    Private Sub btnDeleteArtist_Click(sender As Object, e As EventArgs) Handles btnDeleteArtist.Click
        Dim confirmResult As Integer

        If dgvArtists.SelectedRows.Count = 0 Then
            MsgBox("You must select an artist to delete", MsgBoxStyle.Exclamation, "Error")
            Return
        End If

        If dgvArtists.SelectedRows.Count = 1 Then
            Dim rowIndex As Integer = dgvArtists.SelectedRows(0).Index
            confirmResult = MsgBox("Are you sure you want to delete artist " _
                   & dgvArtists.Rows(rowIndex).Cells(1).Value.ToString() & "?", MsgBoxStyle.OkCancel, "Confirm Record Deletion")

        ElseIf dgvArtists.SelectedRows.Count = dgvArtists.Rows.Count Then
            confirmResult = MsgBox("Are you sure you want to delete ALL the artists? " _
                    , MsgBoxStyle.OkCancel, "Confirm Record Deletion")
        Else
            confirmResult = MsgBox("Are you sure you want to delete the selected " & dgvArtists.SelectedRows.Count & " artists? " _
                   , MsgBoxStyle.OkCancel, "Confirm Record Deletion")
        End If

        If confirmResult = DialogResult.Cancel Then
            Return
        End If

        DeleteArtists()
        RefreshArtistsForm()
        dgvArtists.ClearSelection()
    End Sub
    Private Sub btnExit2_Click(sender As Object, e As EventArgs) Handles btnExit2.Click
        Me.Close()
    End Sub

    Private Sub DeleteArtists()
        Dim connectionString As String = "Data Source=184.168.47.21;Initial Catalog=0000_DUPAGE;Persist Security Info=True;User ID=#####;Password=#########" 'Redacted
        Dim connection As New SqlConnection(connectionString)

        Dim deleteStatement As String = "DELETE FROM mod40Artist WHERE ArtistId = @ArtistId"
        connection.Open()

        For counter As Integer = 0 To dgvArtists.SelectedRows.Count - 1
            Dim rowIndex As Integer = dgvArtists.SelectedRows(counter).Index
            Dim artistId As Integer = Convert.ToInt32(dgvArtists.Rows(rowIndex).Cells(0).Value)

            Try
                Dim deleteCommand As SqlCommand = New SqlCommand(deleteStatement, connection)
                deleteCommand.Parameters.AddWithValue("@ArtistID", artistId)
                deleteCommand.ExecuteNonQuery()

            Catch ex As Exception
                connection.Close()
                MsgBox("Unable to perform the requested deletion(s). Please contact your administrator.", MsgBoxStyle.Critical, "Database Error")
                Return

            End Try
        Next

        connection.Close()

    End Sub

    Private Sub RefreshArtistsForm()
        Me.Mod40ArtistTableAdapter.Fill(Me._0000_DUPAGEDataSet.mod40Artist)
    End Sub


    '---------------------------------------------------------Insight (Charts)---------------------------------------------------------
    Private Sub btnCharts_Click(sender As Object, e As EventArgs) Handles btnCharts.Click
        chtMain.Series.Clear()
        If ddlCharts.SelectedIndex = 0 Then
            LoadArtistPayouts()
        ElseIf ddlCharts.SelectedIndex = 1 Then
            LoadArtistMonthlyListeners()
        ElseIf ddlCharts.SelectedIndex = 2 Then
            LoadVenueSizes()
        Else
            MsgBox("Please select a chart option", MsgBoxStyle.Exclamation)
        End If
    End Sub


    Private Sub LoadArtistPayouts()
        'Dim connectionString As String = ConfigurationManager.ConnectionStrings("DuPageDatabase").ConnectionString
        Dim connectionString As String = "Data Source=184.168.47.21;Initial Catalog=0000_DUPAGE;Persist Security Info=True;User ID=#####;Password=#########" 'Redacted
        Dim connection As New SqlConnection(connectionString)
        Dim selectChart As String = "SELECT * FROM mod40Bookings"

        Try
            connection.Open()
            Dim selectCommand As SqlCommand = New SqlCommand(selectChart, connection)
            Dim reader As SqlDataReader = selectCommand.ExecuteReader()

            Do While reader.Read()
                Dim artistName As String = reader("ArtistName").ToString()
                If chtMain.Series.IndexOf(artistName) < 0 Then
                    chtMain.Series.Add(artistName)
                End If
                Dim dpnt1 As DataPoint = New DataPoint()
                dpnt1.SetValueY(reader("Payout"))
                chtMain.Series(artistName).Points.Add(dpnt1)
            Loop
            reader.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox("Unable to retrieve the requested records. Please contact your database administrator.", MsgBoxStyle.Critical, "Database Error")
            Return
        End Try
        connection.Close()

        chtMain.ChartAreas(0).RecalculateAxesScale()
    End Sub

    Private Sub LoadArtistMonthlyListeners()
        Dim connectionString As String = "Data Source=184.168.47.21;Initial Catalog=0000_DUPAGE;Persist Security Info=True;User ID=#####;Password=#########" 'Redacted
        Dim connection As New SqlConnection(connectionString)
        Dim selectChart As String = "SELECT * FROM mod40Bookings"

        Try
            connection.Open()
            Dim selectCommand As SqlCommand = New SqlCommand(selectChart, connection)
            Dim reader As SqlDataReader = selectCommand.ExecuteReader()

            Do While reader.Read()
                Dim artistName As String = reader("ArtistName").ToString()
                If chtMain.Series.IndexOf(artistName) < 0 Then
                    chtMain.Series.Add(artistName)
                End If
                Dim dpnt1 As DataPoint = New DataPoint()
                dpnt1.SetValueY(reader("MonthlyListeners"))
                chtMain.Series(artistName).Points.Add(dpnt1)
            Loop
            reader.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox("Unable to retrieve the requested records. Please contact your database administrator.", MsgBoxStyle.Critical, "Database Error")
            Return
        End Try
        connection.Close()

        chtMain.ChartAreas(0).RecalculateAxesScale()
    End Sub

    Private Sub LoadVenueSizes()

        Dim connectionString As String = "Data Source=184.168.47.21;Initial Catalog=0000_DUPAGE;Persist Security Info=True;User ID=#####;Password=#########" 'Redacted
        Dim connection As New SqlConnection(connectionString)
        Dim selectChart As String = "SELECT * FROM mod40Venues"

        Try
            connection.Open()
            Dim selectCommand As SqlCommand = New SqlCommand(selectChart, connection)
            Dim reader As SqlDataReader = selectCommand.ExecuteReader()

            Do While reader.Read()
                Dim venueName As String = reader("VenueName").ToString()
                chtMain.Series.Add(venueName)
                Dim dpnt1 As DataPoint = New DataPoint()
                dpnt1.SetValueY(reader("Capacity"))
                chtMain.Series(venueName).Points.Add(dpnt1)
            Loop
            reader.Close()
        Catch ex As Exception
            connection.Close()
            MsgBox("Unable to retrieve the requested records. Please contact your database administrator.", MsgBoxStyle.Critical, "Database Error")
            Return
        End Try
        connection.Close()

        chtMain.ChartAreas(0).RecalculateAxesScale()
    End Sub
End Class
