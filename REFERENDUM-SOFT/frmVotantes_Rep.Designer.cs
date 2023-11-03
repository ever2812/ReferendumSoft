namespace REFERENDUM_SOFT
{
    partial class frmVotantes_Rep
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTotalRepresentante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfiltrar = new System.Windows.Forms.TextBox();
            this.dgvListaRep = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImprimir = new System.Windows.Forms.Label();
            this.dgvListaPersonas = new System.Windows.Forms.DataGridView();
            this.txtTotalPersonas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalRepresentante
            // 
            this.txtTotalRepresentante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalRepresentante.Location = new System.Drawing.Point(194, 382);
            this.txtTotalRepresentante.Name = "txtTotalRepresentante";
            this.txtTotalRepresentante.Size = new System.Drawing.Size(89, 23);
            this.txtTotalRepresentante.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "TOTAL-REPRESENTANTES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "REPRESENTANTES";
            // 
            // txtfiltrar
            // 
            this.txtfiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfiltrar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtfiltrar.Location = new System.Drawing.Point(764, 45);
            this.txtfiltrar.Name = "txtfiltrar";
            this.txtfiltrar.Size = new System.Drawing.Size(247, 23);
            this.txtfiltrar.TabIndex = 63;
            this.txtfiltrar.Tag = "A. Paterno - A. Materno - Nombre (s)";
            this.txtfiltrar.Text = "A. Paterno - A. Materno - Nombre (s)";
            this.txtfiltrar.TextChanged += new System.EventHandler(this.txtfiltrar_TextChanged);
            this.txtfiltrar.Enter += new System.EventHandler(this.txtfiltrar_Enter);
            this.txtfiltrar.Leave += new System.EventHandler(this.txtfiltrar_Leave);
            // 
            // dgvListaRep
            // 
            this.dgvListaRep.AllowUserToAddRows = false;
            this.dgvListaRep.AllowUserToDeleteRows = false;
            this.dgvListaRep.AllowUserToResizeColumns = false;
            this.dgvListaRep.AllowUserToResizeRows = false;
            this.dgvListaRep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvListaRep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaRep.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListaRep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaRep.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvListaRep.Location = new System.Drawing.Point(39, 75);
            this.dgvListaRep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListaRep.Name = "dgvListaRep";
            this.dgvListaRep.ReadOnly = true;
            this.dgvListaRep.RowHeadersVisible = false;
            this.dgvListaRep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaRep.Size = new System.Drawing.Size(337, 299);
            this.dgvListaRep.TabIndex = 64;
            this.dgvListaRep.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "LISTA DE PERSONAS";
            // 
            // lblImprimir
            // 
            this.lblImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImprimir.AutoSize = true;
            this.lblImprimir.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblImprimir.Location = new System.Drawing.Point(948, 420);
            this.lblImprimir.Name = "lblImprimir";
            this.lblImprimir.Size = new System.Drawing.Size(63, 17);
            this.lblImprimir.TabIndex = 76;
            this.lblImprimir.Text = "IMPRIMIR";
            this.lblImprimir.Click += new System.EventHandler(this.lblImprimir_Click);
            // 
            // dgvListaPersonas
            // 
            this.dgvListaPersonas.AllowUserToAddRows = false;
            this.dgvListaPersonas.AllowUserToDeleteRows = false;
            this.dgvListaPersonas.AllowUserToResizeColumns = false;
            this.dgvListaPersonas.AllowUserToResizeRows = false;
            this.dgvListaPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaPersonas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPersonas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvListaPersonas.Location = new System.Drawing.Point(403, 76);
            this.dgvListaPersonas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvListaPersonas.Name = "dgvListaPersonas";
            this.dgvListaPersonas.ReadOnly = true;
            this.dgvListaPersonas.RowHeadersVisible = false;
            this.dgvListaPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPersonas.Size = new System.Drawing.Size(608, 298);
            this.dgvListaPersonas.TabIndex = 79;
            // 
            // txtTotalPersonas
            // 
            this.txtTotalPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPersonas.Location = new System.Drawing.Point(922, 382);
            this.txtTotalPersonas.Name = "txtTotalPersonas";
            this.txtTotalPersonas.Size = new System.Drawing.Size(89, 23);
            this.txtTotalPersonas.TabIndex = 81;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(803, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 80;
            this.label5.Text = "TOTAL-PERSONAS";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmVotantes_Rep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1077, 480);
            this.Controls.Add(this.txtTotalPersonas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvListaPersonas);
            this.Controls.Add(this.lblImprimir);
            this.Controls.Add(this.txtTotalRepresentante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvListaRep);
            this.Controls.Add(this.txtfiltrar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVotantes_Rep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmgestion_electores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTotalRepresentante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfiltrar;
        internal System.Windows.Forms.DataGridView dgvListaRep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImprimir;
        internal System.Windows.Forms.DataGridView dgvListaPersonas;
        private System.Windows.Forms.TextBox txtTotalPersonas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

