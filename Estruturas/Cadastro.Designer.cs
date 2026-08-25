namespace Estruturas
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            pibImagem = new PictureBox();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)pibImagem).BeginInit();
            SuspendLayout();
            // 
            // pibImagem
            // 
            pibImagem.Image = (Image)resources.GetObject("pibImagem.Image");
            pibImagem.Location = new Point(47, 30);
            pibImagem.Name = "pibImagem";
            pibImagem.Size = new Size(213, 237);
            pibImagem.TabIndex = 0;
            pibImagem.TabStop = false;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(98, 285);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(106, 40);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(pibImagem);
            Name = "frmCadastro";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)pibImagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pibImagem;
        private Button btnFechar;
    }
}