namespace WindowsBanking
{
    partial class BatchProcess
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkProcess = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.radSelect = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.rtxtLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lnkProcess);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.radSelect);
            this.groupBox1.Controls.Add(this.radAll);
            this.groupBox1.Location = new System.Drawing.Point(31, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transmission Selection";
            // 
            // lnkProcess
            // 
            this.lnkProcess.AutoSize = true;
            this.lnkProcess.Location = new System.Drawing.Point(54, 159);
            this.lnkProcess.Name = "lnkProcess";
            this.lnkProcess.Size = new System.Drawing.Size(109, 13);
            this.lnkProcess.TabIndex = 4;
            this.lnkProcess.TabStop = true;
            this.lnkProcess.Text = "Process Transmission";
            this.lnkProcess.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProcess_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Key:";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(481, 65);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '*';
            this.txtKey.Size = new System.Drawing.Size(139, 20);
            this.txtKey.TabIndex = 2;
            // 
            // radSelect
            // 
            this.radSelect.AutoSize = true;
            this.radSelect.Location = new System.Drawing.Point(54, 65);
            this.radSelect.Name = "radSelect";
            this.radSelect.Size = new System.Drawing.Size(128, 17);
            this.radSelect.TabIndex = 1;
            this.radSelect.TabStop = true;
            this.radSelect.Text = "Select a Transmission";
            this.radSelect.UseVisualStyleBackColor = true;
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Location = new System.Drawing.Point(53, 35);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(128, 17);
            this.radAll.TabIndex = 0;
            this.radAll.TabStop = true;
            this.radAll.Text = "Run All Transmissions";
            this.radAll.UseVisualStyleBackColor = true;
            // 
            // rtxtLog
            // 
            this.rtxtLog.Location = new System.Drawing.Point(31, 262);
            this.rtxtLog.Name = "rtxtLog";
            this.rtxtLog.Size = new System.Drawing.Size(706, 264);
            this.rtxtLog.TabIndex = 1;
            this.rtxtLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Transmission Log:";
            // 
            // BatchProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtLog);
            this.Controls.Add(this.groupBox1);
            this.Name = "BatchProcess";
            this.Text = "BatchProcess";
            this.Load += new System.EventHandler(this.BatchProcess_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkProcess;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.RadioButton radSelect;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RichTextBox rtxtLog;
        private System.Windows.Forms.Label label1;
    }
}