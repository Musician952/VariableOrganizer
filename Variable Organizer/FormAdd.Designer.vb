<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdd))
        Me.ButtonAddAnother = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.TextBoxType = New System.Windows.Forms.TextBox()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonAddAnother
        '
        Me.ButtonAddAnother.Location = New System.Drawing.Point(307, 229)
        Me.ButtonAddAnother.Name = "ButtonAddAnother"
        Me.ButtonAddAnother.Size = New System.Drawing.Size(140, 23)
        Me.ButtonAddAnother.TabIndex = 0
        Me.ButtonAddAnother.Text = "Save and Add Another"
        Me.ButtonAddAnother.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(226, 229)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 1
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(145, 229)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSave.TabIndex = 2
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(12, 13)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(79, 13)
        Me.LabelName.TabIndex = 3
        Me.LabelName.Text = "Variable Name:"
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Location = New System.Drawing.Point(12, 39)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(21, 13)
        Me.LabelID.TabIndex = 4
        Me.LabelID.Text = "ID:"
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.Location = New System.Drawing.Point(12, 66)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(34, 13)
        Me.LabelType.TabIndex = 5
        Me.LabelType.Text = "Type:"
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Location = New System.Drawing.Point(12, 93)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(63, 13)
        Me.LabelDescription.TabIndex = 6
        Me.LabelDescription.Text = "Description:"
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(120, 10)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(327, 20)
        Me.TextBoxName.TabIndex = 7
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(120, 36)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(327, 20)
        Me.TextBoxID.TabIndex = 8
        '
        'TextBoxType
        '
        Me.TextBoxType.Location = New System.Drawing.Point(120, 63)
        Me.TextBoxType.Name = "TextBoxType"
        Me.TextBoxType.Size = New System.Drawing.Size(327, 20)
        Me.TextBoxType.TabIndex = 9
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(120, 90)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(327, 133)
        Me.TextBoxDescription.TabIndex = 10
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(12, 229)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClear.TabIndex = 11
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'FormAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 264)
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
        Me.Controls.Add(Me.ButtonAddAnother)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Variable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAddAnother As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents LabelName As System.Windows.Forms.Label
    Friend WithEvents LabelID As System.Windows.Forms.Label
    Friend WithEvents LabelType As System.Windows.Forms.Label
    Friend WithEvents LabelDescription As System.Windows.Forms.Label
    Friend WithEvents TextBoxName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxType As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
End Class
