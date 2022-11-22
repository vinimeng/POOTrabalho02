using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio01
{
    public partial class JanelaPrincipal : Form
    {
        public JanelaPrincipal()
        {
            InitializeComponent();
            comboBoxTipoFunc.SelectedIndex = 0;
        }

        private void comboBoxTipoFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipoFunc.SelectedIndex == 0)
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
    }
}
