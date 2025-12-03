namespace Tracnghiem_Application
{
    partial class Form_TTDSTS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_ma = new System.Windows.Forms.ComboBox();
            this.comboBox_ten = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_dc = new System.Windows.Forms.Label();
            this.label_ns = new System.Windows.Forms.Label();
            this.label_l = new System.Windows.Forms.Label();
            this.label_tr = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(423, 126);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox_ma
            // 
            this.comboBox_ma.FormattingEnabled = true;
            this.comboBox_ma.Location = new System.Drawing.Point(85, 10);
            this.comboBox_ma.Name = "comboBox_ma";
            this.comboBox_ma.Size = new System.Drawing.Size(129, 21);
            this.comboBox_ma.TabIndex = 1;
            this.comboBox_ma.SelectedIndexChanged += new System.EventHandler(this.comboBox_ma_SelectedIndexChanged);
            // 
            // comboBox_ten
            // 
            this.comboBox_ten.FormattingEnabled = true;
            this.comboBox_ten.Location = new System.Drawing.Point(313, 10);
            this.comboBox_ten.Name = "comboBox_ten";
            this.comboBox_ten.Size = new System.Drawing.Size(129, 21);
            this.comboBox_ten.TabIndex = 2;
            this.comboBox_ten.SelectedIndexChanged += new System.EventHandler(this.comboBox_ten_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã thí sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên thí sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày sinh:";
            // 
            // label_dc
            // 
            this.label_dc.BackColor = System.Drawing.Color.White;
            this.label_dc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_dc.Location = new System.Drawing.Point(85, 36);
            this.label_dc.Name = "label_dc";
            this.label_dc.Size = new System.Drawing.Size(129, 21);
            this.label_dc.TabIndex = 11;
            // 
            // label_ns
            // 
            this.label_ns.BackColor = System.Drawing.Color.White;
            this.label_ns.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_ns.Location = new System.Drawing.Point(85, 62);
            this.label_ns.Name = "label_ns";
            this.label_ns.Size = new System.Drawing.Size(129, 21);
            this.label_ns.TabIndex = 12;
            // 
            // label_l
            // 
            this.label_l.BackColor = System.Drawing.Color.White;
            this.label_l.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_l.Location = new System.Drawing.Point(313, 62);
            this.label_l.Name = "label_l";
            this.label_l.Size = new System.Drawing.Size(129, 21);
            this.label_l.TabIndex = 16;
            // 
            // label_tr
            // 
            this.label_tr.BackColor = System.Drawing.Color.White;
            this.label_tr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_tr.Location = new System.Drawing.Point(313, 36);
            this.label_tr.Name = "label_tr";
            this.label_tr.Size = new System.Drawing.Size(129, 21);
            this.label_tr.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Lớp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Trường:";
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // Form_TTDSTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(458, 248);
            this.Controls.Add(this.label_l);
            this.Controls.Add(this.label_tr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_ns);
            this.Controls.Add(this.label_dc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_ten);
            this.Controls.Add(this.comboBox_ma);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_TTDSTS";
            this.Text = "Thông tin danh sách thí sinh";
            this.Load += new System.EventHandler(this.Form_TTDSTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_ma;
        private System.Windows.Forms.ComboBox comboBox_ten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_dc;
        private System.Windows.Forms.Label label_ns;
        private System.Windows.Forms.Label label_l;
        private System.Windows.Forms.Label label_tr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}