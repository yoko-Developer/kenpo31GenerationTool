using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using kenpo31GenerationTool.csvHandling; // CsvReaderの名前空間

namespace kenpo31GenerationTool
{
	public partial class Form1 : Form
	{
		private CsvReader csvReader = new CsvReader();

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// フォームがロードされたときに呼ばれるイベントハンドラ
		/// </summary>
		private void Form1_Load(object sender, EventArgs e)
		{
			// 必要に応じて初期化処理を追加
			txtFilePath.Text = "FI_JRK_0004.csv のパスを入力または参照してください";
			txtFilePath.ForeColor = System.Drawing.Color.Gray;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void TxtFilePath_TextChanged(object sender, EventArgs e)
		{
			// テキストが変更されたときに必要な処理をここに追加
			// 例えば、入力されたファイルパスのバリデーションなど
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
				// 通常のテキストカラーに戻す
				txtFilePath.ForeColor = System.Drawing.Color.Black;
			}
		}

		/// <summary>
		/// 変換開始ボタンをクリックした際のイベントハンドラ
		/// </summary>
		private void btnConvert_Click(object sender, EventArgs e)
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
					string[] expectedHeaders = { "要求レコード番号", "個人番号", "照会結果氏名" /* ... 他のヘッダ ... */ };
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
		/// テキストボックスからフォーカスが外れたときにプレースホルダを表示
		/// </summary>
		private void txtFilePath_Leave(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtFilePath.Text))
			{
				txtFilePath.Text = "FI_JRK_0004.csv のパスを入力または参照してください";
				txtFilePath.ForeColor = System.Drawing.Color.Gray; // プレースホルダ用のグレー色にする
			}
		}
	}
}
