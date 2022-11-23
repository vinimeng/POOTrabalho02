namespace Exercicio01
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
            this.groupBoxAddFunc = new System.Windows.Forms.GroupBox();
            this.buttonAddFunc = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.numBonus = new System.Windows.Forms.NumericUpDown();
            this.labelBonus = new System.Windows.Forms.Label();
            this.comboBoxTipoFunc = new System.Windows.Forms.ComboBox();
            this.labelTipoFunc = new System.Windows.Forms.Label();
            this.numSalarioBase = new System.Windows.Forms.NumericUpDown();
            this.labelSalarioBase = new System.Windows.Forms.Label();
            this.textBoxMatricula = new System.Windows.Forms.TextBox();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.groupBoxFunc = new System.Windows.Forms.GroupBox();
            this.listBoxFunc = new System.Windows.Forms.ListBox();
            this.groupBoxFolhaSalarial = new System.Windows.Forms.GroupBox();
            this.richTextBoxGerarFolha = new System.Windows.Forms.RichTextBox();
            this.buttonGerar = new System.Windows.Forms.Button();
            this.groupBoxAddFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalarioBase)).BeginInit();
            this.groupBoxFunc.SuspendLayout();
            this.groupBoxFolhaSalarial.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddFunc
            // 
            this.groupBoxAddFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxAddFunc.Controls.Add(this.buttonAddFunc);
            this.groupBoxAddFunc.Controls.Add(this.buttonLimpar);
            this.groupBoxAddFunc.Controls.Add(this.numBonus);
            this.groupBoxAddFunc.Controls.Add(this.labelBonus);
            this.groupBoxAddFunc.Controls.Add(this.comboBoxTipoFunc);
            this.groupBoxAddFunc.Controls.Add(this.labelTipoFunc);
            this.groupBoxAddFunc.Controls.Add(this.numSalarioBase);
            this.groupBoxAddFunc.Controls.Add(this.labelSalarioBase);
            this.groupBoxAddFunc.Controls.Add(this.textBoxMatricula);
            this.groupBoxAddFunc.Controls.Add(this.labelMatricula);
            this.groupBoxAddFunc.Controls.Add(this.textBoxNome);
            this.groupBoxAddFunc.Controls.Add(this.labelNome);
            this.groupBoxAddFunc.Location = new System.Drawing.Point(9, 10);
            this.groupBoxAddFunc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAddFunc.Name = "groupBoxAddFunc";
            this.groupBoxAddFunc.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxAddFunc.Size = new System.Drawing.Size(242, 258);
            this.groupBoxAddFunc.TabIndex = 0;
            this.groupBoxAddFunc.TabStop = false;
            this.groupBoxAddFunc.Text = "Adicionar funcionário";
            // 
            // buttonAddFunc
            // 
            this.buttonAddFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddFunc.Location = new System.Drawing.Point(39, 221);
            this.buttonAddFunc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddFunc.Name = "buttonAddFunc";
            this.buttonAddFunc.Size = new System.Drawing.Size(137, 28);
            this.buttonAddFunc.TabIndex = 11;
            this.buttonAddFunc.Text = "Adicionar funcionário";
            this.buttonAddFunc.UseVisualStyleBackColor = true;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpar.Location = new System.Drawing.Point(181, 221);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(56, 28);
            this.buttonLimpar.TabIndex = 10;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // numBonus
            // 
            this.numBonus.DecimalPlaces = 2;
            this.numBonus.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numBonus.Location = new System.Drawing.Point(7, 190);
            this.numBonus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numBonus.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numBonus.Name = "numBonus";
            this.numBonus.Size = new System.Drawing.Size(230, 20);
            this.numBonus.TabIndex = 9;
            // 
            // labelBonus
            // 
            this.labelBonus.AutoSize = true;
            this.labelBonus.Location = new System.Drawing.Point(4, 175);
            this.labelBonus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBonus.Name = "labelBonus";
            this.labelBonus.Size = new System.Drawing.Size(72, 13);
            this.labelBonus.TabIndex = 8;
            this.labelBonus.Text = "Bônus salarial";
            // 
            // comboBoxTipoFunc
            // 
            this.comboBoxTipoFunc.FormattingEnabled = true;
            this.comboBoxTipoFunc.Items.AddRange(new object[] {
            "Analista",
            "Programador",
            "Suporte Técnico"});
            this.comboBoxTipoFunc.Location = new System.Drawing.Point(7, 149);
            this.comboBoxTipoFunc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxTipoFunc.Name = "comboBoxTipoFunc";
            this.comboBoxTipoFunc.Size = new System.Drawing.Size(231, 21);
            this.comboBoxTipoFunc.TabIndex = 7;
            this.comboBoxTipoFunc.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoFunc_SelectedIndexChanged);
            // 
            // labelTipoFunc
            // 
            this.labelTipoFunc.AutoSize = true;
            this.labelTipoFunc.Location = new System.Drawing.Point(4, 133);
            this.labelTipoFunc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipoFunc.Name = "labelTipoFunc";
            this.labelTipoFunc.Size = new System.Drawing.Size(98, 13);
            this.labelTipoFunc.TabIndex = 6;
            this.labelTipoFunc.Text = "Tipo de funcionário";
            // 
            // numSalarioBase
            // 
            this.numSalarioBase.DecimalPlaces = 2;
            this.numSalarioBase.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numSalarioBase.Location = new System.Drawing.Point(7, 109);
            this.numSalarioBase.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numSalarioBase.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numSalarioBase.Name = "numSalarioBase";
            this.numSalarioBase.Size = new System.Drawing.Size(230, 20);
            this.numSalarioBase.TabIndex = 5;
            // 
            // labelSalarioBase
            // 
            this.labelSalarioBase.AutoSize = true;
            this.labelSalarioBase.Location = new System.Drawing.Point(4, 93);
            this.labelSalarioBase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalarioBase.Name = "labelSalarioBase";
            this.labelSalarioBase.Size = new System.Drawing.Size(65, 13);
            this.labelSalarioBase.TabIndex = 4;
            this.labelSalarioBase.Text = "Salário base";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(7, 69);
            this.textBoxMatricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(231, 20);
            this.textBoxMatricula.TabIndex = 3;
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(4, 54);
            this.labelMatricula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(52, 13);
            this.labelMatricula.TabIndex = 2;
            this.labelMatricula.Text = "Matrícula";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(7, 30);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(231, 20);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(4, 15);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(81, 13);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome completo";
            // 
            // groupBoxFunc
            // 
            this.groupBoxFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxFunc.Controls.Add(this.listBoxFunc);
            this.groupBoxFunc.Location = new System.Drawing.Point(255, 10);
            this.groupBoxFunc.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFunc.Name = "groupBoxFunc";
            this.groupBoxFunc.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFunc.Size = new System.Drawing.Size(242, 258);
            this.groupBoxFunc.TabIndex = 12;
            this.groupBoxFunc.TabStop = false;
            this.groupBoxFunc.Text = "Funcionários";
            // 
            // listBoxFunc
            // 
            this.listBoxFunc.FormattingEnabled = true;
            this.listBoxFunc.Location = new System.Drawing.Point(5, 18);
            this.listBoxFunc.Name = "listBoxFunc";
            this.listBoxFunc.Size = new System.Drawing.Size(232, 225);
            this.listBoxFunc.TabIndex = 0;
            // 
            // groupBoxFolhaSalarial
            // 
            this.groupBoxFolhaSalarial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxFolhaSalarial.Controls.Add(this.buttonGerar);
            this.groupBoxFolhaSalarial.Controls.Add(this.richTextBoxGerarFolha);
            this.groupBoxFolhaSalarial.Location = new System.Drawing.Point(501, 10);
            this.groupBoxFolhaSalarial.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFolhaSalarial.Name = "groupBoxFolhaSalarial";
            this.groupBoxFolhaSalarial.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFolhaSalarial.Size = new System.Drawing.Size(242, 258);
            this.groupBoxFolhaSalarial.TabIndex = 13;
            this.groupBoxFolhaSalarial.TabStop = false;
            this.groupBoxFolhaSalarial.Text = "Folha salarial";
            // 
            // richTextBoxGerarFolha
            // 
            this.richTextBoxGerarFolha.Location = new System.Drawing.Point(6, 18);
            this.richTextBoxGerarFolha.Name = "richTextBoxGerarFolha";
            this.richTextBoxGerarFolha.Size = new System.Drawing.Size(231, 192);
            this.richTextBoxGerarFolha.TabIndex = 0;
            this.richTextBoxGerarFolha.Text = "";
            // 
            // buttonGerar
            // 
            this.buttonGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGerar.Location = new System.Drawing.Point(100, 221);
            this.buttonGerar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(137, 28);
            this.buttonGerar.TabIndex = 12;
            this.buttonGerar.Text = "Gerar folha";
            this.buttonGerar.UseVisualStyleBackColor = true;
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 280);
            this.Controls.Add(this.groupBoxFolhaSalarial);
            this.Controls.Add(this.groupBoxFunc);
            this.Controls.Add(this.groupBoxAddFunc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "JanelaPrincipal";
            this.Text = "Exercício 01";
            this.groupBoxAddFunc.ResumeLayout(false);
            this.groupBoxAddFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSalarioBase)).EndInit();
            this.groupBoxFunc.ResumeLayout(false);
            this.groupBoxFolhaSalarial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddFunc;
        private System.Windows.Forms.ComboBox comboBoxTipoFunc;
        private System.Windows.Forms.Label labelTipoFunc;
        private System.Windows.Forms.NumericUpDown numSalarioBase;
        private System.Windows.Forms.Label labelSalarioBase;
        private System.Windows.Forms.TextBox textBoxMatricula;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.NumericUpDown numBonus;
        private System.Windows.Forms.Label labelBonus;
        private System.Windows.Forms.Button buttonAddFunc;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.GroupBox groupBoxFunc;
        private System.Windows.Forms.ListBox listBoxFunc;
        private System.Windows.Forms.GroupBox groupBoxFolhaSalarial;
        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.RichTextBox richTextBoxGerarFolha;
    }
}

