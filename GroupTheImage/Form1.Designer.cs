namespace GroupTheImage
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
            this.txtBoxSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDestination = new System.Windows.Forms.TextBox();
            this.btnGetSourcePath = new System.Windows.Forms.Button();
            this.btnGetDestination = new System.Windows.Forms.Button();
            this.lblBasicInfo = new System.Windows.Forms.Label();
            this.chkBoxList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMmove = new System.Windows.Forms.RadioButton();
            this.rbCopy = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxSource
            // 
            this.txtBoxSource.Location = new System.Drawing.Point(28, 38);
            this.txtBoxSource.Name = "txtBoxSource";
            this.txtBoxSource.Size = new System.Drawing.Size(418, 26);
            this.txtBoxSource.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select source path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output destination";
            // 
            // txtBoxDestination
            // 
            this.txtBoxDestination.Location = new System.Drawing.Point(28, 99);
            this.txtBoxDestination.Name = "txtBoxDestination";
            this.txtBoxDestination.Size = new System.Drawing.Size(418, 26);
            this.txtBoxDestination.TabIndex = 2;
            // 
            // btnGetSourcePath
            // 
            this.btnGetSourcePath.Location = new System.Drawing.Point(452, 38);
            this.btnGetSourcePath.Name = "btnGetSourcePath";
            this.btnGetSourcePath.Size = new System.Drawing.Size(75, 26);
            this.btnGetSourcePath.TabIndex = 4;
            this.btnGetSourcePath.Text = "...";
            this.btnGetSourcePath.UseVisualStyleBackColor = true;
            this.btnGetSourcePath.Click += new System.EventHandler(this.btnGetSourcePath_Click);
            // 
            // btnGetDestination
            // 
            this.btnGetDestination.Location = new System.Drawing.Point(452, 99);
            this.btnGetDestination.Name = "btnGetDestination";
            this.btnGetDestination.Size = new System.Drawing.Size(75, 26);
            this.btnGetDestination.TabIndex = 5;
            this.btnGetDestination.Text = "...";
            this.btnGetDestination.UseVisualStyleBackColor = true;
            this.btnGetDestination.Click += new System.EventHandler(this.btnGetDestination_Click);
            // 
            // lblBasicInfo
            // 
            this.lblBasicInfo.AutoSize = true;
            this.lblBasicInfo.Location = new System.Drawing.Point(28, 238);
            this.lblBasicInfo.Name = "lblBasicInfo";
            this.lblBasicInfo.Size = new System.Drawing.Size(37, 18);
            this.lblBasicInfo.TabIndex = 6;
            this.lblBasicInfo.Text = "Info:";
            // 
            // chkBoxList
            // 
            this.chkBoxList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chkBoxList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkBoxList.CheckOnClick = true;
            this.chkBoxList.ColumnWidth = 60;
            this.chkBoxList.FormattingEnabled = true;
            this.chkBoxList.Location = new System.Drawing.Point(28, 197);
            this.chkBoxList.MultiColumn = true;
            this.chkBoxList.Name = "chkBoxList";
            this.chkBoxList.Size = new System.Drawing.Size(496, 21);
            this.chkBoxList.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Choose file types";
            // 
            // rbMmove
            // 
            this.rbMmove.AutoSize = true;
            this.rbMmove.Location = new System.Drawing.Point(31, 136);
            this.rbMmove.Name = "rbMmove";
            this.rbMmove.Size = new System.Drawing.Size(64, 22);
            this.rbMmove.TabIndex = 9;
            this.rbMmove.Text = "Move";
            this.rbMmove.UseVisualStyleBackColor = true;
            this.rbMmove.CheckedChanged += new System.EventHandler(this.rbMmove_CheckedChanged);
            // 
            // rbCopy
            // 
            this.rbCopy.AutoSize = true;
            this.rbCopy.Checked = true;
            this.rbCopy.Location = new System.Drawing.Point(101, 136);
            this.rbCopy.Name = "rbCopy";
            this.rbCopy.Size = new System.Drawing.Size(60, 22);
            this.rbCopy.TabIndex = 10;
            this.rbCopy.TabStop = true;
            this.rbCopy.Text = "Copy";
            this.rbCopy.UseVisualStyleBackColor = true;
            this.rbCopy.CheckedChanged += new System.EventHandler(this.rdCopy_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Group";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbCopy);
            this.Controls.Add(this.rbMmove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkBoxList);
            this.Controls.Add(this.lblBasicInfo);
            this.Controls.Add(this.btnGetDestination);
            this.Controls.Add(this.btnGetSourcePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxDestination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxSource);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Group it";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDestination;
        private System.Windows.Forms.Button btnGetSourcePath;
        private System.Windows.Forms.Button btnGetDestination;
        private System.Windows.Forms.Label lblBasicInfo;
        private System.Windows.Forms.CheckedListBox chkBoxList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMmove;
        private System.Windows.Forms.RadioButton rbCopy;
        private System.Windows.Forms.Button button1;
    }
}

