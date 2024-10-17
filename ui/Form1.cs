using System;
using System.Collections.Generic;
using System.Windows.Forms;
using kenpo31GenerationTool.csvHandling; // CsvReaderの名前空間

namespace kenpo31GenerationTool
{
	public partial class Form1 : Form
	{
		private CsvReader csvReader = new CsvReader();  // CsvReaderのインスタンス

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// ファイル選択ボタンをクリックした際のイベントハンドラ
		/// </summary>
		private void btnBrowse_Click(object sender, EventArgs e)
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
			}
		}

		/// <summary>
		/// 変換開始ボタンをクリックした際のイベントハンドラ
		/// </summary>
		private void btnConvert_Click(object sender, EventArgs e)
		{
			string filePath = txtFilePath.Text;

			if (string.IsNullOrEmpty(filePath))
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
					string[] expectedHeaders = { "要求レコード番号", "個人番号", "照会結果氏名", "照会結果氏名かな", "照会結果生年月日", "照会結果性別コード", "照会結果住所", "市町村コード", "対象者識別情報" };
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
	}
}
