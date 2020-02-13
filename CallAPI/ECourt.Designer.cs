namespace CallAPI
{
    partial class ECourt
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
            this.btnCallApi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DateNotice = new System.Windows.Forms.DateTimePicker();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCallApi
            // 
            this.btnCallApi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCallApi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCallApi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCallApi.Location = new System.Drawing.Point(24, 76);
            this.btnCallApi.Name = "btnCallApi";
            this.btnCallApi.Size = new System.Drawing.Size(458, 34);
            this.btnCallApi.TabIndex = 0;
            this.btnCallApi.Text = "Submit";
            this.btnCallApi.UseVisualStyleBackColor = false;
            this.btnCallApi.Click += new System.EventHandler(this.btnCallApi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date: ";
            // 
            // DateNotice
            // 
            this.DateNotice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNotice.Location = new System.Drawing.Point(24, 40);
            this.DateNotice.Name = "DateNotice";
            this.DateNotice.Size = new System.Drawing.Size(458, 27);
            this.DateNotice.TabIndex = 2;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(24, 146);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(458, 27);
            this.txtFilePath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "File saved at:";
            // 
            // ECourt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 206);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.DateNotice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCallApi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ECourt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E Court";
            this.Load += new System.EventHandler(this.ECourt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCallApi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateNotice;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label2;
    }
}

