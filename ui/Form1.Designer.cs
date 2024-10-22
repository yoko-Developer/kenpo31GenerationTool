﻿using System;
using System.Windows.Forms;
using System.Drawing; // Colorクラスを使用

namespace kenpo31GenerationTool
{
	partial class Form1
	{
		// フォームで使用するコンポーネント
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtFilePath;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.Label lblFilePath;
		private System.Windows.Forms.Button btnOK;

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
			this.btnOK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtFilePath
			// 
			this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFilePath.ForeColor = System.Drawing.Color.Gray;
			this.txtFilePath.Location = new System.Drawing.Point(22, 21);
			this.txtFilePath.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
			this.txtFilePath.Name = "txtFilePath";
			this.txtFilePath.Size = new System.Drawing.Size(547, 28);
			this.txtFilePath.TabIndex = 0;
			this.txtFilePath.Text = "FI_JRK_0004.csv のパスを入力または参照してください";
			this.txtFilePath.Enter += new System.EventHandler(this.txtFilePath_Enter);
			this.txtFilePath.Leave += new System.EventHandler(this.txtFilePath_Leave);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(587, 18);
			this.btnBrowse.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(138, 40);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "参照";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
			// 
			// btnConvert
			// 
			this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnConvert.Location = new System.Drawing.Point(22, 98);
			this.btnConvert.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(849, 40);
			this.btnConvert.TabIndex = 3;
			this.btnConvert.Text = "変換開始";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// lblFilePath
			// 
			this.lblFilePath.AutoSize = true;
			this.lblFilePath.Location = new System.Drawing.Point(22, 68);
			this.lblFilePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblFilePath.Name = "lblFilePath";
			this.lblFilePath.Size = new System.Drawing.Size(219, 21);
			this.lblFilePath.TabIndex = 4;
			this.lblFilePath.Text = "FI_JRK_0004.csv ファイル";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(733, 18);
			this.btnOK.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(138, 40);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1578, 665);
			this.Controls.Add(this.lblFilePath);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txtFilePath);
			this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
			this.Name = "Form1";
			this.Text = "KENPO31 ファイル変換ツール";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
