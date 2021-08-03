<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.HeadBox = New System.Windows.Forms.PictureBox
        Me.Arm2Box = New System.Windows.Forms.PictureBox
        Me.Leg1Box = New System.Windows.Forms.PictureBox
        Me.BodyBox = New System.Windows.Forms.PictureBox
        Me.Arm1Box = New System.Windows.Forms.PictureBox
        Me.Leg2Box = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RBtn = New System.Windows.Forms.Button
        Me.FBtn = New System.Windows.Forms.Button
        Me.VBtn = New System.Windows.Forms.Button
        Me.JBtn = New System.Windows.Forms.Button
        Me.PBtn = New System.Windows.Forms.Button
        Me.DBtn = New System.Windows.Forms.Button
        Me.TBtn = New System.Windows.Forms.Button
        Me.HBtn = New System.Windows.Forms.Button
        Me.NBtn = New System.Windows.Forms.Button
        Me.BBtn = New System.Windows.Forms.Button
        Me.ZBtn = New System.Windows.Forms.Button
        Me.XBtn = New System.Windows.Forms.Button
        Me.YBtn = New System.Windows.Forms.Button
        Me.WBtn = New System.Windows.Forms.Button
        Me.LBtn = New System.Windows.Forms.Button
        Me.KBtn = New System.Windows.Forms.Button
        Me.QBtn = New System.Windows.Forms.Button
        Me.EBtn = New System.Windows.Forms.Button
        Me.UBtn = New System.Windows.Forms.Button
        Me.IBtn = New System.Windows.Forms.Button
        Me.OBtn = New System.Windows.Forms.Button
        Me.CBtn = New System.Windows.Forms.Button
        Me.SBtn = New System.Windows.Forms.Button
        Me.GBtn = New System.Windows.Forms.Button
        Me.MBtn = New System.Windows.Forms.Button
        Me.ABtn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CurrWord = New System.Windows.Forms.Label
        Me.NewWordBtn = New System.Windows.Forms.Button
        Me.MistakesLbl = New System.Windows.Forms.Label
        Me.SettingsBtn = New System.Windows.Forms.Button
        CType(Me.HeadBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Arm2Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Leg1Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BodyBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Arm1Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Leg2Box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeadBox
        '
        Me.HeadBox.BackgroundImage = Global.Hangman.My.Resources.Resources.head
        Me.HeadBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HeadBox.Location = New System.Drawing.Point(12, 12)
        Me.HeadBox.Name = "HeadBox"
        Me.HeadBox.Size = New System.Drawing.Size(120, 105)
        Me.HeadBox.TabIndex = 0
        Me.HeadBox.TabStop = False
        Me.HeadBox.Visible = False
        '
        'Arm2Box
        '
        Me.Arm2Box.BackColor = System.Drawing.Color.Transparent
        Me.Arm2Box.BackgroundImage = Global.Hangman.My.Resources.Resources.arm_2
        Me.Arm2Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Arm2Box.Location = New System.Drawing.Point(72, 123)
        Me.Arm2Box.Name = "Arm2Box"
        Me.Arm2Box.Size = New System.Drawing.Size(38, 41)
        Me.Arm2Box.TabIndex = 0
        Me.Arm2Box.TabStop = False
        Me.Arm2Box.Visible = False
        '
        'Leg1Box
        '
        Me.Leg1Box.BackgroundImage = Global.Hangman.My.Resources.Resources.leg_1
        Me.Leg1Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Leg1Box.Location = New System.Drawing.Point(49, 198)
        Me.Leg1Box.Name = "Leg1Box"
        Me.Leg1Box.Size = New System.Drawing.Size(22, 50)
        Me.Leg1Box.TabIndex = 0
        Me.Leg1Box.TabStop = False
        Me.Leg1Box.Visible = False
        '
        'BodyBox
        '
        Me.BodyBox.BackgroundImage = Global.Hangman.My.Resources.Resources.body
        Me.BodyBox.Location = New System.Drawing.Point(65, 111)
        Me.BodyBox.Name = "BodyBox"
        Me.BodyBox.Size = New System.Drawing.Size(13, 89)
        Me.BodyBox.TabIndex = 0
        Me.BodyBox.TabStop = False
        Me.BodyBox.Visible = False
        '
        'Arm1Box
        '
        Me.Arm1Box.BackColor = System.Drawing.Color.Transparent
        Me.Arm1Box.BackgroundImage = Global.Hangman.My.Resources.Resources.arm_1
        Me.Arm1Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Arm1Box.Location = New System.Drawing.Point(33, 124)
        Me.Arm1Box.Name = "Arm1Box"
        Me.Arm1Box.Size = New System.Drawing.Size(38, 41)
        Me.Arm1Box.TabIndex = 0
        Me.Arm1Box.TabStop = False
        Me.Arm1Box.Visible = False
        '
        'Leg2Box
        '
        Me.Leg2Box.BackgroundImage = Global.Hangman.My.Resources.Resources.leg_2
        Me.Leg2Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Leg2Box.Location = New System.Drawing.Point(72, 198)
        Me.Leg2Box.Name = "Leg2Box"
        Me.Leg2Box.Size = New System.Drawing.Size(22, 50)
        Me.Leg2Box.TabIndex = 0
        Me.Leg2Box.TabStop = False
        Me.Leg2Box.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(138, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 73)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Word"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBtn)
        Me.GroupBox2.Controls.Add(Me.FBtn)
        Me.GroupBox2.Controls.Add(Me.VBtn)
        Me.GroupBox2.Controls.Add(Me.JBtn)
        Me.GroupBox2.Controls.Add(Me.PBtn)
        Me.GroupBox2.Controls.Add(Me.DBtn)
        Me.GroupBox2.Controls.Add(Me.TBtn)
        Me.GroupBox2.Controls.Add(Me.HBtn)
        Me.GroupBox2.Controls.Add(Me.NBtn)
        Me.GroupBox2.Controls.Add(Me.BBtn)
        Me.GroupBox2.Controls.Add(Me.ZBtn)
        Me.GroupBox2.Controls.Add(Me.XBtn)
        Me.GroupBox2.Controls.Add(Me.YBtn)
        Me.GroupBox2.Controls.Add(Me.WBtn)
        Me.GroupBox2.Controls.Add(Me.LBtn)
        Me.GroupBox2.Controls.Add(Me.KBtn)
        Me.GroupBox2.Controls.Add(Me.QBtn)
        Me.GroupBox2.Controls.Add(Me.EBtn)
        Me.GroupBox2.Controls.Add(Me.UBtn)
        Me.GroupBox2.Controls.Add(Me.IBtn)
        Me.GroupBox2.Controls.Add(Me.OBtn)
        Me.GroupBox2.Controls.Add(Me.CBtn)
        Me.GroupBox2.Controls.Add(Me.SBtn)
        Me.GroupBox2.Controls.Add(Me.GBtn)
        Me.GroupBox2.Controls.Add(Me.MBtn)
        Me.GroupBox2.Controls.Add(Me.ABtn)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Location = New System.Drawing.Point(138, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(372, 74)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Letters"
        '
        'RBtn
        '
        Me.RBtn.Location = New System.Drawing.Point(118, 44)
        Me.RBtn.Name = "RBtn"
        Me.RBtn.Size = New System.Drawing.Size(22, 23)
        Me.RBtn.TabIndex = 0
        Me.RBtn.Text = "R"
        Me.RBtn.UseVisualStyleBackColor = True
        '
        'FBtn
        '
        Me.FBtn.Location = New System.Drawing.Point(146, 19)
        Me.FBtn.Name = "FBtn"
        Me.FBtn.Size = New System.Drawing.Size(22, 23)
        Me.FBtn.TabIndex = 0
        Me.FBtn.Text = "F"
        Me.FBtn.UseVisualStyleBackColor = True
        '
        'VBtn
        '
        Me.VBtn.Location = New System.Drawing.Point(230, 44)
        Me.VBtn.Name = "VBtn"
        Me.VBtn.Size = New System.Drawing.Size(22, 23)
        Me.VBtn.TabIndex = 0
        Me.VBtn.Text = "V"
        Me.VBtn.UseVisualStyleBackColor = True
        '
        'JBtn
        '
        Me.JBtn.Location = New System.Drawing.Point(258, 19)
        Me.JBtn.Name = "JBtn"
        Me.JBtn.Size = New System.Drawing.Size(22, 23)
        Me.JBtn.TabIndex = 0
        Me.JBtn.Text = "J"
        Me.JBtn.UseVisualStyleBackColor = True
        '
        'PBtn
        '
        Me.PBtn.Location = New System.Drawing.Point(62, 44)
        Me.PBtn.Name = "PBtn"
        Me.PBtn.Size = New System.Drawing.Size(22, 23)
        Me.PBtn.TabIndex = 0
        Me.PBtn.Text = "P"
        Me.PBtn.UseVisualStyleBackColor = True
        '
        'DBtn
        '
        Me.DBtn.Location = New System.Drawing.Point(90, 19)
        Me.DBtn.Name = "DBtn"
        Me.DBtn.Size = New System.Drawing.Size(22, 23)
        Me.DBtn.TabIndex = 0
        Me.DBtn.Text = "D"
        Me.DBtn.UseVisualStyleBackColor = True
        '
        'TBtn
        '
        Me.TBtn.Location = New System.Drawing.Point(174, 44)
        Me.TBtn.Name = "TBtn"
        Me.TBtn.Size = New System.Drawing.Size(22, 23)
        Me.TBtn.TabIndex = 0
        Me.TBtn.Text = "T"
        Me.TBtn.UseVisualStyleBackColor = True
        '
        'HBtn
        '
        Me.HBtn.Location = New System.Drawing.Point(202, 19)
        Me.HBtn.Name = "HBtn"
        Me.HBtn.Size = New System.Drawing.Size(22, 23)
        Me.HBtn.TabIndex = 0
        Me.HBtn.Text = "H"
        Me.HBtn.UseVisualStyleBackColor = True
        '
        'NBtn
        '
        Me.NBtn.Location = New System.Drawing.Point(6, 44)
        Me.NBtn.Name = "NBtn"
        Me.NBtn.Size = New System.Drawing.Size(22, 23)
        Me.NBtn.TabIndex = 0
        Me.NBtn.Text = "N"
        Me.NBtn.UseVisualStyleBackColor = True
        '
        'BBtn
        '
        Me.BBtn.Location = New System.Drawing.Point(34, 19)
        Me.BBtn.Name = "BBtn"
        Me.BBtn.Size = New System.Drawing.Size(22, 23)
        Me.BBtn.TabIndex = 0
        Me.BBtn.Text = "B"
        Me.BBtn.UseVisualStyleBackColor = True
        '
        'ZBtn
        '
        Me.ZBtn.Location = New System.Drawing.Point(342, 44)
        Me.ZBtn.Name = "ZBtn"
        Me.ZBtn.Size = New System.Drawing.Size(22, 23)
        Me.ZBtn.TabIndex = 0
        Me.ZBtn.Text = "Z"
        Me.ZBtn.UseVisualStyleBackColor = True
        '
        'XBtn
        '
        Me.XBtn.Location = New System.Drawing.Point(286, 44)
        Me.XBtn.Name = "XBtn"
        Me.XBtn.Size = New System.Drawing.Size(22, 23)
        Me.XBtn.TabIndex = 0
        Me.XBtn.Text = "X"
        Me.XBtn.UseVisualStyleBackColor = True
        '
        'YBtn
        '
        Me.YBtn.Location = New System.Drawing.Point(314, 44)
        Me.YBtn.Name = "YBtn"
        Me.YBtn.Size = New System.Drawing.Size(22, 23)
        Me.YBtn.TabIndex = 0
        Me.YBtn.Text = "Y"
        Me.YBtn.UseVisualStyleBackColor = True
        '
        'WBtn
        '
        Me.WBtn.Location = New System.Drawing.Point(258, 44)
        Me.WBtn.Name = "WBtn"
        Me.WBtn.Size = New System.Drawing.Size(22, 23)
        Me.WBtn.TabIndex = 0
        Me.WBtn.Text = "W"
        Me.WBtn.UseVisualStyleBackColor = True
        '
        'LBtn
        '
        Me.LBtn.Location = New System.Drawing.Point(314, 19)
        Me.LBtn.Name = "LBtn"
        Me.LBtn.Size = New System.Drawing.Size(22, 23)
        Me.LBtn.TabIndex = 0
        Me.LBtn.Text = "L"
        Me.LBtn.UseVisualStyleBackColor = True
        '
        'KBtn
        '
        Me.KBtn.Location = New System.Drawing.Point(286, 19)
        Me.KBtn.Name = "KBtn"
        Me.KBtn.Size = New System.Drawing.Size(22, 23)
        Me.KBtn.TabIndex = 0
        Me.KBtn.Text = "K"
        Me.KBtn.UseVisualStyleBackColor = True
        '
        'QBtn
        '
        Me.QBtn.Location = New System.Drawing.Point(90, 44)
        Me.QBtn.Name = "QBtn"
        Me.QBtn.Size = New System.Drawing.Size(22, 23)
        Me.QBtn.TabIndex = 0
        Me.QBtn.Text = "Q"
        Me.QBtn.UseVisualStyleBackColor = True
        '
        'EBtn
        '
        Me.EBtn.Location = New System.Drawing.Point(118, 19)
        Me.EBtn.Name = "EBtn"
        Me.EBtn.Size = New System.Drawing.Size(22, 23)
        Me.EBtn.TabIndex = 0
        Me.EBtn.Text = "E"
        Me.EBtn.UseVisualStyleBackColor = True
        '
        'UBtn
        '
        Me.UBtn.Location = New System.Drawing.Point(202, 44)
        Me.UBtn.Name = "UBtn"
        Me.UBtn.Size = New System.Drawing.Size(22, 23)
        Me.UBtn.TabIndex = 0
        Me.UBtn.Text = "U"
        Me.UBtn.UseVisualStyleBackColor = True
        '
        'IBtn
        '
        Me.IBtn.Location = New System.Drawing.Point(230, 19)
        Me.IBtn.Name = "IBtn"
        Me.IBtn.Size = New System.Drawing.Size(22, 23)
        Me.IBtn.TabIndex = 0
        Me.IBtn.Text = "I"
        Me.IBtn.UseVisualStyleBackColor = True
        '
        'OBtn
        '
        Me.OBtn.Location = New System.Drawing.Point(34, 44)
        Me.OBtn.Name = "OBtn"
        Me.OBtn.Size = New System.Drawing.Size(22, 23)
        Me.OBtn.TabIndex = 0
        Me.OBtn.Text = "O"
        Me.OBtn.UseVisualStyleBackColor = True
        '
        'CBtn
        '
        Me.CBtn.Location = New System.Drawing.Point(62, 19)
        Me.CBtn.Name = "CBtn"
        Me.CBtn.Size = New System.Drawing.Size(22, 23)
        Me.CBtn.TabIndex = 0
        Me.CBtn.Text = "C"
        Me.CBtn.UseVisualStyleBackColor = True
        '
        'SBtn
        '
        Me.SBtn.Location = New System.Drawing.Point(146, 44)
        Me.SBtn.Name = "SBtn"
        Me.SBtn.Size = New System.Drawing.Size(22, 23)
        Me.SBtn.TabIndex = 0
        Me.SBtn.Text = "S"
        Me.SBtn.UseVisualStyleBackColor = True
        '
        'GBtn
        '
        Me.GBtn.Location = New System.Drawing.Point(174, 19)
        Me.GBtn.Name = "GBtn"
        Me.GBtn.Size = New System.Drawing.Size(22, 23)
        Me.GBtn.TabIndex = 0
        Me.GBtn.Text = "G"
        Me.GBtn.UseVisualStyleBackColor = True
        '
        'MBtn
        '
        Me.MBtn.Location = New System.Drawing.Point(342, 19)
        Me.MBtn.Name = "MBtn"
        Me.MBtn.Size = New System.Drawing.Size(22, 23)
        Me.MBtn.TabIndex = 0
        Me.MBtn.Text = "M"
        Me.MBtn.UseVisualStyleBackColor = True
        '
        'ABtn
        '
        Me.ABtn.Location = New System.Drawing.Point(6, 19)
        Me.ABtn.Name = "ABtn"
        Me.ABtn.Size = New System.Drawing.Size(22, 23)
        Me.ABtn.TabIndex = 0
        Me.ABtn.Text = "A"
        Me.ABtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Current Word:"
        '
        'CurrWord
        '
        Me.CurrWord.AutoSize = True
        Me.CurrWord.Location = New System.Drawing.Point(214, 168)
        Me.CurrWord.Name = "CurrWord"
        Me.CurrWord.Size = New System.Drawing.Size(39, 13)
        Me.CurrWord.TabIndex = 3
        Me.CurrWord.Text = "Label2"
        '
        'NewWordBtn
        '
        Me.NewWordBtn.Location = New System.Drawing.Point(138, 184)
        Me.NewWordBtn.Name = "NewWordBtn"
        Me.NewWordBtn.Size = New System.Drawing.Size(97, 23)
        Me.NewWordBtn.TabIndex = 4
        Me.NewWordBtn.Text = "Pick New Word"
        Me.NewWordBtn.UseVisualStyleBackColor = True
        '
        'MistakesLbl
        '
        Me.MistakesLbl.AutoSize = True
        Me.MistakesLbl.Location = New System.Drawing.Point(365, 168)
        Me.MistakesLbl.Name = "MistakesLbl"
        Me.MistakesLbl.Size = New System.Drawing.Size(114, 13)
        Me.MistakesLbl.TabIndex = 5
        Me.MistakesLbl.Text = "Remaining Mistakes: 6"
        '
        'SettingsBtn
        '
        Me.SettingsBtn.Location = New System.Drawing.Point(368, 184)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(111, 23)
        Me.SettingsBtn.TabIndex = 6
        Me.SettingsBtn.Text = "Settings"
        Me.SettingsBtn.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(522, 254)
        Me.Controls.Add(Me.SettingsBtn)
        Me.Controls.Add(Me.MistakesLbl)
        Me.Controls.Add(Me.NewWordBtn)
        Me.Controls.Add(Me.CurrWord)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Arm1Box)
        Me.Controls.Add(Me.Leg2Box)
        Me.Controls.Add(Me.Leg1Box)
        Me.Controls.Add(Me.Arm2Box)
        Me.Controls.Add(Me.HeadBox)
        Me.Controls.Add(Me.BodyBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hangman Demo"
        CType(Me.HeadBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Arm2Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Leg1Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BodyBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Arm1Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Leg2Box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeadBox As System.Windows.Forms.PictureBox
    Friend WithEvents Arm2Box As System.Windows.Forms.PictureBox
    Friend WithEvents Leg1Box As System.Windows.Forms.PictureBox
    Friend WithEvents BodyBox As System.Windows.Forms.PictureBox
    Friend WithEvents Arm1Box As System.Windows.Forms.PictureBox
    Friend WithEvents Leg2Box As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RBtn As System.Windows.Forms.Button
    Friend WithEvents FBtn As System.Windows.Forms.Button
    Friend WithEvents VBtn As System.Windows.Forms.Button
    Friend WithEvents JBtn As System.Windows.Forms.Button
    Friend WithEvents PBtn As System.Windows.Forms.Button
    Friend WithEvents DBtn As System.Windows.Forms.Button
    Friend WithEvents TBtn As System.Windows.Forms.Button
    Friend WithEvents HBtn As System.Windows.Forms.Button
    Friend WithEvents NBtn As System.Windows.Forms.Button
    Friend WithEvents BBtn As System.Windows.Forms.Button
    Friend WithEvents ZBtn As System.Windows.Forms.Button
    Friend WithEvents XBtn As System.Windows.Forms.Button
    Friend WithEvents YBtn As System.Windows.Forms.Button
    Friend WithEvents WBtn As System.Windows.Forms.Button
    Friend WithEvents LBtn As System.Windows.Forms.Button
    Friend WithEvents KBtn As System.Windows.Forms.Button
    Friend WithEvents QBtn As System.Windows.Forms.Button
    Friend WithEvents EBtn As System.Windows.Forms.Button
    Friend WithEvents UBtn As System.Windows.Forms.Button
    Friend WithEvents IBtn As System.Windows.Forms.Button
    Friend WithEvents OBtn As System.Windows.Forms.Button
    Friend WithEvents CBtn As System.Windows.Forms.Button
    Friend WithEvents SBtn As System.Windows.Forms.Button
    Friend WithEvents GBtn As System.Windows.Forms.Button
    Friend WithEvents MBtn As System.Windows.Forms.Button
    Friend WithEvents ABtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CurrWord As System.Windows.Forms.Label
    Friend WithEvents NewWordBtn As System.Windows.Forms.Button
    Friend WithEvents MistakesLbl As System.Windows.Forms.Label
    Friend WithEvents SettingsBtn As System.Windows.Forms.Button

End Class
