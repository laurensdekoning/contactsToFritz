namespace ContactsToFritzBox
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbInputFile = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectInputFile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSelectInputFile = new System.Windows.Forms.Label();
            this.dlgOpenInputFile = new System.Windows.Forms.OpenFileDialog();
            this.gbDestinationFile = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSelectOutputFile = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dlgSaveOutputFile = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.gbInputFile.SuspendLayout();
            this.gbDestinationFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(631, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // gbInputFile
            // 
            this.gbInputFile.Controls.Add(this.radioButton2);
            this.gbInputFile.Controls.Add(this.radioButton1);
            this.gbInputFile.Controls.Add(this.label2);
            this.gbInputFile.Controls.Add(this.btnSelectInputFile);
            this.gbInputFile.Controls.Add(this.textBox1);
            this.gbInputFile.Controls.Add(this.lblSelectInputFile);
            this.gbInputFile.Location = new System.Drawing.Point(4, 27);
            this.gbInputFile.Name = "gbInputFile";
            this.gbInputFile.Size = new System.Drawing.Size(627, 117);
            this.gbInputFile.TabIndex = 1;
            this.gbInputFile.TabStop = false;
            this.gbInputFile.Text = "Source";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(166, 24);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(62, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "Outlook";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(107, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Google";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Set input type:";
            // 
            // btnSelectInputFile
            // 
            this.btnSelectInputFile.Location = new System.Drawing.Point(546, 64);
            this.btnSelectInputFile.Name = "btnSelectInputFile";
            this.btnSelectInputFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectInputFile.TabIndex = 2;
            this.btnSelectInputFile.Text = "&Browse";
            this.btnSelectInputFile.UseVisualStyleBackColor = true;
            this.btnSelectInputFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(521, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblSelectInputFile
            // 
            this.lblSelectInputFile.AutoSize = true;
            this.lblSelectInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectInputFile.Location = new System.Drawing.Point(6, 50);
            this.lblSelectInputFile.Name = "lblSelectInputFile";
            this.lblSelectInputFile.Size = new System.Drawing.Size(100, 13);
            this.lblSelectInputFile.TabIndex = 0;
            this.lblSelectInputFile.Text = "Select input file:";
            // 
            // dlgOpenInputFile
            // 
            this.dlgOpenInputFile.Filter = "Comma-Seperated Value File (*.csv)|*.csv";
            // 
            // gbDestinationFile
            // 
            this.gbDestinationFile.Controls.Add(this.button3);
            this.gbDestinationFile.Controls.Add(this.btnSelectOutputFile);
            this.gbDestinationFile.Controls.Add(this.textBox2);
            this.gbDestinationFile.Location = new System.Drawing.Point(0, 150);
            this.gbDestinationFile.Name = "gbDestinationFile";
            this.gbDestinationFile.Size = new System.Drawing.Size(631, 136);
            this.gbDestinationFile.TabIndex = 2;
            this.gbDestinationFile.TabStop = false;
            this.gbDestinationFile.Text = "Destination";
            // 
            // button3
            // 
            this.button3.Image = global::ContactsToFritzBox.Properties.Resources.export_icon1;
            this.button3.Location = new System.Drawing.Point(7, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(618, 64);
            this.button3.TabIndex = 5;
            this.button3.Text = "&Convert";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSelectOutputFile
            // 
            this.btnSelectOutputFile.Location = new System.Drawing.Point(550, 23);
            this.btnSelectOutputFile.Name = "btnSelectOutputFile";
            this.btnSelectOutputFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectOutputFile.TabIndex = 4;
            this.btnSelectOutputFile.Text = "B&rowse";
            this.btnSelectOutputFile.UseVisualStyleBackColor = true;
            this.btnSelectOutputFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(521, 20);
            this.textBox2.TabIndex = 3;
            // 
            // dlgSaveOutputFile
            // 
            this.dlgSaveOutputFile.Filter = "Fritz-Box Phonebookfile (*.xml)|*.xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 299);
            this.Controls.Add(this.gbDestinationFile);
            this.Controls.Add(this.gbInputFile);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ContactsToFritzBox v0.1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbInputFile.ResumeLayout(false);
            this.gbInputFile.PerformLayout();
            this.gbDestinationFile.ResumeLayout(false);
            this.gbDestinationFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbInputFile;
        private System.Windows.Forms.Button btnSelectInputFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblSelectInputFile;
        private System.Windows.Forms.OpenFileDialog dlgOpenInputFile;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDestinationFile;
        private System.Windows.Forms.Button btnSelectOutputFile;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.SaveFileDialog dlgSaveOutputFile;
        private System.Windows.Forms.Button button3;
    }
}

