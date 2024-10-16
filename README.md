# kenpo31GenerationTool


## レイヤー構成

```
kenpo31GenerationTool/
├── ui/
│   ├── Form1.cs               // UIのファイル
├── BusinessLogic/
│   ├── CsvHandler.cs          // CSV関連のビジネスロジック
│   ├── ValidationHandler.cs   // バリデーション関連のロジック
├── DataAccess/
│   ├── CsvReader.cs           // CSVファイルの読み込みや書き込み
├── Models/
│   ├── Kenpo31Model.cs        // KENPO31.csv のモデル定義
│   ├── FI_JRK_0004Model.cs    // FI_JRK_0004.csv のモデル定義
└── Program.cs                 // メインエントリーポイント

```