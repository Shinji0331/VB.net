Public Class Form1

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

        'ダイアログを表示する
        If fbd.ShowDialog(Me) = DialogResult.OK Then

            '選択されたフォルダを表示する
            selectPath = fbd.SelectedPath



        End If

    End Sub
#End Region


End Class
