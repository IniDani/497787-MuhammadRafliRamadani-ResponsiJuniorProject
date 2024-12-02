using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace Responsi_497787
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
            this.logotxt = new System.Windows.Forms.TextBox();
            this.namakaryawantxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NamaKaryawantb = new System.Windows.Forms.TextBox();
            this.DepKaryawantb = new System.Windows.Forms.TextBox();
            this.Insertbtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Loadbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 37);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // logotxt
            // 
            this.logotxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logotxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logotxt.Location = new System.Drawing.Point(54, 24);
            this.logotxt.Name = "logotxt";
            this.logotxt.Size = new System.Drawing.Size(100, 16);
            this.logotxt.TabIndex = 1;
            this.logotxt.Text = "logo";
            // 
            // namakaryawantxt
            // 
            this.namakaryawantxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.namakaryawantxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namakaryawantxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.namakaryawantxt.Location = new System.Drawing.Point(12, 70);
            this.namakaryawantxt.Name = "namakaryawantxt";
            this.namakaryawantxt.Size = new System.Drawing.Size(120, 16);
            this.namakaryawantxt.TabIndex = 2;
            this.namakaryawantxt.Text = "Nama Karyawan :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(12, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 16);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Dep. Karyawan   \r\n:";
            // 
            // NamaKaryawantb
            // 
            this.NamaKaryawantb.Location = new System.Drawing.Point(122, 69);
            this.NamaKaryawantb.Name = "NamaKaryawantb";
            this.NamaKaryawantb.Size = new System.Drawing.Size(162, 20);
            this.NamaKaryawantb.TabIndex = 4;
            // 
            // DepKaryawantb
            // 
            this.DepKaryawantb.Location = new System.Drawing.Point(122, 107);
            this.DepKaryawantb.Name = "DepKaryawantb";
            this.DepKaryawantb.Size = new System.Drawing.Size(162, 20);
            this.DepKaryawantb.TabIndex = 5;
            // 
            // Insertbtn
            // 
            this.Insertbtn.Location = new System.Drawing.Point(12, 145);
            this.Insertbtn.Name = "Insertbtn";
            this.Insertbtn.Size = new System.Drawing.Size(116, 32);
            this.Insertbtn.TabIndex = 6;
            this.Insertbtn.Text = "Insert";
            this.Insertbtn.UseVisualStyleBackColor = true;
            // 
            // Editbtn
            // 
            this.Editbtn.Location = new System.Drawing.Point(180, 145);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(116, 32);
            this.Editbtn.TabIndex = 7;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(330, 145);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(116, 32);
            this.Deletebtn.TabIndex = 8;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(434, 218);
            this.dataGridView1.TabIndex = 9;
            // 
            // Loadbtn
            // 
            this.Loadbtn.Location = new System.Drawing.Point(368, 418);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(78, 20);
            this.Loadbtn.TabIndex = 10;
            this.Loadbtn.Text = "Load Data";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.Insertbtn);
            this.Controls.Add(this.DepKaryawantb);
            this.Controls.Add(this.NamaKaryawantb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.namakaryawantxt);
            this.Controls.Add(this.logotxt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox logotxt;
        private TextBox namakaryawantxt;
        private TextBox textBox1;
        private TextBox NamaKaryawantb;
        private TextBox DepKaryawantb;
        private Button Insertbtn;
        private Button Editbtn;
        private Button Deletebtn;
        private DataGridView dataGridView1;
        private Button Loadbtn;
    }
}

