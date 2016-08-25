Public Class FormAdd

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
        Me.Hide()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim item As New ListViewItem
        item.Text = TextBoxName.Text
        item.SubItems.Add(TextBoxID.Text)
        item.SubItems.Add(TextBoxType.Text)
        item.SubItems.Add(TextBoxDescription.Text)
        FormMain.ListViewMain.Items.Add(item)
        TextBoxName.Clear()
        TextBoxID.Clear()
        TextBoxType.Clear()
        TextBoxDescription.Clear()
        Me.Hide()
    End Sub

    Private Sub ButtonAddAnother_Click(sender As Object, e As EventArgs) Handles ButtonAddAnother.Click
        Dim item As New ListViewItem
        item.Text = TextBoxName.Text
        item.SubItems.Add(TextBoxID.Text)
        item.SubItems.Add(TextBoxType.Text)
        item.SubItems.Add(TextBoxDescription.Text)
        FormMain.ListViewMain.Items.Add(item)
        TextBoxName.Clear()
        TextBoxID.Clear()
        TextBoxType.Clear()
        TextBoxDescription.Clear()
    End Sub
End Class