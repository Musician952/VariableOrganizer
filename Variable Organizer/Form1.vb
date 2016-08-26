Imports System.IO
Imports System.Net

Public Class FormMain

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Do you wish to save any changes you may have made?", "Save Changes", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then
            Application.Exit()
        ElseIf result = DialogResult.Yes Then
            Dim mySaveFileDialog As New SaveFileDialog()
            Dim rtb As New RichTextBox

            If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer") Then
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer")
            End If

            mySaveFileDialog.CheckFileExists = False
            mySaveFileDialog.Filter = "Text files only (*.txt)|*.txt"
            mySaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer"
            mySaveFileDialog.DefaultExt = "txt"



            For Each saveitem As ListViewItem In ListViewMain.Items
                rtb.AppendText("--" & vbNewLine & saveitem.Text & vbNewLine & saveitem.SubItems(1).Text & vbNewLine & saveitem.SubItems(2).Text & vbNewLine & saveitem.SubItems(3).Text & vbNewLine)
            Next

            If mySaveFileDialog.ShowDialog = DialogResult.OK Then
                rtb.SaveFile(mySaveFileDialog.FileName, RichTextBoxStreamType.PlainText)
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Do you wish to save any changes you may have made?", "Save Changes", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then
            ListViewMain.Items.Clear()
        ElseIf result = DialogResult.Yes Then
            Dim mySaveFileDialog As New SaveFileDialog()
            Dim rtb As New RichTextBox

            If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer") Then
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer")
            End If

            mySaveFileDialog.CheckFileExists = False
            mySaveFileDialog.Filter = "Text files only (*.txt)|*.txt"
            mySaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer"
            mySaveFileDialog.DefaultExt = "txt"



            For Each saveitem As ListViewItem In ListViewMain.Items
                rtb.AppendText("--" & vbNewLine & saveitem.Text & vbNewLine & saveitem.SubItems(1).Text & vbNewLine & saveitem.SubItems(2).Text & vbNewLine & saveitem.SubItems(3).Text & vbNewLine)
            Next

            If mySaveFileDialog.ShowDialog = DialogResult.OK Then
                rtb.SaveFile(mySaveFileDialog.FileName, RichTextBoxStreamType.PlainText)
                ListViewMain.Items.Clear()
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ListViewMain.Refresh()
    End Sub

    Private Sub AddVariableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddVariableToolStripMenuItem.Click
        FormAdd.Show()
    End Sub

    Private Sub LoadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadToolStripMenuItem.Click
        Dim myOpenFileDialog As New OpenFileDialog()
        Dim rtb As New RichTextBox
        Dim result As Integer = MessageBox.Show("Do you wish to save any changes you may have made?", "Save Changes", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then
            If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer") Then
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer")
            End If

            myOpenFileDialog.CheckFileExists = True
            myOpenFileDialog.Filter = "Text files only (*.txt)|*.txt"
            myOpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer"
            myOpenFileDialog.Multiselect = False

            If myOpenFileDialog.ShowDialog = DialogResult.OK Then
                rtb.Text = IO.File.ReadAllText(myOpenFileDialog.FileName)
            End If

            ListViewMain.Items.Clear()

            Dim i As Integer
            For Each line As String In rtb.Lines
                If line = "--" Then
                    Dim item As New ListViewItem
                    item.Text = rtb.Lines(i + 1)
                    item.SubItems.Add(rtb.Lines(i + 2))
                    item.SubItems.Add(rtb.Lines(i + 3))
                    item.SubItems.Add(rtb.Lines(i + 4))
                    i = i + 5
                    ListViewMain.Items.Add(item)
                End If
            Next
        ElseIf result = DialogResult.Yes Then
            Dim mySaveFileDialog As New SaveFileDialog()

            If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer") Then
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer")
            End If

            mySaveFileDialog.CheckFileExists = False
            mySaveFileDialog.Filter = "Text files only (*.txt)|*.txt"
            mySaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer"
            mySaveFileDialog.DefaultExt = "txt"



            For Each saveitem As ListViewItem In ListViewMain.Items
                rtb.AppendText("--" & vbNewLine & saveitem.Text & vbNewLine & saveitem.SubItems(1).Text & vbNewLine & saveitem.SubItems(2).Text & vbNewLine & saveitem.SubItems(3).Text & vbNewLine)
            Next

            If mySaveFileDialog.ShowDialog = DialogResult.OK Then
                rtb.SaveFile(mySaveFileDialog.FileName, RichTextBoxStreamType.PlainText)

                If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer") Then
                    My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer")
                End If

                myOpenFileDialog.CheckFileExists = True
                myOpenFileDialog.Filter = "Text files only (*.txt)|*.txt"
                myOpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer"
                myOpenFileDialog.Multiselect = False

                If myOpenFileDialog.ShowDialog = DialogResult.OK Then
                    rtb.Text = IO.File.ReadAllText(myOpenFileDialog.FileName)
                End If

                ListViewMain.Items.Clear()

                Dim i As Integer
                For Each line As String In rtb.Lines
                    If line = "--" Then
                        Dim item As New ListViewItem
                        item.Text = rtb.Lines(i + 1)
                        item.SubItems.Add(rtb.Lines(i + 2))
                        item.SubItems.Add(rtb.Lines(i + 3))
                        item.SubItems.Add(rtb.Lines(i + 4))
                        i = i + 5
                        ListViewMain.Items.Add(item)
                    End If
                Next
            End If
        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim mySaveFileDialog As New SaveFileDialog()
        Dim rtb As New RichTextBox

        If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer") Then
            My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer")
        End If

        mySaveFileDialog.CheckFileExists = False
        mySaveFileDialog.Filter = "Text files only (*.txt)|*.txt"
        mySaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer"
        mySaveFileDialog.DefaultExt = "txt"



        For Each saveitem As ListViewItem In ListViewMain.Items
            rtb.AppendText("--" & vbNewLine & saveitem.Text & vbNewLine & saveitem.SubItems(1).Text & vbNewLine & saveitem.SubItems(2).Text & vbNewLine & saveitem.SubItems(3).Text & vbNewLine)
        Next

        If mySaveFileDialog.ShowDialog = DialogResult.OK Then
            rtb.SaveFile(mySaveFileDialog.FileName, RichTextBoxStreamType.PlainText)
        End If

    End Sub
    ' The column currently used for sorting.
    Private m_SortingColumn As ColumnHeader
    Private Sub ListViewMain_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListViewMain.ColumnClick

        ' Get the new sorting column.
        Dim new_sorting_column As ColumnHeader = _
            ListViewMain.Columns(e.Column)

        ' Figure out the new sorting order.
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            ' New column. Sort ascending.
            sort_order = SortOrder.Ascending
        Else
            ' See if this is the same column.
            If new_sorting_column.Equals(m_SortingColumn) Then
                ' Same column. Switch the sort order.
                If m_SortingColumn.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending.
                sort_order = SortOrder.Ascending
            End If

            ' Remove the old sort indicator.
            m_SortingColumn.Text = _
                m_SortingColumn.Text.Substring(2)
        End If

        ' Display the new sort order.
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = "> " & m_SortingColumn.Text
        Else
            m_SortingColumn.Text = "< " & m_SortingColumn.Text
        End If

        ' Create a comparer.
        ListViewMain.ListViewItemSorter = New  _
            ListViewComparer(e.Column, sort_order)

        ' Sort.
        ListViewMain.Sort()
    End Sub

    Private Sub EditVariableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditVariableToolStripMenuItem.Click
        Dim i As Integer = -1
        If Not ListViewMain.SelectedItems.Count > 0 Then
            MessageBox.Show("No item selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            My.Settings.TotalSelectedItems = ListViewMain.SelectedItems.Count
            For Each selecteditem In ListViewMain.SelectedItems
                If Not My.Settings.TotalSelectedItems = 0 Then
                    i = i + 1
                    My.Settings.ItemNumber = i
                    FormEdit.TextBoxName.Text = selecteditem.Text
                    FormEdit.TextBoxID.Text = selecteditem.SubItems().Item(1).Text
                    FormEdit.TextBoxType.Text = selecteditem.SubItems().Item(2).Text
                    FormEdit.TextBoxDescription.Text = selecteditem.SubItems().Item(3).Text
                    FormEdit.Show()
                    My.Settings.Editing = True
                    While My.Settings.Editing = True
                        Application.DoEvents()
                    End While
                End If
            Next
        End If
    End Sub

    Private Sub DeleteVariableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteVariableToolStripMenuItem.Click
        If Not ListViewMain.SelectedItems.Count > 0 Then
            MessageBox.Show("No item selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            For Each selecteditem In ListViewMain.SelectedItems
                ListViewMain.SelectedItems.Item(0).Remove()
            Next
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Dim address As String = "https://musician952.github.io/VariableOrganizer/Updates.txt"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        Dim rtb As New RichTextBox
        rtb.Text = reader.ReadToEnd
        If String.Format(My.Application.Info.Version.ToString) = rtb.Text Then
            MessageBox.Show("Your app is up to date!", "Up to Date")
        Else
            Dim result As Integer = MessageBox.Show("You are currently running Version " + My.Application.Info.Version.ToString + ". Would you like to download Version " + rtb.Text + "?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                MessageBox.Show("The application will automatically run when the download finishes.", "Downloading...")

                My.Computer.Network.DownloadFile("https://musician952.github.io/VariableOrganizer/Variable%20Organizer.exe", My.Computer.FileSystem.SpecialDirectories.MyDocuments + "Variable Organizer.exe")

                If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer") Then
                    My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer")
                End If

                Dim sb As New System.Text.StringBuilder

                sb.AppendLine("move ""Variable Organizer.exe"" """ + My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer""")
                sb.AppendLine("Start """ + My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Variable Organizer.exe""")
                sb.AppendLine("(goto) 2>nul & del ""%~f0""")

                IO.File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "MoveApp.bat", sb.ToString())

                Process.Start(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "MoveApp.bat")
                Application.Exit()
            End If
        End If
        reader.Close()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim appPath As String = My.Application.Info.DirectoryPath
        If Not appPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer" Then
            Dim result As Integer = MessageBox.Show("We noticed that the application is not in the default directory of " + My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer" + vbNewLine + "If you would like, we can automatically move the program for you, or you can manually move it yourself.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.No Then
                Application.Exit()
            ElseIf result = DialogResult.Yes Then
                If Not My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer") Then
                    My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer")
                End If

                Dim sb As New System.Text.StringBuilder

                sb.AppendLine("move ""Variable Organizer.exe"" """ + My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\VariableOrganizer""")
                sb.AppendLine("Start """ + My.Computer.FileSystem.SpecialDirectories.MyDocuments + "\Variable Organizer.exe""")
                sb.AppendLine("(goto) 2>nul & del ""%~f0""")

                IO.File.WriteAllText("MoveApp.bat", sb.ToString())

                Process.Start("MoveApp.bat")
                Application.Exit()
            End If
        End If
    End Sub
End Class
