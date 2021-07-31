'******************************************************
'* Name:       Karthik Umashankar
'* Class:      CIS-2510
'* Assignment: Project 02 Spring '20
'* File:       frmBookingDetails.vb
'* Purpose:    Application for Artist Management
'******************************************************
Option Strict On
Option Explicit On
Option Infer Off
Option Compare Binary

Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text.RegularExpressions

Public Class frmBookingDetails

    Private CONNECTION_STRING As String = "Data Source=184.168.47.21;Initial Catalog=0000_DUPAGE;User ID=dupage;Password=dotnet4ever;Persist Security Info=True"
    Private BookingId As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        BookingId = 0
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(selectedId As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        BookingId = selectedId

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub frmBookingDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'POPULATE ARTIST NAME COMBO BOX
        LoadComboBox()
        btnAddSave.Enabled = False
        'TODO: This line of code loads data into the '_0000_DUPAGEDataSet.mod40Artist' table. You can move, or remove it, as needed.
        Me.Mod40ArtistTableAdapter.Fill(Me._0000_DUPAGEDataSet.mod40Artist)
        'TODO: This line of code loads data into the '_0000_DUPAGEDataSet.mod40Venues' table. You can move, or remove it, as needed.
        Me.Mod40VenuesTableAdapter.Fill(Me._0000_DUPAGEDataSet.mod40Venues)
        'TODO: This line of code loads data into the '_0000_DUPAGEDataSet.mod40Genres' table. You can move, or remove it, as needed.
        Me.Mod40GenresTableAdapter.Fill(Me._0000_DUPAGEDataSet.mod40Genres)
        'TODO: This line of code loads data into the '_0000_DUPAGEDataSet.mod40Bookings' table. You can move, or remove it, as needed.
        Me.Mod40BookingsTableAdapter.Fill(Me._0000_DUPAGEDataSet.mod40Bookings)

        If BookingId = 0 Then
            btnAddSave.Text = "&Add"
            Me.Text = "New Booking (Karthik #40)"
            Me.Mod40BookingsBindingSource.AddNew()
            BookingIdTextBox.Text = "-1"
            ArtistNameComboBox.SelectedIndex = -1

        Else
            btnAddSave.Text = "&Save"
            Me.Text = "Edit Booking (Karthik #40)"
            Me.Mod40BookingsTableAdapter.FillByBookingId(Me._0000_DUPAGEDataSet.mod40Bookings, BookingId)
        End If


        If Me.Mod40BookingsBindingSource.Count = 0 Then
            MsgBox("Database Error: Booking not found", MsgBoxStyle.Critical, "Database Error")
            Me.Close()
        End If

        'If Me.Mod40BookingsBindingSource.Count > 1 Then
        '    MsgBox("Database Error: Too many rows found", MsgBoxStyle.Critical, "Database Error")
        '    Me.Close()
        'End If
    End Sub

    Private Sub btnAddSave_Click(sender As Object, e As EventArgs) Handles btnAddSave.Click
        ClearErrors()

        Try
            Me.Mod40BookingsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._0000_DUPAGEDataSet)
        Catch ex As SqlException
            If (ex.Number = 547 AndAlso ex.Message.Contains("BookingId")) Then
                erpBooking.SetError(BookingIdTextBox, "The Booking ID must be a number between 0 and 9999999, or -1 for a new booking.")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("ArtistName")) Then
                erpBooking.SetError(ArtistNameComboBox, "Please select an Artist.")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("GenreCode")) Then
                erpBooking.SetError(GenreCodeComboBox, "Please select a valid genre.")
                Return
            End If


            If (ex.Number = 547 AndAlso ex.Message.Contains("NumberOfMembers")) Then
                erpBooking.SetError(NumberOfMembersNumericUpDown, "Number of members must be between 1 and 10 (inclusive).")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("YearsActive")) Then
                erpBooking.SetError(YearsActiveTextBox, "Number of years active must be between 1 and 100 (inclusive).")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("MonthltListeners")) Then
                erpBooking.SetError(MonthlyListenersTextBox, "Monthly listeners must be a number between 0 and 9999999999.")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("VenueCode")) Then
                erpBooking.SetError(VenueCodeComboBox, "Please select a valid venue.")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("SetStartDt")) Then
                erpBooking.SetError(SetStartDtDateTimePicker, "Booking date cannot be in the past or the current time.")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("Duration")) Then
                erpBooking.SetError(DurationTextBox, "Set duration must be in decimal format, greater than 0 Hrs and less than 10 Hrs.")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("Payout")) Then
                erpBooking.SetError(PayoutTextBox, "Payout must be a valid decimal between 0 and 9,999,999.00")
                Return
            End If

            If (ex.Message.Contains("uc1_mod40Bookings")) Then
                MsgBox("Artist is already booked at that time. Select a different time.", MsgBoxStyle.Critical, "Error")
                Return
            End If

            If (ex.Message.Contains("uc2_mod40Bookings")) Then
                MsgBox("Venue is already booked at that time. Select a different time.", MsgBoxStyle.Critical, "Error")
                Return
            End If

            MsgBox("A database error occured. ", MsgBoxStyle.Critical, "Error")
            Return

        Catch ex As Exception
            If ex.Message.Contains("nulls") Then
                MsgBox("One or more required fields is incomplete. Please fill out the fields.", MsgBoxStyle.Critical, "Error")
                Return
            End If
            MsgBox("An unexpected error occured. ", MsgBoxStyle.Critical, "Error")
            Return
        End Try
        Me.Close()
    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub IntegersOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BookingIdTextBox.KeyPress, YearsActiveTextBox.KeyPress,
                                                                                        MonthlyListenersTextBox.KeyPress

        If e.KeyChar = ControlChars.Back Then
            Return
        End If
        If e.KeyChar < "0" Or e.KeyChar > "9" Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub DecimalsOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DurationTextBox.KeyPress, PayoutTextBox.KeyPress

        If e.KeyChar = ControlChars.Back Then
            Return
        End If

        If DurationTextBox.Text.Contains(".") = False Then
            If e.KeyChar = "." Then
                Return
            End If
        End If

        If PayoutTextBox.Text.Contains(".") = False Then
            If e.KeyChar = "." Then
                Return
            End If
        End If

        If e.KeyChar < "0" Or e.KeyChar > "9" Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub BookingIdTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles BookingIdTextBox.Validating
        Dim text As String = BookingIdTextBox.Text.Trim()

        If Convert.ToInt16(text) = -1 Then
            Return
        End If
        If Regex.Matches(text, "^\d{1,6}$").Count <> 1 Then
            erpBooking.SetError(BookingIdTextBox, "The Booking ID must be a number between 0 and 9999999, or -1 for a new booking.")
            e.Cancel = True
        Else
            erpBooking.SetError(BookingIdTextBox, "")
        End If
    End Sub

    Private Sub ArtistNameComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ArtistNameComboBox.Validating

        If ArtistNameComboBox.SelectedIndex = -1 Then
            erpBooking.SetError(ArtistNameComboBox, "Please select an Artist.")
            e.Cancel = True
        Else
            erpBooking.SetError(ArtistNameComboBox, "")
        End If
    End Sub

    Private Sub GenreCodeComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles GenreCodeComboBox.Validating

        If GenreCodeComboBox.SelectedIndex = -1 Then
            erpBooking.SetError(GenreCodeComboBox, "Please select a valid genre.")
            e.Cancel = True
        Else
            erpBooking.SetError(GenreCodeComboBox, "")
        End If

    End Sub

    Private Sub NumberOfMembersNumericUpDown_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NumberOfMembersNumericUpDown.Validating
        If NumberOfMembersNumericUpDown.Value < 1 OrElse NumberOfMembersNumericUpDown.Value > 10 Then
            erpBooking.SetError(NumberOfMembersNumericUpDown, "Number of members must be between 1 and 10 (inclusive).")
            e.Cancel = True
        Else
            erpBooking.SetError(NumberOfMembersNumericUpDown, "")
        End If
    End Sub

    Private Sub YearsActiveTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles YearsActiveTextBox.Validating
        If YearsActiveTextBox.Text.Trim() = "" OrElse Convert.ToInt16(YearsActiveTextBox.Text) < 0 _
                                               OrElse Convert.ToInt16(YearsActiveTextBox.Text) > 100 Then

            erpBooking.SetError(YearsActiveTextBox, "Number of years active must be between 1 and 100 (inclusive).")
            e.Cancel = True
        Else
            erpBooking.SetError(YearsActiveTextBox, "")
        End If
    End Sub

    Private Sub MonthlyListenersTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MonthlyListenersTextBox.Validating
        Dim text As String = MonthlyListenersTextBox.Text.Trim()

        If Regex.Matches(text, "^\d{1,10}").Count <> 1 Then
            erpBooking.SetError(MonthlyListenersTextBox, "Monthly listeners must be a number between 0 and 9999999999.")
            e.Cancel = True
        Else
            erpBooking.SetError(MonthlyListenersTextBox, "")
        End If
    End Sub

    Private Sub VenueCodeComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles VenueCodeComboBox.Validating
        If VenueCodeComboBox.SelectedIndex = -1 Then
            erpBooking.SetError(VenueCodeComboBox, "Please select a valid venue.")
            e.Cancel = True
        Else
            erpBooking.SetError(VenueCodeComboBox, "")
        End If
    End Sub

    Private Sub SetStartDtDateTimePicker_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SetStartDtDateTimePicker.Validating
        If SetStartDtDateTimePicker.Value <= DateAndTime.Now() Then
            erpBooking.SetError(SetStartDtDateTimePicker, "Booking date cannot be in the past or the current time.")
            e.Cancel = True
        Else
            erpBooking.SetError(SetStartDtDateTimePicker, "")
        End If
    End Sub

    Private Sub DurationTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles DurationTextBox.Validating
        Dim text As String = DurationTextBox.Text.Trim()

        If Regex.Matches(text, "^[0-9]{1,2}(\.[0-9]{2})?$").Count <> 1 OrElse Convert.ToDecimal(DurationTextBox.Text) > 10 Then
            erpBooking.SetError(DurationTextBox, "Set duration must be in decimal format, greater than 0 Hrs and less than 10 Hrs.")
            e.Cancel = True
        Else
            erpBooking.SetError(DurationTextBox, "")
        End If
    End Sub

    Private Sub PayoutTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles PayoutTextBox.Validating
        Dim text As String = PayoutTextBox.Text.Trim()

        If Regex.Matches(text, "^[0-9]{1,7}(\.[0-9]{2})?$").Count <> 1 Then
            erpBooking.SetError(PayoutTextBox, "Payout must be a valid decimal between 0 and 9,999,999.00")
            e.Cancel = True
        Else
            erpBooking.SetError(PayoutTextBox, "")
            btnAddSave.Enabled = True
        End If

    End Sub

    Private Sub LoadComboBox()
        Dim connection As SqlConnection
        Dim selectStatement As String
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        connection = New SqlConnection(CONNECTION_STRING)
        connection.Open()
        selectStatement = "SELECT DISTINCT ArtistName FROM mod40Artist"
        command = New SqlCommand(selectStatement, connection)
        reader = command.ExecuteReader()

        While reader.Read()
            ArtistNameComboBox.Items.Add(reader("ArtistName"))
        End While

        reader.Close()
        connection.Close()
    End Sub
    Private Sub ClearErrors()
        erpBooking.SetError(BookingIdTextBox, "")
        erpBooking.SetError(ArtistNameComboBox, "")
        erpBooking.SetError(GenreCodeComboBox, "")
        erpBooking.SetError(NumberOfMembersNumericUpDown, "")
        erpBooking.SetError(YearsActiveTextBox, "")
        erpBooking.SetError(MonthlyListenersTextBox, "")
        erpBooking.SetError(VenueCodeComboBox, "")
        erpBooking.SetError(SetStartDtDateTimePicker, "")
        erpBooking.SetError(DurationTextBox, "")
        erpBooking.SetError(PayoutTextBox, "")
    End Sub


End Class