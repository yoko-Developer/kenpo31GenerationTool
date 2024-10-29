namespace kenpo31GenerationTool.ui
{
	partial class DBConnectionForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.labelTitle = new System.Windows.Forms.Label();
			this.labelServerName = new System.Windows.Forms.Label();
			this.txtServerName = new System.Windows.Forms.TextBox();
			this.labelDatabaseName = new System.Windows.Forms.Label();
			this.txtDatabaseName = new System.Windows.Forms.TextBox();
			this.labelUserId = new System.Windows.Forms.Label();
			this.txtUserId = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.SuspendLayout();

			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelTitle.Location = new System.Drawing.Point(10, 10);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(145, 20);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "データベース接続設定";
			this.labelTitle.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left);

			// 
			// labelServerName
			// 
			this.labelServerName.AutoSize = true;
			this.labelServerName.Location = new System.Drawing.Point(10, 40);
			this.labelServerName.Name = "labelServerName";
			this.labelServerName.Size = new System.Drawing.Size(85, 13);
			this.labelServerName.TabIndex = 1;
			this.labelServerName.Text = "サーバ名";

			// 
			// txtServerName
			// 
			this.txtServerName.Location = new System.Drawing.Point(100, 37);
			this.txtServerName.Name = "txtServerName";
			this.txtServerName.Size = new System.Drawing.Size(200, 20);
			this.txtServerName.TabIndex = 2;
			this.txtServerName.Text = "KW21SVR";
			this.txtServerName.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

			// 
			// labelDatabaseName
			// 
			this.labelDatabaseName.AutoSize = true;
			this.labelDatabaseName.Location = new System.Drawing.Point(10, 80);
			this.labelDatabaseName.Name = "labelDatabaseName";
			this.labelDatabaseName.Size = new System.Drawing.Size(85, 13);
			this.labelDatabaseName.TabIndex = 3;
			this.labelDatabaseName.Text = "データベース名";

			// 
			// txtDatabaseName
			// 
			this.txtDatabaseName.Location = new System.Drawing.Point(100, 77);
			this.txtDatabaseName.Name = "txtDatabaseName";
			this.txtDatabaseName.Size = new System.Drawing.Size(200, 20);
			this.txtDatabaseName.TabIndex = 4;
			this.txtDatabaseName.Text = "kw21";
			this.txtDatabaseName.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

			// 
			// labelUserId
			// 
			this.labelUserId.AutoSize = true;
			this.labelUserId.Location = new System.Drawing.Point(10, 120);
			this.labelUserId.Name = "labelUserId";
			this.labelUserId.Size = new System.Drawing.Size(85, 13);
			this.labelUserId.TabIndex = 5;
			this.labelUserId.Text = "ユーザID";

			// 
			// txtUserId
			// 
			this.txtUserId.Location = new System.Drawing.Point(100, 117);
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.Size = new System.Drawing.Size(200, 20);
			this.txtUserId.TabIndex = 6;
			this.txtUserId.Text = "sa";
			this.txtUserId.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(10, 160);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(85, 13);
			this.labelPassword.TabIndex = 7;
			this.labelPassword.Text = "パスワード";

			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(100, 157);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(200, 20);
			this.txtPassword.TabIndex = 8;
			this.txtPassword.UseSystemPasswordChar = true;
			this.txtPassword.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);

			//
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(100, 200);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 23);
			this.btnConnect.TabIndex = 9;
			this.btnConnect.Text = "接続";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
			this.btnConnect.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);

			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(200, 200);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 23);
			this.btnBack.TabIndex = 10;
			this.btnBack.Text = "戻る";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
			this.btnBack.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);

			// 
			// DBConnectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(320, 240);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.txtUserId);
			this.Controls.Add(this.labelUserId);
			this.Controls.Add(this.txtDatabaseName);
			this.Controls.Add(this.labelDatabaseName);
			this.Controls.Add(this.txtServerName);
			this.Controls.Add(this.labelServerName);
			this.Controls.Add(this.labelTitle);
			this.Name = "DBConnectionForm";
			this.Text = "データベース接続";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.Label labelServerName;
		private System.Windows.Forms.TextBox txtServerName;
		private System.Windows.Forms.Label labelDatabaseName;
		private System.Windows.Forms.TextBox txtDatabaseName;
		private System.Windows.Forms.Label labelUserId;
		private System.Windows.Forms.TextBox txtUserId;
		private System.Windows.Forms.Label labelPassword;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.Button btnBack;
	}
}
