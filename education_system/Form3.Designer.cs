﻿namespace education_system
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.tip_txt = new System.Windows.Forms.ComboBox();
            this.input_txt = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(245, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入需要查找学生的信息";
            // 
            // tip_txt
            // 
            this.tip_txt.FormattingEnabled = true;
            this.tip_txt.Location = new System.Drawing.Point(255, 198);
            this.tip_txt.Name = "tip_txt";
            this.tip_txt.Size = new System.Drawing.Size(200, 23);
            this.tip_txt.TabIndex = 2;
            // 
            // input_txt
            // 
            this.input_txt.Location = new System.Drawing.Point(536, 198);
            this.input_txt.Name = "input_txt";
            this.input_txt.Size = new System.Drawing.Size(433, 25);
            this.input_txt.TabIndex = 3;
            // 
            // bt_search
            // 
            this.bt_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_search.Location = new System.Drawing.Point(1030, 187);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(106, 42);
            this.bt_search.TabIndex = 4;
            this.bt_search.Text = "查  找";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(881, 261);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1030, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "返  回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1289, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.input_txt);
            this.Controls.Add(this.tip_txt);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tip_txt;
        private System.Windows.Forms.TextBox input_txt;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}