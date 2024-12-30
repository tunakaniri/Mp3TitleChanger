//Created by GitHub Copilot

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.FileIO;
using TagLib;

namespace Mp3TitleChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            string? albumName = null;
            string csvFilePath = "rename.csv";
            string mp3Directory = Directory.GetCurrentDirectory();

            // 引数の解析
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "--album" && i + 1 < args.Length)
                {
                    albumName = args[i + 1];
                }
                else if (args[i] == "--csv" && i + 1 < args.Length)
                {
                    csvFilePath = args[i + 1];
                }
                else if (args[i] == "--dir" && i + 1 < args.Length)
                {
                    mp3Directory = args[i + 1];
                }
            }

            // CSVファイルの読み込み
            var titleChanges = ReadCsvFile(csvFilePath);

            // MP3ファイルの処理
            ProcessMp3Files(mp3Directory, titleChanges, albumName);
        }

        // CSVファイルを読み込み、タイトルの変更情報を取得するメソッド
        static Dictionary<string, string> ReadCsvFile(string csvFilePath)
        {
            var titleChanges = new Dictionary<string, string>();

            using (TextFieldParser parser = new TextFieldParser(csvFilePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // ヘッダー行をスキップ
                parser.ReadLine();

                while (!parser.EndOfData)
                {
                    string[]? fields = parser.ReadFields();
                    if (fields != null && fields.Length == 2)
                    {
                        titleChanges[fields[0]] = fields[1];
                    }
                }
            }

            return titleChanges;
        }

        // MP3ファイルを処理し、タイトルとアルバム名を変更するメソッド
        static void ProcessMp3Files(string mp3Directory, Dictionary<string, string> titleChanges, string? albumName)
        {
            var mp3Files = Directory.GetFiles(mp3Directory, "*.mp3");

            foreach (var file in mp3Files)
            {
                var tagFile = TagLib.File.Create(file);
                bool changed = false;

                // タイトルの変更
                if (titleChanges.ContainsKey(tagFile.Tag.Title))
                {
                    tagFile.Tag.Title = titleChanges[tagFile.Tag.Title];
                    changed = true;
                }

                // アルバム名の変更
                if (!string.IsNullOrEmpty(albumName))
                {
                    tagFile.Tag.Album = albumName;
                    changed = true;
                }

                // 変更があった場合、ファイルを保存
                if (changed)
                {
                    tagFile.Save();
                    Console.WriteLine($"Updated: {file}");
                }
            }
        }
    }
}
