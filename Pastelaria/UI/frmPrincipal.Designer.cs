﻿namespace Pastelaria
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CADASTROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fUNCIONÁRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CADASTROSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1428, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CADASTROSToolStripMenuItem
            // 
            this.CADASTROSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fUNCIONÁRIOSToolStripMenuItem,
            this.pRODUTOSToolStripMenuItem,
            this.cLIENTESToolStripMenuItem});
            this.CADASTROSToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CADASTROSToolStripMenuItem.Name = "CADASTROSToolStripMenuItem";
            this.CADASTROSToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.CADASTROSToolStripMenuItem.Text = "CADASTROS";
            // 
            // fUNCIONÁRIOSToolStripMenuItem
            // 
            this.fUNCIONÁRIOSToolStripMenuItem.Name = "fUNCIONÁRIOSToolStripMenuItem";
            this.fUNCIONÁRIOSToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.fUNCIONÁRIOSToolStripMenuItem.Text = "FUNCIONÁRIOS";
            this.fUNCIONÁRIOSToolStripMenuItem.Click += new System.EventHandler(this.fUNCIONÁRIOSToolStripMenuItem_Click);
            // 
            // pRODUTOSToolStripMenuItem
            // 
            this.pRODUTOSToolStripMenuItem.Name = "pRODUTOSToolStripMenuItem";
            this.pRODUTOSToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.pRODUTOSToolStripMenuItem.Text = "PRODUTOS";
            this.pRODUTOSToolStripMenuItem.Click += new System.EventHandler(this.pRODUTOSToolStripMenuItem_Click);
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1428, 719);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pastelaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CADASTROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fUNCIONÁRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
    }
}

