using System;
using System.Data;
using System.Drawing;
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
		/// <param name="tableKA11">被保険者のデータテーブル</param>
		/// <param name="tableKA12">被扶養者のデータテーブル</param>
		/// <param name="tableAddress">住民票住所管理のデータテーブル</param>
		public TableDataViewerForm(DataTable tableKA11, DataTable tableKA12, DataTable tableAddress)
		{
			InitializeComponent();

			// フォームのタイトル設定
			this.Text = "テーブル情報";

			// TabControlの設定
			tabControl = new TabControl
			{
				Dock = DockStyle.Fill,
				DrawMode = TabDrawMode.OwnerDrawFixed // カスタム描画モードを設定
			};

			// DrawItemイベントハンドラを追加
			tabControl.DrawItem += TabControl_DrawItem;

			this.Controls.Add(tabControl);

			// 各テーブルに対するタブを追加
			AddTabWithData("KA11LICH：被保険者", tableKA11);
			AddTabWithData("KA12LICF：被扶養者", tableKA12);
			AddTabWithData("KAFIJADL：住民票住所管理", tableAddress);
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

		/// <summary>
		/// タブのカスタム描画を行う
		/// </summary>
		private void TabControl_DrawItem(object sender, DrawItemEventArgs e)
		{
			var tabPage = tabControl.TabPages[e.Index];
			var tabRect = tabControl.GetTabRect(e.Index);

			// タブの背景色を淡いピンクに設定
			using (Brush brush = new SolidBrush(Color.FromArgb(255, 192, 255)))
			{
				e.Graphics.FillRectangle(brush, tabRect);
			}

			// タブのテキストを描画
			TextRenderer.DrawText(
				e.Graphics,
				tabPage.Text,
				e.Font,
				tabRect,
				Color.Black,
				TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
			);
		}

		private void TableDataViewerForm_Load(object sender, EventArgs e)
		{
		}
	}
}
