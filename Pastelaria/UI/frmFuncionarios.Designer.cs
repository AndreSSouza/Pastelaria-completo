namespace Pastelaria.UI
{
    partial class frmFuncionarios
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
            this.btnLimparFunc = new System.Windows.Forms.Button();
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
            this.lblSalarioFunc = new System.Windows.Forms.Label();
            this.txtSalarioFunc = new System.Windows.Forms.TextBox();
            this.lblFuncaoFunc = new System.Windows.Forms.Label();
            this.txtFuncaoFunc = new System.Windows.Forms.TextBox();
            this.lblCelularFunc = new System.Windows.Forms.Label();
            this.mtxtCelularFunc = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcluirFunc = new System.Windows.Forms.Button();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.dgvConsultaFunc = new System.Windows.Forms.DataGridView();
            this.btnEditarFunc = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFunc)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(611, 386);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLimparFunc);
            this.tabPage1.Controls.Add(this.btnCadastrarFunc);
            this.tabPage1.Controls.Add(this.lblSalarioFunc);
            this.tabPage1.Controls.Add(this.txtSalarioFunc);
            this.tabPage1.Controls.Add(this.lblFuncaoFunc);
            this.tabPage1.Controls.Add(this.txtFuncaoFunc);
            this.tabPage1.Controls.Add(this.lblCelularFunc);
            this.tabPage1.Controls.Add(this.mtxtCelularFunc);
            this.tabPage1.Controls.Add(this.lblNomeFunc);
            this.tabPage1.Controls.Add(this.txtNomeFunc);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(603, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CADASTRO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimparFunc
            // 
            this.btnLimparFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimparFunc.Location = new System.Drawing.Point(311, 219);
            this.btnLimparFunc.Name = "btnLimparFunc";
            this.btnLimparFunc.Size = new System.Drawing.Size(128, 34);
            this.btnLimparFunc.TabIndex = 23;
            this.btnLimparFunc.Text = "Limpar";
            this.btnLimparFunc.UseVisualStyleBackColor = true;
            this.btnLimparFunc.Click += new System.EventHandler(this.btnLimparFunc_Click);
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.Location = new System.Drawing.Point(89, 219);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(151, 34);
            this.btnCadastrarFunc.TabIndex = 22;
            this.btnCadastrarFunc.Text = "Cadastrar";
            this.btnCadastrarFunc.UseVisualStyleBackColor = true;
            this.btnCadastrarFunc.Click += new System.EventHandler(this.btnCadastrarFunc_Click);
            // 
            // lblSalarioFunc
            // 
            this.lblSalarioFunc.AutoSize = true;
            this.lblSalarioFunc.Location = new System.Drawing.Point(41, 136);
            this.lblSalarioFunc.Name = "lblSalarioFunc";
            this.lblSalarioFunc.Size = new System.Drawing.Size(66, 22);
            this.lblSalarioFunc.TabIndex = 17;
            this.lblSalarioFunc.Text = "Salário:";
            // 
            // txtSalarioFunc
            // 
            this.txtSalarioFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalarioFunc.Location = new System.Drawing.Point(116, 134);
            this.txtSalarioFunc.Name = "txtSalarioFunc";
            this.txtSalarioFunc.Size = new System.Drawing.Size(128, 28);
            this.txtSalarioFunc.TabIndex = 16;
            // 
            // lblFuncaoFunc
            // 
            this.lblFuncaoFunc.AutoSize = true;
            this.lblFuncaoFunc.Location = new System.Drawing.Point(41, 86);
            this.lblFuncaoFunc.Name = "lblFuncaoFunc";
            this.lblFuncaoFunc.Size = new System.Drawing.Size(66, 22);
            this.lblFuncaoFunc.TabIndex = 15;
            this.lblFuncaoFunc.Text = "Função:";
            // 
            // txtFuncaoFunc
            // 
            this.txtFuncaoFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFuncaoFunc.Location = new System.Drawing.Point(116, 84);
            this.txtFuncaoFunc.Name = "txtFuncaoFunc";
            this.txtFuncaoFunc.Size = new System.Drawing.Size(356, 28);
            this.txtFuncaoFunc.TabIndex = 14;
            // 
            // lblCelularFunc
            // 
            this.lblCelularFunc.AutoSize = true;
            this.lblCelularFunc.Location = new System.Drawing.Point(273, 136);
            this.lblCelularFunc.Name = "lblCelularFunc";
            this.lblCelularFunc.Size = new System.Drawing.Size(65, 22);
            this.lblCelularFunc.TabIndex = 10;
            this.lblCelularFunc.Text = "Celular:";
            // 
            // mtxtCelularFunc
            // 
            this.mtxtCelularFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtCelularFunc.Location = new System.Drawing.Point(344, 134);
            this.mtxtCelularFunc.Mask = "(00)00000-0000";
            this.mtxtCelularFunc.Name = "mtxtCelularFunc";
            this.mtxtCelularFunc.Size = new System.Drawing.Size(128, 28);
            this.mtxtCelularFunc.TabIndex = 9;
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(50, 33);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(57, 22);
            this.lblNomeFunc.TabIndex = 4;
            this.lblNomeFunc.Text = "Nome:";
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeFunc.Location = new System.Drawing.Point(116, 31);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(356, 28);
            this.txtNomeFunc.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEditarFunc);
            this.tabPage2.Controls.Add(this.btnExcluirFunc);
            this.tabPage2.Controls.Add(this.txtFiltrar);
            this.tabPage2.Controls.Add(this.lblFiltrar);
            this.tabPage2.Controls.Add(this.dgvConsultaFunc);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(603, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CONSULTA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcluirFunc
            // 
            this.btnExcluirFunc.Location = new System.Drawing.Point(422, 7);
            this.btnExcluirFunc.Name = "btnExcluirFunc";
            this.btnExcluirFunc.Size = new System.Drawing.Size(75, 28);
            this.btnExcluirFunc.TabIndex = 6;
            this.btnExcluirFunc.Text = "Excluir";
            this.btnExcluirFunc.UseVisualStyleBackColor = true;
            this.btnExcluirFunc.Click += new System.EventHandler(this.btnExcluirFunc_Click);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(75, 6);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(341, 28);
            this.txtFiltrar.TabIndex = 5;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(5, 9);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(63, 22);
            this.lblFiltrar.TabIndex = 4;
            this.lblFiltrar.Text = "Filtrar:";
            // 
            // dgvConsultaFunc
            // 
            this.dgvConsultaFunc.AllowUserToAddRows = false;
            this.dgvConsultaFunc.AllowUserToDeleteRows = false;
            this.dgvConsultaFunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultaFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaFunc.Location = new System.Drawing.Point(0, 41);
            this.dgvConsultaFunc.Name = "dgvConsultaFunc";
            this.dgvConsultaFunc.ReadOnly = true;
            this.dgvConsultaFunc.RowHeadersVisible = false;
            this.dgvConsultaFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaFunc.Size = new System.Drawing.Size(603, 310);
            this.dgvConsultaFunc.TabIndex = 3;
            this.dgvConsultaFunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaProd_CellContentClick);
            this.dgvConsultaFunc.DoubleClick += new System.EventHandler(this.dgvConsultaFunc_DoubleClick);
            // 
            // btnEditarFunc
            // 
            this.btnEditarFunc.Location = new System.Drawing.Point(511, 7);
            this.btnEditarFunc.Name = "btnEditarFunc";
            this.btnEditarFunc.Size = new System.Drawing.Size(84, 28);
            this.btnEditarFunc.TabIndex = 7;
            this.btnEditarFunc.Text = "Editar";
            this.btnEditarFunc.UseVisualStyleBackColor = true;
            this.btnEditarFunc.Click += new System.EventHandler(this.btnEditarFunc_Click);
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 386);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários";
            this.Load += new System.EventHandler(this.frmFuncionarios_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFunc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.Label lblFuncaoFunc;
        private System.Windows.Forms.MaskedTextBox mtxtCelularFunc;
        public System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Button btnLimparFunc;
        private System.Windows.Forms.Button btnCadastrarFunc;
        public System.Windows.Forms.Label lblSalarioFunc;
        private System.Windows.Forms.TextBox txtSalarioFunc;
        private System.Windows.Forms.TextBox txtFuncaoFunc;
        private System.Windows.Forms.Label lblCelularFunc;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.DataGridView dgvConsultaFunc;
        private System.Windows.Forms.Button btnExcluirFunc;
        private System.Windows.Forms.Button btnEditarFunc;
    }
}