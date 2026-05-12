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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvZivotinje = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.cbxFilterVrsta = new System.Windows.Forms.ComboBox();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnUdomljene = new System.Windows.Forms.Button();
            this.dtpPocetakFilter = new System.Windows.Forms.DateTimePicker();
            this.dtpKrajFilter = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Životinje u skloništu";
            // 
            // dgvZivotinje
            // 
            this.dgvZivotinje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZivotinje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZivotinje.Location = new System.Drawing.Point(13, 95);
            this.dgvZivotinje.Margin = new System.Windows.Forms.Padding(4);
            this.dgvZivotinje.Name = "dgvZivotinje";
            this.dgvZivotinje.RowHeadersWidth = 51;
            this.dgvZivotinje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZivotinje.Size = new System.Drawing.Size(1300, 397);
            this.dgvZivotinje.TabIndex = 1;
            this.dgvZivotinje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvZivotinje_CellContentClick);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovo.Location = new System.Drawing.Point(13, 500);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(119, 39);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzmijeni.Location = new System.Drawing.Point(139, 500);
            this.btnIzmijeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(135, 41);
            this.btnIzmijeni.TabIndex = 3;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnBrisi
            // 
            this.btnBrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBrisi.Location = new System.Drawing.Point(282, 500);
            this.btnBrisi.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(124, 41);
            this.btnBrisi.TabIndex = 4;
            this.btnBrisi.Text = "Obriši";
            this.btnBrisi.UseVisualStyleBackColor = true;
            // 
            // cbxFilterVrsta
            // 
            this.cbxFilterVrsta.FormattingEnabled = true;
            this.cbxFilterVrsta.Location = new System.Drawing.Point(913, 15);
            this.cbxFilterVrsta.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFilterVrsta.Name = "cbxFilterVrsta";
            this.cbxFilterVrsta.Size = new System.Drawing.Size(159, 24);
            this.cbxFilterVrsta.TabIndex = 5;
            this.cbxFilterVrsta.SelectedIndexChanged += new System.EventHandler(this.filterVrsta_SelectedIndexChanged);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFiltriraj.Location = new System.Drawing.Point(1089, 10);
            this.btnFiltriraj.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(112, 36);
            this.btnFiltriraj.TabIndex = 6;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnUdomljene
            // 
            this.btnUdomljene.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUdomljene.Location = new System.Drawing.Point(861, 500);
            this.btnUdomljene.Name = "btnUdomljene";
            this.btnUdomljene.Size = new System.Drawing.Size(453, 39);
            this.btnUdomljene.TabIndex = 7;
            this.btnUdomljene.Text = "Prikaz udomljenih životinja";
            this.btnUdomljene.UseVisualStyleBackColor = true;
            this.btnUdomljene.Click += new System.EventHandler(this.btnUdomljene_Click);
            // 
            // dtpPocetakFilter
            // 
            this.dtpPocetakFilter.Location = new System.Drawing.Point(438, 509);
            this.dtpPocetakFilter.Name = "dtpPocetakFilter";
            this.dtpPocetakFilter.Size = new System.Drawing.Size(200, 22);
            this.dtpPocetakFilter.TabIndex = 8;
            // 
            // dtpKrajFilter
            // 
            this.dtpKrajFilter.Location = new System.Drawing.Point(655, 509);
            this.dtpKrajFilter.Name = "dtpKrajFilter";
            this.dtpKrajFilter.Size = new System.Drawing.Size(200, 22);
            this.dtpKrajFilter.TabIndex = 9;
            // 
            // FormaZaPregledZivotinja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 554);
            this.Controls.Add(this.dtpKrajFilter);
            this.Controls.Add(this.dtpPocetakFilter);
            this.Controls.Add(this.btnUdomljene);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.cbxFilterVrsta);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvZivotinje);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaZaPregledZivotinja";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormaZaPregledZivotinja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvZivotinje;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.ComboBox cbxFilterVrsta;
        private System.Windows.Forms.Button btnUdomljene;
        private System.Windows.Forms.DateTimePicker dtpPocetakFilter;
        private System.Windows.Forms.DateTimePicker dtpKrajFilter;
    }
}

