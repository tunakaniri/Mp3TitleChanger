# Mp3TitleChanger

****このプログラムはGitHub Copilotにより作成されました。****

## 概要

`Mp3TitleChanger`は、指定されたCSVファイルに基づいてMP3ファイルのタイトルを変更し、オプションでアルバム名も変更するC#プログラムです。

## 注意
- タイトルの**先頭**にダブルクオーテーションが入ったMP3には使えませんし、新しく名付ける際にも使えません。
- タイトル前後のスペースは無視されます。
- ダブルクオーテーションで囲むと先頭と末尾のダブルクオーテーションは無視されます(その際ダブルクオーテーションの間にダブルクオーテーションが奇数個入っているとエラーになり、偶数個だとダブルクオーテーションが無視されます)。

## サンプル
[极限委托](https://bfan.link/ji-xian-wei-tuo)の翻訳データ(公式翻訳があるもののみ)
- [rename.csv](https://github.com/user-attachments/files/18305826/rename.csv)

[极限委托：PV原声集](https://bfan.link/ji-xian-wei-tuo-pvyuan-sheng-ji-1)の翻訳データ(動画タイトルが一致しているもののみ)
- [rename.csv](https://github.com/user-attachments/files/18364946/rename.csv)


## 使用方法(基本的にコマンドプロンプトから実行してください)
- 同じフォルダにMp3TitleChanger.exe、rename.csv、変更するMP3ファイルが存在する場合は実行ファイルをダブルクリックまたは実行ファイルの入ったディレクトリで
```cmd
Mp3TitleChanger
```
- Mp3TitleChanger.exeがある場所にMP3ファイルの入ったmusicフォルダが存在する場合は実行ファイルの入ったディレクトリで
```cmd
Mp3TitleChanger --dir music
```

### コマンドライン引数(任意)
- `--album <アルバム名>`: 指定するとすべてのMP3ファイルのアルバム名を指定されたアルバム名に変更します。
- `--csv <CSVファイルパス>`: タイトル変更情報が含まれるCSVファイルのパスを指定します。デフォルトは`rename.csv`です。
- `--dir <ディレクトリパス>`: MP3ファイルが含まれるディレクトリのパスを指定します。デフォルトはプログラムが存在するディレクトリです。

### CSVファイル形式

CSVファイルは以下の形式である必要があります。

例:
```csv
OldTitle, NewTitle
old1, new1
old2, new2
```
## ライセンス


このプロジェクトはCreative Commons Zero v1.0 Universalライセンスの下で公開されています。

