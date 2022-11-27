using Exercicio02.Itens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio02
{
    public partial class JanelaPrincipal : Form
    {
        private BindingList<Item> Items;
        private BindingList<Combo> Combos;
        private Pedido Pedido;
        private BindingList<Item> MontagemCombo;

        public JanelaPrincipal()
        {
            InitializeComponent();
            Items = new BindingList<Item>();
            Combos = new BindingList<Combo>();
            MontagemCombo = new BindingList<Item>();
            Pedido = new Pedido();
            PrecoTotalPedido.Text = Pedido.CalcularPreco().ToString("c");

            comboBoxTipoItem.SelectedIndex = 0;
            numQuantidadeMlItem.Enabled = false;
            numQuantidadeUnidadeItem.Enabled = false;
            numAdicionalLinhaNobreItem.Enabled = false;
            listBoxItensDisponiveis.DataSource = Items;
            listBoxItensCombo.DataSource = MontagemCombo;
            listBoxItensDisponiveisPedido.DataSource = Items;
            listBoxCombosDisponiveisPedido.DataSource = Combos;
            listBoxItensPedido.DataSource = Pedido.GetItens();
        }

        private void comboBoxTipoItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var tipo = (string)comboBoxTipoItem.SelectedItem;

            switch (tipo)
            {
                case "Batata Frita":
                    checkBoxLinhaNobre.Enabled = false;
                    numQuantidadeMlItem.Enabled = false;
                    numQuantidadeUnidadeItem.Enabled = false;
                    numAdicionalLinhaNobreItem.Enabled = false;
                    numQuantidadeGramasItem.Enabled = true;
                    break;
                case "Nuggets":
                    checkBoxLinhaNobre.Enabled = false;
                    numQuantidadeMlItem.Enabled = false;
                    numQuantidadeUnidadeItem.Enabled = true;
                    numAdicionalLinhaNobreItem.Enabled = false;
                    numQuantidadeGramasItem.Enabled = false;
                    break;
                case "Refresco":
                    checkBoxLinhaNobre.Enabled = false;
                    numQuantidadeMlItem.Enabled = true;
                    numQuantidadeUnidadeItem.Enabled = false;
                    numAdicionalLinhaNobreItem.Enabled = false;
                    numQuantidadeGramasItem.Enabled = false;
                    break;
                case "Sanduíche":
                    checkBoxLinhaNobre.Enabled = true;
                    numQuantidadeMlItem.Enabled = false;
                    numQuantidadeUnidadeItem.Enabled = false;
                    numAdicionalLinhaNobreItem.Enabled = true;
                    numQuantidadeGramasItem.Enabled = false;
                    break;
            }
        }

        private void btnCriarItem_Click(object sender, EventArgs e)
        {
            var tipo = (string)comboBoxTipoItem.SelectedItem;
            var nome = textBoxNomeItem.Text;
            var preco = Convert.ToDouble(numPrecoItem.Value);

            if (nome.Length < 1)
            {
                MessageBox.Show("Nome do item necessita estar preenchido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (preco < 0.01)
            {
                MessageBox.Show("Valor deve ser maior que zero.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            switch (tipo)
            {
                case "Batata Frita":
                    var gramas = Convert.ToInt32(numQuantidadeGramasItem.Value);

                    if (gramas < 1)
                    {
                        MessageBox.Show("Gramas devem ser maiores que zero.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Items.Add(new BatataFrita(nome, preco, gramas));
                    break;
                case "Nuggets":
                    var unidades = Convert.ToInt32(numQuantidadeUnidadeItem.Value);

                    if (unidades < 0)
                    {
                        MessageBox.Show("Unidades devem ser maiores que zero.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Items.Add(new Nuggets(nome, preco, unidades));
                    break;
                case "Refresco":
                    var ml = Convert.ToInt32(numQuantidadeMlItem.Value);

                    if (ml < 0)
                    {
                        MessageBox.Show("Mililitros devem ser maiores que zero.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    Items.Add(new Refresco(nome, preco, ml));
                    break;
                case "Sanduíche":
                    var adicionalPreco = Convert.ToDouble(numAdicionalLinhaNobreItem.Value);
                    var adicionalCheck = checkBoxLinhaNobre.Checked;

                    Items.Add(new Sanduiche(nome, preco, adicionalCheck, adicionalPreco));
                    break;
            }
        }

        private void btnCriarCombo_Click(object sender, EventArgs e)
        {
            var nome = textBoxNomeCombo.Text;

            if (nome.Length < 1)
            {
                MessageBox.Show("Nome do combo necessita estar preenchido.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var precoBase = Convert.ToDouble(numPrecoBaseCombo.Value);
            var porcentagem = Convert.ToDouble(numPorcentagemDescontoCombo.Value) / 100;

            Combos.Add(new Combo(nome, precoBase, porcentagem, MontagemCombo.ToList()));
            MontagemCombo.Clear();
        }

        private void listBoxItensDisponiveis_DoubleClick(object sender, EventArgs e)
        {
            var list = (ListBox)sender;
            Item selItem = (Item)list.SelectedItem;
            if (selItem != null)
            {
                MontagemCombo.Add(selItem);
            }
        }

        private void listBoxItensCombo_DoubleClick(object sender, EventArgs e)
        {
            var list = (ListBox)sender;
            Item selItem = (Item)list.SelectedItem;
            if (selItem != null)
            {
                MontagemCombo.Remove(selItem);
            }
        }

        private void listBoxItensDisponiveisPedido_DoubleClick(object sender, EventArgs e)
        {
            var list = (ListBox)sender;
            Item selItem = (Item)list.SelectedItem;
            if (selItem != null)
            {
                Pedido.AdicionarItem(selItem);
            }

            PrecoTotalPedido.Text = Pedido.CalcularPreco().ToString("c");
        }

        private void listBoxCombosDisponiveisPedido_DoubleClick(object sender, EventArgs e)
        {
            var list = (ListBox)sender;
            Item selItem = (Combo)list.SelectedItem;
            if (selItem != null)
            {
                Pedido.AdicionarItem(selItem);
            }

            PrecoTotalPedido.Text = Pedido.CalcularPreco().ToString("c");
        }

        private void listBoxItensPedido_DoubleClick(object sender, EventArgs e)
        {
            var list = (ListBox)sender;
            Item selItem = (Item)list.SelectedItem;
            if (selItem != null)
            {
                Pedido.RemoverItem(selItem);
            }

            PrecoTotalPedido.Text = Pedido.CalcularPreco().ToString("c");
        }

        private void btnFazerPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pedido deu " + Pedido.CalcularPreco().ToString("c") + ". Obrigado por comprar!", "Pedido Feito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Pedido.LimparItens();
            PrecoTotalPedido.Text = Pedido.CalcularPreco().ToString("c");
        }
    }
}
