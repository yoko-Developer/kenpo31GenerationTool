namespace kenpo31GenerationTool.ui
{
	partial class DBConnectionForm
	{

		private System.Windows.Forms.DataGridView dataGridViewKA11;
		private System.Windows.Forms.DataGridView dataGridViewKA12;
		private System.Windows.Forms.DataGridView dataGridViewAddress;

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
			this.dataGridViewKA11 = new System.Windows.Forms.DataGridView();
			this.dataGridViewKA12 = new System.Windows.Forms.DataGridView();
			this.dataGridViewAddress = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKA11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKA12)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddress)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.labelTitle.Location = new System.Drawing.Point(10, 9);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(268, 32);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "データベース接続設定";
			// 
			// labelServerName
			// 
			this.labelServerName.AutoSize = true;
			this.labelServerName.Location = new System.Drawing.Point(10, 57);
			this.labelServerName.Name = "labelServerName";
			this.labelServerName.Size = new System.Drawing.Size(53, 13);
			this.labelServerName.TabIndex = 1;
			this.labelServerName.Text = "サーバ名";
			// 
			// txtServerName
			// 
			this.txtServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtServerName.Location = new System.Drawing.Point(100, 54);
			this.txtServerName.Name = "txtServerName";
			this.txtServerName.Size = new System.Drawing.Size(370, 19);
			this.txtServerName.TabIndex = 2;
			this.txtServerName.Text = "KW21SVR";
			// 
			// labelDatabaseName
			// 
			this.labelDatabaseName.AutoSize = true;
			this.labelDatabaseName.Location = new System.Drawing.Point(10, 94);
			this.labelDatabaseName.Name = "labelDatabaseName";
			this.labelDatabaseName.Size = new System.Drawing.Size(83, 13);
			this.labelDatabaseName.TabIndex = 3;
			this.labelDatabaseName.Text = "データベース名";
			// 
			// txtDatabaseName
			// 
			this.txtDatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDatabaseName.Location = new System.Drawing.Point(100, 91);
			this.txtDatabaseName.Name = "txtDatabaseName";
			this.txtDatabaseName.Size = new System.Drawing.Size(370, 19);
			this.txtDatabaseName.TabIndex = 4;
			this.txtDatabaseName.Text = "kw21";
			// 
			// labelUserId
			// 
			this.labelUserId.AutoSize = true;
			this.labelUserId.Location = new System.Drawing.Point(10, 131);
			this.labelUserId.Name = "labelUserId";
			this.labelUserId.Size = new System.Drawing.Size(51, 13);
			this.labelUserId.TabIndex = 5;
			this.labelUserId.Text = "ユーザID";
			// 
			// txtUserId
			// 
			this.txtUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUserId.Location = new System.Drawing.Point(100, 128);
			this.txtUserId.Name = "txtUserId";
			this.txtUserId.Size = new System.Drawing.Size(370, 19);
			this.txtUserId.TabIndex = 6;
			this.txtUserId.Text = "sa";
			// 
			// labelPassword
			// 
			this.labelPassword.AutoSize = true;
			this.labelPassword.Location = new System.Drawing.Point(10, 168);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(58, 13);
			this.labelPassword.TabIndex = 7;
			this.labelPassword.Text = "パスワード";
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword.Location = new System.Drawing.Point(100, 165);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(370, 19);
			this.txtPassword.TabIndex = 8;
			this.txtPassword.UseSystemPasswordChar = true;
//			this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
			// 
			// btnConnect
			// 
			this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnConnect.Location = new System.Drawing.Point(100, 320);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(75, 21);
			this.btnConnect.TabIndex = 9;
			this.btnConnect.Text = "接続";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
			// 
			// btnBack
			// 
			this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBack.Location = new System.Drawing.Point(370, 320);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(75, 21);
			this.btnBack.TabIndex = 10;
			this.btnBack.Text = "戻る";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
			// 
			// dataGridViewKA11
			// 
			this.dataGridViewKA11.ColumnHeadersHeight = 40;
			this.dataGridViewKA11.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewKA11.Name = "dataGridViewKA11";
			this.dataGridViewKA11.RowHeadersWidth = 72;
			this.dataGridViewKA11.Size = new System.Drawing.Size(240, 150);
			this.dataGridViewKA11.TabIndex = 0;
			// 
			// dataGridViewKA12
			// 
			this.dataGridViewKA12.ColumnHeadersHeight = 40;
			this.dataGridViewKA12.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewKA12.Name = "dataGridViewKA12";
			this.dataGridViewKA12.RowHeadersWidth = 72;
			this.dataGridViewKA12.Size = new System.Drawing.Size(240, 150);
			this.dataGridViewKA12.TabIndex = 0;
			// 
			// dataGridViewAddress
			// 
			this.dataGridViewAddress.ColumnHeadersHeight = 40;
			this.dataGridViewAddress.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewAddress.Name = "dataGridViewAddress";
			this.dataGridViewAddress.RowHeadersWidth = 72;
			this.dataGridViewAddress.Size = new System.Drawing.Size(240, 150);
			this.dataGridViewAddress.TabIndex = 0;
			// 
			// DBConnectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 357);
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
			this.Load += new System.EventHandler(this.DBConnectionForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKA11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewKA12)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddress)).EndInit();
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
