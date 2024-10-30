using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kenpo31GenerationTool.ui
{

	/// <summary>
	/// 各テーブルデータを表示するためのモーダルフォーム
	/// </summary>
	public partial class TableDataViewerForm : Form
	{
		private TabControl tabControl;
		/// <summary>
		/// 指定されたテーブルデータを表示するフォームのコンストラクタ
		/// </summary>
		/// <param name="tableNKA11">被保険者のデータテーブル</param>
		/// <param name="tableKA12">被扶養者のデータテーブル</param>
		/// <param name="tableAddress">住民票住所管理のデータテーブル</param>
		public TableDataViewerForm(DataTable tableKA11, DataTable tableKA12, DataTable tableAddress)
		{
			InitializeComponent();
			
			// フォームのタイトル設定
			this.Text = "データベーステーブルのデータ表示";

			// TabControlの設定
			tabControl = new TabControl
			{
				// フォーム全体に展開
				Dock = DockStyle.Fill
			};

			this.Controls.Add(tabControl);

			// 各テーブルに対するタブを追加
			AddTabWithData("KA11 - 被保険者", tableKA11);
			AddTabWithData("KA12 - 被扶養者", tableKA12);
			AddTabWithData("住所管理", tableAddress);
		}

		/// <summary>
		/// 各テーブルを表示するタブを追加
		/// </summary>
		/// <param name="tableName">タブの名前</param>
		/// <param name="tableData">表示するテーブルのデータ</param>
		private void AddTabWithData(string tableName, DataTable tableData)
		{
			var tabPage = new TabPage(tableName);
			var dataGridView = new DataGridView
			{
				Dock = DockStyle.Fill,
				DataSource = tableData,
				AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
			};
			tabPage.Controls.Add(dataGridView);
			tabControl.TabPages.Add(tabPage);
		}

		private void TableDataViewerForm_Load(object sender, EventArgs e)
		{

		}
	}
}