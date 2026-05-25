namespace DataBeagle
{
    partial class FormaZaPregledZivotinja
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.dgvZivotinje = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.cbxFilterVrsta = new System.Windows.Forms.ComboBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnUdomljene = new System.Windows.Forms.Button();
            this.btnIzvjestaj = new System.Windows.Forms.Button();
            this.dtpPocetak = new System.Windows.Forms.DateTimePicker();
            this.dtpKraj = new System.Windows.Forms.DateTimePicker();
            this.lblPocetak = new System.Windows.Forms.Label();
            this.lblKraj = new System.Windows.Forms.Label();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.ForeColor = System.Drawing.Color.Indigo;
            this.lblNaslov.Location = new System.Drawing.Point(12, 15);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(243, 29);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Životinje u skloništu";
            // 
            // dgvZivotinje
            // 
            this.dgvZivotinje.AllowUserToAddRows = false;
            this.dgvZivotinje.AllowUserToDeleteRows = false;
            this.dgvZivotinje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZivotinje.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgvZivotinje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZivotinje.Location = new System.Drawing.Point(10, 59);
            this.dgvZivotinje.MultiSelect = false;
            this.dgvZivotinje.Name = "dgvZivotinje";
            this.dgvZivotinje.RowHeadersWidth = 51;
            this.dgvZivotinje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZivotinje.Size = new System.Drawing.Size(853, 280);
            this.dgvZivotinje.TabIndex = 1;
            this.dgvZivotinje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZivotinje_CellContentClick);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Violet;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovo.Location = new System.Drawing.Point(10, 429);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(89, 32);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.BackColor = System.Drawing.Color.Violet;
            this.btnIzmijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmijeni.Location = new System.Drawing.Point(104, 429);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(101, 33);
            this.btnIzmijeni.TabIndex = 3;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = false;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.BackColor = System.Drawing.Color.Violet;
            this.btnBrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrisi.Location = new System.Drawing.Point(212, 429);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(93, 33);
            this.btnBrisi.TabIndex = 4;
            this.btnBrisi.Text = "Obriši";
            this.btnBrisi.UseVisualStyleBackColor = false;
            this.btnBrisi.Click += new System.EventHandler(this.btnBrisi_Click);
            // 
            // cbxFilterVrsta
            // 
            this.cbxFilterVrsta.BackColor = System.Drawing.SystemColors.Window;
            this.cbxFilterVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFilterVrsta.FormattingEnabled = true;
            this.cbxFilterVrsta.Location = new System.Drawing.Point(646, 18);
            this.cbxFilterVrsta.Name = "cbxFilterVrsta";
            this.cbxFilterVrsta.Size = new System.Drawing.Size(120, 21);
            this.cbxFilterVrsta.TabIndex = 5;
            this.cbxFilterVrsta.SelectedIndexChanged += new System.EventHandler(this.filterVrsta_SelectedIndexChanged);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.BackColor = System.Drawing.Color.Violet;
            this.btnFiltriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFiltriraj.Location = new System.Drawing.Point(778, 14);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(84, 29);
            this.btnFiltriraj.TabIndex = 6;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = false;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnUdomljene
            // 
            this.btnUdomljene.BackColor = System.Drawing.Color.Violet;
            this.btnUdomljene.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUdomljene.Location = new System.Drawing.Point(394, 431);
            this.btnUdomljene.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUdomljene.Name = "btnUdomljene";
            this.btnUdomljene.Size = new System.Drawing.Size(183, 32);
            this.btnUdomljene.TabIndex = 7;
            this.btnUdomljene.Text = "Udomljene ";
            this.btnUdomljene.UseVisualStyleBackColor = false;
            this.btnUdomljene.Click += new System.EventHandler(this.btnUdomljene_Click);
            // 
            // btnIzvjestaj
            // 
            this.btnIzvjestaj.BackColor = System.Drawing.Color.Violet;
            this.btnIzvjestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvjestaj.Location = new System.Drawing.Point(582, 431);
            this.btnIzvjestaj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzvjestaj.Name = "btnIzvjestaj";
            this.btnIzvjestaj.Size = new System.Drawing.Size(98, 32);
            this.btnIzvjestaj.TabIndex = 8;
            this.btnIzvjestaj.Text = "Izvještaj";
            this.btnIzvjestaj.UseVisualStyleBackColor = false;
            this.btnIzvjestaj.Click += new System.EventHandler(this.btnIzvjestaj_Click);
            // 
            // dtpPocetak
            // 
            this.dtpPocetak.Location = new System.Drawing.Point(725, 417);
            this.dtpPocetak.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpPocetak.Name = "dtpPocetak";
            this.dtpPocetak.Size = new System.Drawing.Size(146, 20);
            this.dtpPocetak.TabIndex = 9;
            // 
            // dtpKraj
            // 
            this.dtpKraj.Location = new System.Drawing.Point(725, 444);
            this.dtpKraj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpKraj.Name = "dtpKraj";
            this.dtpKraj.Size = new System.Drawing.Size(146, 20);
            this.dtpKraj.TabIndex = 10;
            // 
            // lblPocetak
            // 
            this.lblPocetak.AutoSize = true;
            this.lblPocetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPocetak.Location = new System.Drawing.Point(685, 417);
            this.lblPocetak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPocetak.Name = "lblPocetak";
            this.lblPocetak.Size = new System.Drawing.Size(34, 20);
            this.lblPocetak.TabIndex = 11;
            this.lblPocetak.Text = "od:";
            // 
            // lblKraj
            // 
            this.lblKraj.AutoSize = true;
            this.lblKraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKraj.Location = new System.Drawing.Point(685, 444);
            this.lblKraj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKraj.Name = "lblKraj";
            this.lblKraj.Size = new System.Drawing.Size(34, 20);
            this.lblKraj.TabIndex = 12;
            this.lblKraj.Text = "do:";
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.BackColor = System.Drawing.Color.Violet;
            this.txtPretrazi.Location = new System.Drawing.Point(394, 18);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(123, 20);
            this.txtPretrazi.TabIndex = 13;
            this.txtPretrazi.Text = "ime";
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.Color.Violet;
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPretrazi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPretrazi.Location = new System.Drawing.Point(531, 14);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(84, 29);
            this.btnPretrazi.TabIndex = 14;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // FormaZaPregledZivotinja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(880, 468);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretrazi);
            this.Controls.Add(this.lblKraj);
            this.Controls.Add(this.lblPocetak);
            this.Controls.Add(this.dtpKraj);
            this.Controls.Add(this.dtpPocetak);
            this.Controls.Add(this.btnIzvjestaj);
            this.Controls.Add(this.btnUdomljene);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.cbxFilterVrsta);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvZivotinje);
            this.Controls.Add(this.lblNaslov);
            this.Name = "FormaZaPregledZivotinja";
            this.Text = "Pregled životinja";
            this.Load += new System.EventHandler(this.FormaZaPregledZivotinja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.DataGridView dgvZivotinje;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.ComboBox cbxFilterVrsta;
        private System.Windows.Forms.Button btnUdomljene;
        private System.Windows.Forms.Button btnIzvjestaj;
        private System.Windows.Forms.DateTimePicker dtpPocetak;
        private System.Windows.Forms.DateTimePicker dtpKraj;
        private System.Windows.Forms.Label lblPocetak;
        private System.Windows.Forms.Label lblKraj;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Button btnPretrazi;
    }
}

