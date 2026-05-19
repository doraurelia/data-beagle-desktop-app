namespace DataBeagle
{
    partial class FormaUnosIzmjena
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbxVrsta = new System.Windows.Forms.ComboBox();
            this.cmbxUdomljena = new System.Windows.Forms.ComboBox();
            this.dtpDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDolaska = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumUdomljenja = new System.Windows.Forms.DateTimePicker();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.txtUdomitelj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(282, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(269, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vrsta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(194, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Datum rođenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(101, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datum dolaska u sklonište:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(227, 230);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Udomljena:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(194, 306);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "OIB udomitelja:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(168, 271);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Datum udomljenja:";
            // 
            // cmbxVrsta
            // 
            this.cmbxVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxVrsta.FormattingEnabled = true;
            this.cmbxVrsta.Location = new System.Drawing.Point(444, 113);
            this.cmbxVrsta.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxVrsta.Name = "cmbxVrsta";
            this.cmbxVrsta.Size = new System.Drawing.Size(160, 24);
            this.cmbxVrsta.TabIndex = 8;
            // 
            // cmbxUdomljena
            // 
            this.cmbxUdomljena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxUdomljena.FormattingEnabled = true;
            this.cmbxUdomljena.Location = new System.Drawing.Point(444, 230);
            this.cmbxUdomljena.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxUdomljena.Name = "cmbxUdomljena";
            this.cmbxUdomljena.Size = new System.Drawing.Size(160, 24);
            this.cmbxUdomljena.TabIndex = 9;
            // 
            // dtpDatumRodjenja
            // 
            this.dtpDatumRodjenja.Location = new System.Drawing.Point(444, 153);
            this.dtpDatumRodjenja.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumRodjenja.Name = "dtpDatumRodjenja";
            this.dtpDatumRodjenja.Size = new System.Drawing.Size(265, 22);
            this.dtpDatumRodjenja.TabIndex = 10;
            // 
            // dtpDatumDolaska
            // 
            this.dtpDatumDolaska.Location = new System.Drawing.Point(444, 192);
            this.dtpDatumDolaska.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumDolaska.Name = "dtpDatumDolaska";
            this.dtpDatumDolaska.Size = new System.Drawing.Size(265, 22);
            this.dtpDatumDolaska.TabIndex = 11;
            // 
            // dtpDatumUdomljenja
            // 
            this.dtpDatumUdomljenja.Location = new System.Drawing.Point(444, 271);
            this.dtpDatumUdomljenja.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumUdomljenja.Name = "dtpDatumUdomljenja";
            this.dtpDatumUdomljenja.Size = new System.Drawing.Size(265, 22);
            this.dtpDatumUdomljenja.TabIndex = 12;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(444, 70);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(132, 22);
            this.txtIme.TabIndex = 14;
            // 
            // btnSpremi
            // 
            this.btnSpremi.BackColor = System.Drawing.Color.Violet;
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremi.Location = new System.Drawing.Point(859, 468);
            this.btnSpremi.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(144, 44);
            this.btnSpremi.TabIndex = 16;
            this.btnSpremi.Text = "Spremi->";
            this.btnSpremi.UseVisualStyleBackColor = false;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // txtUdomitelj
            // 
            this.txtUdomitelj.Location = new System.Drawing.Point(444, 306);
            this.txtUdomitelj.Name = "txtUdomitelj";
            this.txtUdomitelj.Size = new System.Drawing.Size(100, 22);
            this.txtUdomitelj.TabIndex = 17;
            this.txtUdomitelj.TextChanged += new System.EventHandler(this.txtUdomitelj_TextChanged);
            // 
            // FormaUnosIzmjena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.txtUdomitelj);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.dtpDatumUdomljenja);
            this.Controls.Add(this.dtpDatumDolaska);
            this.Controls.Add(this.dtpDatumRodjenja);
            this.Controls.Add(this.cmbxUdomljena);
            this.Controls.Add(this.cmbxVrsta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaUnosIzmjena";
            this.Text = "FormaUnosIzmjena";
            this.Load += new System.EventHandler(this.FormaUnosIzmjena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbxVrsta;
        private System.Windows.Forms.ComboBox cmbxUdomljena;
        private System.Windows.Forms.DateTimePicker dtpDatumRodjenja;
        private System.Windows.Forms.DateTimePicker dtpDatumDolaska;
        private System.Windows.Forms.DateTimePicker dtpDatumUdomljenja;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox txtUdomitelj;
    }
}