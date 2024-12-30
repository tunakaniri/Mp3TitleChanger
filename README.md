# Mp3TitleChanger

****このプログラムはGitHub Copilotにより作成されました。****

## 概要

`Mp3TitleChanger`は、指定されたCSVファイルに基づいてMP3ファイルのタイトルを変更し、オプションでアルバム名も変更するC#プログラムです。

## 使用方法(基本的にコマンドプロンプトまたはPowerShellをお使いください)
- 同じフォルダにMp3TitleChanger.exe、rename.csv、変更するmp3ファイルが存在する場合は実行ファイルをダブルクリックまたは実行ファイルの入ったディレクトリで
```cmd
Mp3TitleChanger
```
- Mp3TitleChanger.exeがある場所にmp3ファイルの入ったmusicフォルダが存在する場合は実行ファイルの入ったディレクトリで
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
3
