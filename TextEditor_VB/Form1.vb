﻿Imports System.IO
Public Class Form1
	Private Sub MidnightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
		If DarkToolStripMenuItem.CheckState = CheckState.Checked Then 'Dark Theme
			MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
			MenuStrip1.ForeColor = System.Drawing.Color.WhiteSmoke
			Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
			rtbMainBody.BackColor = System.Drawing.SystemColors.MenuText
			rtbMainBody.ForeColor = System.Drawing.SystemColors.HighlightText
		End If
		If DarkToolStripMenuItem.CheckState = CheckState.Unchecked Then 'Revert to standard
			MenuStrip1.BackColor = System.Drawing.SystemColors.Control
			MenuStrip1.ForeColor = System.Drawing.SystemColors.MenuText
			Me.BackColor = System.Drawing.SystemColors.Control
			rtbMainBody.BackColor = System.Drawing.SystemColors.Window
			rtbMainBody.ForeColor = System.Drawing.SystemColors.MenuText
		End If

		If AutumnToolStripMenuItem.CheckState = CheckState.Checked Then 'Defensive Code that does not allow theme
			DarkToolStripMenuItem.CheckState = CheckState.Unchecked     'to be changed if Dark theme is selected
			MenuStrip1.BackColor = System.Drawing.Color.Maroon
			MenuStrip1.ForeColor = System.Drawing.Color.Orange
			Me.BackColor = System.Drawing.Color.Maroon
			rtbMainBody.BackColor = System.Drawing.Color.Khaki
			rtbMainBody.ForeColor = System.Drawing.Color.SaddleBrown
		End If
		If OceanToolStripMenuItem.CheckState = CheckState.Checked Then
			DarkToolStripMenuItem.CheckState = CheckState.Unchecked
			MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
			MenuStrip1.ForeColor = System.Drawing.Color.LemonChiffon
			Me.BackColor = System.Drawing.Color.MidnightBlue
			rtbMainBody.BackColor = System.Drawing.Color.PaleTurquoise
			rtbMainBody.ForeColor = System.Drawing.SystemColors.MenuText
		End If
	End Sub

	Private Sub AutumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutumnToolStripMenuItem.Click
		If AutumnToolStripMenuItem.CheckState = CheckState.Checked Then 'Autumn Theme
			MenuStrip1.BackColor = System.Drawing.Color.Maroon
			MenuStrip1.ForeColor = System.Drawing.Color.Orange
			Me.BackColor = System.Drawing.Color.Maroon
			rtbMainBody.BackColor = System.Drawing.Color.Khaki
			rtbMainBody.ForeColor = System.Drawing.Color.SaddleBrown
		End If
		If AutumnToolStripMenuItem.CheckState = CheckState.Unchecked Then
			MenuStrip1.BackColor = System.Drawing.SystemColors.Control
			MenuStrip1.ForeColor = System.Drawing.SystemColors.MenuText
			Me.BackColor = System.Drawing.SystemColors.Control
			rtbMainBody.BackColor = System.Drawing.SystemColors.Window
			rtbMainBody.ForeColor = System.Drawing.SystemColors.MenuText
		End If

		If DarkToolStripMenuItem.CheckState = CheckState.Checked Then   'Defensive code block
			AutumnToolStripMenuItem.CheckState = CheckState.Unchecked
			MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
			MenuStrip1.ForeColor = System.Drawing.Color.WhiteSmoke
			Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
			rtbMainBody.BackColor = System.Drawing.SystemColors.MenuText
			rtbMainBody.ForeColor = System.Drawing.SystemColors.HighlightText
		End If
		If OceanToolStripMenuItem.CheckState = CheckState.Checked Then
			AutumnToolStripMenuItem.CheckState = CheckState.Unchecked
			MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
			MenuStrip1.ForeColor = System.Drawing.Color.LemonChiffon
			Me.BackColor = System.Drawing.Color.MidnightBlue
			rtbMainBody.BackColor = System.Drawing.Color.PaleTurquoise
			rtbMainBody.ForeColor = System.Drawing.SystemColors.MenuText
		End If
	End Sub

	Private Sub OceanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OceanToolStripMenuItem.Click
		If OceanToolStripMenuItem.CheckState = CheckState.Checked Then 'Ocean theme
			MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
			MenuStrip1.ForeColor = System.Drawing.Color.LemonChiffon
			Me.BackColor = System.Drawing.Color.MidnightBlue
			rtbMainBody.BackColor = System.Drawing.Color.PaleTurquoise
			rtbMainBody.ForeColor = System.Drawing.SystemColors.MenuText
		End If
		If OceanToolStripMenuItem.CheckState = CheckState.Unchecked Then
			MenuStrip1.BackColor = System.Drawing.SystemColors.Control
			MenuStrip1.ForeColor = System.Drawing.SystemColors.MenuText
			Me.BackColor = System.Drawing.SystemColors.Control
			rtbMainBody.BackColor = System.Drawing.SystemColors.Window
			rtbMainBody.ForeColor = System.Drawing.SystemColors.MenuText
		End If

		If DarkToolStripMenuItem.CheckState = CheckState.Checked Then   'Defensive Code Block
			OceanToolStripMenuItem.CheckState = CheckState.Unchecked
			MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
			MenuStrip1.ForeColor = System.Drawing.Color.WhiteSmoke
			Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
			rtbMainBody.BackColor = System.Drawing.SystemColors.MenuText
			rtbMainBody.ForeColor = System.Drawing.SystemColors.HighlightText
		End If
		If AutumnToolStripMenuItem.CheckState = CheckState.Checked Then
			OceanToolStripMenuItem.CheckState = CheckState.Unchecked
			MenuStrip1.BackColor = System.Drawing.Color.Maroon
			MenuStrip1.ForeColor = System.Drawing.Color.Orange
			Me.BackColor = System.Drawing.Color.Maroon
			rtbMainBody.BackColor = System.Drawing.Color.Khaki
			rtbMainBody.ForeColor = System.Drawing.Color.SaddleBrown
		End If
	End Sub

	Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
		If WordWrapToolStripMenuItem.CheckState = CheckState.Checked Then 'Simple if statements for word wrap
			rtbMainBody.WordWrap = True
		End If
		If WordWrapToolStripMenuItem.CheckState = CheckState.Unchecked Then
			rtbMainBody.WordWrap = False
		End If
	End Sub

	Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
		FontDialog1.ShowDialog()                    'select font and color whenever you click Font menu item
		ColorDialog1.ShowDialog()
		rtbMainBody.Font = FontDialog1.Font         'Sets changes to rich text box
		rtbMainBody.ForeColor = ColorDialog1.Color
	End Sub

	Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
		MessageBox.Show("This is a general text editor" & vbNewLine &
						"Open, Save, and Edit your text files" & vbNewLine &
						"Author: James Polk" & vbNewLine &
						"Version: 1.0" & vbNewLine &
						"Course: Web Developer Boot Camp")
	End Sub

	Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
		Dim UserFile = OpenFileDialog1.FileName                     'Code Based of example done in class
		Dim UserFileRead = New StreamReader(UserFile)

		If OpenFileDialog1.ShowDialog = DialogResult.OK Then        'checkstate implemented as part of defensive
			OpenToolStripMenuItem.CheckState = CheckState.Checked   'code for Save function
			Me.Text = OpenFileDialog1.SafeFileName  'changes title for form
		End If

		While Not UserFileRead.EndOfStream
			rtbMainBody.Text += UserFileRead.ReadLine
		End While

		UserFileRead.Close()
	End Sub

	Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
		With SaveFileDialog1                    'Code based off example in book
			.Title = "Save File"
			.Filter = "Text Files | *.txt"
			.DefaultExt = ".txt"
			.OverwritePrompt = True
		End With

		If SaveFileDialog1.ShowDialog = DialogResult.OK Then
			rtbMainBody.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
			SaveAsToolStripMenuItem.CheckState = CheckState.Checked
			Me.Text = Path.GetFileName(SaveFileDialog1.FileName) 'SafeFileName not available for SavefileDialog
		End If
	End Sub

	Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
		If OpenToolStripMenuItem.Checked Then
			rtbMainBody.SaveFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
		ElseIf SaveAsToolStripMenuItem.Checked Then
			rtbMainBody.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
		ElseIf OpenToolStripMenuItem.CheckState = CheckState.Unchecked AndAlso SaveAsToolStripMenuItem.CheckState = CheckState.Unchecked Then
			With SaveFileDialog1
				.Title = "Save File"                    'Checkstate allows Save to act has save as if 
				.Filter = "Text Files | *.txt"          'Open or Save as have not been used
				.DefaultExt = ".txt"
				.OverwritePrompt = True
			End With

			If SaveFileDialog1.ShowDialog = DialogResult.OK Then
				rtbMainBody.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
				Me.Text = Path.GetFileName(SaveFileDialog1.FileName)
				SaveAsToolStripMenuItem.CheckState = CheckState.Checked
			End If
		End If
	End Sub

	Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
		Dim Message, Title, UserInput As String 'Variables needed for Input Box
		Dim FindKeyword As String
		Message = "Type Keyword to Search below:"
		Title = "Find"
		UserInput = ""

		FindKeyword = InputBox(Message, Title, UserInput, 400, 150) 'Stores user input

		If FindKeyword IsNot "" Then
			Dim WordLength = FindKeyword.Length
			Dim Position = rtbMainBody.Find(FindKeyword, 0, RichTextBoxFinds.WholeWord)
			While Position >= 0 'Finds user input in textbox and selects the last occurences of it while 
				rtbMainBody.Select(Position, WordLength)    'highlighting all instances
				rtbMainBody.SelectionBackColor = Color.LightPink
				Position = rtbMainBody.Find(FindKeyword, Position + WordLength, RichTextBoxFinds.WholeWord)
			End While
		End If
	End Sub


End Class
