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
		/// UIコンポーネントの初期化
		/// </summary>
		private void InitializeComponent()
		{
			this.txtFilePath = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnConvert = new System.Windows.Forms.Button();
			this.lblFilePath = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtFilePath
			// 
			this.txtFilePath.ForeColor = System.Drawing.Color.Gray;
			this.txtFilePath.Location = new System.Drawing.Point(10, 23);
			this.txtFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtFilePath.Name = "txtFilePath";
			this.txtFilePath.Size = new System.Drawing.Size(301, 19);
			this.txtFilePath.TabIndex = 0;
			this.txtFilePath.Text = "FI_JRK_0004.csv のパスを入力または参照してください";
			this.txtFilePath.TextChanged += new System.EventHandler(this.TxtFilePath_TextChanged);
			this.txtFilePath.Enter += new System.EventHandler(this.txtFilePath_Enter);
			this.txtFilePath.Leave += new System.EventHandler(this.txtFilePath_Leave);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(326, 23);
			this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(64, 18);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "参照";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(10, 56);
			this.btnConvert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(380, 18);
			this.btnConvert.TabIndex = 2;
			this.btnConvert.Text = "変換開始";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// lblFilePath
			// 
			this.lblFilePath.AutoSize = true;
			this.lblFilePath.Location = new System.Drawing.Point(10, 7);
			this.lblFilePath.Name = "lblFilePath";
			this.lblFilePath.Size = new System.Drawing.Size(139, 13);
			this.lblFilePath.TabIndex = 3;
			this.lblFilePath.Text = "FI_JRK_0004.csv ファイル";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 96);
			this.Controls.Add(this.lblFilePath);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtFilePath);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "KENPO31 ファイル変換ツール";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
