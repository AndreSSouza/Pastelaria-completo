namespace Pastelaria.UI
{
    partial class frmClientes
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
            this.mtxtCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblCpfCliente = new System.Windows.Forms.Label();
            this.lblReferenciaCliente = new System.Windows.Forms.Label();
            this.txtReferenciaCliente = new System.Windows.Forms.TextBox();
            this.mtxtCep = new System.Windows.Forms.MaskedTextBox();
            this.lblCepCliente = new System.Windows.Forms.Label();
            this.btnLimparCli = new System.Windows.Forms.Button();
            this.btnCadastrarCli = new System.Windows.Forms.Button();
            this.lblCidadeCliente = new System.Windows.Forms.Label();
            this.txtCidadeCliente = new System.Windows.Forms.TextBox();
            this.lblBairroCliente = new System.Windows.Forms.Label();
            this.txtBairroCliente = new System.Windows.Forms.TextBox();
            this.lblNumeroCliente = new System.Windows.Forms.Label();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.lblEnderecoCliente = new System.Windows.Forms.Label();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.mtxtTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.mtxtCelularCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.dgvConsultaCli = new System.Windows.Forms.DataGridView();
            this.btnExcluirCli = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCli)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 570);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mtxtCpfCliente);
            this.tabPage1.Controls.Add(this.lblCpfCliente);
            this.tabPage1.Controls.Add(this.lblReferenciaCliente);
            this.tabPage1.Controls.Add(this.txtReferenciaCliente);
            this.tabPage1.Controls.Add(this.mtxtCep);
            this.tabPage1.Controls.Add(this.lblCepCliente);
            this.tabPage1.Controls.Add(this.btnLimparCli);
            this.tabPage1.Controls.Add(this.btnCadastrarCli);
            this.tabPage1.Controls.Add(this.lblCidadeCliente);
            this.tabPage1.Controls.Add(this.txtCidadeCliente);
            this.tabPage1.Controls.Add(this.lblBairroCliente);
            this.tabPage1.Controls.Add(this.txtBairroCliente);
            this.tabPage1.Controls.Add(this.lblNumeroCliente);
            this.tabPage1.Controls.Add(this.txtNumeroCliente);
            this.tabPage1.Controls.Add(this.lblEnderecoCliente);
            this.tabPage1.Controls.Add(this.txtEnderecoCliente);
            this.tabPage1.Controls.Add(this.lblEmailCliente);
            this.tabPage1.Controls.Add(this.lblCelular);
            this.tabPage1.Controls.Add(this.mtxtTelefoneCliente);
            this.tabPage1.Controls.Add(this.mtxtCelularCliente);
            this.tabPage1.Controls.Add(this.lblTelefoneCliente);
            this.tabPage1.Controls.Add(this.lblNomeCliente);
            this.tabPage1.Controls.Add(this.txtEmailCliente);
            this.tabPage1.Controls.Add(this.txtNomeCliente);
            this.tabPage1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CADASTRO";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // mtxtCpfCliente
            // 
            this.mtxtCpfCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtCpfCliente.Location = new System.Drawing.Point(151, 335);
            this.mtxtCpfCliente.Mask = "000,000,000-00";
            this.mtxtCpfCliente.Name = "mtxtCpfCliente";
            this.mtxtCpfCliente.Size = new System.Drawing.Size(130, 28);
            this.mtxtCpfCliente.TabIndex = 23;
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Location = new System.Drawing.Point(89, 337);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(43, 22);
            this.lblCpfCliente.TabIndex = 22;
            this.lblCpfCliente.Text = "CPF:";
            // 
            // lblReferenciaCliente
            // 
            this.lblReferenciaCliente.AutoSize = true;
            this.lblReferenciaCliente.Location = new System.Drawing.Point(37, 303);
            this.lblReferenciaCliente.Name = "lblReferenciaCliente";
            this.lblReferenciaCliente.Size = new System.Drawing.Size(94, 22);
            this.lblReferenciaCliente.TabIndex = 21;
            this.lblReferenciaCliente.Text = "Referência:";
            // 
            // txtReferenciaCliente
            // 
            this.txtReferenciaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReferenciaCliente.Location = new System.Drawing.Point(151, 297);
            this.txtReferenciaCliente.Name = "txtReferenciaCliente";
            this.txtReferenciaCliente.Size = new System.Drawing.Size(241, 28);
            this.txtReferenciaCliente.TabIndex = 20;
            // 
            // mtxtCep
            // 
            this.mtxtCep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtCep.Location = new System.Drawing.Point(417, 255);
            this.mtxtCep.Mask = "00000-000";
            this.mtxtCep.Name = "mtxtCep";
            this.mtxtCep.Size = new System.Drawing.Size(90, 28);
            this.mtxtCep.TabIndex = 19;
            this.mtxtCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // lblCepCliente
            // 
            this.lblCepCliente.AutoSize = true;
            this.lblCepCliente.Location = new System.Drawing.Point(377, 258);
            this.lblCepCliente.Name = "lblCepCliente";
            this.lblCepCliente.Size = new System.Drawing.Size(43, 22);
            this.lblCepCliente.TabIndex = 18;
            this.lblCepCliente.Text = "CEP:";
            // 
            // btnLimparCli
            // 
            this.btnLimparCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimparCli.Location = new System.Drawing.Point(376, 420);
            this.btnLimparCli.Name = "btnLimparCli";
            this.btnLimparCli.Size = new System.Drawing.Size(128, 34);
            this.btnLimparCli.TabIndex = 17;
            this.btnLimparCli.Text = "Limpar";
            this.btnLimparCli.UseVisualStyleBackColor = true;
            this.btnLimparCli.Click += new System.EventHandler(this.btnLimparCli_Click);
            // 
            // btnCadastrarCli
            // 
            this.btnCadastrarCli.Location = new System.Drawing.Point(154, 420);
            this.btnCadastrarCli.Name = "btnCadastrarCli";
            this.btnCadastrarCli.Size = new System.Drawing.Size(151, 34);
            this.btnCadastrarCli.TabIndex = 16;
            this.btnCadastrarCli.Text = "Cadastrar";
            this.btnCadastrarCli.UseVisualStyleBackColor = true;
            this.btnCadastrarCli.Click += new System.EventHandler(this.btnCadastrarCli_Click);
            // 
            // lblCidadeCliente
            // 
            this.lblCidadeCliente.AutoSize = true;
            this.lblCidadeCliente.Location = new System.Drawing.Point(68, 258);
            this.lblCidadeCliente.Name = "lblCidadeCliente";
            this.lblCidadeCliente.Size = new System.Drawing.Size(64, 22);
            this.lblCidadeCliente.TabIndex = 15;
            this.lblCidadeCliente.Text = "Cidade:";
            // 
            // txtCidadeCliente
            // 
            this.txtCidadeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCidadeCliente.Location = new System.Drawing.Point(151, 255);
            this.txtCidadeCliente.Name = "txtCidadeCliente";
            this.txtCidadeCliente.Size = new System.Drawing.Size(210, 28);
            this.txtCidadeCliente.TabIndex = 14;
            // 
            // lblBairroCliente
            // 
            this.lblBairroCliente.AutoSize = true;
            this.lblBairroCliente.Location = new System.Drawing.Point(68, 217);
            this.lblBairroCliente.Name = "lblBairroCliente";
            this.lblBairroCliente.Size = new System.Drawing.Size(60, 22);
            this.lblBairroCliente.TabIndex = 13;
            this.lblBairroCliente.Text = "Bairro:";
            this.lblBairroCliente.Click += new System.EventHandler(this.lblBairroCliente_Click);
            // 
            // txtBairroCliente
            // 
            this.txtBairroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairroCliente.Location = new System.Drawing.Point(151, 214);
            this.txtBairroCliente.Name = "txtBairroCliente";
            this.txtBairroCliente.Size = new System.Drawing.Size(210, 28);
            this.txtBairroCliente.TabIndex = 12;
            // 
            // lblNumeroCliente
            // 
            this.lblNumeroCliente.AutoSize = true;
            this.lblNumeroCliente.Location = new System.Drawing.Point(413, 171);
            this.lblNumeroCliente.Name = "lblNumeroCliente";
            this.lblNumeroCliente.Size = new System.Drawing.Size(38, 22);
            this.lblNumeroCliente.TabIndex = 11;
            this.lblNumeroCliente.Text = "Nº:";
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroCliente.Location = new System.Drawing.Point(460, 168);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(47, 28);
            this.txtNumeroCliente.TabIndex = 10;
            // 
            // lblEnderecoCliente
            // 
            this.lblEnderecoCliente.AutoSize = true;
            this.lblEnderecoCliente.Location = new System.Drawing.Point(54, 171);
            this.lblEnderecoCliente.Name = "lblEnderecoCliente";
            this.lblEnderecoCliente.Size = new System.Drawing.Size(82, 22);
            this.lblEnderecoCliente.TabIndex = 9;
            this.lblEnderecoCliente.Text = "Endereço:";
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnderecoCliente.Location = new System.Drawing.Point(151, 168);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(241, 28);
            this.txtEnderecoCliente.TabIndex = 8;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(68, 131);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(63, 22);
            this.lblEmailCliente.TabIndex = 7;
            this.lblEmailCliente.Text = "E-mail:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(296, 97);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(65, 22);
            this.lblCelular.TabIndex = 6;
            this.lblCelular.Text = "Celular:";
            // 
            // mtxtTelefoneCliente
            // 
            this.mtxtTelefoneCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtTelefoneCliente.Location = new System.Drawing.Point(151, 91);
            this.mtxtTelefoneCliente.Mask = "(00)0000-0000";
            this.mtxtTelefoneCliente.Name = "mtxtTelefoneCliente";
            this.mtxtTelefoneCliente.Size = new System.Drawing.Size(118, 28);
            this.mtxtTelefoneCliente.TabIndex = 5;
            // 
            // mtxtCelularCliente
            // 
            this.mtxtCelularCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mtxtCelularCliente.Location = new System.Drawing.Point(379, 94);
            this.mtxtCelularCliente.Mask = "(00)00000-0000";
            this.mtxtCelularCliente.Name = "mtxtCelularCliente";
            this.mtxtCelularCliente.Size = new System.Drawing.Size(128, 28);
            this.mtxtCelularCliente.TabIndex = 4;
            // 
            // lblTelefoneCliente
            // 
            this.lblTelefoneCliente.AutoSize = true;
            this.lblTelefoneCliente.Location = new System.Drawing.Point(54, 94);
            this.lblTelefoneCliente.Name = "lblTelefoneCliente";
            this.lblTelefoneCliente.Size = new System.Drawing.Size(79, 22);
            this.lblTelefoneCliente.TabIndex = 3;
            this.lblTelefoneCliente.Text = "Telefone:";
            this.lblTelefoneCliente.Click += new System.EventHandler(this.lblTelefoneCliente_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(76, 55);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(57, 22);
            this.lblNomeCliente.TabIndex = 2;
            this.lblNomeCliente.Text = "Nome:";
            this.lblNomeCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailCliente.Location = new System.Drawing.Point(151, 128);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(356, 28);
            this.txtEmailCliente.TabIndex = 1;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCliente.Location = new System.Drawing.Point(151, 49);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(356, 28);
            this.txtNomeCliente.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcluirCli);
            this.tabPage2.Controls.Add(this.txtFiltrar);
            this.tabPage2.Controls.Add(this.lblFiltrar);
            this.tabPage2.Controls.Add(this.dgvConsultaCli);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CONSULTA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(82, 6);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(488, 28);
            this.txtFiltrar.TabIndex = 5;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(12, 9);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(63, 22);
            this.lblFiltrar.TabIndex = 4;
            this.lblFiltrar.Text = "Filtrar:";
            // 
            // dgvConsultaCli
            // 
            this.dgvConsultaCli.AllowUserToAddRows = false;
            this.dgvConsultaCli.AllowUserToDeleteRows = false;
            this.dgvConsultaCli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsultaCli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaCli.Location = new System.Drawing.Point(0, 40);
            this.dgvConsultaCli.Name = "dgvConsultaCli";
            this.dgvConsultaCli.ReadOnly = true;
            this.dgvConsultaCli.RowHeadersVisible = false;
            this.dgvConsultaCli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaCli.Size = new System.Drawing.Size(676, 495);
            this.dgvConsultaCli.TabIndex = 3;
            // 
            // btnExcluirCli
            // 
            this.btnExcluirCli.Location = new System.Drawing.Point(576, 6);
            this.btnExcluirCli.Name = "btnExcluirCli";
            this.btnExcluirCli.Size = new System.Drawing.Size(94, 28);
            this.btnExcluirCli.TabIndex = 6;
            this.btnExcluirCli.Text = "Excluir";
            this.btnExcluirCli.UseVisualStyleBackColor = true;
            this.btnExcluirCli.Click += new System.EventHandler(this.btnExcluirCli_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 570);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaCli)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTelefoneCliente;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        public System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.MaskedTextBox mtxtCelularCliente;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.MaskedTextBox mtxtTelefoneCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        public System.Windows.Forms.Label lblBairroCliente;
        private System.Windows.Forms.TextBox txtBairroCliente;
        public System.Windows.Forms.Label lblNumeroCliente;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        public System.Windows.Forms.Label lblEnderecoCliente;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.MaskedTextBox mtxtCep;
        private System.Windows.Forms.Label lblCepCliente;
        private System.Windows.Forms.Button btnLimparCli;
        private System.Windows.Forms.Button btnCadastrarCli;
        public System.Windows.Forms.Label lblCidadeCliente;
        private System.Windows.Forms.TextBox txtCidadeCliente;
        public System.Windows.Forms.Label lblReferenciaCliente;
        private System.Windows.Forms.TextBox txtReferenciaCliente;
        private System.Windows.Forms.MaskedTextBox mtxtCpfCliente;
        private System.Windows.Forms.Label lblCpfCliente;
        private System.Windows.Forms.TextBox txtFiltrar;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.DataGridView dgvConsultaCli;
        private System.Windows.Forms.Button btnExcluirCli;
    }
}