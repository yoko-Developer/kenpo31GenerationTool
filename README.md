# kenpo31GenerationTool


## レイヤー構成

```
kenpo31GenerationTool/
├── ui/
│   ├── Form1.cs                // UIファイル（CSV操作やデータベース連携の開始地点）
├── businessLogic/               // ビジネスロジック層
│   ├── CsvHandler.cs           // CSV関連のビジネスロジック
│   ├── ValidationHandler.cs    // バリデーション関連のロジック
│   ├── DataService.cs          // データベース操作のビジネスロジック
├── dataAccess/                  // データアクセス層
│   ├── CsvReader.cs            // CSVファイルの読み込み
│   ├── CsvRecord.cs            // CSVレコードのクラス定義
│   ├── DatabaseConnection.cs   // SQL Server接続処理
│   ├── SqlQueries.cs           // SQLクエリの管理
├── models/                      // モデル層
│   ├── Kenpo31Model.cs         // KENPO31.csv のモデル定義
│   ├── FI_JRK_0004Model.cs     // FI_JRK_0004.csv のモデル定義
│   ├── DatabaseModels.cs       // KA11LICH, KA14HFUY, KA22ADLK のテーブルモデル
└── Program.cs                   // エントリーポイント


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

- Form1
　ユーザーインターフェース（UI）として動作し、CSVファイルのパス入力や、データの表示などの機能を提供する
　CsvReaderクラスを使ってファイルを読み込み、そのデータを DisplayCsvData メソッドで表示する

- CsvReader
  CSVファイルの読み込みを担当
  ReadCsv メソッドは、CSVデータを読み込んで List<string[]> 型で返す
  List<string[]> で返すため、各行が string[] 形式で格納されるリストとして扱われる

- FI_JRK_0004Model
  CSVデータをオブジェクトとして扱う





