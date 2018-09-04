namespace Pastelaria.UI
{
    partial class frmProdutos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLimparProd = new System.Windows.Forms.Button();
            this.btnCadastrarProd = new System.Windows.Forms.Button();
            this.lblSalarioFunc = new System.Windows.Forms.Label();
            this.txtQuantidadeProd = new System.Windows.Forms.TextBox();
            this.lblObsProd = new System.Windows.Forms.Label();
            this.txtObsProd = new System.Windows.Forms.TextBox();
            this.lblPrecoProd = new System.Windows.Forms.Label();
            this.lblNomeProd = new System.Windows.Forms.Label();
            this.txtNomeProd = new System.Windows.Forms.TextBox();
            this.txtPrecoProd = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcluirProd = new System.Windows.Forms.Button();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.dgvConsultaProd = new System.Windows.Forms.DataGridView();
            this.btnEditarProd = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProd)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 352);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimparProd);
            this.tabPage1.Controls.Add(this.btnCadastrarProd);
            this.tabPage1.Controls.Add(this.lblSalarioFunc);
            this.tabPage1.Controls.Add(this.txtQuantidadeProd);
            this.tabPage1.Controls.Add(this.lblObsProd);
            this.tabPage1.Controls.Add(this.txtObsProd);
            this.tabPage1.Controls.Add(this.lblPrecoProd);
            this.tabPage1.Controls.Add(this.lblNomeProd);
            this.tabPage1.Controls.Add(this.txtNomeProd);
            this.tabPage1.Controls.Add(this.txtPrecoProd);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(617, 317);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CADASTRO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimparProd
            // 
            this.btnLimparProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimparProd.Location = new System.Drawing.Point(395, 230);
            this.btnLimparProd.Name = "btnLimparProd";
            this.btnLimparProd.Size = new System.Drawing.Size(143, 34);
            this.btnLimparProd.TabIndex = 33;
            this.btnLimparProd.Text = "Limpar";
            this.btnLimparProd.UseVisualStyleBackColor = true;
            this.btnLimparProd.Click += new System.EventHandler(this.btnLimparProd_Click);
            // 
            // btnCadastrarProd
            // 
            this.btnCadastrarProd.Location = new System.Drawing.Point(154, 230);
            this.btnCadastrarProd.Name = "btnCadastrarProd";
            this.btnCadastrarProd.Size = new System.Drawing.Size(145, 34);
            this.btnCadastrarProd.TabIndex = 32;
            this.btnCadastrarProd.Text = "Cadastrar";
            this.btnCadastrarProd.UseVisualStyleBackColor = true;
            this.btnCadastrarProd.Click += new System.EventHandler(this.btnCadastrarProd_Click);
            // 
            // lblSalarioFunc
            // 
            this.lblSalarioFunc.AutoSize = true;
            this.lblSalarioFunc.Location = new System.Drawing.Point(357, 86);
            this.lblSalarioFunc.Name = "lblSalarioFunc";
            this.lblSalarioFunc.Size = new System.Drawing.Size(99, 22);
            this.lblSalarioFunc.TabIndex = 31;
            this.lblSalarioFunc.Text = "Quantidade:";
            // 
            // txtQuantidadeProd
            // 
            this.txtQuantidadeProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidadeProd.Location = new System.Drawing.Point(465, 84);
            this.txtQuantidadeProd.Name = "txtQuantidadeProd";
            this.txtQuantidadeProd.Size = new System.Drawing.Size(118, 28);
            this.txtQuantidadeProd.TabIndex = 30;
            this.txtQuantidadeProd.TextChanged += new System.EventHandler(this.txtSalarioFunc_TextChanged);
            // 
            // lblObsProd
            // 
            this.lblObsProd.AutoSize = true;
            this.lblObsProd.Location = new System.Drawing.Point(35, 142);
            this.lblObsProd.Name = "lblObsProd";
            this.lblObsProd.Size = new System.Drawing.Size(55, 22);
            this.lblObsProd.TabIndex = 29;
            this.lblObsProd.Text = "OBS.:";
            // 
            // txtObsProd
            // 
            this.txtObsProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObsProd.Location = new System.Drawing.Point(100, 140);
            this.txtObsProd.Multiline = true;
            this.txtObsProd.Name = "txtObsProd";
            this.txtObsProd.Size = new System.Drawing.Size(483, 66);
            this.txtObsProd.TabIndex = 28;
            // 
            // lblPrecoProd
            // 
            this.lblPrecoProd.AutoSize = true;
            this.lblPrecoProd.Location = new System.Drawing.Point(35, 91);
            this.lblPrecoProd.Name = "lblPrecoProd";
            this.lblPrecoProd.Size = new System.Drawing.Size(56, 22);
            this.lblPrecoProd.TabIndex = 27;
            this.lblPrecoProd.Text = "Preço:";
            // 
            // lblNomeProd
            // 
            this.lblNomeProd.AutoSize = true;
            this.lblNomeProd.Location = new System.Drawing.Point(34, 44);
            this.lblNomeProd.Name = "lblNomeProd";
            this.lblNomeProd.Size = new System.Drawing.Size(57, 22);
            this.lblNomeProd.TabIndex = 25;
            this.lblNomeProd.Text = "Nome:";
            // 
            // txtNomeProd
            // 
            this.txtNomeProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeProd.Location = new System.Drawing.Point(100, 42);
            this.txtNomeProd.Name = "txtNomeProd";
            this.txtNomeProd.Size = new System.Drawing.Size(483, 28);
            this.txtNomeProd.TabIndex = 24;
            // 
            // txtPrecoProd
            // 
            this.txtPrecoProd.Location = new System.Drawing.Point(100, 85);
            this.txtPrecoProd.Name = "txtPrecoProd";
            this.txtPrecoProd.Size = new System.Drawing.Size(166, 28);
            this.txtPrecoProd.TabIndex = 34;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEditarProd);
            this.tabPage2.Controls.Add(this.btnExcluirProd);
            this.tabPage2.Controls.Add(this.txtFiltrar);
            this.tabPage2.Controls.Add(this.lblFiltrar);
            this.tabPage2.Controls.Add(this.dgvConsultaProd);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(617, 317);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CONSULTA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcluirProd
            // 
            this.btnExcluirProd.Location = new System.Drawing.Point(405, 7);
            this.btnExcluirProd.Name = "btnExcluirProd";
            this.btnExcluirProd.Size = new System.Drawing.Size(94, 28);
            this.btnExcluirProd.TabIndex = 3;
            this.btnExcluirProd.Text = "Excluir";
            this.btnExcluirProd.UseVisualStyleBackColor = true;
            this.btnExcluirProd.Click += new System.EventHandler(this.btnExcluirProd_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(77, 7);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(309, 28);
            this.txtFiltrar.TabIndex = 2;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(7, 10);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(63, 22);
            this.lblFiltrar.TabIndex = 1;
            this.lblFiltrar.Text = "Filtrar:";
            this.lblFiltrar.Click += new System.EventHandler(this.lblFiltrar_Click);
            // 
            // dgvConsultaProd
            // 
            this.dgvConsultaProd.AllowUserToAddRows = false;
            this.dgvConsultaProd.AllowUserToDeleteRows = false;
            this.dgvConsultaProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaProd.Location = new System.Drawing.Point(0, 41);
            this.dgvConsultaProd.Name = "dgvConsultaProd";
            this.dgvConsultaProd.ReadOnly = true;
            this.dgvConsultaProd.RowHeadersVisible = false;
            this.dgvConsultaProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaProd.Size = new System.Drawing.Size(616, 276);
            this.dgvConsultaProd.TabIndex = 0;
            this.dgvConsultaProd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaProd_CellContentClick);
            this.dgvConsultaProd.DoubleClick += new System.EventHandler(this.dgvConsultaProd_DoubleClick);
            // 
            // btnEditarProd
            // 
            this.btnEditarProd.Location = new System.Drawing.Point(515, 7);
            this.btnEditarProd.Name = "btnEditarProd";
            this.btnEditarProd.Size = new System.Drawing.Size(94, 28);
            this.btnEditarProd.TabIndex = 4;
            this.btnEditarProd.Text = "Editar";
            this.btnEditarProd.UseVisualStyleBackColor = true;
            this.btnEditarProd.Click += new System.EventHandler(this.btnEditarProd_Click);
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 352);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.frmProdutos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnLimparProd;
        private System.Windows.Forms.Button btnCadastrarProd;
        public System.Windows.Forms.Label lblSalarioFunc;
        private System.Windows.Forms.TextBox txtQuantidadeProd;
        public System.Windows.Forms.Label lblObsProd;
        private System.Windows.Forms.TextBox txtObsProd;
        private System.Windows.Forms.Label lblPrecoProd;
        public System.Windows.Forms.Label lblNomeProd;
        private System.Windows.Forms.TextBox txtNomeProd;
        private System.Windows.Forms.TextBox txtPrecoProd;
        private System.Windows.Forms.DataGridView dgvConsultaProd;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Button btnExcluirProd;
        private System.Windows.Forms.Button btnEditarProd;
    }
}