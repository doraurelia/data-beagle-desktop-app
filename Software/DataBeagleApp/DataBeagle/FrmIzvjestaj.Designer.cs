namespace DataBeagle
{
    partial class FrmIzvjestaj
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
            this.dgvUdomljene = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPocetak = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKraj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUdomljene)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUdomljene
            // 
            this.dgvUdomljene.AllowUserToAddRows = false;
            this.dgvUdomljene.AllowUserToDeleteRows = false;
            this.dgvUdomljene.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgvUdomljene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUdomljene.Location = new System.Drawing.Point(21, 56);
            this.dgvUdomljene.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUdomljene.MaximumSize = new System.Drawing.Size(900, 390);
            this.dgvUdomljene.MinimumSize = new System.Drawing.Size(844, 65);
            this.dgvUdomljene.MultiSelect = false;
            this.dgvUdomljene.Name = "dgvUdomljene";
            this.dgvUdomljene.ReadOnly = true;
            this.dgvUdomljene.RowHeadersWidth = 51;
            this.dgvUdomljene.RowTemplate.Height = 24;
            this.dgvUdomljene.Size = new System.Drawing.Size(855, 390);
            this.dgvUdomljene.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Izvještaj o udomljenim životinjama u razdoblju od ";
            // 
            // lblPocetak
            // 
            this.lblPocetak.AutoSize = true;
            this.lblPocetak.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPocetak.Location = new System.Drawing.Point(484, 11);
            this.lblPocetak.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPocetak.Name = "lblPocetak";
            this.lblPocetak.Size = new System.Drawing.Size(134, 24);
            this.lblPocetak.TabIndex = 2;
            this.lblPocetak.Text = "dd.mm.gggg.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(589, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "do";
            // 
            // lblKraj
            // 
            this.lblKraj.AutoSize = true;
            this.lblKraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKraj.Location = new System.Drawing.Point(626, 11);
            this.lblKraj.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKraj.Name = "lblKraj";
            this.lblKraj.Size = new System.Drawing.Size(134, 24);
            this.lblKraj.TabIndex = 4;
            this.lblKraj.Text = "dd.mm.gggg.";
            // 
            // FrmIzvjestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(898, 469);
            this.Controls.Add(this.lblKraj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPocetak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUdomljene);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmIzvjestaj";
            this.Text = "FrmIzvjestaj";
            this.Load += new System.EventHandler(this.FrmIzvjestaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUdomljene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUdomljene;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPocetak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKraj;
    }
}