namespace OCR_ImageToText_Example
{
    partial class BasicForm
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
            this.btnConvertToText = new System.Windows.Forms.Button();
            this.tbInputURL = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtcText = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvertToText
            // 
            this.btnConvertToText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnConvertToText.Location = new System.Drawing.Point(334, 3);
            this.btnConvertToText.Name = "btnConvertToText";
            this.btnConvertToText.Size = new System.Drawing.Size(109, 24);
            this.btnConvertToText.TabIndex = 0;
            this.btnConvertToText.Text = "Convert To Text";
            this.btnConvertToText.UseVisualStyleBackColor = true;
            this.btnConvertToText.Click += new System.EventHandler(this.btnConvertToText_Click);
            // 
            // tbInputURL
            // 
            this.tbInputURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbInputURL.Location = new System.Drawing.Point(3, 3);
            this.tbInputURL.Name = "tbInputURL";
            this.tbInputURL.Size = new System.Drawing.Size(320, 20);
            this.tbInputURL.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.Controls.Add(this.rtcText, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnConvertToText, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbInputURL, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStatus, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 205);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // rtcText
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtcText, 2);
            this.rtcText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtcText.Location = new System.Drawing.Point(3, 63);
            this.rtcText.Name = "rtcText";
            this.rtcText.ReadOnly = true;
            this.rtcText.Size = new System.Drawing.Size(445, 139);
            this.rtcText.TabIndex = 3;
            this.rtcText.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(3, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 30);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Status: ";
            // 
            // BasicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 205);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BasicForm";
            this.Text = "BasicForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConvertToText;
        private System.Windows.Forms.TextBox tbInputURL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox rtcText;
        private System.Windows.Forms.Label lblStatus;
    }
}