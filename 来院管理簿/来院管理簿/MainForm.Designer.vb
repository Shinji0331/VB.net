<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.header = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sidebar = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.entryBtn = New System.Windows.Forms.Button()
        Me.serchBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.header.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.sidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.WhiteSmoke
        Me.header.Controls.Add(Me.GroupBox1)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(262, 0)
        Me.header.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(2448, 221)
        Me.header.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TextBox8)
        Me.GroupBox4.Location = New System.Drawing.Point(1072, 911)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(338, 104)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "氏名（ふりがな）"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(238, 56)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 24)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "を含む"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(20, 48)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(203, 31)
        Me.TextBox8.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TextBox7)
        Me.GroupBox3.Location = New System.Drawing.Point(1499, 529)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(342, 102)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "氏名（漢字）"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(249, 56)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "を含む"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(30, 48)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(203, 31)
        Me.TextBox7.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Location = New System.Drawing.Point(1004, 481)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(338, 102)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "管理番号"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(182, 48)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(117, 31)
        Me.TextBox6.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 56)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "～"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(20, 48)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(117, 31)
        Me.TextBox5.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Font = New System.Drawing.Font("メイリオ", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(33, 24)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(578, 127)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "来院日（西暦）"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("メイリオ", 7.0!)
        Me.TextBox4.Location = New System.Drawing.Point(134, 44)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(65, 35)
        Me.TextBox4.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 36)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "月～"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "年"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 204)
        Me.Panel1.TabIndex = 0
        '
        'sidebar
        '
        Me.sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.sidebar.Controls.Add(Me.Button1)
        Me.sidebar.Controls.Add(Me.entryBtn)
        Me.sidebar.Controls.Add(Me.serchBtn)
        Me.sidebar.Controls.Add(Me.Panel1)
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebar.Location = New System.Drawing.Point(0, 0)
        Me.sidebar.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Size = New System.Drawing.Size(262, 1883)
        Me.sidebar.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(0, 396)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(262, 96)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "終了"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'entryBtn
        '
        Me.entryBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.entryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.entryBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.entryBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.entryBtn.FlatAppearance.BorderSize = 0
        Me.entryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.entryBtn.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entryBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.entryBtn.Location = New System.Drawing.Point(0, 300)
        Me.entryBtn.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.entryBtn.Name = "entryBtn"
        Me.entryBtn.Size = New System.Drawing.Size(262, 96)
        Me.entryBtn.TabIndex = 3
        Me.entryBtn.Text = "登録"
        Me.entryBtn.UseVisualStyleBackColor = False
        '
        'serchBtn
        '
        Me.serchBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.serchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.serchBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.serchBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.serchBtn.FlatAppearance.BorderSize = 0
        Me.serchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.serchBtn.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serchBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.serchBtn.Location = New System.Drawing.Point(0, 204)
        Me.serchBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.serchBtn.Name = "serchBtn"
        Me.serchBtn.Size = New System.Drawing.Size(262, 96)
        Me.serchBtn.TabIndex = 2
        Me.serchBtn.Text = "検索"
        Me.serchBtn.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("メイリオ", 7.0!)
        Me.TextBox1.Location = New System.Drawing.Point(22, 44)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(65, 35)
        Me.TextBox1.TabIndex = 5
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(2710, 1883)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.sidebar)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.header.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.sidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents header As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents sidebar As Panel
    Friend WithEvents serchBtn As Button
    Friend WithEvents entryBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
