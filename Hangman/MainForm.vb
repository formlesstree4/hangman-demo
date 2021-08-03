'Import Sections.
Imports System.IO 'File Manipulation Namespace
Imports System.Text 'Allows better String Manipulation
Public Class MainForm
    'Create a few variables.
    Private Mistakes As Integer = 0I 'All mistakes are here.
    Private PictureList As New List(Of PictureBox) 'The list of pictures!
    Private LabelList As New List(Of Label) 'Each label created goes here.
    Private WordList As New List(Of String) 'The wordlist is populated here.
    Private CurrentWord As String = String.Empty 'The current word.
    Private RandomGenerator As New Random(Date.Now.Millisecond) 'RANDOMNESS!
    'Capture KeyDown events.
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.A
                If ABtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(ABtn, Button), Nothing)
            Case Keys.B
                If BBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(BBtn, Button), Nothing)
            Case Keys.C
                If CBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(CBtn, Button), Nothing)
            Case Keys.D
                If DBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(DBtn, Button), Nothing)
            Case Keys.E
                If EBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(EBtn, Button), Nothing)
            Case Keys.F
                If FBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(FBtn, Button), Nothing)
            Case Keys.G
                If GBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(GBtn, Button), Nothing)
            Case Keys.H
                If HBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(HBtn, Button), Nothing)
            Case Keys.I
                If IBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(IBtn, Button), Nothing)
            Case Keys.J
                If JBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(JBtn, Button), Nothing)
            Case Keys.K
                If KBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(KBtn, Button), Nothing)
            Case Keys.L
                If LBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(LBtn, Button), Nothing)
            Case Keys.M
                If MBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(MBtn, Button), Nothing)
            Case Keys.N
                If NBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(NBtn, Button), Nothing)
            Case Keys.O
                If OBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(OBtn, Button), Nothing)
            Case Keys.P
                If PBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(PBtn, Button), Nothing)
            Case Keys.Q
                If QBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(QBtn, Button), Nothing)
            Case Keys.R
                If RBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(RBtn, Button), Nothing)
            Case Keys.S
                If SBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(SBtn, Button), Nothing)
            Case Keys.T
                If TBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(TBtn, Button), Nothing)
            Case Keys.U
                If UBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(UBtn, Button), Nothing)
            Case Keys.V
                If VBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(VBtn, Button), Nothing)
            Case Keys.W
                If WBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(WBtn, Button), Nothing)
            Case Keys.X
                If XBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(XBtn, Button), Nothing)
            Case Keys.Y
                If YBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(YBtn, Button), Nothing)
            Case Keys.Z
                If ZBtn.Enabled = False Then Exit Sub
                ButtonClick(DirectCast(ZBtn, Button), Nothing)
            Case Keys.Space
                e.Handled = True
                Exit Sub
            Case Keys.Enter
                e.Handled = True
                Exit Sub
        End Select
    End Sub
    'Initialization.
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Do Until File.Exists(My.Settings.CurrWordlist) = True
            If My.Settings.InternalWordList = True Then
                Exit Do
            End If
            Settings.ShowDialog()
        Loop
        PictureList.Add(HeadBox)
        PictureList.Add(BodyBox)
        PictureList.Add(Arm1Box)
        PictureList.Add(Arm2Box)
        PictureList.Add(Leg1Box)
        PictureList.Add(Leg2Box)
        Call LoadWordList()
    End Sub
    ''' <summary>
    ''' Load the WordList
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub LoadWordList()
        WordList.Clear() 'Clear the current Wordlist.
        Try
            If My.Settings.InternalWordList = False Then 'If we aren't using the internal wordlist
                For Each item As String In File.ReadAllLines(My.Settings.CurrWordlist) 'load the wordlist
                    WordList.Add(item)
                Next
            Else
                File.WriteAllText("wordlist.txt", My.Resources.Wordlist) 'Create the Wordlist from the internal one.
                For Each item As String In File.ReadAllLines("wordlist.txt") 'now read it.
                    WordList.Add(item)
                Next
                File.Delete("wordlist.txt") 'delete it
            End If
            Call GetWord() 'get a word now!
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    ''' <summary>
    ''' Select a Random Word from the WordList
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GetWord()
        'Lock the groupbox2
        GroupBox2.Enabled = False
        For Each btn As Button In GroupBox2.Controls
            btn.Enabled = True
        Next
        'Reset mistakes
        Mistakes = 0I
        For Each p As PictureBox In PictureList
            p.Visible = False
        Next
        'Generate a Random Integer
        Dim CW As Integer = 0
        CW = RandomGenerator.Next(0, WordList.Count - 1)
        'Make sure we don't get a duplicate word.
        'This prevents getting two words in a row.
        If CurrentWord = WordList(CW) Then
            Do Until CurrentWord <> WordList(CW)
                CW = RandomGenerator.Next(0, WordList.Count - 1)
            Loop
        End If
        CurrentWord = WordList(CW)
        CurrWord.Text = CurrentWord
        MistakesLbl.Text = String.Format("Remaining Mistakes: {0}", 6I - Mistakes)
        Call GenerateLabels()
        Call ApplySymbols()
    End Sub
    ''' <summary>
    ''' Create the Dynamic Labels.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GenerateLabels()
        If LabelList.Count > 0 Then 'Clear the list and remove each from the control
            For Each item As Label In LabelList
                GroupBox1.Controls.Remove(item)
            Next
            LabelList.Clear()
        End If
        'Create the initial point values.
        Dim xVal As Integer = 6I
        Dim yVal As Integer = 21I
        Dim d As Integer = 0I 'label count.
        For Each c As Char In CurrentWord 'Now setup a For Loop.
            Dim x As New Label 'Create a new Label.
            If xVal >= 351I Then 'Reset the xVal if >= 351I
                xVal = 6I
                yVal += 27I 'Set the yVal to the next row.
            End If
            x.Location = New Point(xVal, yVal) 'Create new Point.
            x.Name = d.ToString & "_lbl" 'Set the name
            x.Text = "__" 'Set the text
            x.Visible = True 'Make it visible.
            x.AutoSize = True 'Autosize it
            x.BackColor = Color.Transparent 'Set the backColor to transparent.
            LabelList.Add(x) 'Add it to the list
            GroupBox1.Controls.Add(x) 'Add to controls.
            x.BringToFront() 'Bring it to front.
            GroupBox1.Refresh() 'refresh it.
            xVal += 15 'move it over 15 pixels
            d += 1 'add to the count.
        Next
        GroupBox2.Enabled = True
    End Sub
    ''' <summary>
    ''' Apply any special symbols to words.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ApplySymbols()
        Dim x As Integer = 0I '
        For Each ch As Char In CurrentWord
            Select Case ch
                Case " "c
                    Dim Lblname As String = LabelList(x).Name.ToString
                    GroupBox1.Controls(Lblname).Text = " "
                Case "-"c
                    Dim Lblname As String = LabelList(x).Name.ToString
                    GroupBox1.Controls(Lblname).Text = "-"
                Case "&"c
                    Dim Lblname As String = LabelList(x).Name.ToString
                    GroupBox1.Controls(Lblname).Text = "&"
                Case "'"c
                    Dim Lblname As String = LabelList(x).Name.ToString
                    GroupBox1.Controls(Lblname).Text = "'"
            End Select
            x += 1
        Next
    End Sub
    Private Sub NewWordBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWordBtn.Click
        'Make a new word.
        Select Case MessageBox.Show("Do you want to make a new word?", "New word?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Case Windows.Forms.DialogResult.Yes
                Call GetWord()
            Case Windows.Forms.DialogResult.No
                '
            Case Windows.Forms.DialogResult.Cancel
                '
        End Select
    End Sub
    ''' <summary>
    ''' All Button Click Events.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABtn.Click, BBtn.Click, CBtn.Click, DBtn.Click, EBtn.Click, FBtn.Click, GBtn.Click, HBtn.Click, IBtn.Click, JBtn.Click, KBtn.Click, LBtn.Click, MBtn.Click, NBtn.Click, OBtn.Click, PBtn.Click, QBtn.Click, RBtn.Click, SBtn.Click, TBtn.Click, UBtn.Click, VBtn.Click, WBtn.Click, XBtn.Click, YBtn.Click, ZBtn.Click
        Select Case DirectCast(sender, Button).Name
            Case "ABtn"
                ABtn.Enabled = False
                Call EvaluateString("a"c)

            Case "BBtn"
                BBtn.Enabled = False
                Call EvaluateString("b"c)

            Case "CBtn"
                CBtn.Enabled = False
                Call EvaluateString("c"c)

            Case "DBtn"
                DBtn.Enabled = False
                Call EvaluateString("d"c)

            Case "EBtn"
                EBtn.Enabled = False
                Call EvaluateString("e"c)

            Case "FBtn"
                FBtn.Enabled = False
                Call EvaluateString("f"c)

            Case "GBtn"
                GBtn.Enabled = False
                Call EvaluateString("g"c)

            Case "HBtn"
                HBtn.Enabled = False
                Call EvaluateString("h"c)

            Case "IBtn"
                IBtn.Enabled = False
                Call EvaluateString("i"c)

            Case "JBtn"
                JBtn.Enabled = False
                Call EvaluateString("j"c)

            Case "KBtn"
                KBtn.Enabled = False
                Call EvaluateString("k"c)

            Case "LBtn"
                LBtn.Enabled = False
                Call EvaluateString("l"c)

            Case "MBtn"
                MBtn.Enabled = False
                Call EvaluateString("m"c)

            Case "NBtn"
                NBtn.Enabled = False
                Call EvaluateString("n"c)

            Case "OBtn"
                OBtn.Enabled = False
                Call EvaluateString("o"c)

            Case "PBtn"
                PBtn.Enabled = False
                Call EvaluateString("p"c)

            Case "QBtn"
                QBtn.Enabled = False
                Call EvaluateString("q"c)

            Case "RBtn"
                RBtn.Enabled = False
                Call EvaluateString("r"c)

            Case "SBtn"
                SBtn.Enabled = False
                Call EvaluateString("s"c)

            Case "TBtn"
                TBtn.Enabled = False
                Call EvaluateString("t"c)

            Case "UBtn"
                UBtn.Enabled = False
                Call EvaluateString("u"c)

            Case "VBtn"
                VBtn.Enabled = False
                Call EvaluateString("v"c)

            Case "WBtn"
                WBtn.Enabled = False
                Call EvaluateString("w"c)

            Case "XBtn"
                XBtn.Enabled = False
                Call EvaluateString("x"c)

            Case "YBtn"
                YBtn.Enabled = False
                Call EvaluateString("y"c)

            Case "ZBtn"
                ZBtn.Enabled = False
                Call EvaluateString("z"c)
        End Select
    End Sub
    ''' <summary>
    ''' All Mistakes are calculated here.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MistakeCalculations()
        PictureList(Mistakes - 1).Visible = True
        MistakesLbl.Text = String.Format("Remaining Mistakes: {0}", 6I - Mistakes)
        If Mistakes = 6I Then
            MessageBox.Show("You have lost this round! The word was: " & CurrentWord & "!", "Oh no! :(", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Mistakes = 0I
            For Each p As PictureBox In PictureList
                p.Visible = False
            Next
            Call GetWord()
            Exit Sub
        End If
    End Sub
    ''' <summary>
    ''' Evaluate the string to see if one is missing or there.
    ''' </summary>
    ''' <param name="ch">The Character</param>
    ''' <remarks></remarks>
    Private Sub EvaluateString(ByVal ch As Char)
        Dim x As Integer = 0
        Dim Success As Boolean = False
        For Each c As Char In CurrentWord.ToLower
            If c = ch Then
                'We have the zero based position.
                'So get the name from the label list.
                Dim Lblname As String = LabelList(x).Name.ToString
                'Now assign the text to the control
                GroupBox1.Controls(Lblname).Text = If(x = 0, c.ToString.ToUpper, c.ToString.ToLower)
                Success = True
            End If
            x += 1
        Next
        If Success = False Then
            Mistakes += 1
            Call MistakeCalculations()
        End If
        If WordSolved() = True Then
            MessageBox.Show("finished!")
            Call GetWord()
        End If
    End Sub
    ''' <summary>
    ''' Is the word solved?
    ''' </summary>
    ''' <returns>Boolean for if word is solved or not.</returns>
    ''' <remarks></remarks>
    Private Function WordSolved() As Boolean
        Dim count As Integer = 0
        For Each lbl As Label In GroupBox1.Controls
            If lbl.Text = "__" Then
                count += 1
            End If
        Next
        If count = 0 Then Return True Else Return False
    End Function
    ''' <summary>
    ''' Handles arbitrary KeyDown events.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub MainKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ABtn.KeyDown, BBtn.KeyDown, CBtn.KeyDown, DBtn.KeyDown, EBtn.KeyDown, FBtn.KeyDown, GBtn.KeyDown, HBtn.KeyDown, IBtn.KeyDown, JBtn.KeyDown, KBtn.KeyDown, LBtn.KeyDown, MBtn.KeyDown, NBtn.KeyDown, OBtn.KeyDown, PBtn.KeyDown, QBtn.KeyDown, RBtn.KeyDown, SBtn.KeyDown, TBtn.KeyDown, UBtn.KeyDown, VBtn.KeyDown, WBtn.KeyDown, XBtn.KeyDown, YBtn.KeyDown, ZBtn.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                e.Handled = True
                Exit Sub
            Case Keys.Space
                Exit Sub
        End Select
    End Sub
    Private Sub Settings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsBtn.Click
        Settings.ShowDialog()
        Call LoadWordList()
    End Sub
End Class