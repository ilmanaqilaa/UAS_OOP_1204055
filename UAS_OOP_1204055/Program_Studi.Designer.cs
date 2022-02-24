namespace UAS_OOP_1204055
{
    partial class programStudi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbKodeProdi = new System.Windows.Forms.TextBox();
            this.tbNamaProdi = new System.Windows.Forms.TextBox();
            this.tbSingkatan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.tbBiayaKuliah = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Program Studi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Prodi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Prodi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Singkatan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Biaya Kuliah";
            // 
            // tbKodeProdi
            // 
            this.tbKodeProdi.Location = new System.Drawing.Point(153, 97);
            this.tbKodeProdi.Name = "tbKodeProdi";
            this.tbKodeProdi.ReadOnly = true;
            this.tbKodeProdi.Size = new System.Drawing.Size(187, 20);
            this.tbKodeProdi.TabIndex = 5;
            // 
            // tbNamaProdi
            // 
            this.tbNamaProdi.Location = new System.Drawing.Point(153, 130);
            this.tbNamaProdi.Name = "tbNamaProdi";
            this.tbNamaProdi.Size = new System.Drawing.Size(187, 20);
            this.tbNamaProdi.TabIndex = 6;
            this.tbNamaProdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNamaProdi_KeyPress);
            // 
            // tbSingkatan
            // 
            this.tbSingkatan.Location = new System.Drawing.Point(153, 163);
            this.tbSingkatan.Name = "tbSingkatan";
            this.tbSingkatan.Size = new System.Drawing.Size(187, 20);
            this.tbSingkatan.TabIndex = 7;
            this.tbSingkatan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSingkatan_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(137, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = ":";
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(98, 255);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 13;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(220, 255);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 14;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // tbBiayaKuliah
            // 
            this.tbBiayaKuliah.Location = new System.Drawing.Point(153, 199);
            this.tbBiayaKuliah.Name = "tbBiayaKuliah";
            this.tbBiayaKuliah.Size = new System.Drawing.Size(187, 20);
            this.tbBiayaKuliah.TabIndex = 15;
            this.tbBiayaKuliah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBiayaKuliah_KeyPress);
            // 
            // programStudi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 333);
            this.Controls.Add(this.tbBiayaKuliah);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSingkatan);
            this.Controls.Add(this.tbNamaProdi);
            this.Controls.Add(this.tbKodeProdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "programStudi";
            this.Text = "Program Studi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbKodeProdi;
        private System.Windows.Forms.TextBox tbNamaProdi;
        private System.Windows.Forms.TextBox tbSingkatan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox tbBiayaKuliah;
    }
}