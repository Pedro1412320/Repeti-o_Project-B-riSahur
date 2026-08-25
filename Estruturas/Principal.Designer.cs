namespace Estruturas
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlContainer = new Panel();
            btnSair = new Button();
            pnlLogin = new Panel();
            btnLimpar = new Button();
            btnTestar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            lsbMostra = new ListBox();
            lblRepeticao = new Label();
            pnlRepeticao = new Panel();
            btnContinue = new Button();
            btnFor = new Button();
            btnBreak = new Button();
            btnDoWhile = new Button();
            btnForEach = new Button();
            btnWhile = new Button();
            lblCondicional = new Label();
            pnlContainer.SuspendLayout();
            pnlLogin.SuspendLayout();
            pnlRepeticao.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Anchor = AnchorStyles.None;
            pnlContainer.Controls.Add(btnSair);
            pnlContainer.Controls.Add(pnlLogin);
            pnlContainer.Controls.Add(lsbMostra);
            pnlContainer.Controls.Add(lblRepeticao);
            pnlContainer.Controls.Add(pnlRepeticao);
            pnlContainer.Controls.Add(lblCondicional);
            pnlContainer.Location = new Point(31, 27);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(811, 498);
            pnlContainer.TabIndex = 0;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(626, 21);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(103, 38);
            btnSair.TabIndex = 11;
            btnSair.Text = "Sair do sistema";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.BorderStyle = BorderStyle.Fixed3D;
            pnlLogin.Controls.Add(btnLimpar);
            pnlLogin.Controls.Add(btnTestar);
            pnlLogin.Controls.Add(txtSenha);
            pnlLogin.Controls.Add(lblSenha);
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Controls.Add(lblUsuario);
            pnlLogin.Location = new Point(72, 66);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(270, 139);
            pnlLogin.TabIndex = 10;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(159, 89);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(91, 23);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnTestar
            // 
            btnTestar.Location = new Point(159, 34);
            btnTestar.Name = "btnTestar";
            btnTestar.Size = new Size(91, 23);
            btnTestar.TabIndex = 1;
            btnTestar.Text = "Entrar";
            btnTestar.UseVisualStyleBackColor = true;
            btnTestar.Click += btnTestar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(20, 89);
            txtSenha.MaxLength = 20;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(114, 23);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(20, 70);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(20, 34);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(114, 23);
            txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(20, 15);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(47, 15);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário";
            // 
            // lsbMostra
            // 
            lsbMostra.FormattingEnabled = true;
            lsbMostra.ItemHeight = 15;
            lsbMostra.Location = new Point(373, 65);
            lsbMostra.Name = "lsbMostra";
            lsbMostra.Size = new Size(356, 379);
            lsbMostra.TabIndex = 9;
            // 
            // lblRepeticao
            // 
            lblRepeticao.AutoSize = true;
            lblRepeticao.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRepeticao.Location = new Point(72, 222);
            lblRepeticao.Name = "lblRepeticao";
            lblRepeticao.Size = new Size(185, 21);
            lblRepeticao.TabIndex = 8;
            lblRepeticao.Text = "Estruturas de repetição";
            // 
            // pnlRepeticao
            // 
            pnlRepeticao.BorderStyle = BorderStyle.Fixed3D;
            pnlRepeticao.Controls.Add(btnContinue);
            pnlRepeticao.Controls.Add(btnFor);
            pnlRepeticao.Controls.Add(btnBreak);
            pnlRepeticao.Controls.Add(btnDoWhile);
            pnlRepeticao.Controls.Add(btnForEach);
            pnlRepeticao.Controls.Add(btnWhile);
            pnlRepeticao.Location = new Point(72, 255);
            pnlRepeticao.Name = "pnlRepeticao";
            pnlRepeticao.Size = new Size(270, 189);
            pnlRepeticao.TabIndex = 7;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(146, 130);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(91, 40);
            btnContinue.TabIndex = 10;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // btnFor
            // 
            btnFor.Location = new Point(32, 130);
            btnFor.Name = "btnFor";
            btnFor.Size = new Size(91, 40);
            btnFor.TabIndex = 9;
            btnFor.Text = "For";
            btnFor.UseVisualStyleBackColor = true;
            btnFor.Click += btnFor_Click;
            // 
            // btnBreak
            // 
            btnBreak.Location = new Point(147, 68);
            btnBreak.Name = "btnBreak";
            btnBreak.Size = new Size(91, 40);
            btnBreak.TabIndex = 8;
            btnBreak.Text = "Break";
            btnBreak.UseVisualStyleBackColor = true;
            btnBreak.Click += btnBreak_Click;
            // 
            // btnDoWhile
            // 
            btnDoWhile.Location = new Point(33, 68);
            btnDoWhile.Name = "btnDoWhile";
            btnDoWhile.Size = new Size(91, 40);
            btnDoWhile.TabIndex = 7;
            btnDoWhile.Text = "Do...While";
            btnDoWhile.UseVisualStyleBackColor = true;
            btnDoWhile.Click += btnDoWhile_Click;
            // 
            // btnForEach
            // 
            btnForEach.Location = new Point(146, 10);
            btnForEach.Name = "btnForEach";
            btnForEach.Size = new Size(91, 40);
            btnForEach.TabIndex = 6;
            btnForEach.Text = "ForEach";
            btnForEach.UseVisualStyleBackColor = true;
            btnForEach.Click += btnForEach_Click;
            // 
            // btnWhile
            // 
            btnWhile.Location = new Point(32, 10);
            btnWhile.Name = "btnWhile";
            btnWhile.Size = new Size(91, 40);
            btnWhile.TabIndex = 5;
            btnWhile.Text = "While";
            btnWhile.UseVisualStyleBackColor = true;
            btnWhile.Click += btnWhile_Click;
            // 
            // lblCondicional
            // 
            lblCondicional.AutoSize = true;
            lblCondicional.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCondicional.Location = new Point(72, 40);
            lblCondicional.Name = "lblCondicional";
            lblCondicional.Size = new Size(175, 21);
            lblCondicional.TabIndex = 6;
            lblCondicional.Text = "Estrutura Condicional";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 525);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Principal";
            WindowState = FormWindowState.Maximized;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlRepeticao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private ListBox lsbMostra;
        private Label lblRepeticao;
        private Panel pnlRepeticao;
        private Button btnContinue;
        private Button btnFor;
        private Button btnBreak;
        private Button btnDoWhile;
        private Button btnForEach;
        private Button btnWhile;
        private Label lblCondicional;
        private Panel pnlLogin;
        private Button btnLimpar;
        private Button btnTestar;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Button btnSair;
    }
}
