# kenpo31GenerationTool


## レイヤー構成

```
kenpo31GenerationTool/
├── ui/
│   ├── Form1.cs               // UIのファイル
├── businessLogic/             // ビジネスロジック層 (CSVやバリデーション関連)
│   ├── CsvHandler.cs          // CSV関連のビジネスロジック
│   ├── ValidationHandler.cs   // バリデーション関連のロジック
├── dataAccess/                // データアクセス層
│   ├── CsvReader.cs           // CSVファイルの読み込みや書き込み
├── models/                    // モデル層
│   ├── Kenpo31Model.cs        // KENPO31.csv のモデル定義
│   ├── FI_JRK_0004Model.cs    // FI_JRK_0004.csv のモデル定義（FI_JRK_0004 クラスを定義）
└── Program.cs                 // メインエントリーポイント

```