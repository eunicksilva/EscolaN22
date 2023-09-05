namespace Escola_POO_Base.Telas
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.sspRodape = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslNomeUserLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslEmailUserLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslPerfilUserLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiAlterarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiCadastrarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.sspRodape.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sspRodape
            // 
            this.sspRodape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslNomeUserLogado,
            this.toolStripStatusLabel2,
            this.tslEmailUserLogado,
            this.toolStripStatusLabel3,
            this.tslPerfilUserLogado,
            this.tslDataHora});
            this.sspRodape.Location = new System.Drawing.Point(0, 627);
            this.sspRodape.Name = "sspRodape";
            this.sspRodape.Size = new System.Drawing.Size(1014, 22);
            this.sspRodape.TabIndex = 1;
            this.sspRodape.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "Usuário Logado:";
            // 
            // tslNomeUserLogado
            // 
            this.tslNomeUserLogado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslNomeUserLogado.ForeColor = System.Drawing.Color.OrangeRed;
            this.tslNomeUserLogado.Name = "tslNomeUserLogado";
            this.tslNomeUserLogado.Size = new System.Drawing.Size(120, 17);
            this.tslNomeUserLogado.Text = "toolStripStatusLabel";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel2.Text = "Email:";
            // 
            // tslEmailUserLogado
            // 
            this.tslEmailUserLogado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslEmailUserLogado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tslEmailUserLogado.Name = "tslEmailUserLogado";
            this.tslEmailUserLogado.Size = new System.Drawing.Size(127, 17);
            this.tslEmailUserLogado.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel3.Text = "Perfil:";
            // 
            // tslPerfilUserLogado
            // 
            this.tslPerfilUserLogado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslPerfilUserLogado.ForeColor = System.Drawing.Color.Blue;
            this.tslPerfilUserLogado.Name = "tslPerfilUserLogado";
            this.tslPerfilUserLogado.Size = new System.Drawing.Size(127, 17);
            this.tslPerfilUserLogado.Text = "toolStripStatusLabel3";
            // 
            // tslDataHora
            // 
            this.tslDataHora.Name = "tslDataHora";
            this.tslDataHora.Size = new System.Drawing.Size(306, 17);
            this.tslDataHora.Spring = true;
            this.tslDataHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.tsiCadastro});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiAlterarSenha});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // tsiAlterarSenha
            // 
            this.tsiAlterarSenha.Name = "tsiAlterarSenha";
            this.tsiAlterarSenha.Size = new System.Drawing.Size(144, 22);
            this.tsiAlterarSenha.Text = "Alterar Senha";
            this.tsiAlterarSenha.Click += new System.EventHandler(this.tsiAlterarSenha_Click);
            // 
            // tsiCadastro
            // 
            this.tsiCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiCadastrarAluno});
            this.tsiCadastro.Name = "tsiCadastro";
            this.tsiCadastro.Size = new System.Drawing.Size(71, 20);
            this.tsiCadastro.Text = "Cadastros";
            // 
            // tsiCadastrarAluno
            // 
            this.tsiCadastrarAluno.Name = "tsiCadastrarAluno";
            this.tsiCadastrarAluno.Size = new System.Drawing.Size(106, 22);
            this.tsiCadastrarAluno.Text = "Aluno";
            this.tsiCadastrarAluno.Click += new System.EventHandler(this.tsiCadastrarAluno_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1014, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tmrRelogio
            // 
            this.tmrRelogio.Tick += new System.EventHandler(this.tmrRelogio_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 649);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.sspRodape);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.sspRodape.ResumeLayout(false);
            this.sspRodape.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip sspRodape;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslNomeUserLogado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tslEmailUserLogado;
        private System.Windows.Forms.ToolStripStatusLabel tslDataHora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsiAlterarSenha;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tslPerfilUserLogado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsiCadastro;
        private System.Windows.Forms.ToolStripMenuItem tsiCadastrarAluno;
        private System.Windows.Forms.Timer tmrRelogio;
    }
}