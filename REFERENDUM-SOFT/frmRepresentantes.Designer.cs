namespace REFERENDUM_SOFT
{
    partial class frmRepresentantes
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
            this.txtTotalGeneral = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgrega = new System.Windows.Forms.Button();
            this.cmbSeccion = new System.Windows.Forms.ComboBox();
            this.rbtBasica = new System.Windows.Forms.RadioButton();
            this.rbtcontigua1 = new System.Windows.Forms.RadioButton();
            this.rbtcontigua2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfiltrar = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtTodos = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalGeneral
            // 
            this.txtTotalGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalGeneral.Location = new System.Drawing.Point(94, 404);
            this.txtTotalGeneral.Name = "txtTotalGeneral";
            this.txtTotalGeneral.Size = new System.Drawing.Size(89, 23);
            this.txtTotalGeneral.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "TOTAL :";
            // 
            // btnAgrega
            // 
            this.btnAgrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgrega.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAgrega.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgrega.FlatAppearance.BorderSize = 0;
            this.btnAgrega.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAgrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrega.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrega.ForeColor = System.Drawing.Color.White;
            this.btnAgrega.Location = new System.Drawing.Point(920, 400);
            this.btnAgrega.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(91, 31);
            this.btnAgrega.TabIndex = 75;
            this.btnAgrega.Text = "AGREGAR";
            this.btnAgrega.UseVisualStyleBackColor = false;
            this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
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
            this.rbtBasica.Location = new System.Drawing.Point(161, 75);
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
            this.rbtcontigua1.Location = new System.Drawing.Point(238, 75);
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
            this.rbtcontigua2.Location = new System.Drawing.Point(349, 75);
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
            this.txtfiltrar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtfiltrar.Location = new System.Drawing.Point(769, 73);
            this.txtfiltrar.Name = "txtfiltrar";
            this.txtfiltrar.Size = new System.Drawing.Size(242, 23);
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
            this.dgvLista.Size = new System.Drawing.Size(972, 256);
            this.dgvLista.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "FILTRAR NOMBRE";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(948, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 76;
            this.label3.Text = "IMPRIMIR";
            // 
            // rbtTodos
            // 
            this.rbtTodos.AutoSize = true;
            this.rbtTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtTodos.Location = new System.Drawing.Point(460, 75);
            this.rbtTodos.Name = "rbtTodos";
            this.rbtTodos.Size = new System.Drawing.Size(97, 21);
            this.rbtTodos.TabIndex = 77;
            this.rbtTodos.TabStop = true;
            this.rbtTodos.Tag = "";
            this.rbtTodos.Text = "VER TODOS";
            this.rbtTodos.UseVisualStyleBackColor = true;
            this.rbtTodos.Click += new System.EventHandler(this.rbtTodos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 78;
            this.label5.Text = "CASILLAS";
            // 
            // frmRepresentantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1077, 480);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtTodos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgrega);
            this.Controls.Add(this.txtTotalGeneral);
            this.Controls.Add(this.label4);
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
            this.Name = "frmRepresentantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmgestion_electores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTotalGeneral;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnAgrega;
        private System.Windows.Forms.ComboBox cmbSeccion;
        private System.Windows.Forms.RadioButton rbtBasica;
        private System.Windows.Forms.RadioButton rbtcontigua1;
        private System.Windows.Forms.RadioButton rbtcontigua2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfiltrar;
        internal System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtTodos;
        private System.Windows.Forms.Label label5;
    }
}

