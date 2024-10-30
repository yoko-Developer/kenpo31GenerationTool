using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace kenpo31GenerationTool.ui
{

	/// <summary>
	/// データベース接続を行い、テーブル情報を表示するためのフォーム
	/// </summary>
	public partial class DBConnectionForm : Form
	{

		/// <summary>
		/// DBConnectionForm クラスの新しいインスタンスを初期化する
		/// </summary>
		public DBConnectionForm()
		{
			InitializeComponent();
		}

		/// <summary>	
		/// データベースに接続し、テーブル情報をモーダルに表示
		/// </summary>
		private void BtnConnect_Click(object sender, EventArgs e)
		{
			// 確認ダイアログを表示
			var result = MessageBox.Show("接続してよろしいですか？", "接続確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			// 「はい」が選択された場合のみ接続処理を行う	
			if (result == DialogResult.Yes)
			{
				string serverName = txtServerName.Text;
				string databaseName = txtDatabaseName.Text;
				string userId = txtUserId.Text;
				string password = txtPassword.Text;

				// 接続文字列を作成
				string connectionString = $"Server={serverName};Database={databaseName};User Id={userId};Password={password};";

				try
				{
					using (SqlConnection connection = new SqlConnection(connectionString))
					{
						connection.Open();
						MessageBox.Show("データベースに接続されました", "接続成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

						// 各テーブルからデータを取得
						SqlDataAdapter adapterKA11 = new SqlDataAdapter("SELECT * FROM KA11LICH", connection);
						SqlDataAdapter adapterKA12 = new SqlDataAdapter("SELECT * FROM KA12LICF", connection);
						SqlDataAdapter adapterAddress = new SqlDataAdapter("SELECT * FROM KAFIJADL", connection);

						// 各テーブルデータを格納する DataTable を作成
						DataTable tableKA11 = new DataTable();
						DataTable tableKA12 = new DataTable();
						DataTable tableAddress = new DataTable();

						// 各テーブルにデータを読み込み
						adapterKA11.Fill(tableKA11);
						adapterKA12.Fill(tableKA12);
						adapterAddress.Fill(tableAddress);

						// 各テーブルのデータをモーダルフォームで表示
						ShowTableData("KA11LICH", tableKA11);
						ShowTableData("KA12LICF", tableKA12);
						ShowTableData("KAFIJADL", tableAddress);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"接続に失敗しました: {ex.Message}", "接続エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		/// <summary>
		/// 指定されたテーブルのデータを TableDataViewerForm で表示
		/// </summary>
		/// <param name="tableName">表示するテーブルの名前</param>
		/// <param name="tableData">表示するテーブルデータ</param>
		private void ShowTableData(string tableName, DataTable tableData)
		{
			using (var viewerForm = new TableDataViewerForm(tableName, tableData))
			{
				viewerForm.ShowDialog(); // モーダルで表示

			}
		}

		/// <summary>	
		/// 戻るボタンの処理でフォームを閉じて前の画面に戻る	
		/// </summary>
		private void BtnBack_Click(object sender, EventArgs e)
{
			this.Close();
		}

		private void TxtPassword_TextChanged(object sender, EventArgs e)
		{

		}

		private void DBConnectionForm_Load(object sender, EventArgs e)
		{

		}
	}
}
