namespace Exercicio02
{
    partial class JanelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaPrincipal));
            this.groupBoxItem = new System.Windows.Forms.GroupBox();
            this.checkBoxLinhaNobre = new System.Windows.Forms.CheckBox();
            this.btnCriarItem = new System.Windows.Forms.Button();
            this.numQuantidadeMlItem = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numQuantidadeUnidadeItem = new System.Windows.Forms.NumericUpDown();
            this.labelQuantidadeUnidadeItem = new System.Windows.Forms.Label();
            this.numQuantidadeGramasItem = new System.Windows.Forms.NumericUpDown();
            this.labelQuantidadeGramasItem = new System.Windows.Forms.Label();
            this.numAdicionalLinhaNobreItem = new System.Windows.Forms.NumericUpDown();
            this.labelAdicionalLinhaNobre = new System.Windows.Forms.Label();
            this.comboBoxTipoItem = new System.Windows.Forms.ComboBox();
            this.labelTipoItem = new System.Windows.Forms.Label();
            this.numPrecoItem = new System.Windows.Forms.NumericUpDown();
            this.labelPrecoItem = new System.Windows.Forms.Label();
            this.textBoxNomeItem = new System.Windows.Forms.TextBox();
            this.labelNomeItem = new System.Windows.Forms.Label();
            this.groupBoxCombo = new System.Windows.Forms.GroupBox();
            this.listBoxItensCombo = new System.Windows.Forms.ListBox();
            this.labelItensCombo = new System.Windows.Forms.Label();
            this.listBoxItensDisponiveis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriarCombo = new System.Windows.Forms.Button();
            this.numPorcentagemDescontoCombo = new System.Windows.Forms.NumericUpDown();
            this.labelPorcentagemDescontoCombo = new System.Windows.Forms.Label();
            this.numPrecoBaseCombo = new System.Windows.Forms.NumericUpDown();
            this.labelPrecoBaseCombo = new System.Windows.Forms.Label();
            this.textBoxNomeCombo = new System.Windows.Forms.TextBox();
            this.labelNomeCombo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxCombosDisponiveisPedido = new System.Windows.Forms.ListBox();
            this.labelCombosDisponiveisPedido = new System.Windows.Forms.Label();
            this.labelItensDisponiveisPedido = new System.Windows.Forms.Label();
            this.btnFazerPedido = new System.Windows.Forms.Button();
            this.listBoxItensDisponiveisPedido = new System.Windows.Forms.ListBox();
            this.listBoxItensPedido = new System.Windows.Forms.ListBox();
            this.labelItensPedido = new System.Windows.Forms.Label();
            this.labelPrecoTotalPedido = new System.Windows.Forms.Label();
            this.PrecoTotalPedido = new System.Windows.Forms.Label();
            this.groupBoxItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeMlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeUnidadeItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeGramasItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdicionalLinhaNobreItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoItem)).BeginInit();
            this.groupBoxCombo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentagemDescontoCombo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoBaseCombo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxItem
            // 
            this.groupBoxItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxItem.Controls.Add(this.checkBoxLinhaNobre);
            this.groupBoxItem.Controls.Add(this.btnCriarItem);
            this.groupBoxItem.Controls.Add(this.numQuantidadeMlItem);
            this.groupBoxItem.Controls.Add(this.label2);
            this.groupBoxItem.Controls.Add(this.numQuantidadeUnidadeItem);
            this.groupBoxItem.Controls.Add(this.labelQuantidadeUnidadeItem);
            this.groupBoxItem.Controls.Add(this.numQuantidadeGramasItem);
            this.groupBoxItem.Controls.Add(this.labelQuantidadeGramasItem);
            this.groupBoxItem.Controls.Add(this.numAdicionalLinhaNobreItem);
            this.groupBoxItem.Controls.Add(this.labelAdicionalLinhaNobre);
            this.groupBoxItem.Controls.Add(this.comboBoxTipoItem);
            this.groupBoxItem.Controls.Add(this.labelTipoItem);
            this.groupBoxItem.Controls.Add(this.numPrecoItem);
            this.groupBoxItem.Controls.Add(this.labelPrecoItem);
            this.groupBoxItem.Controls.Add(this.textBoxNomeItem);
            this.groupBoxItem.Controls.Add(this.labelNomeItem);
            this.groupBoxItem.Location = new System.Drawing.Point(12, 12);
            this.groupBoxItem.Name = "groupBoxItem";
            this.groupBoxItem.Size = new System.Drawing.Size(271, 537);
            this.groupBoxItem.TabIndex = 0;
            this.groupBoxItem.TabStop = false;
            this.groupBoxItem.Text = "Criar Itens";
            // 
            // checkBoxLinhaNobre
            // 
            this.checkBoxLinhaNobre.AutoSize = true;
            this.checkBoxLinhaNobre.Location = new System.Drawing.Point(7, 182);
            this.checkBoxLinhaNobre.Name = "checkBoxLinhaNobre";
            this.checkBoxLinhaNobre.Size = new System.Drawing.Size(84, 17);
            this.checkBoxLinhaNobre.TabIndex = 8;
            this.checkBoxLinhaNobre.Text = "Linha Nobre";
            this.checkBoxLinhaNobre.UseVisualStyleBackColor = true;
            // 
            // btnCriarItem
            // 
            this.btnCriarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriarItem.Location = new System.Drawing.Point(189, 508);
            this.btnCriarItem.Name = "btnCriarItem";
            this.btnCriarItem.Size = new System.Drawing.Size(75, 23);
            this.btnCriarItem.TabIndex = 15;
            this.btnCriarItem.Text = "Criar Item";
            this.btnCriarItem.UseVisualStyleBackColor = true;
            this.btnCriarItem.Click += new System.EventHandler(this.btnCriarItem_Click);
            // 
            // numQuantidadeMlItem
            // 
            this.numQuantidadeMlItem.Location = new System.Drawing.Point(7, 297);
            this.numQuantidadeMlItem.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numQuantidadeMlItem.Name = "numQuantidadeMlItem";
            this.numQuantidadeMlItem.Size = new System.Drawing.Size(258, 20);
            this.numQuantidadeMlItem.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quantidade em Mililitros";
            // 
            // numQuantidadeUnidadeItem
            // 
            this.numQuantidadeUnidadeItem.Location = new System.Drawing.Point(7, 258);
            this.numQuantidadeUnidadeItem.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numQuantidadeUnidadeItem.Name = "numQuantidadeUnidadeItem";
            this.numQuantidadeUnidadeItem.Size = new System.Drawing.Size(258, 20);
            this.numQuantidadeUnidadeItem.TabIndex = 12;
            // 
            // labelQuantidadeUnidadeItem
            // 
            this.labelQuantidadeUnidadeItem.AutoSize = true;
            this.labelQuantidadeUnidadeItem.Location = new System.Drawing.Point(6, 242);
            this.labelQuantidadeUnidadeItem.Name = "labelQuantidadeUnidadeItem";
            this.labelQuantidadeUnidadeItem.Size = new System.Drawing.Size(127, 13);
            this.labelQuantidadeUnidadeItem.TabIndex = 11;
            this.labelQuantidadeUnidadeItem.Text = "Quantidade em Unidades";
            // 
            // numQuantidadeGramasItem
            // 
            this.numQuantidadeGramasItem.Location = new System.Drawing.Point(7, 219);
            this.numQuantidadeGramasItem.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numQuantidadeGramasItem.Name = "numQuantidadeGramasItem";
            this.numQuantidadeGramasItem.Size = new System.Drawing.Size(258, 20);
            this.numQuantidadeGramasItem.TabIndex = 10;
            // 
            // labelQuantidadeGramasItem
            // 
            this.labelQuantidadeGramasItem.AutoSize = true;
            this.labelQuantidadeGramasItem.Location = new System.Drawing.Point(6, 203);
            this.labelQuantidadeGramasItem.Name = "labelQuantidadeGramasItem";
            this.labelQuantidadeGramasItem.Size = new System.Drawing.Size(118, 13);
            this.labelQuantidadeGramasItem.TabIndex = 9;
            this.labelQuantidadeGramasItem.Text = "Quantidade em Gramas";
            // 
            // numAdicionalLinhaNobreItem
            // 
            this.numAdicionalLinhaNobreItem.DecimalPlaces = 2;
            this.numAdicionalLinhaNobreItem.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numAdicionalLinhaNobreItem.Location = new System.Drawing.Point(7, 156);
            this.numAdicionalLinhaNobreItem.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numAdicionalLinhaNobreItem.Name = "numAdicionalLinhaNobreItem";
            this.numAdicionalLinhaNobreItem.Size = new System.Drawing.Size(258, 20);
            this.numAdicionalLinhaNobreItem.TabIndex = 7;
            // 
            // labelAdicionalLinhaNobre
            // 
            this.labelAdicionalLinhaNobre.AutoSize = true;
            this.labelAdicionalLinhaNobre.Location = new System.Drawing.Point(6, 140);
            this.labelAdicionalLinhaNobre.Name = "labelAdicionalLinhaNobre";
            this.labelAdicionalLinhaNobre.Size = new System.Drawing.Size(134, 13);
            this.labelAdicionalLinhaNobre.TabIndex = 6;
            this.labelAdicionalLinhaNobre.Text = "Adicional Linha Nobre (R$)";
            // 
            // comboBoxTipoItem
            // 
            this.comboBoxTipoItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoItem.FormattingEnabled = true;
            this.comboBoxTipoItem.Items.AddRange(new object[] {
            "Batata Frita",
            "Nuggets",
            "Refresco",
            "Sanduíche"});
            this.comboBoxTipoItem.Location = new System.Drawing.Point(7, 116);
            this.comboBoxTipoItem.Name = "comboBoxTipoItem";
            this.comboBoxTipoItem.Size = new System.Drawing.Size(258, 21);
            this.comboBoxTipoItem.TabIndex = 5;
            this.comboBoxTipoItem.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoItem_SelectedIndexChanged);
            // 
            // labelTipoItem
            // 
            this.labelTipoItem.AutoSize = true;
            this.labelTipoItem.Location = new System.Drawing.Point(6, 99);
            this.labelTipoItem.Name = "labelTipoItem";
            this.labelTipoItem.Size = new System.Drawing.Size(28, 13);
            this.labelTipoItem.TabIndex = 4;
            this.labelTipoItem.Text = "Tipo";
            // 
            // numPrecoItem
            // 
            this.numPrecoItem.DecimalPlaces = 2;
            this.numPrecoItem.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPrecoItem.Location = new System.Drawing.Point(7, 76);
            this.numPrecoItem.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPrecoItem.Name = "numPrecoItem";
            this.numPrecoItem.Size = new System.Drawing.Size(258, 20);
            this.numPrecoItem.TabIndex = 3;
            // 
            // labelPrecoItem
            // 
            this.labelPrecoItem.AutoSize = true;
            this.labelPrecoItem.Location = new System.Drawing.Point(6, 60);
            this.labelPrecoItem.Name = "labelPrecoItem";
            this.labelPrecoItem.Size = new System.Drawing.Size(58, 13);
            this.labelPrecoItem.TabIndex = 2;
            this.labelPrecoItem.Text = "Preço (R$)";
            // 
            // textBoxNomeItem
            // 
            this.textBoxNomeItem.Location = new System.Drawing.Point(7, 37);
            this.textBoxNomeItem.Name = "textBoxNomeItem";
            this.textBoxNomeItem.Size = new System.Drawing.Size(258, 20);
            this.textBoxNomeItem.TabIndex = 1;
            // 
            // labelNomeItem
            // 
            this.labelNomeItem.AutoSize = true;
            this.labelNomeItem.Location = new System.Drawing.Point(6, 21);
            this.labelNomeItem.Name = "labelNomeItem";
            this.labelNomeItem.Size = new System.Drawing.Size(35, 13);
            this.labelNomeItem.TabIndex = 0;
            this.labelNomeItem.Text = "Nome";
            // 
            // groupBoxCombo
            // 
            this.groupBoxCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxCombo.Controls.Add(this.listBoxItensCombo);
            this.groupBoxCombo.Controls.Add(this.labelItensCombo);
            this.groupBoxCombo.Controls.Add(this.listBoxItensDisponiveis);
            this.groupBoxCombo.Controls.Add(this.label1);
            this.groupBoxCombo.Controls.Add(this.btnCriarCombo);
            this.groupBoxCombo.Controls.Add(this.numPorcentagemDescontoCombo);
            this.groupBoxCombo.Controls.Add(this.labelPorcentagemDescontoCombo);
            this.groupBoxCombo.Controls.Add(this.numPrecoBaseCombo);
            this.groupBoxCombo.Controls.Add(this.labelPrecoBaseCombo);
            this.groupBoxCombo.Controls.Add(this.textBoxNomeCombo);
            this.groupBoxCombo.Controls.Add(this.labelNomeCombo);
            this.groupBoxCombo.Location = new System.Drawing.Point(289, 12);
            this.groupBoxCombo.Name = "groupBoxCombo";
            this.groupBoxCombo.Size = new System.Drawing.Size(271, 537);
            this.groupBoxCombo.TabIndex = 1;
            this.groupBoxCombo.TabStop = false;
            this.groupBoxCombo.Text = "Criar Combos";
            // 
            // listBoxItensCombo
            // 
            this.listBoxItensCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxItensCombo.FormattingEnabled = true;
            this.listBoxItensCombo.Location = new System.Drawing.Point(8, 335);
            this.listBoxItensCombo.Name = "listBoxItensCombo";
            this.listBoxItensCombo.Size = new System.Drawing.Size(257, 160);
            this.listBoxItensCombo.TabIndex = 9;
            this.listBoxItensCombo.DoubleClick += new System.EventHandler(this.listBoxItensCombo_DoubleClick);
            // 
            // labelItensCombo
            // 
            this.labelItensCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelItensCombo.AutoSize = true;
            this.labelItensCombo.Location = new System.Drawing.Point(6, 319);
            this.labelItensCombo.Name = "labelItensCombo";
            this.labelItensCombo.Size = new System.Drawing.Size(224, 13);
            this.labelItensCombo.TabIndex = 8;
            this.labelItensCombo.Text = "Itens no Combo (2 cliques no item p/ remover)";
            // 
            // listBoxItensDisponiveis
            // 
            this.listBoxItensDisponiveis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxItensDisponiveis.FormattingEnabled = true;
            this.listBoxItensDisponiveis.Location = new System.Drawing.Point(7, 156);
            this.listBoxItensDisponiveis.Name = "listBoxItensDisponiveis";
            this.listBoxItensDisponiveis.Size = new System.Drawing.Size(257, 160);
            this.listBoxItensDisponiveis.TabIndex = 7;
            this.listBoxItensDisponiveis.DoubleClick += new System.EventHandler(this.listBoxItensDisponiveis_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Itens Disponíveis (2 cliques no item p/ adicionar)";
            // 
            // btnCriarCombo
            // 
            this.btnCriarCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriarCombo.Location = new System.Drawing.Point(189, 508);
            this.btnCriarCombo.Name = "btnCriarCombo";
            this.btnCriarCombo.Size = new System.Drawing.Size(75, 23);
            this.btnCriarCombo.TabIndex = 10;
            this.btnCriarCombo.Text = "Criar Combo";
            this.btnCriarCombo.UseVisualStyleBackColor = true;
            this.btnCriarCombo.Click += new System.EventHandler(this.btnCriarCombo_Click);
            // 
            // numPorcentagemDescontoCombo
            // 
            this.numPorcentagemDescontoCombo.DecimalPlaces = 1;
            this.numPorcentagemDescontoCombo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numPorcentagemDescontoCombo.Location = new System.Drawing.Point(7, 117);
            this.numPorcentagemDescontoCombo.Name = "numPorcentagemDescontoCombo";
            this.numPorcentagemDescontoCombo.Size = new System.Drawing.Size(258, 20);
            this.numPorcentagemDescontoCombo.TabIndex = 5;
            // 
            // labelPorcentagemDescontoCombo
            // 
            this.labelPorcentagemDescontoCombo.AutoSize = true;
            this.labelPorcentagemDescontoCombo.Location = new System.Drawing.Point(6, 99);
            this.labelPorcentagemDescontoCombo.Name = "labelPorcentagemDescontoCombo";
            this.labelPorcentagemDescontoCombo.Size = new System.Drawing.Size(136, 13);
            this.labelPorcentagemDescontoCombo.TabIndex = 4;
            this.labelPorcentagemDescontoCombo.Text = "Porcentagem Desconto (%)";
            // 
            // numPrecoBaseCombo
            // 
            this.numPrecoBaseCombo.DecimalPlaces = 2;
            this.numPrecoBaseCombo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numPrecoBaseCombo.Location = new System.Drawing.Point(7, 76);
            this.numPrecoBaseCombo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numPrecoBaseCombo.Name = "numPrecoBaseCombo";
            this.numPrecoBaseCombo.Size = new System.Drawing.Size(258, 20);
            this.numPrecoBaseCombo.TabIndex = 3;
            // 
            // labelPrecoBaseCombo
            // 
            this.labelPrecoBaseCombo.AutoSize = true;
            this.labelPrecoBaseCombo.Location = new System.Drawing.Point(6, 60);
            this.labelPrecoBaseCombo.Name = "labelPrecoBaseCombo";
            this.labelPrecoBaseCombo.Size = new System.Drawing.Size(85, 13);
            this.labelPrecoBaseCombo.TabIndex = 2;
            this.labelPrecoBaseCombo.Text = "Preço Base (R$)";
            // 
            // textBoxNomeCombo
            // 
            this.textBoxNomeCombo.Location = new System.Drawing.Point(7, 37);
            this.textBoxNomeCombo.Name = "textBoxNomeCombo";
            this.textBoxNomeCombo.Size = new System.Drawing.Size(258, 20);
            this.textBoxNomeCombo.TabIndex = 1;
            // 
            // labelNomeCombo
            // 
            this.labelNomeCombo.AutoSize = true;
            this.labelNomeCombo.Location = new System.Drawing.Point(6, 21);
            this.labelNomeCombo.Name = "labelNomeCombo";
            this.labelNomeCombo.Size = new System.Drawing.Size(35, 13);
            this.labelNomeCombo.TabIndex = 0;
            this.labelNomeCombo.Text = "Nome";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.PrecoTotalPedido);
            this.groupBox1.Controls.Add(this.labelPrecoTotalPedido);
            this.groupBox1.Controls.Add(this.labelItensPedido);
            this.groupBox1.Controls.Add(this.listBoxItensPedido);
            this.groupBox1.Controls.Add(this.listBoxItensDisponiveisPedido);
            this.groupBox1.Controls.Add(this.listBoxCombosDisponiveisPedido);
            this.groupBox1.Controls.Add(this.labelCombosDisponiveisPedido);
            this.groupBox1.Controls.Add(this.labelItensDisponiveisPedido);
            this.groupBox1.Controls.Add(this.btnFazerPedido);
            this.groupBox1.Location = new System.Drawing.Point(566, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 537);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fazer Pedido";
            // 
            // listBoxCombosDisponiveisPedido
            // 
            this.listBoxCombosDisponiveisPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCombosDisponiveisPedido.FormattingEnabled = true;
            this.listBoxCombosDisponiveisPedido.Location = new System.Drawing.Point(6, 283);
            this.listBoxCombosDisponiveisPedido.Name = "listBoxCombosDisponiveisPedido";
            this.listBoxCombosDisponiveisPedido.Size = new System.Drawing.Size(257, 212);
            this.listBoxCombosDisponiveisPedido.TabIndex = 3;
            this.listBoxCombosDisponiveisPedido.DoubleClick += new System.EventHandler(this.listBoxCombosDisponiveisPedido_DoubleClick);
            // 
            // labelCombosDisponiveisPedido
            // 
            this.labelCombosDisponiveisPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCombosDisponiveisPedido.AutoSize = true;
            this.labelCombosDisponiveisPedido.Location = new System.Drawing.Point(6, 265);
            this.labelCombosDisponiveisPedido.Name = "labelCombosDisponiveisPedido";
            this.labelCombosDisponiveisPedido.Size = new System.Drawing.Size(250, 13);
            this.labelCombosDisponiveisPedido.TabIndex = 2;
            this.labelCombosDisponiveisPedido.Text = "Combos disponíveis (2 cliques no item p/ adicionar)";
            // 
            // labelItensDisponiveisPedido
            // 
            this.labelItensDisponiveisPedido.AutoSize = true;
            this.labelItensDisponiveisPedido.Location = new System.Drawing.Point(6, 21);
            this.labelItensDisponiveisPedido.Name = "labelItensDisponiveisPedido";
            this.labelItensDisponiveisPedido.Size = new System.Drawing.Size(237, 13);
            this.labelItensDisponiveisPedido.TabIndex = 0;
            this.labelItensDisponiveisPedido.Text = "Itens Disponíveis (2 cliques no item p/ adicionar)";
            // 
            // btnFazerPedido
            // 
            this.btnFazerPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFazerPedido.Location = new System.Drawing.Point(468, 508);
            this.btnFazerPedido.Name = "btnFazerPedido";
            this.btnFazerPedido.Size = new System.Drawing.Size(82, 23);
            this.btnFazerPedido.TabIndex = 8;
            this.btnFazerPedido.Text = "Fazer Pedido";
            this.btnFazerPedido.UseVisualStyleBackColor = true;
            this.btnFazerPedido.Click += new System.EventHandler(this.btnFazerPedido_Click);
            // 
            // listBoxItensDisponiveisPedido
            // 
            this.listBoxItensDisponiveisPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxItensDisponiveisPedido.FormattingEnabled = true;
            this.listBoxItensDisponiveisPedido.Location = new System.Drawing.Point(6, 37);
            this.listBoxItensDisponiveisPedido.Name = "listBoxItensDisponiveisPedido";
            this.listBoxItensDisponiveisPedido.Size = new System.Drawing.Size(257, 225);
            this.listBoxItensDisponiveisPedido.TabIndex = 1;
            this.listBoxItensDisponiveisPedido.DoubleClick += new System.EventHandler(this.listBoxItensDisponiveisPedido_DoubleClick);
            // 
            // listBoxItensPedido
            // 
            this.listBoxItensPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxItensPedido.FormattingEnabled = true;
            this.listBoxItensPedido.Location = new System.Drawing.Point(293, 36);
            this.listBoxItensPedido.Name = "listBoxItensPedido";
            this.listBoxItensPedido.Size = new System.Drawing.Size(257, 459);
            this.listBoxItensPedido.TabIndex = 5;
            this.listBoxItensPedido.DoubleClick += new System.EventHandler(this.listBoxItensPedido_DoubleClick);
            // 
            // labelItensPedido
            // 
            this.labelItensPedido.AutoSize = true;
            this.labelItensPedido.Location = new System.Drawing.Point(292, 21);
            this.labelItensPedido.Name = "labelItensPedido";
            this.labelItensPedido.Size = new System.Drawing.Size(224, 13);
            this.labelItensPedido.TabIndex = 4;
            this.labelItensPedido.Text = "Itens no Pedido (2 cliques no item p/ remover)";
            // 
            // labelPrecoTotalPedido
            // 
            this.labelPrecoTotalPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPrecoTotalPedido.AutoSize = true;
            this.labelPrecoTotalPedido.Location = new System.Drawing.Point(6, 513);
            this.labelPrecoTotalPedido.Name = "labelPrecoTotalPedido";
            this.labelPrecoTotalPedido.Size = new System.Drawing.Size(65, 13);
            this.labelPrecoTotalPedido.TabIndex = 6;
            this.labelPrecoTotalPedido.Text = "Preço Total:";
            // 
            // PrecoTotalPedido
            // 
            this.PrecoTotalPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PrecoTotalPedido.AutoSize = true;
            this.PrecoTotalPedido.Location = new System.Drawing.Point(77, 513);
            this.PrecoTotalPedido.Name = "PrecoTotalPedido";
            this.PrecoTotalPedido.Size = new System.Drawing.Size(0, 13);
            this.PrecoTotalPedido.TabIndex = 7;
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCombo);
            this.Controls.Add(this.groupBoxItem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JanelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 02";
            this.groupBoxItem.ResumeLayout(false);
            this.groupBoxItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeMlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeUnidadeItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantidadeGramasItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAdicionalLinhaNobreItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoItem)).EndInit();
            this.groupBoxCombo.ResumeLayout(false);
            this.groupBoxCombo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPorcentagemDescontoCombo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecoBaseCombo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxItem;
        private System.Windows.Forms.NumericUpDown numPrecoItem;
        private System.Windows.Forms.Label labelPrecoItem;
        private System.Windows.Forms.TextBox textBoxNomeItem;
        private System.Windows.Forms.Label labelNomeItem;
        private System.Windows.Forms.ComboBox comboBoxTipoItem;
        private System.Windows.Forms.Label labelTipoItem;
        private System.Windows.Forms.Label labelAdicionalLinhaNobre;
        private System.Windows.Forms.NumericUpDown numAdicionalLinhaNobreItem;
        private System.Windows.Forms.NumericUpDown numQuantidadeMlItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQuantidadeUnidadeItem;
        private System.Windows.Forms.Label labelQuantidadeUnidadeItem;
        private System.Windows.Forms.NumericUpDown numQuantidadeGramasItem;
        private System.Windows.Forms.Label labelQuantidadeGramasItem;
        private System.Windows.Forms.Button btnCriarItem;
        private System.Windows.Forms.CheckBox checkBoxLinhaNobre;
        private System.Windows.Forms.GroupBox groupBoxCombo;
        private System.Windows.Forms.Button btnCriarCombo;
        private System.Windows.Forms.NumericUpDown numPorcentagemDescontoCombo;
        private System.Windows.Forms.Label labelPorcentagemDescontoCombo;
        private System.Windows.Forms.NumericUpDown numPrecoBaseCombo;
        private System.Windows.Forms.Label labelPrecoBaseCombo;
        private System.Windows.Forms.TextBox textBoxNomeCombo;
        private System.Windows.Forms.Label labelNomeCombo;
        private System.Windows.Forms.ListBox listBoxItensCombo;
        private System.Windows.Forms.Label labelItensCombo;
        private System.Windows.Forms.ListBox listBoxItensDisponiveis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label PrecoTotalPedido;
        private System.Windows.Forms.Label labelPrecoTotalPedido;
        private System.Windows.Forms.Label labelItensPedido;
        private System.Windows.Forms.ListBox listBoxItensPedido;
        private System.Windows.Forms.ListBox listBoxItensDisponiveisPedido;
        private System.Windows.Forms.ListBox listBoxCombosDisponiveisPedido;
        private System.Windows.Forms.Label labelCombosDisponiveisPedido;
        private System.Windows.Forms.Label labelItensDisponiveisPedido;
        private System.Windows.Forms.Button btnFazerPedido;
    }
}

