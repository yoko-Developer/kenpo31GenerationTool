using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kenpo31GenerationTool.ui
{
	public partial class DBConnectionForm : Form
	{
		public DBConnectionForm()
		{
			InitializeComponent();
		}

		private void BtnConnect_Click(object sender, EventArgs e)
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
					MessageBox.Show("データベースに接続されました！", "接続成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"接続に失敗しました: {ex.Message}", "接続エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnBack_Click(object sender, EventArgs e)
		{
			// 戻るボタンの処理をここに追加
			this.Close();
		}
	}
}
