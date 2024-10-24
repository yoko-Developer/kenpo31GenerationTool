using kenpo31GenerationTool.csvHandling; // CsvReaderの名前空間
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace kenpo31GenerationTool
{
	public partial class Form1 : Form
	{
		private CsvReader csvReader = new CsvReader();
		private DataGridView dataGridView;

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// フォームがロードされたときに呼ばれるイベントハンドラ
		/// </summary>
		private void Form1_Load(object sender, EventArgs e)
		{
			dataGridView = new DataGridView
			{
				// フォーム全体を使う
				Dock = DockStyle.Fill
			};
			this.Controls.Add(dataGridView);

			// 各コンポーネントの配置を設定
			txtFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

			btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;

			btnOK.Anchor = AnchorStyles.Top | AnchorStyles.Right;

			btnConvert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

			// フォームロード時にプレースホルダを設定
			SetPlaceholder();
		}

		/// <summary>
		/// 参照ボタンをクリックした際のイベントハンドラ
		/// </summary>
		private void BtnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog
			{

				Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
				Title = "FI_JRK_0004.csvファイルを選択してください"
			};

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				// 選択したファイルのパスをテキストボックスに表示
				txtFilePath.Text = openFileDialog.FileName;
				// 通常のテキストカラーに戻す
				txtFilePath.ForeColor = System.Drawing.Color.Black;
			}
		}

		/// <summary>
		/// CSVファイルからデータを読み込み、DataGridViewに表示する
		/// </summary>
		/// <param name="records">読み込んだCSVのレコードリスト</param>
		private void DisplayCsvData(List<string[]> records)
		{
			var dataTable = new DataTable();
			if (records.Count > 0)
			{
				// ヘッダー行を追加
				for (int i = 0; i < records[0].Length; i++)
				{
					dataTable.Columns.Add($"Column{i + 1}");
				}

				// データ行を追加
				foreach (var record in records)
				{
					dataTable.Rows.Add(record);
				}
			}
			dataGridView.DataSource = dataTable;
		}


		/// <summary>
		/// OKボタンをクリックした際のイベントハンドラ
		/// </summary>
		private void BtnOk_Click(object sender, EventArgs e)
		{
			// テキストボックスからファイルパスを取得
			string filePath = txtFilePath.Text;

			if (string.IsNullOrWhiteSpace(filePath))
			{
				MessageBox.Show("ファイルパスが指定されていません。参照ボタンでCSVファイルを選択してください。");
				return;
			}

			try
			{
				// CSVファイルを読み込む
				List<string[]> records = csvReader.ReadCsv(filePath);

				// 読み込んだデータをDataGridViewに表示
				DisplayCsvData(records);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"エラーが発生しました: {ex.Message}");
			}

		}

		/// <summary>
		/// 変換開始ボタンをクリックした際のイベントハンドラ
		/// </summary>
		private void BtnConvert_Click(object sender, EventArgs e)
		{
			
			string filePath = txtFilePath.Text;

			if (string.IsNullOrEmpty(filePath) || filePath == "FI_JRK_0004.csv のパスを入力または参照してください")
			{
				MessageBox.Show("CSVファイルのパスを指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				// CSVファイル読み込み
				List<string[]> records = csvReader.ReadCsv(filePath);

				if (records.Count > 0)
				{
					// ヘッダチェック
					string[] expectedHeaders = {
						"要求レコード番号", "個人番号", "照会結果氏名",
						"照会結果生年月日", "照会結果性別コード", "照会結果性別",
						"照会結果住所", "市町村コード", "対象者識別情報",
						"照会処理結果コード", "照会処理結果", "照会結果レコード数",
						"照会結果レコード連番", "異動有無コード", "異動有無",
						"生存状況コード", "生存状況", "変更状況コード",
						"変更状況", "異動事由コード", "異動事由",
						"異動年月日", "照会結果氏名外字数", "照会結果住所外字数",
						"不参加団体対象フラグ", "不参加団体対象要因"
					};
					if (!csvReader.ValidateHeaders(records[0], expectedHeaders))

					{
						MessageBox.Show("CSVファイルのヘッダが不正です。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}

					// バリデーションチェック
					for (int i = 1; i < records.Count; i++) // ヘッダ以外の行をチェック
					{
						if (!csvReader.ValidateRecord(records[i]))
						{
							MessageBox.Show($"レコード {i + 1} でバリデーションエラーが発生しました。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							return;
						}
					}

					// DataGridViewにデータをバインド	
					DisplayCsvData(records);

					MessageBox.Show("CSVファイルの読み込みとバリデーションが成功しました。", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("CSVファイルが空です。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"エラーが発生しました: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// プレースホルダの設定
		/// </summary>
		private void SetPlaceholder()
		{
			if (string.IsNullOrWhiteSpace(txtFilePath.Text))
			{
				txtFilePath.Text = "FI_JRK_0004.csv のパスを入力または参照してください";
				txtFilePath.ForeColor = Color.Gray; // プレースホルダの色
			}
		}

		/// <summary>
		/// テキストボックスにフォーカスが入ったときにプレースホルダをクリア
		/// </summary>
		private void txtFilePath_Enter(object sender, EventArgs e)
		{
			if (txtFilePath.Text == "FI_JRK_0004.csv のパスを入力または参照してください")
			{
				txtFilePath.Text = "";
				txtFilePath.ForeColor = System.Drawing.Color.Black; // 通常のテキストカラーに戻す
			}
		}

		/// <summary>
		/// テキストボックスからフォーカスが外れたときにプレースホルダを再表示
		/// </summary>
		private void txtFilePath_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtFilePath.Text))
			{
				SetPlaceholder(); // プレースホルダを再設定
			}
		}

		private void txtFilePath_TextChanged(object sender, EventArgs e)
		{

		}

		private void lblFilePath_Click(object sender, EventArgs e)
		{

		}
	}

	// ヘルパークラス: CsvRecordをDataTableに変換するメソッドを追加
	public static class Extensions
	{
		public static System.Data.DataTable ConvertToDataTable(this List<string[]> records)
		{
			var dataTable = new System.Data.DataTable();
			// ヘッダー行を追加
			for (int i = 0; i < records[0].Length; i++)
			{
				dataTable.Columns.Add($"Column{i + 1}"); // 列名をColumn1, Column2, ...に設定
			}

			// データ行を追加
			foreach (var record in records)
			{
				dataTable.Rows.Add(record);
			}

			return dataTable;
		}
	}
}
