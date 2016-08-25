<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEdit))
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.TextBoxType = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonCancelAll = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(12, 230)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 23
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(120, 91)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(327, 133)
        Me.TextBoxDescription.TabIndex = 22
        '
        'TextBoxType
        '
        Me.TextBoxType.Location = New System.Drawing.Point(120, 64)
        Me.TextBoxType.Name = "TextBoxType"
        Me.TextBoxType.Size = New System.Drawing.Size(327, 20)
        Me.TextBoxType.TabIndex = 21
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(120, 37)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(327, 20)
        Me.TextBoxID.TabIndex = 20
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(120, 11)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(327, 20)
        Me.TextBoxName.TabIndex = 19
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Location = New System.Drawing.Point(12, 94)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(63, 13)
        Me.LabelDescription.TabIndex = 18
        Me.LabelDescription.Text = "Description:"
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.Location = New System.Drawing.Point(12, 67)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(34, 13)
        Me.LabelType.TabIndex = 17
        Me.LabelType.Text = "Type:"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(12, 40)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(21, 13)
        Me.LabelID.TabIndex = 16
        Me.LabelID.Text = "ID:"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(12, 14)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(79, 13)
        Me.LabelName.TabIndex = 15
        Me.LabelName.Text = "Variable Name:"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(210, 230)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 14
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(291, 230)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 13
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonCancelAll
        '
        Me.ButtonCancelAll.Location = New System.Drawing.Point(372, 230)
        Me.ButtonCancelAll.Name = "ButtonCancelAll"
        Me.ButtonCancelAll.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancelAll.TabIndex = 24
        Me.ButtonCancelAll.Text = "Cancel All"
        Me.ButtonCancelAll.UseVisualStyleBackColor = True
        '
        'FormEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 264)
        Me.Controls.Add(Me.ButtonCancelAll)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.TextBoxDescription)
        Me.Controls.Add(Me.TextBoxType)
        Me.Controls.Add(Me.TextBoxID)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.LabelType)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Variable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxType As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents LabelDescription As System.Windows.Forms.Label
    Friend WithEvents LabelType As System.Windows.Forms.Label
    Friend WithEvents LabelID As System.Windows.Forms.Label
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonCancelAll As System.Windows.Forms.Button
End Class
