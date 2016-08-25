Public Class FormEdit
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxName.Clear()
        TextBoxID.Clear()
        TextBoxType.Clear()
        TextBoxDescription.Clear()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        TextBoxName.Clear()
        TextBoxID.Clear()
        TextBoxType.Clear()
        TextBoxDescription.Clear()
        My.Settings.Editing = False
        Me.Hide()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        If TextBoxName.Text = "" And TextBoxID.Text = "" Then
            Dim result As Integer = MessageBox.Show("The Variable Name and ID boxes are both empty. Save item anyway?", "Warning", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then

            ElseIf result = DialogResult.No Then
                TextBoxName.Clear()
                TextBoxID.Clear()
                TextBoxType.Clear()
                TextBoxDescription.Clear()
                My.Settings.Editing = False
                Me.Hide()
            ElseIf result = DialogResult.Yes Then
                FormMain.ListViewMain.SelectedItems.Item(My.Settings.ItemNumber).Text = TextBoxName.Text
                FormMain.ListViewMain.SelectedItems.Item(My.Settings.ItemNumber).SubItems.Item(1).Text = TextBoxID.Text
                FormMain.ListViewMain.SelectedItems.Item(My.Settings.ItemNumber).SubItems.Item(2).Text = TextBoxType.Text
                FormMain.ListViewMain.SelectedItems.Item(My.Settings.ItemNumber).SubItems.Item(3).Text = TextBoxDescription.Text
                TextBoxName.Clear()
                TextBoxID.Clear()
                TextBoxType.Clear()
                TextBoxDescription.Clear()
                My.Settings.Editing = False
                Me.Hide()
            End If
        Else
            FormMain.ListViewMain.SelectedItems.Item(My.Settings.ItemNumber).Text = TextBoxName.Text
            FormMain.ListViewMain.SelectedItems.Item(My.Settings.ItemNumber).SubItems.Item(1).Text = TextBoxID.Text
            FormMain.ListViewMain.SelectedItems.Item(My.Settings.ItemNumber).SubItems.Item(2).Text = TextBoxType.Text
            FormMain.ListViewMain.SelectedItems.Item(My.Settings.ItemNumber).SubItems.Item(3).Text = TextBoxDescription.Text
            TextBoxName.Clear()
            TextBoxID.Clear()
            TextBoxType.Clear()
            TextBoxDescription.Clear()
            My.Settings.Editing = False
            Me.Hide()
        End If
    End Sub

    Private Sub ButtonCancelAll_Click(sender As Object, e As EventArgs) Handles ButtonCancelAll.Click
        TextBoxName.Clear()
        TextBoxID.Clear()
        TextBoxType.Clear()
        TextBoxDescription.Clear()
        My.Settings.TotalSelectedItems = 0
        My.Settings.Editing = False
        Me.Hide()
    End Sub
End Class