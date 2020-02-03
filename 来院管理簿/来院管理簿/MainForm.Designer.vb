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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.sidebar = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.entryBtn = New System.Windows.Forms.Button()
        Me.serchBtn = New System.Windows.Forms.Button()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.sidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.WhiteSmoke
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(121, 0)
        Me.header.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(1237, 64)
        Me.header.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 102)
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
        Me.sidebar.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Size = New System.Drawing.Size(121, 855)
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
        Me.Button1.Location = New System.Drawing.Point(0, 198)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 48)
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
        Me.entryBtn.Location = New System.Drawing.Point(0, 150)
        Me.entryBtn.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.entryBtn.Name = "entryBtn"
        Me.entryBtn.Size = New System.Drawing.Size(121, 48)
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
        Me.serchBtn.Location = New System.Drawing.Point(0, 102)
        Me.serchBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.serchBtn.Name = "serchBtn"
        Me.serchBtn.Size = New System.Drawing.Size(121, 48)
        Me.serchBtn.TabIndex = 2
        Me.serchBtn.Text = "検索"
        Me.serchBtn.UseVisualStyleBackColor = False
        '
        'PanelFormularios
        '
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(121, 64)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1237, 791)
        Me.PanelFormularios.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1358, 855)
        Me.Controls.Add(Me.PanelFormularios)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.sidebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ああｓｄ"
        Me.sidebar.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents header As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents sidebar As Panel
    Friend WithEvents serchBtn As Button
    Friend WithEvents entryBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelFormularios As Panel
End Class
