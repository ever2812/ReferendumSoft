namespace REFERENDUM_SOFT
{
    partial class frmgestion_electores
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
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.rbtBasica = new System.Windows.Forms.RadioButton();
            this.rbtcontigua1 = new System.Windows.Forms.RadioButton();
            this.rbtcontigua2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfiltrar = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSeccion
            // 
            this.cmbSeccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSeccion.FormattingEnabled = true;
            this.cmbSeccion.Location = new System.Drawing.Point(39, 74);
            this.cmbSeccion.Name = "cmbSeccion";
            this.cmbSeccion.Size = new System.Drawing.Size(85, 25);
            this.cmbSeccion.TabIndex = 0;
            this.cmbSeccion.SelectedValueChanged += new System.EventHandler(this.cmbcasillas_SelectedValueChanged);
            // 
            // rbtBasica
            // 
            this.rbtBasica.AutoSize = true;
            this.rbtBasica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtBasica.Location = new System.Drawing.Point(166, 75);
            this.rbtBasica.Name = "rbtBasica";
            this.rbtBasica.Size = new System.Drawing.Size(71, 21);
            this.rbtBasica.TabIndex = 1;
            this.rbtBasica.TabStop = true;
            this.rbtBasica.Tag = "1";
            this.rbtBasica.Text = "BÁSICA";
            this.rbtBasica.UseVisualStyleBackColor = true;
            this.rbtBasica.Click += new System.EventHandler(this.rbtBasica_Click);
            // 
            // rbtcontigua1
            // 
            this.rbtcontigua1.AutoSize = true;
            this.rbtcontigua1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtcontigua1.Location = new System.Drawing.Point(243, 75);
            this.rbtcontigua1.Name = "rbtcontigua1";
            this.rbtcontigua1.Size = new System.Drawing.Size(105, 21);
            this.rbtcontigua1.TabIndex = 2;
            this.rbtcontigua1.TabStop = true;
            this.rbtcontigua1.Tag = "2";
            this.rbtcontigua1.Text = "CONTIGUA 1";
            this.rbtcontigua1.UseVisualStyleBackColor = true;
            this.rbtcontigua1.Click += new System.EventHandler(this.rbtcontigua1_Click);
            // 
            // rbtcontigua2
            // 
            this.rbtcontigua2.AutoSize = true;
            this.rbtcontigua2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtcontigua2.Location = new System.Drawing.Point(354, 75);
            this.rbtcontigua2.Name = "rbtcontigua2";
            this.rbtcontigua2.Size = new System.Drawing.Size(105, 21);
            this.rbtcontigua2.TabIndex = 3;
            this.rbtcontigua2.TabStop = true;
            this.rbtcontigua2.Tag = "3";
            this.rbtcontigua2.Text = "CONTIGUA 2";
            this.rbtcontigua2.UseVisualStyleBackColor = true;
            this.rbtcontigua2.Click += new System.EventHandler(this.rbtcontigua2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "SECCION";
            // 
            // txtfiltrar
            // 
            this.txtfiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtfiltrar.Enabled = false;
            this.txtfiltrar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtfiltrar.Location = new System.Drawing.Point(739, 72);
            this.txtfiltrar.Name = "txtfiltrar";
            this.txtfiltrar.Size = new System.Drawing.Size(280, 23);
            this.txtfiltrar.TabIndex = 63;
            this.txtfiltrar.Tag = "A. Paterno - A. Materno - Nombre (s)";
            this.txtfiltrar.Text = "A. Paterno - A. Materno - Nombre (s)";
            this.txtfiltrar.TextChanged += new System.EventHandler(this.txtfiltrar_TextChanged);
            this.txtfiltrar.Enter += new System.EventHandler(this.txtfiltrar_Enter);
            this.txtfiltrar.Leave += new System.EventHandler(this.txtfiltrar_Leave);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToResizeColumns = false;
            this.dgvLista.AllowUserToResizeRows = false;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLista.Location = new System.Drawing.Point(39, 111);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(980, 326);
            this.dgvLista.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "FILTRAR NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "CASILLAS";
            // 
            // frmgestion_electores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1085, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.txtfiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtcontigua2);
            this.Controls.Add(this.rbtcontigua1);
            this.Controls.Add(this.rbtBasica);
            this.Controls.Add(this.cmbSeccion);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmgestion_electores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmgestion_electores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.RadioButton rbtBasica;
        private System.Windows.Forms.RadioButton rbtcontigua1;
        private System.Windows.Forms.RadioButton rbtcontigua2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfiltrar;
        internal System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

