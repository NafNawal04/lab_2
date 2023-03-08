namespace _210042130_lab05
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FN1_label = new System.Windows.Forms.Label();
            this.FT_label = new System.Windows.Forms.Label();
            this.FC_label = new System.Windows.Forms.Label();
            this.FN1_textBox = new System.Windows.Forms.TextBox();
            this.FC_textBox = new System.Windows.Forms.TextBox();
            this.FT_comboBox = new System.Windows.Forms.ComboBox();
            this.AddFile_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FN2_textBox = new System.Windows.Forms.TextBox();
            this.Remove_button = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.FN3_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Update_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.FN4_label = new System.Windows.Forms.Label();
            this.Content_label = new System.Windows.Forms.Label();
            this.AF_label = new System.Windows.Forms.Label();
            this.FN3_textBox = new System.Windows.Forms.TextBox();
            this.SC_textBox = new System.Windows.Forms.TextBox();
            this.NC_textBox = new System.Windows.Forms.TextBox();
            this.Content_textBox = new System.Windows.Forms.TextBox();
            this.FN4_textBox = new System.Windows.Forms.TextBox();
            this.View_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 147);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FN1_label
            // 
            this.FN1_label.AutoSize = true;
            this.FN1_label.Location = new System.Drawing.Point(20, 27);
            this.FN1_label.Name = "FN1_label";
            this.FN1_label.Size = new System.Drawing.Size(84, 20);
            this.FN1_label.TabIndex = 1;
            this.FN1_label.Text = "File Name:";
            // 
            // FT_label
            // 
            this.FT_label.AutoSize = true;
            this.FT_label.Location = new System.Drawing.Point(20, 58);
            this.FT_label.Name = "FT_label";
            this.FT_label.Size = new System.Drawing.Size(76, 20);
            this.FT_label.TabIndex = 2;
            this.FT_label.Text = "File Type:";
            // 
            // FC_label
            // 
            this.FC_label.AutoSize = true;
            this.FC_label.Location = new System.Drawing.Point(20, 90);
            this.FC_label.Name = "FC_label";
            this.FC_label.Size = new System.Drawing.Size(99, 20);
            this.FC_label.TabIndex = 3;
            this.FC_label.Text = "File Content:";
            // 
            // FN1_textBox
            // 
            this.FN1_textBox.Location = new System.Drawing.Point(123, 24);
            this.FN1_textBox.Name = "FN1_textBox";
            this.FN1_textBox.Size = new System.Drawing.Size(112, 26);
            this.FN1_textBox.TabIndex = 4;
            this.FN1_textBox.TextChanged += new System.EventHandler(this.FN1_textBox_TextChanged);
            // 
            // FC_textBox
            // 
            this.FC_textBox.Location = new System.Drawing.Point(125, 90);
            this.FC_textBox.Name = "FC_textBox";
            this.FC_textBox.Size = new System.Drawing.Size(242, 26);
            this.FC_textBox.TabIndex = 5;
            // 
            // FT_comboBox
            // 
            this.FT_comboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Read-only",
            "Editable"});
            this.FT_comboBox.FormattingEnabled = true;
            this.FT_comboBox.Location = new System.Drawing.Point(125, 56);
            this.FT_comboBox.Name = "FT_comboBox";
            this.FT_comboBox.Size = new System.Drawing.Size(112, 28);
            this.FT_comboBox.TabIndex = 6;
            // 
            // AddFile_button
            // 
            this.AddFile_button.Location = new System.Drawing.Point(262, 122);
            this.AddFile_button.Name = "AddFile_button";
            this.AddFile_button.Size = new System.Drawing.Size(105, 32);
            this.AddFile_button.TabIndex = 7;
            this.AddFile_button.Text = "Add File";
            this.AddFile_button.UseVisualStyleBackColor = true;
            this.AddFile_button.Click += new System.EventHandler(this.AddFile_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(12, 165);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(369, 88);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "File Name:";
            // 
            // FN2_textBox
            // 
            this.FN2_textBox.Location = new System.Drawing.Point(123, 176);
            this.FN2_textBox.Name = "FN2_textBox";
            this.FN2_textBox.Size = new System.Drawing.Size(114, 26);
            this.FN2_textBox.TabIndex = 10;
            // 
            // Remove_button
            // 
            this.Remove_button.Location = new System.Drawing.Point(262, 208);
            this.Remove_button.Name = "Remove_button";
            this.Remove_button.Size = new System.Drawing.Size(105, 35);
            this.Remove_button.TabIndex = 11;
            this.Remove_button.Text = "Remove";
            this.Remove_button.UseVisualStyleBackColor = true;
            this.Remove_button.Click += new System.EventHandler(this.Remove_button_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(12, 259);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(369, 179);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // FN3_label
            // 
            this.FN3_label.AutoSize = true;
            this.FN3_label.Location = new System.Drawing.Point(20, 271);
            this.FN3_label.Name = "FN3_label";
            this.FN3_label.Size = new System.Drawing.Size(84, 20);
            this.FN3_label.TabIndex = 13;
            this.FN3_label.Text = "File Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Show Content";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "New Content  ";
            // 
            // Update_button
            // 
            this.Update_button.Location = new System.Drawing.Point(262, 292);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(105, 32);
            this.Update_button.TabIndex = 16;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(262, 393);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(105, 32);
            this.Save_button.TabIndex = 17;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox4.Location = new System.Drawing.Point(387, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(423, 225);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // FN4_label
            // 
            this.FN4_label.AutoSize = true;
            this.FN4_label.Location = new System.Drawing.Point(397, 24);
            this.FN4_label.Name = "FN4_label";
            this.FN4_label.Size = new System.Drawing.Size(84, 20);
            this.FN4_label.TabIndex = 19;
            this.FN4_label.Text = "File Name:";
            // 
            // Content_label
            // 
            this.Content_label.AutoSize = true;
            this.Content_label.Location = new System.Drawing.Point(397, 75);
            this.Content_label.Name = "Content_label";
            this.Content_label.Size = new System.Drawing.Size(70, 20);
            this.Content_label.TabIndex = 20;
            this.Content_label.Text = "Content:";
            // 
            // AF_label
            // 
            this.AF_label.AutoSize = true;
            this.AF_label.Location = new System.Drawing.Point(397, 108);
            this.AF_label.Name = "AF_label";
            this.AF_label.Size = new System.Drawing.Size(136, 20);
            this.AF_label.TabIndex = 21;
            this.AF_label.Text = "Allowed Features:";
            // 
            // FN3_textBox
            // 
            this.FN3_textBox.Location = new System.Drawing.Point(137, 268);
            this.FN3_textBox.Name = "FN3_textBox";
            this.FN3_textBox.Size = new System.Drawing.Size(112, 26);
            this.FN3_textBox.TabIndex = 22;
            // 
            // SC_textBox
            // 
            this.SC_textBox.Location = new System.Drawing.Point(137, 330);
            this.SC_textBox.Name = "SC_textBox";
            this.SC_textBox.Size = new System.Drawing.Size(230, 26);
            this.SC_textBox.TabIndex = 23;
            // 
            // NC_textBox
            // 
            this.NC_textBox.Location = new System.Drawing.Point(137, 361);
            this.NC_textBox.Name = "NC_textBox";
            this.NC_textBox.Size = new System.Drawing.Size(230, 26);
            this.NC_textBox.TabIndex = 24;
            // 
            // Content_textBox
            // 
            this.Content_textBox.Location = new System.Drawing.Point(487, 75);
            this.Content_textBox.Name = "Content_textBox";
            this.Content_textBox.Size = new System.Drawing.Size(281, 26);
            this.Content_textBox.TabIndex = 25;
            // 
            // FN4_textBox
            // 
            this.FN4_textBox.Location = new System.Drawing.Point(487, 21);
            this.FN4_textBox.Name = "FN4_textBox";
            this.FN4_textBox.Size = new System.Drawing.Size(112, 26);
            this.FN4_textBox.TabIndex = 26;
            // 
            // View_button
            // 
            this.View_button.Location = new System.Drawing.Point(663, 36);
            this.View_button.Name = "View_button";
            this.View_button.Size = new System.Drawing.Size(105, 32);
            this.View_button.TabIndex = 27;
            this.View_button.Text = "Save";
            this.View_button.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(550, 108);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 104);
            this.listBox1.TabIndex = 28;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox5.Location = new System.Drawing.Point(387, 243);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(423, 221);
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "Show Summary";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.View_button);
            this.Controls.Add(this.FN4_textBox);
            this.Controls.Add(this.Content_textBox);
            this.Controls.Add(this.NC_textBox);
            this.Controls.Add(this.SC_textBox);
            this.Controls.Add(this.FN3_textBox);
            this.Controls.Add(this.AF_label);
            this.Controls.Add(this.Content_label);
            this.Controls.Add(this.FN4_label);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FN3_label);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Remove_button);
            this.Controls.Add(this.FN2_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AddFile_button);
            this.Controls.Add(this.FT_comboBox);
            this.Controls.Add(this.FC_textBox);
            this.Controls.Add(this.FN1_textBox);
            this.Controls.Add(this.FC_label);
            this.Controls.Add(this.FT_label);
            this.Controls.Add(this.FN1_label);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FN1_label;
        private System.Windows.Forms.Label FT_label;
        private System.Windows.Forms.Label FC_label;
        private System.Windows.Forms.TextBox FN1_textBox;
        private System.Windows.Forms.TextBox FC_textBox;
        private System.Windows.Forms.ComboBox FT_comboBox;
        private System.Windows.Forms.Button AddFile_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FN2_textBox;
        private System.Windows.Forms.Button Remove_button;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label FN3_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label FN4_label;
        private System.Windows.Forms.Label Content_label;
        private System.Windows.Forms.Label AF_label;
        private System.Windows.Forms.TextBox FN3_textBox;
        private System.Windows.Forms.TextBox SC_textBox;
        private System.Windows.Forms.TextBox NC_textBox;
        private System.Windows.Forms.TextBox Content_textBox;
        private System.Windows.Forms.TextBox FN4_textBox;
        private System.Windows.Forms.Button View_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button1;
    }
}

