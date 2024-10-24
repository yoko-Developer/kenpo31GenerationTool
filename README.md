# kenpo31GenerationTool


## レイヤー構成

```
kkenpo31GenerationTool/
├── ui/
│   ├── Form1.cs               // UIのファイル
├── businessLogic/             // ビジネスロジック層 (CSVやバリデーション関連)
│   ├── CsvHandler.cs          // CSV関連のビジネスロジック
│   ├── ValidationHandler.cs   // バリデーション関連のロジック
├── dataAccess/                // データアクセス層
│   ├── CsvReader.cs           // CSVファイルの読み込みや書き込み
│   ├── CsvRecord.cs           // CSVレコードを定義するクラス
├── models/                    // モデル層
│   ├── Kenpo31Model.cs        // KENPO31.csv のモデル定義
│   ├── FI_JRK_0004Model.cs    // FI_JRK_0004.csv のモデル定義（FI_JRK_0004 クラスを定義）
└── Program.cs                 // メインエントリーポイント

```

- CsvRecord
  - 役割：CSVファイルから読み込んだデータを一時的に格納するためのクラス
  - 用途：CSVファイルの1行をレコードとしてマッピングする際に使用
          CSVを読み込む処理（例えば CsvHelper）で主に使用され、CSVの各列をプロパティに対応させる

- FI_JRK_0004Model
  - 役割：アプリケーション全体で利用するためのモデルクラス
          データベースやUI層、ビジネスロジック層で使用される
  - 用途：データを保持し、ビジネスロジックやユーザーインターフェースに渡すときに使う、より洗練されたモデルクラス
          CSVのデータを読み込んだ後、これにマッピングし直して使用する