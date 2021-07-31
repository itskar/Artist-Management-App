'******************************************************
'* Name:       Karthik Umashankar
'* Class:      CIS-2510
'* Assignment: Project 02 Spring '20
'* File:       frmArtistDetails.vb
'* Purpose:    Application for Artist Management
'******************************************************
Option Strict On
Option Explicit On
Option Infer Off
Option Compare Binary

Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Text.RegularExpressions

Public Class frmArtistDetails
    Private ArtistId As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ArtistId = 0
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub New(selectedId As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ArtistId = selectedId

        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub frmArtistDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_0000_DUPAGEDataSet.mod40Artist' table. You can move, or remove it, as needed.
        Me.Mod40ArtistTableAdapter.Fill(Me._0000_DUPAGEDataSet.mod40Artist)
        'TODO: This line of code loads data into the '_0000_DUPAGEDataSet.mod40Instruments' table. You can move, or remove it, as needed.
        Me.Mod40InstrumentsTableAdapter.Fill(Me._0000_DUPAGEDataSet.mod40Instruments)
        btnAddSave.Enabled = False
        If ArtistId = 0 Then
            btnAddSave.Text = "&Add"
            Me.Text = "New Artist (Karthik #40)"
            Me.Mod40ArtistBindingSource.AddNew()
            ArtistIdTextBox.Text = "-1"
        Else
            btnAddSave.Text = "&Save"
            Me.Text = "Edit Artist (Karthik #40)"
            Me.Mod40ArtistTableAdapter.FillBy(Me._0000_DUPAGEDataSet.mod40Artist, ArtistId)
        End If


        If Me.Mod40ArtistBindingSource.Count = 0 Then
            MsgBox("Database Error: Artist not found", MsgBoxStyle.Critical, "Database Error")
            Me.Close()
        End If

        'If Me.Mod40ArtistBindingSource.Count > 1 Then
        '    MsgBox("Database Error: Too many rows found", MsgBoxStyle.Critical, "Database Error")
        '    Me.Close()
        'End If
    End Sub

    Private Sub btnAddSave_Click(sender As Object, e As EventArgs) Handles btnAddSave.Click
        ClearErrors()

        Try
            If CellPhoneMaskedTextBox.Text.Replace("-", "").Trim() = "" Then
                CellPhoneMaskedTextBox.Text = CellPhoneMaskedTextBox.Text.Replace("-", "").Trim()
            End If
            Me.Mod40ArtistBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._0000_DUPAGEDataSet)
        Catch ex As SqlException
            If (ex.Number = 547 AndAlso ex.Message.Contains("ArtistId")) Then
                erpArtist.SetError(ArtistIdTextBox, "The Artist ID must be a number between 0 and 9999999.")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("ArtistName")) Then
                erpArtist.SetError(ArtistNameTextBox, "Artist Name is a required field and must be between 2-30 characters.")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("FirstName")) Then
                erpArtist.SetError(FirstNameTextBox, "First Name is a required field, must be between 2- 30 characters. Ex: 'John'")
                Return
            End If


            If (ex.Number = 547 AndAlso ex.Message.Contains("LastName")) Then
                erpArtist.SetError(LastNameTextBox, "Last Name is a required field, must be between 2- 30 characters. Ex: 'Jones'")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("BirthDate")) Then
                erpArtist.SetError(BirthDateDateTimePicker, "Date of birth cannot be in the future.")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("WorkPhone")) Then
                erpArtist.SetError(WorkPhoneMaskedTextBox, "Work Phone is a required field and must be in the format ###-###-####.")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("CellPhone")) Then
                erpArtist.SetError(CellPhoneMaskedTextBox, "Cell Phone must be in the format ###-###-####.")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("Email")) Then
                erpArtist.SetError(EmailTextBox, "Email is a required field and must be in a valid email format(example@example.com)")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("City")) Then
                erpArtist.SetError(CityTextBox, "City is a required field and cannot exceed 30 characters.")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("States")) Then
                erpArtist.SetError(StatesTextBox, "State is a required field and cannot exceed 30 characters.")
                Return
            End If

            If (ex.Number = 547 AndAlso ex.Message.Contains("Country")) Then
                erpArtist.SetError(CountryTextBox, "Country is a required field and cannot exceed 30 characters.")
                Return
            End If
            If (ex.Number = 547 AndAlso ex.Message.Contains("InstrumentCode")) Then
                erpArtist.SetError(InstrumentCodeComboBox, "Please select a valid instrument.")
                Return
            End If

            If (ex.Message.Contains("uc4_mod40Artist")) Then
                MsgBox("This artist already exists.", MsgBoxStyle.Critical, "Error")
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

    Private Sub IntegersOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ArtistIdTextBox.KeyPress
        If e.KeyChar = ControlChars.Back Then
            Return
        End If
        If e.KeyChar < "0" Or e.KeyChar > "9" Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub LettersOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstNameTextBox.KeyPress, LastNameTextBox.KeyPress,
                                                                                    CityTextBox.KeyPress, StatesTextBox.KeyPress,
                                                                                    CountryTextBox.KeyPress
        If e.KeyChar = ControlChars.Back Then
            Return
        End If
        If e.KeyChar = " " Then
            Return
        End If
        If e.KeyChar = "'" Then
            Return
        End If
        If e.KeyChar < "A" Or e.KeyChar > "z" Then
            e.Handled = True
            Return
        End If
    End Sub

    Private Sub ArtistIdTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ArtistIdTextBox.Validating
        Dim text As String = ArtistIdTextBox.Text.Trim()

        If Convert.ToInt16(text) = -1 Then
            erpArtist.SetError(ArtistIdTextBox, "")
            Return
        End If
        If Regex.Matches(text, "^\d{1,6}$").Count <> 1 Then
            erpArtist.SetError(ArtistIdTextBox, "The Artist ID must be a number between 0 and 9999999, or -1 for a new Artist.")
            e.Cancel = True
        Else
            erpArtist.SetError(ArtistIdTextBox, "")
        End If
    End Sub

    Private Sub ArtistNameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ArtistNameTextBox.Validating
        Dim text As String = ArtistNameTextBox.Text

        If text.Length < 2 OrElse text.Length > 30 Then
            erpArtist.SetError(ArtistNameTextBox, "Artist Name is a required field and must be between 2-30 characters.")
            e.Cancel = True
        ElseIf text.IndexOf(" ") = 0 OrElse text.IndexOf(" ") = text.Length - 1 Then
            erpArtist.SetError(ArtistNameTextBox, "Artist Name must not begin or end with spaces.")
            e.Cancel = True
        Else
            erpArtist.SetError(ArtistNameTextBox, "")
        End If
    End Sub

    Private Sub FirstNameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles FirstNameTextBox.Validating

        Dim text As String = FirstNameTextBox.Text

        If text.Length < 2 OrElse text.Length > 30 Then
            erpArtist.SetError(FirstNameTextBox, "First Name must be between 2-30 characters.")
            e.Cancel = True
        ElseIf text.IndexOf(" ") = 0 OrElse text.IndexOf(" ") = text.Length - 1 Then
            erpArtist.SetError(FirstNameTextBox, "First Name must not begin or end with spaces.")
            e.Cancel = True
        ElseIf text.First <> text.ToUpper().First Then
            erpArtist.SetError(FirstNameTextBox, "First Name must begin with an uppercase letter.")
            e.Cancel = True
        ElseIf text.ElementAt(1) <> text.ToLower().ElementAt(1) Then
            erpArtist.SetError(FirstNameTextBox, "Second letter cannot be uppercase.")
            e.Cancel = True
        Else
            erpArtist.SetError(FirstNameTextBox, "")
        End If

    End Sub

    Private Sub LastNameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles LastNameTextBox.Validating
        Dim text As String = LastNameTextBox.Text

        If text.Length < 2 OrElse text.Length > 30 Then
            erpArtist.SetError(LastNameTextBox, "Last Name must be between 2-30 characters.")
            e.Cancel = True
        ElseIf text.IndexOf(" ") = 0 OrElse text.IndexOf(" ") = text.Length - 1 Then
            erpArtist.SetError(LastNameTextBox, "Last Name must not begin or end with spaces.")
            e.Cancel = True
        ElseIf text.First <> text.ToUpper().First Then
            erpArtist.SetError(LastNameTextBox, "Last Name must begin with an uppercase letter.")
            e.Cancel = True
        ElseIf text.ElementAt(1) <> text.ToLower().ElementAt(1) Then
            erpArtist.SetError(LastNameTextBox, "Second letter cannot be uppercase.")
            e.Cancel = True
        Else
            erpArtist.SetError(LastNameTextBox, "")
        End If
    End Sub

    Private Sub BirthDateDateTimePicker_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles BirthDateDateTimePicker.Validating
        If BirthDateDateTimePicker.Value >= DateAndTime.Now() Then
            erpArtist.SetError(BirthDateDateTimePicker, "Birth date cannot be today or in the future.")
            e.Cancel = True
        Else
            erpArtist.SetError(BirthDateDateTimePicker, "")
        End If
    End Sub

    Private Sub WorkPhoneMaskedTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WorkPhoneMaskedTextBox.Validating
        Dim text As String = WorkPhoneMaskedTextBox.Text.Trim()

        If Regex.Matches(text, "^\d{3}-\d{3}-\d{4}$").Count <> 1 Then
            erpArtist.SetError(WorkPhoneMaskedTextBox, "Work Phone is a required field and must be in the format ###-###-####.")
            e.Cancel = True
        Else
            erpArtist.SetError(WorkPhoneMaskedTextBox, "")
        End If
    End Sub

    Private Sub CellPhoneMaskedTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CellPhoneMaskedTextBox.Validating
        Dim text As String = CellPhoneMaskedTextBox.Text.Trim()

        If text.Replace("-", "").Trim() = "" Then
            erpArtist.SetError(CellPhoneMaskedTextBox, "")
            Return
        End If

        If Regex.Matches(text, "^\d{3}-\d{3}-\d{4}$").Count <> 1 Then
            erpArtist.SetError(CellPhoneMaskedTextBox, "Cell phone number must be in the format ###-###-####.")
            e.Cancel = True
        Else
            erpArtist.SetError(CellPhoneMaskedTextBox, "")
        End If
    End Sub

    Private Sub EmailTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles EmailTextBox.Validating
        Dim text As String = EmailTextBox.Text.Trim()

        If (text.Contains("@") = False OrElse text.Contains(".") = False _
                  OrElse text.IndexOf("@") < 2 OrElse text.IndexOf("@") > text.Length - 5 _
                  OrElse text.IndexOf("@") <> text.LastIndexOf("@") _
                  OrElse text.IndexOf("@") > text.LastIndexOf(".") _
                  OrElse text.LastIndexOf(".") > text.Length() - 3) Then
            erpArtist.SetError(EmailTextBox, "Email is a required field and must be in a valid email format(example@example.com)")
            e.Cancel = True
        Else
            erpArtist.SetError(EmailTextBox, "")
        End If
    End Sub

    Private Sub CityTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CityTextBox.Validating
        Dim text As String = CityTextBox.Text
        If text.Length < 2 OrElse text.Length > 30 Then
            erpArtist.SetError(CityTextBox, "City is a required field and must be between 2-30 characters.")
            e.Cancel = True
        ElseIf text.IndexOf(" ") = 0 OrElse text.IndexOf(" ") = text.Length - 1 Then
            erpArtist.SetError(CityTextBox, "City must not begin or end with spaces.")
            e.Cancel = True
        Else
            erpArtist.SetError(CityTextBox, "")
        End If
    End Sub

    Private Sub StatesTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles StatesTextBox.Validating
        Dim text As String = StatesTextBox.Text

        If text.Length < 2 OrElse text.Length > 30 Then
            erpArtist.SetError(StatesTextBox, "States is a required field and must be between 2-30 characters.")
            e.Cancel = True
        ElseIf text.IndexOf(" ") = 0 OrElse text.IndexOf(" ") = text.Length - 1 Then
            erpArtist.SetError(StatesTextBox, "State must not begin or end with spaces.")
            e.Cancel = True
        Else
            erpArtist.SetError(StatesTextBox, "")
        End If

    End Sub
    Private Sub CountryTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CountryTextBox.Validating
        Dim text As String = CountryTextBox.Text

        If text.Length < 2 OrElse text.Length > 30 Then
            erpArtist.SetError(CountryTextBox, "Country is a required field and must be between 2-30 characters.")
            e.Cancel = True
        ElseIf text.IndexOf(" ") = 0 OrElse text.IndexOf(" ") = text.Length - 1 Then
            erpArtist.SetError(CountryTextBox, "Country must not begin or end with spaces.")
            e.Cancel = True
        Else
            erpArtist.SetError(CountryTextBox, "")
        End If

    End Sub
    Private Sub InstrumentCodeComboBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles InstrumentCodeComboBox.Validating
        If InstrumentCodeComboBox.SelectedIndex = -1 Then
            erpArtist.SetError(InstrumentCodeComboBox, "Please select a valid instrument.")
            e.Cancel = True
        Else
            erpArtist.SetError(InstrumentCodeComboBox, "")
            btnAddSave.Enabled = True
        End If


    End Sub


    Private Sub ClearErrors()
        erpArtist.SetError(ArtistIdTextBox, "")
        erpArtist.SetError(ArtistNameTextBox, "")
        erpArtist.SetError(FirstNameTextBox, "")
        erpArtist.SetError(LastNameTextBox, "")
        erpArtist.SetError(BirthDateDateTimePicker, "")
        erpArtist.SetError(WorkPhoneMaskedTextBox, "")
        erpArtist.SetError(CellPhoneMaskedTextBox, "")
        erpArtist.SetError(EmailTextBox, "")
        erpArtist.SetError(CityTextBox, "")
        erpArtist.SetError(StatesTextBox, "")
        erpArtist.SetError(CountryTextBox, "")
        erpArtist.SetError(InstrumentCodeComboBox, "")
    End Sub
End Class