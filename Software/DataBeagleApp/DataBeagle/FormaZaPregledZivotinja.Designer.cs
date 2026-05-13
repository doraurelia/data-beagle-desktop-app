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
            ((System.ComponentModel.ISupportInitialize)(this.dgvZivotinje)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNaslov.Location = new System.Drawing.Point(16, 18);
            this.lblNaslov.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(243, 29);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Životinje u skloništu";
            // 
            // dgvZivotinje
            // 
            this.dgvZivotinje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZivotinje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZivotinje.Location = new System.Drawing.Point(13, 73);
            this.dgvZivotinje.Margin = new System.Windows.Forms.Padding(4);
            this.dgvZivotinje.Name = "dgvZivotinje";
            this.dgvZivotinje.RowHeadersWidth = 51;
            this.dgvZivotinje.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZivotinje.Size = new System.Drawing.Size(1300, 419);
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
            this.cbxFilterVrsta.Location = new System.Drawing.Point(1025, 22);
            this.cbxFilterVrsta.Margin = new System.Windows.Forms.Padding(4);
            this.cbxFilterVrsta.Name = "cbxFilterVrsta";
            this.cbxFilterVrsta.Size = new System.Drawing.Size(159, 24);
            this.cbxFilterVrsta.TabIndex = 5;
            this.cbxFilterVrsta.SelectedIndexChanged += new System.EventHandler(this.filterVrsta_SelectedIndexChanged);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFiltriraj.Location = new System.Drawing.Point(1201, 17);
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
            this.btnUdomljene.Location = new System.Drawing.Point(1069, 503);
            this.btnUdomljene.Name = "btnUdomljene";
            this.btnUdomljene.Size = new System.Drawing.Size(244, 39);
            this.btnUdomljene.TabIndex = 7;
            this.btnUdomljene.Text = "Udomljene životinje";
            this.btnUdomljene.UseVisualStyleBackColor = true;
            this.btnUdomljene.Click += new System.EventHandler(this.btnUdomljene_Click);
            // 
            // FormaZaPregledZivotinja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 554);
            this.Controls.Add(this.btnUdomljene);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.cbxFilterVrsta);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvZivotinje);
            this.Controls.Add(this.lblNaslov);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormaZaPregledZivotinja";
            this.Text = "Form1";
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
    }
}

