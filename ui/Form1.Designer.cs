namespace kenpo31GenerationTool
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtFilePath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.Label lblFilePath;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		/// <summary>
		/// コンポーネントの初期化
		/// </summary>
		private void InitializeComponent()
		{
			this.txtFilePath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnConvert = new System.Windows.Forms.Button();
			this.lblFilePath = new System.Windows.Forms.Label();
			this.SuspendLayout();

			// txtFilePath
			this.txtFilePath.Location = new System.Drawing.Point(12, 29);
			this.txtFilePath.Name = "txtFilePath";
			this.txtFilePath.Size = new System.Drawing.Size(260, 20);
			this.txtFilePath.TabIndex = 0;

			// btnBrowse
			this.btnBrowse.Location = new System.Drawing.Point(278, 27);
			this.btnBrowse.Name = "btnBrowswe";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

			// btnConvert
			this.btnConvert.Location = new System.Drawing.Point(12, 60);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(75, 23);
			this.btnConvert.TabIndex = 2;
			this.btnConvert.Text = "変換開始";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);

			// lblFilePath
			this.lblFilePath.AutoSize = true;
			this.lblFilePath.Location = new System.Drawing.Point(12, 9);
			this.lblFilePath.Name = "lblFilePath";
			this.lblFilePath.Size = new System.Drawing.Size(109, 13);
			this.lblFilePath.TabIndex = 3;
			this.lblFilePath.Text = "FI_JRK_0004.csvのパス";

			// Form1
			this.ClientSize = new System.Drawing.Size(365, 101);
			this.Controls.Add(this.lblFilePath);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtFilePath);
			this.Name = "Form1";
			this.Text = "FI_JRK_0004.csv読み込みツール";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}

