Public Class selectForm

#Region "フォルダ選択ボタン"
    Private Sub Folder_Select_Btn_Click(sender As Object, e As EventArgs) Handles Folder_Select_Btn.Click

        '' FolderBrowserDialogクラスのインスタンスを作成
        Dim fbd As New FolderBrowserDialog

        '' 上部に表示する説明テキストを指定する
        fbd.Description = "証跡画像の格納されているフォルダを指定してください。"

        'ルートフォルダを指定する
        'デフォルトでDesktop
        fbd.RootFolder = Environment.SpecialFolder.Desktop

        '最初に選択するフォルダを指定する
        'RootFolder以下にあるフォルダである必要がある
        fbd.SelectedPath = "C:\Windows"

        'ユーザーが新しいフォルダを作成できるようにする
        'デフォルトでTrue
        fbd.ShowNewFolderButton = True

        Try
            'ダイアログを表示する
            If fbd.ShowDialog(Me) = DialogResult.OK Then

                '選択されたフォルダをテキストボックスへ表示する
                selectPath = fbd.SelectedPath
                Me.TextBox_folPath.Text = selectPath

                '"C:\test"以下のサブフォルダをすべて取得する
                Dim di As New System.IO.DirectoryInfo(selectPath)
                Dim subFolders As System.IO.DirectoryInfo() =
                    di.GetDirectories("*", System.IO.SearchOption.AllDirectories)

                '詳細表示にする
                ListView1.View = View.Details

                'ヘッダーを追加する（ヘッダー名、幅、アライメント）
                ListView1.Columns.Add("シート名（サブフォルダ名）", 100, HorizontalAlignment.Left)
                ListView1.Columns.Add("フォルダパス", 300, HorizontalAlignment.Left)
                ListView1.Columns.Add("氏名", 100, HorizontalAlignment.Left)

                'チェックボックスを表示する
                ListView1.CheckBoxes = True

                'リスビューに結果を表示する
                For Each subFolder As System.IO.DirectoryInfo In subFolders

                    Dim itemx1 As New ListViewItem

                    'アイテムの作成
                    'アイテムの追加（シート名取得）
                    itemx1.Text = subFolder.Name
                    'サブアイテムの追加（フルパスの取得）
                    itemx1.SubItems.Add(subFolder.FullName)

                    'アイテムをリスビューに追加する
                    ListView1.Items.Add(itemx1)
                Next
            End If
        Catch ex As Exception

        End Try



    End Sub
#End Region
#Region "全選択ボタン"
    Private Sub All_Select_Btn_Click(sender As Object, e As EventArgs) Handles All_Select_Btn.Click

        'ListViewの全項目を選択済みとする
        For Each itm In ListView1.Items
            itm.Checked = True
        Next
    End Sub


#End Region
#Region "全解除ボタン"
    Private Sub All_Clear_Btn_Click(sender As Object, e As EventArgs) Handles All_Clear_Btn.Click

        'ListViewの全項目を選択済みとする
        For Each itm In ListView1.Items
            itm.Checked = False
        Next
    End Sub

#Region "開始ボタン"
    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click

        'フォルダ選択されていない場合は、メッセージ表示
        If TextBox_folPath.Text = "" Then
            MsgBox("フォルダを選択してください。", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, toolName)
            Exit Sub
        End If

        'ListViewが選択されていない場合は、メッセージ表示
        Dim listViewCnt As Integer = 0
        For Each itm In ListView1.Items
            If itm.Checked = True Then
                listViewCnt += 1
            End If
        Next
        If listViewCnt = 0 Then
            MsgBox("証跡を作成する対象を選択してください。", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, toolName)
            Exit Sub
        End If

        '' フォームを閉じる
        Me.Close()

        '' 主処理実行
        Call Main()


    End Sub
#End Region

#End Region



End Class
