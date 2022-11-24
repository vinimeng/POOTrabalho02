using Exercicio01.Cargos;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class JanelaPrincipal : Form
    {
        private BindingList<Funcionario> Funcionarios;

        public JanelaPrincipal()
        {
            InitializeComponent();
            Funcionarios = new BindingList<Funcionario>();
            comboBoxTipoFunc.SelectedIndex = 0;
            listBoxFunc.DataSource = Funcionarios;
            richTextBoxGerarFolha.ReadOnly = true;
        }

        private void comboBoxTipoFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipo = (string)comboBoxTipoFunc.SelectedItem;
            if (tipo == "Analista")
            {
                numBonus.Enabled = true;
            }
            else
            {
                numBonus.Enabled = false;
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = string.Empty;
            textBoxMatricula.Text = string.Empty;
            numSalarioBase.Value = 0;
            comboBoxTipoFunc.SelectedIndex = 0;
            numBonus.Value = 0;
        }

        private void buttonAddFunc_Click(object sender, EventArgs e)
        {
            var nome = textBoxNome.Text.Trim();
            var matricula = textBoxMatricula.Text.Trim();
            var salarioBase = Convert.ToDouble(numSalarioBase.Value);
            var bonus = Convert.ToDouble(numBonus.Value);

            if (nome.Length < 1)
            {
                MessageBox.Show("Nome necessita estar preenchido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (matricula.Length < 1)
            {
                MessageBox.Show("Matrícula necessita estar preenchida.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (salarioBase == 0)
            {
                MessageBox.Show("Salário base deve ser maior que 0.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var tipo = (string)comboBoxTipoFunc.SelectedItem;
            switch (tipo)
            {
                case "Analista":
                    Funcionarios.Add(new Analista(nome, matricula, salarioBase, bonus));
                    break;
                case "Programador":
                    Funcionarios.Add(new Programador(nome, matricula, salarioBase));
                    break;
                case "Suporte Técnico":
                    Funcionarios.Add(new SuporteTecnico(nome, matricula, salarioBase));
                    break;
            }

            buttonLimpar_Click(null, null);
        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            richTextBoxGerarFolha.Text = string.Empty;

            var total = 0.0;

            var folha = "Folha salarial\n";
            folha += "=======================\n";
            
            foreach (Funcionario f in Funcionarios)
            {
                folha += "Nome: " + f.GetNome() + "\n";
                folha += "Matrícula: " + f.GetMatricula() + "\n";
                folha += "Salário base: " + f.GetSalarioBase().ToString("c") + "\n";

                if (f is Analista analista)
                {
                    folha += "Bônus: " + analista.GetBonus().ToString("c") + "\n";
                    folha += "Cargo: Analista\n";
                }
                else if (f is Programador)
                {
                    folha += "Cargo: Programador\n";
                }
                else if (f is SuporteTecnico)
                {
                    folha += "Cargo: Suporte Técnico\n";
                }

                folha += "Salário final: " + f.CalculaSalario().ToString("c") + "\n";
                folha += "=======================\n";

                total += f.CalculaSalario();
            }

            folha += "Total: " + total.ToString("c") + "\n";

            richTextBoxGerarFolha.Text = folha;
        }
    }
}
