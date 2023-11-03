namespace REFERENDUM_SOFT
{
    partial class frmLista_electoresRep
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.txtfiltroClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtcontigua2 = new System.Windows.Forms.RadioButton();
            this.rbtcontigua1 = new System.Windows.Forms.RadioButton();
            this.rbtBasica = new System.Windows.Forms.RadioButton();
            this.cmbcasillas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnAgrega = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(698, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "CLAVE ELECTOR";
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AllowUserToResizeColumns = false;
            this.dgvLista.AllowUserToResizeRows = false;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvLista.Location = new System.Drawing.Point(15, 93);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(980, 266);
            this.dgvLista.TabIndex = 72;
            this.dgvLista.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentDoubleClick);
            this.dgvLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellDoubleClick);
            // 
            // txtfiltroClave
            // 
            this.txtfiltroClave.Enabled = false;
            this.txtfiltroClave.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtfiltroClave.Location = new System.Drawing.Point(813, 15);
            this.txtfiltroClave.MaxLength = 18;
            this.txtfiltroClave.Name = "txtfiltroClave";
            this.txtfiltroClave.Size = new System.Drawing.Size(182, 23);
            this.txtfiltroClave.TabIndex = 71;
            this.txtfiltroClave.Tag = "Clave de Elector";
            this.txtfiltroClave.Text = "Clave de Elector";
            this.txtfiltroClave.TextChanged += new System.EventHandler(this.txtfiltroClave_TextChanged);
            this.txtfiltroClave.Enter += new System.EventHandler(this.txtfiltroClave_Enter);
            this.txtfiltroClave.Leave += new System.EventHandler(this.txtfiltroClave_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 70;
            this.label1.Text = "SECCION";
            // 
            // rbtcontigua2
            // 
            this.rbtcontigua2.AutoSize = true;
            this.rbtcontigua2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtcontigua2.Location = new System.Drawing.Point(321, 57);
            this.rbtcontigua2.Name = "rbtcontigua2";
            this.rbtcontigua2.Size = new System.Drawing.Size(105, 21);
            this.rbtcontigua2.TabIndex = 69;
            this.rbtcontigua2.TabStop = true;
            this.rbtcontigua2.Tag = "3";
            this.rbtcontigua2.Text = "CONTIGUA 2";
            this.rbtcontigua2.UseVisualStyleBackColor = true;
            this.rbtcontigua2.Click += new System.EventHandler(this.rbtcontigua2_Click_1);
            // 
            // rbtcontigua1
            // 
            this.rbtcontigua1.AutoSize = true;
            this.rbtcontigua1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtcontigua1.Location = new System.Drawing.Point(210, 57);
            this.rbtcontigua1.Name = "rbtcontigua1";
            this.rbtcontigua1.Size = new System.Drawing.Size(105, 21);
            this.rbtcontigua1.TabIndex = 68;
            this.rbtcontigua1.TabStop = true;
            this.rbtcontigua1.Tag = "2";
            this.rbtcontigua1.Text = "CONTIGUA 1";
            this.rbtcontigua1.UseVisualStyleBackColor = true;
            this.rbtcontigua1.Click += new System.EventHandler(this.rbtcontigua1_Click_1);
            // 
            // rbtBasica
            // 
            this.rbtBasica.AutoSize = true;
            this.rbtBasica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtBasica.Location = new System.Drawing.Point(133, 57);
            this.rbtBasica.Name = "rbtBasica";
            this.rbtBasica.Size = new System.Drawing.Size(71, 21);
            this.rbtBasica.TabIndex = 67;
            this.rbtBasica.TabStop = true;
            this.rbtBasica.Tag = "1";
            this.rbtBasica.Text = "BÁSICA";
            this.rbtBasica.UseVisualStyleBackColor = true;
            this.rbtBasica.Click += new System.EventHandler(this.rbtBasica_Click_1);
            // 
            // cmbcasillas
            // 
            this.cmbcasillas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbcasillas.FormattingEnabled = true;
            this.cmbcasillas.Location = new System.Drawing.Point(15, 56);
            this.cmbcasillas.Name = "cmbcasillas";
            this.cmbcasillas.Size = new System.Drawing.Size(85, 25);
            this.cmbcasillas.TabIndex = 66;
            this.cmbcasillas.SelectedValueChanged += new System.EventHandler(this.cmbcasillas_SelectedValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "NOMBRE";
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Enabled = false;
            this.txtFiltroNombre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtFiltroNombre.Location = new System.Drawing.Point(715, 56);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(280, 23);
            this.txtFiltroNombre.TabIndex = 74;
            this.txtFiltroNombre.Tag = "A. Paterno - A. Materno - Nombre (s)";
            this.txtFiltroNombre.Text = "A. Paterno - A. Materno - Nombre (s)";
            this.txtFiltroNombre.TextChanged += new System.EventHandler(this.txtFiltroNombre_TextChanged);
            this.txtFiltroNombre.Enter += new System.EventHandler(this.txtFiltroNombre_Enter);
            this.txtFiltroNombre.Leave += new System.EventHandler(this.txtFiltroNombre_Leave);
            // 
            // txtnombre
            // 
            this.txtnombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnombre.Location = new System.Drawing.Point(15, 393);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(280, 23);
            this.txtnombre.TabIndex = 76;
            this.txtnombre.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 77;
            this.label4.Text = "DESCRIPCIÓN";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtdescripcion.Location = new System.Drawing.Point(382, 393);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(280, 23);
            this.txtdescripcion.TabIndex = 79;
            this.txtdescripcion.Tag = "";
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
            this.btnAgrega.Location = new System.Drawing.Point(701, 385);
            this.btnAgrega.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnAgrega.Name = "btnAgrega";
            this.btnAgrega.Size = new System.Drawing.Size(91, 31);
            this.btnAgrega.TabIndex = 80;
            this.btnAgrega.Text = "AGREGAR";
            this.btnAgrega.UseVisualStyleBackColor = false;
            this.btnAgrega.Click += new System.EventHandler(this.btnAgrega_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 81;
            this.label5.Text = "NOMBRE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 82;
            this.label6.Text = "CASILLAS";
            // 
            // frmLista_electoresRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1012, 479);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgrega);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiltroNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.txtfiltroClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtcontigua2);
            this.Controls.Add(this.rbtcontigua1);
            this.Controls.Add(this.rbtBasica);
            this.Controls.Add(this.cmbcasillas);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLista_electoresRep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir Representantes";
            this.Load += new System.EventHandler(this.frmLista_electores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TextBox txtfiltroClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtcontigua2;
        private System.Windows.Forms.RadioButton rbtcontigua1;
        private System.Windows.Forms.RadioButton rbtBasica;
        private System.Windows.Forms.ComboBox cmbcasillas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdescripcion;
        internal System.Windows.Forms.Button btnAgrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}