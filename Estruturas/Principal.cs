namespace Estruturas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "Tente123@";

            if (usuario == txtUsuario.Text & senha == txtSenha.Text)
            {
                frmCadastro cadastro = new frmCadastro();
                cadastro.FormBorderStyle = FormBorderStyle.None;
                cadastro.Bounds = Screen.PrimaryScreen.Bounds;
                cadastro.TopMost = true;
                cadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!!", "Verificação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
                txtUsuario.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int cont = 1;
            int num = 5;

            lsbMostra.Items.Clear();

            while (cont <= 10)
            {
                lsbMostra.Items.Add(
                    num + " x " + cont + " = " + (num * cont)
                );

                cont++;
            }

        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int num = 5;
            int cont = 1;
            int fatorial = 1;

            lsbMostra.Items.Clear();

            do
            {
                fatorial *= cont;

                lsbMostra.Items.Add(
                    cont + "! = " + fatorial
                );

                cont++;
            }
            while (cont <= num);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lsbMostra.Items.Clear();

            for (int num = 2; num <= 100; num++)
            {
                int cont = 2;
                bool primo = true;

                while (cont < num)
                {
                    if (num % cont == 0)
                    {
                        primo = false;
                        break;
                    }

                    cont++;
                }

                if (primo)
                {
                    lsbMostra.Items.Add(num.ToString());
                }
            }
        }

        private void btnForEach_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[100];

            for (int cont = 0; cont < 100; cont++)
            {
                numeros[cont] = cont + 1;
            }

            lsbMostra.Items.Clear();

            foreach (int numero in numeros)
            {
                lsbMostra.Items.Add(
                    numero + "² = " + (numero * numero)
                );
            }
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            int[] numeros = { 25, 8, 42, 13, 31 };

            int maior = numeros[0];
            int menor = numeros[0];

            lsbMostra.Items.Clear();

            for (int cont = 1; cont < numeros.Length; cont++)
            {
                if (numeros[cont] > maior)
                {
                    maior = numeros[cont];
                }

                if (numeros[cont] < menor)
                {
                    menor = numeros[cont];
                }
            }

            lsbMostra.Items.Add("Maior: " + maior);
            lsbMostra.Items.Add("Menor: " + menor);
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            int cont = 5;
            lsbMostra.Items.Clear();
            double fatorial = 1;

            while (cont <= 5 & cont >= 1)
            {
                fatorial *= cont;
                cont--;

                if (cont == 2)
                {
                    continue;
                }
                lsbMostra.Items.Add(fatorial.ToString());
            }
        }
    }
}
