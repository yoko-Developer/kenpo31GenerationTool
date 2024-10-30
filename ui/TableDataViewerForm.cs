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
		private DataGridView dataGridViewTable;
		/// <summary>
		/// 指定されたテーブルデータを表示するためのコンストラクタ
		/// </summary>
		/// <param name="tableName">テーブル名</param>
		/// <param name="tableData">表示するテーブルのデータ</param>
		public TableDataViewerForm(string tableName, DataTable tableData)
		{
			InitializeComponent();
			this.Text = $"{tableName} のデータ";
			// dataGridViewTableの設定
			dataGridViewTable = new DataGridView
			{
				Dock = DockStyle.Fill, // フォーム全体に展開
				DataSource = tableData,
				AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
			};

			this.Controls.Add(dataGridViewTable);
		}

		private void TableDataViewerForm_Load(object sender, EventArgs e)
		{

		}
	}
}