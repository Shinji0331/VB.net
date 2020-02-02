<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class selectForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Folder_Select_Btn = New System.Windows.Forms.Button()
        Me.TextBox_folPath = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.All_Select_Btn = New System.Windows.Forms.Button()
        Me.All_Clear_Btn = New System.Windows.Forms.Button()
        Me.startBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "①証跡画像が格納されているフォルダを選択してください。"
        '
        'Folder_Select_Btn
        '
        Me.Folder_Select_Btn.BackColor = System.Drawing.Color.Gainsboro
        Me.Folder_Select_Btn.Location = New System.Drawing.Point(12, 52)
        Me.Folder_Select_Btn.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Folder_Select_Btn.Name = "Folder_Select_Btn"
        Me.Folder_Select_Btn.Size = New System.Drawing.Size(75, 23)
        Me.Folder_Select_Btn.TabIndex = 1
        Me.Folder_Select_Btn.Text = "フォルダ選択"
        Me.Folder_Select_Btn.UseVisualStyleBackColor = False
        '
        'TextBox_folPath
        '
        Me.TextBox_folPath.Location = New System.Drawing.Point(12, 79)
        Me.TextBox_folPath.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.TextBox_folPath.Name = "TextBox_folPath"
        Me.TextBox_folPath.Size = New System.Drawing.Size(770, 19)
        Me.TextBox_folPath.TabIndex = 2
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 132)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(770, 405)
        Me.ListView1.TabIndex = 3
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'All_Select_Btn
        '
        Me.All_Select_Btn.Location = New System.Drawing.Point(12, 103)
        Me.All_Select_Btn.Name = "All_Select_Btn"
        Me.All_Select_Btn.Size = New System.Drawing.Size(56, 23)
        Me.All_Select_Btn.TabIndex = 4
        Me.All_Select_Btn.Text = "全選択"
        Me.All_Select_Btn.UseVisualStyleBackColor = True
        '
        'All_Clear_Btn
        '
        Me.All_Clear_Btn.Location = New System.Drawing.Point(74, 103)
        Me.All_Clear_Btn.Name = "All_Clear_Btn"
        Me.All_Clear_Btn.Size = New System.Drawing.Size(56, 23)
        Me.All_Clear_Btn.TabIndex = 5
        Me.All_Clear_Btn.Text = "全解除"
        Me.All_Clear_Btn.UseVisualStyleBackColor = True
        '
        'startBtn
        '
        Me.startBtn.Location = New System.Drawing.Point(12, 545)
        Me.startBtn.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.startBtn.Name = "startBtn"
        Me.startBtn.Size = New System.Drawing.Size(84, 31)
        Me.startBtn.TabIndex = 6
        Me.startBtn.Text = "開始"
        Me.startBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(815, 606)
        Me.Controls.Add(Me.startBtn)
        Me.Controls.Add(Me.All_Clear_Btn)
        Me.Controls.Add(Me.All_Select_Btn)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TextBox_folPath)
        Me.Controls.Add(Me.Folder_Select_Btn)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Name = "Form1"
        Me.Text = "証跡画像作成ツール"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Folder_Select_Btn As Button
    Friend WithEvents TextBox_folPath As TextBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents All_Select_Btn As Button
    Friend WithEvents All_Clear_Btn As Button
    Friend WithEvents startBtn As Button
End Class
