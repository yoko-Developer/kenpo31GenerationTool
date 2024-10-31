using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
		/// データベースに接続し、必要なテーブル情報を取得して表示
		/// </summary>
		private void BtnConnect_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("接続してよろしいですか？", "接続確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				string serverName = txtServerName.Text;
				string databaseName = txtDatabaseName.Text;
				string userId = txtUserId.Text;
				string password = txtPassword.Text;

				string connectionString = $"Server={serverName};Database={databaseName};User Id={userId};Password={password};";

				try
				{
					using (SqlConnection connection = new SqlConnection(connectionString))
					{
						connection.Open();

						// 各テーブルから必要なデータを取得するクエリ
						string queryKA11 = "SELECT KOJINID, SHAINCOD AS 社員コード FROM KA11LICH";
						string queryKA14 = "SELECT KOJINID, ZOKUGARA AS 続柄コード, SEIBETU AS 性別コード, BIRTHDAY AS 生年月日 FROM KA14HFUY";
						string queryAddress = "SELECT KOJINID, EMAIL AS メールアドレス FROM KA13HHKN";

						// 各テーブルのデータを取得
						DataTable tableKA11 = GetData(connection, queryKA11);
						DataTable tableKA14 = GetData(connection, queryKA14);
						DataTable tableAddress = GetData(connection, queryAddress);

						// タブで表示するためにモーダルフォームを生成
						TableDataViewerForm tableViewerForm = new TableDataViewerForm(tableKA11, tableKA14, tableAddress);
						tableViewerForm.ShowDialog();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show($"接続に失敗しました: {ex.Message}", "接続エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		/// <summary>
		/// データを取得するヘルパーメソッド
		/// </summary>
		private DataTable GetData(SqlConnection connection, string query)
		{
			using (SqlCommand command = new SqlCommand(query, connection))
			using (SqlDataAdapter adapter = new SqlDataAdapter(command))
			{
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				return dataTable;
			}
		}

		/// <summary>	
		/// 戻るボタンの処理でフォームを閉じて前の画面に戻る	
		/// </summary>
		private void BtnBack_Click(object sender, EventArgs e)
		{
					this.Close();
				}

				private void DBConnectionForm_Load(object sender, EventArgs e)
				{
			}
		}
	}
