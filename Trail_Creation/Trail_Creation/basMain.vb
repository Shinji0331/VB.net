Module basMain

    Sub Main()

        '' 作成book指定ダイアログ表示
        Dim vFileName As Variant
        xlSheetSave = "C:\test\"
        sName = "田中　一郎"

        'Excelファイル名の入力（単一選択）
        vFileName = xlBook.Application.GetSaveAsFilename(InitialFilename:=
        psxlSheetSave & sName,
        filefilter:=StrConv("Microsoft Excel ファイル (*.x*),*.x*," &
        "すべてのファイル (*.*),*.*", vbNarrow))

        '' ExcelBook作成

        '' ListViewの選択項目分繰り返す

        '' シート作成

        '' フォルダ内の画像を全て取得

        '' 昇順にソート

        '' 画像数分繰り返す

        '' 画像を張り付ける

        '' 3セル分空白行を作成

        '' ExcelBookの保存とクローズ

        '' 終了メッセージ表示

    End Sub

End Module
