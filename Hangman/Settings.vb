Public Class Settings
    Private Sub Settings_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If WordlistBox.Text = String.Empty Then
            My.Settings.InternalWordList = True
            My.Settings.Save()
        End If
    End Sub
    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WordlistBox.Text = My.Settings.CurrWordlist
        InternalList.Checked = My.Settings.InternalWordList
    End Sub
    Private Sub BrowseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseBtn.Click
        Dim x As New OpenFileDialog With {.DefaultExt = "txt", .Filter = "Text File|*.txt", .Multiselect = False, .Title = "Select a WordList."}
        If x.ShowDialog = Windows.Forms.DialogResult.OK Then
            WordlistBox.Text = x.FileName
        End If
    End Sub
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        My.Settings.CurrWordlist = WordlistBox.Text
        My.Settings.InternalWordList = InternalList.Checked
        My.Settings.Save()
        Me.Close()
    End Sub
    Private Sub InternalList_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InternalList.CheckedChanged
        BrowseBtn.Enabled = Not InternalList.Checked
        WordlistBox.Clear()
    End Sub
End Class