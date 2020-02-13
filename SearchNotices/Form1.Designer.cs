namespace SearchNotices
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label2 = new System.Windows.Forms.Label();
			this.txtFilePath = new System.Windows.Forms.TextBox();
			this.DateNotice = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCallApi = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(52, 216);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 29);
			this.label2.TabIndex = 9;
			this.label2.Text = "File saved at:";
			// 
			// txtFilePath
			// 
			this.txtFilePath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFilePath.Location = new System.Drawing.Point(52, 250);
			this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtFilePath.Name = "txtFilePath";
			this.txtFilePath.ReadOnly = true;
			this.txtFilePath.Size = new System.Drawing.Size(685, 37);
			this.txtFilePath.TabIndex = 8;
			// 
			// DateNotice
			// 
			this.DateNotice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateNotice.Location = new System.Drawing.Point(52, 87);
			this.DateNotice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DateNotice.Name = "DateNotice";
			this.DateNotice.Size = new System.Drawing.Size(685, 37);
			this.DateNotice.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 59);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 29);
			this.label1.TabIndex = 6;
			this.label1.Text = "Date: ";
			// 
			// btnCallApi
			// 
			this.btnCallApi.BackColor = System.Drawing.SystemColors.Highlight;
			this.btnCallApi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCallApi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCallApi.Location = new System.Drawing.Point(52, 142);
			this.btnCallApi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnCallApi.Name = "btnCallApi";
			this.btnCallApi.Size = new System.Drawing.Size(687, 52);
			this.btnCallApi.TabIndex = 5;
			this.btnCallApi.Text = "Submit";
			this.btnCallApi.UseVisualStyleBackColor = false;
			this.btnCallApi.Click += new System.EventHandler(this.btnCallApi_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(745, 241);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 52);
			this.button1.TabIndex = 10;
			this.button1.Text = "View";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(848, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtFilePath);
			this.Controls.Add(this.DateNotice);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCallApi);
			this.Name = "Form1";
			this.Text = "Search Notices";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtFilePath;
		private System.Windows.Forms.DateTimePicker DateNotice;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCallApi;
		private System.Windows.Forms.Button button1;
	}
}

