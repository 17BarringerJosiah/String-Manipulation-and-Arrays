<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lstMissions = New System.Windows.Forms.ListBox()
        Me.lstTotals = New System.Windows.Forms.ListBox()
        Me.txtHoursInput = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnAddHours = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtChildrensMinistry = New System.Windows.Forms.TextBox()
        Me.txtUsher = New System.Windows.Forms.TextBox()
        Me.txtWorshipTeam = New System.Windows.Forms.TextBox()
        Me.txtCommunityOutreach = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstMissions
        '
        Me.lstMissions.FormattingEnabled = True
        Me.lstMissions.Location = New System.Drawing.Point(91, 96)
        Me.lstMissions.Name = "lstMissions"
        Me.lstMissions.Size = New System.Drawing.Size(220, 225)
        Me.lstMissions.TabIndex = 0
        '
        'lstTotals
        '
        Me.lstTotals.FormattingEnabled = True
        Me.lstTotals.Location = New System.Drawing.Point(339, 96)
        Me.lstTotals.Name = "lstTotals"
        Me.lstTotals.Size = New System.Drawing.Size(286, 225)
        Me.lstTotals.TabIndex = 1
        '
        'txtHoursInput
        '
        Me.txtHoursInput.Location = New System.Drawing.Point(153, 70)
        Me.txtHoursInput.Name = "txtHoursInput"
        Me.txtHoursInput.Size = New System.Drawing.Size(100, 20)
        Me.txtHoursInput.TabIndex = 2
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(163, 54)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(79, 13)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Hours Donated"
        '
        'btnAddHours
        '
        Me.btnAddHours.Location = New System.Drawing.Point(167, 327)
        Me.btnAddHours.Name = "btnAddHours"
        Me.btnAddHours.Size = New System.Drawing.Size(75, 23)
        Me.btnAddHours.TabIndex = 4
        Me.btnAddHours.Text = "&Add Hour s"
        Me.btnAddHours.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(447, 327)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtChildrensMinistry
        '
        Me.txtChildrensMinistry.Location = New System.Drawing.Point(664, 84)
        Me.txtChildrensMinistry.Name = "txtChildrensMinistry"
        Me.txtChildrensMinistry.Size = New System.Drawing.Size(88, 20)
        Me.txtChildrensMinistry.TabIndex = 8
        '
        'txtUsher
        '
        Me.txtUsher.Location = New System.Drawing.Point(664, 136)
        Me.txtUsher.Name = "txtUsher"
        Me.txtUsher.Size = New System.Drawing.Size(88, 20)
        Me.txtUsher.TabIndex = 9
        '
        'txtWorshipTeam
        '
        Me.txtWorshipTeam.Location = New System.Drawing.Point(664, 194)
        Me.txtWorshipTeam.Name = "txtWorshipTeam"
        Me.txtWorshipTeam.Size = New System.Drawing.Size(88, 20)
        Me.txtWorshipTeam.TabIndex = 10
        '
        'txtCommunityOutreach
        '
        Me.txtCommunityOutreach.Location = New System.Drawing.Point(664, 249)
        Me.txtCommunityOutreach.Name = "txtCommunityOutreach"
        Me.txtCommunityOutreach.Size = New System.Drawing.Size(88, 20)
        Me.txtCommunityOutreach.TabIndex = 11
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(662, 68)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(90, 13)
        Me.lbl3.TabIndex = 12
        Me.lbl3.Text = "Children's Ministry"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(686, 120)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(35, 13)
        Me.lbl4.TabIndex = 13
        Me.lbl4.Text = "Usher"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(662, 178)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(76, 13)
        Me.lbl5.TabIndex = 14
        Me.lbl5.Text = "Worship Team"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Location = New System.Drawing.Point(662, 233)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(105, 13)
        Me.lbl6.TabIndex = 15
        Me.lbl6.Text = "Community Outreach"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.txtCommunityOutreach)
        Me.Controls.Add(Me.txtWorshipTeam)
        Me.Controls.Add(Me.txtUsher)
        Me.Controls.Add(Me.txtChildrensMinistry)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddHours)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.txtHoursInput)
        Me.Controls.Add(Me.lstTotals)
        Me.Controls.Add(Me.lstMissions)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Mission Hours"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstMissions As ListBox
    Friend WithEvents lstTotals As ListBox
    Friend WithEvents txtHoursInput As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnAddHours As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtChildrensMinistry As TextBox
    Friend WithEvents txtUsher As TextBox
    Friend WithEvents txtWorshipTeam As TextBox
    Friend WithEvents txtCommunityOutreach As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl6 As Label
End Class
