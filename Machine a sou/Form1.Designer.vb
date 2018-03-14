<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.PB_a31 = New System.Windows.Forms.PictureBox()
        Me.PB_21 = New System.Windows.Forms.PictureBox()
        Me.PB_11 = New System.Windows.Forms.PictureBox()
        Me.BT_roul = New System.Windows.Forms.Button()
        Me.BT_replay = New System.Windows.Forms.Button()
        Me.BT_exit = New System.Windows.Forms.Button()
        Me.LB_modeDeJeu = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBL_mise = New System.Windows.Forms.Label()
        Me.LBL_mode = New System.Windows.Forms.Label()
        Me.LBL_coef = New System.Windows.Forms.Label()
        Me.LBL_gain = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBL_pasDeSou = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_fond = New System.Windows.Forms.TextBox()
        Me.LBL_fondTime = New System.Windows.Forms.Label()
        Me.LBL_valPlus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_mise = New System.Windows.Forms.TextBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PB_a32 = New System.Windows.Forms.PictureBox()
        Me.PB_a33 = New System.Windows.Forms.PictureBox()
        Me.PB_13 = New System.Windows.Forms.PictureBox()
        Me.PB_12 = New System.Windows.Forms.PictureBox()
        Me.PB_23 = New System.Windows.Forms.PictureBox()
        Me.PB_22 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.LBL_win = New System.Windows.Forms.Label()
        Me.LBL_lose = New System.Windows.Forms.Label()
        Me.LBL_infoBul = New System.Windows.Forms.Label()
        Me.TIM_info = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PB_a31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_a32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_a33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_a31
        '
        Me.PB_a31.Image = CType(resources.GetObject("PB_a31.Image"), System.Drawing.Image)
        Me.PB_a31.Location = New System.Drawing.Point(670, 181)
        Me.PB_a31.Name = "PB_a31"
        Me.PB_a31.Size = New System.Drawing.Size(110, 87)
        Me.PB_a31.TabIndex = 2
        Me.PB_a31.TabStop = False
        '
        'PB_21
        '
        Me.PB_21.Image = CType(resources.GetObject("PB_21.Image"), System.Drawing.Image)
        Me.PB_21.Location = New System.Drawing.Point(541, 181)
        Me.PB_21.Name = "PB_21"
        Me.PB_21.Size = New System.Drawing.Size(110, 87)
        Me.PB_21.TabIndex = 1
        Me.PB_21.TabStop = False
        '
        'PB_11
        '
        Me.PB_11.Image = CType(resources.GetObject("PB_11.Image"), System.Drawing.Image)
        Me.PB_11.Location = New System.Drawing.Point(417, 181)
        Me.PB_11.Name = "PB_11"
        Me.PB_11.Size = New System.Drawing.Size(110, 87)
        Me.PB_11.TabIndex = 0
        Me.PB_11.TabStop = False
        '
        'BT_roul
        '
        Me.BT_roul.Location = New System.Drawing.Point(592, 293)
        Me.BT_roul.Name = "BT_roul"
        Me.BT_roul.Size = New System.Drawing.Size(75, 23)
        Me.BT_roul.TabIndex = 1
        Me.BT_roul.Text = "Rouler"
        Me.BT_roul.UseVisualStyleBackColor = True
        '
        'BT_replay
        '
        Me.BT_replay.Location = New System.Drawing.Point(460, 293)
        Me.BT_replay.Name = "BT_replay"
        Me.BT_replay.Size = New System.Drawing.Size(75, 23)
        Me.BT_replay.TabIndex = 2
        Me.BT_replay.Text = "Rejouer"
        Me.BT_replay.UseVisualStyleBackColor = True
        '
        'BT_exit
        '
        Me.BT_exit.Location = New System.Drawing.Point(705, 455)
        Me.BT_exit.Name = "BT_exit"
        Me.BT_exit.Size = New System.Drawing.Size(75, 23)
        Me.BT_exit.TabIndex = 3
        Me.BT_exit.Text = "Quitter"
        Me.BT_exit.UseVisualStyleBackColor = True
        '
        'LB_modeDeJeu
        '
        Me.LB_modeDeJeu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LB_modeDeJeu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LB_modeDeJeu.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_modeDeJeu.FormattingEnabled = True
        Me.LB_modeDeJeu.ItemHeight = 22
        Me.LB_modeDeJeu.Items.AddRange(New Object() {"Méfiance", "Espoir", "Acceptation", "Confiance", "Intégrité"})
        Me.LB_modeDeJeu.Location = New System.Drawing.Point(73, 88)
        Me.LB_modeDeJeu.Name = "LB_modeDeJeu"
        Me.LB_modeDeJeu.Size = New System.Drawing.Size(131, 114)
        Me.LB_modeDeJeu.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(70, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Mode de jeu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Mise"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 278)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Mode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Coefficient"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Gain"
        '
        'LBL_mise
        '
        Me.LBL_mise.AutoSize = True
        Me.LBL_mise.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_mise.Location = New System.Drawing.Point(162, 248)
        Me.LBL_mise.Name = "LBL_mise"
        Me.LBL_mise.Size = New System.Drawing.Size(42, 20)
        Me.LBL_mise.TabIndex = 10
        Me.LBL_mise.Text = "Mise"
        '
        'LBL_mode
        '
        Me.LBL_mode.AutoSize = True
        Me.LBL_mode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_mode.Location = New System.Drawing.Point(162, 278)
        Me.LBL_mode.Name = "LBL_mode"
        Me.LBL_mode.Size = New System.Drawing.Size(42, 20)
        Me.LBL_mode.TabIndex = 11
        Me.LBL_mode.Text = "Mise"
        '
        'LBL_coef
        '
        Me.LBL_coef.AutoSize = True
        Me.LBL_coef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_coef.Location = New System.Drawing.Point(162, 308)
        Me.LBL_coef.Name = "LBL_coef"
        Me.LBL_coef.Size = New System.Drawing.Size(42, 20)
        Me.LBL_coef.TabIndex = 12
        Me.LBL_coef.Text = "Mise"
        '
        'LBL_gain
        '
        Me.LBL_gain.AutoSize = True
        Me.LBL_gain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_gain.Location = New System.Drawing.Point(162, 337)
        Me.LBL_gain.Name = "LBL_gain"
        Me.LBL_gain.Size = New System.Drawing.Size(42, 20)
        Me.LBL_gain.TabIndex = 13
        Me.LBL_gain.Text = "Mise"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBL_pasDeSou)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXT_fond)
        Me.GroupBox1.Controls.Add(Me.LBL_fondTime)
        Me.GroupBox1.Controls.Add(Me.LBL_valPlus)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(425, 347)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 100)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Votre budget"
        '
        'LBL_pasDeSou
        '
        Me.LBL_pasDeSou.AutoSize = True
        Me.LBL_pasDeSou.ForeColor = System.Drawing.Color.Red
        Me.LBL_pasDeSou.Location = New System.Drawing.Point(87, 40)
        Me.LBL_pasDeSou.Name = "LBL_pasDeSou"
        Me.LBL_pasDeSou.Size = New System.Drawing.Size(150, 13)
        Me.LBL_pasDeSou.TabIndex = 5
        Me.LBL_pasDeSou.Text = "Vous n'avez pas assez de sou"
        Me.LBL_pasDeSou.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "VAL"
        '
        'TXT_fond
        '
        Me.TXT_fond.Location = New System.Drawing.Point(90, 17)
        Me.TXT_fond.Name = "TXT_fond"
        Me.TXT_fond.ReadOnly = True
        Me.TXT_fond.Size = New System.Drawing.Size(100, 20)
        Me.TXT_fond.TabIndex = 3
        '
        'LBL_fondTime
        '
        Me.LBL_fondTime.AutoSize = True
        Me.LBL_fondTime.Location = New System.Drawing.Point(113, 55)
        Me.LBL_fondTime.Name = "LBL_fondTime"
        Me.LBL_fondTime.Size = New System.Drawing.Size(31, 13)
        Me.LBL_fondTime.TabIndex = 2
        Me.LBL_fondTime.Text = "Fond"
        '
        'LBL_valPlus
        '
        Me.LBL_valPlus.AutoSize = True
        Me.LBL_valPlus.Location = New System.Drawing.Point(6, 55)
        Me.LBL_valPlus.Name = "LBL_valPlus"
        Me.LBL_valPlus.Size = New System.Drawing.Size(83, 13)
        Me.LBL_valPlus.TabIndex = 1
        Me.LBL_valPlus.Text = "1000 VAL dans "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Fond"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TXT_mise)
        Me.GroupBox2.Controls.Add(Me.VScrollBar1)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(237, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 118)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Paramettre de jeu"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(177, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "VAL"
        '
        'TXT_mise
        '
        Me.TXT_mise.Location = New System.Drawing.Point(71, 14)
        Me.TXT_mise.Name = "TXT_mise"
        Me.TXT_mise.Size = New System.Drawing.Size(100, 20)
        Me.TXT_mise.TabIndex = 4
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(178, 37)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(12, 53)
        Me.VScrollBar1.TabIndex = 7
        Me.VScrollBar1.Value = 5
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(100, 37)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(71, 53)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Image gagnante"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Votre Mise"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "ami1.jpg")
        Me.ImageList1.Images.SetKeyName(1, "ami2.jpg")
        Me.ImageList1.Images.SetKeyName(2, "ami3.jpg")
        '
        'PB_a32
        '
        Me.PB_a32.Image = CType(resources.GetObject("PB_a32.Image"), System.Drawing.Image)
        Me.PB_a32.Location = New System.Drawing.Point(808, 91)
        Me.PB_a32.Name = "PB_a32"
        Me.PB_a32.Size = New System.Drawing.Size(110, 87)
        Me.PB_a32.TabIndex = 3
        Me.PB_a32.TabStop = False
        '
        'PB_a33
        '
        Me.PB_a33.Image = CType(resources.GetObject("PB_a33.Image"), System.Drawing.Image)
        Me.PB_a33.Location = New System.Drawing.Point(808, 91)
        Me.PB_a33.Name = "PB_a33"
        Me.PB_a33.Size = New System.Drawing.Size(110, 87)
        Me.PB_a33.TabIndex = 16
        Me.PB_a33.TabStop = False
        '
        'PB_13
        '
        Me.PB_13.Image = CType(resources.GetObject("PB_13.Image"), System.Drawing.Image)
        Me.PB_13.Location = New System.Drawing.Point(808, 91)
        Me.PB_13.Name = "PB_13"
        Me.PB_13.Size = New System.Drawing.Size(110, 87)
        Me.PB_13.TabIndex = 3
        Me.PB_13.TabStop = False
        '
        'PB_12
        '
        Me.PB_12.Image = CType(resources.GetObject("PB_12.Image"), System.Drawing.Image)
        Me.PB_12.Location = New System.Drawing.Point(808, 91)
        Me.PB_12.Name = "PB_12"
        Me.PB_12.Size = New System.Drawing.Size(110, 87)
        Me.PB_12.TabIndex = 4
        Me.PB_12.TabStop = False
        '
        'PB_23
        '
        Me.PB_23.Image = CType(resources.GetObject("PB_23.Image"), System.Drawing.Image)
        Me.PB_23.Location = New System.Drawing.Point(808, 88)
        Me.PB_23.Name = "PB_23"
        Me.PB_23.Size = New System.Drawing.Size(110, 87)
        Me.PB_23.TabIndex = 3
        Me.PB_23.TabStop = False
        '
        'PB_22
        '
        Me.PB_22.Image = CType(resources.GetObject("PB_22.Image"), System.Drawing.Image)
        Me.PB_22.Location = New System.Drawing.Point(808, 88)
        Me.PB_22.Name = "PB_22"
        Me.PB_22.Size = New System.Drawing.Size(110, 87)
        Me.PB_22.TabIndex = 4
        Me.PB_22.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(414, 165)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Rolling"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'LBL_win
        '
        Me.LBL_win.AutoSize = True
        Me.LBL_win.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_win.ForeColor = System.Drawing.Color.Lime
        Me.LBL_win.Location = New System.Drawing.Point(636, 88)
        Me.LBL_win.Name = "LBL_win"
        Me.LBL_win.Size = New System.Drawing.Size(98, 25)
        Me.LBL_win.TabIndex = 17
        Me.LBL_win.Text = "GAGNER"
        '
        'LBL_lose
        '
        Me.LBL_lose.AutoSize = True
        Me.LBL_lose.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_lose.ForeColor = System.Drawing.Color.Red
        Me.LBL_lose.Location = New System.Drawing.Point(648, 88)
        Me.LBL_lose.Name = "LBL_lose"
        Me.LBL_lose.Size = New System.Drawing.Size(86, 25)
        Me.LBL_lose.TabIndex = 18
        Me.LBL_lose.Text = "PERDU"
        '
        'LBL_infoBul
        '
        Me.LBL_infoBul.AutoSize = True
        Me.LBL_infoBul.BackColor = System.Drawing.Color.Transparent
        Me.LBL_infoBul.ForeColor = System.Drawing.Color.Blue
        Me.LBL_infoBul.Location = New System.Drawing.Point(182, 100)
        Me.LBL_infoBul.Name = "LBL_infoBul"
        Me.LBL_infoBul.Size = New System.Drawing.Size(22, 13)
        Me.LBL_infoBul.TabIndex = 9
        Me.LBL_infoBul.Text = "kfd"
        '
        'TIM_info
        '
        Me.TIM_info.Interval = 1000
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 490)
        Me.Controls.Add(Me.LBL_infoBul)
        Me.Controls.Add(Me.LBL_lose)
        Me.Controls.Add(Me.LBL_win)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PB_a31)
        Me.Controls.Add(Me.PB_23)
        Me.Controls.Add(Me.PB_21)
        Me.Controls.Add(Me.PB_22)
        Me.Controls.Add(Me.PB_11)
        Me.Controls.Add(Me.PB_13)
        Me.Controls.Add(Me.PB_12)
        Me.Controls.Add(Me.PB_a32)
        Me.Controls.Add(Me.PB_a33)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBL_gain)
        Me.Controls.Add(Me.LBL_coef)
        Me.Controls.Add(Me.LBL_mode)
        Me.Controls.Add(Me.LBL_mise)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LB_modeDeJeu)
        Me.Controls.Add(Me.BT_exit)
        Me.Controls.Add(Me.BT_replay)
        Me.Controls.Add(Me.BT_roul)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "main"
        Me.Text = "Machine à sou"
        CType(Me.PB_a31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_a32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_a33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PB_a31 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_21 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_11 As System.Windows.Forms.PictureBox
    Friend WithEvents BT_roul As System.Windows.Forms.Button
    Friend WithEvents BT_replay As System.Windows.Forms.Button
    Friend WithEvents BT_exit As System.Windows.Forms.Button
    Friend WithEvents LB_modeDeJeu As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LBL_mise As System.Windows.Forms.Label
    Friend WithEvents LBL_mode As System.Windows.Forms.Label
    Friend WithEvents LBL_coef As System.Windows.Forms.Label
    Friend WithEvents LBL_gain As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_fond As System.Windows.Forms.TextBox
    Friend WithEvents LBL_fondTime As System.Windows.Forms.Label
    Friend WithEvents LBL_valPlus As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents VScrollBar1 As System.Windows.Forms.VScrollBar
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT_mise As System.Windows.Forms.TextBox
    Friend WithEvents PB_a32 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_a33 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_13 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_12 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_23 As System.Windows.Forms.PictureBox
    Friend WithEvents PB_22 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents LBL_win As System.Windows.Forms.Label
    Friend WithEvents LBL_lose As System.Windows.Forms.Label
    Friend WithEvents LBL_pasDeSou As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LBL_infoBul As System.Windows.Forms.Label
    Friend WithEvents TIM_info As System.Windows.Forms.Timer

End Class
