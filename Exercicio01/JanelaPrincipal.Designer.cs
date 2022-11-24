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
            this.buttonGerar = new System.Windows.Forms.Button();
            this.richTextBoxGerarFolha = new System.Windows.Forms.RichTextBox();
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
            this.groupBoxAddFunc.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAddFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAddFunc.Name = "groupBoxAddFunc";
            this.groupBoxAddFunc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxAddFunc.Size = new System.Drawing.Size(323, 318);
            this.groupBoxAddFunc.TabIndex = 0;
            this.groupBoxAddFunc.TabStop = false;
            this.groupBoxAddFunc.Text = "Adicionar funcionário";
            // 
            // buttonAddFunc
            // 
            this.buttonAddFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddFunc.Location = new System.Drawing.Point(52, 272);
            this.buttonAddFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddFunc.Name = "buttonAddFunc";
            this.buttonAddFunc.Size = new System.Drawing.Size(183, 34);
            this.buttonAddFunc.TabIndex = 11;
            this.buttonAddFunc.Text = "Adicionar funcionário";
            this.buttonAddFunc.UseVisualStyleBackColor = true;
            this.buttonAddFunc.Click += new System.EventHandler(this.buttonAddFunc_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpar.Location = new System.Drawing.Point(241, 272);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 34);
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
            this.numBonus.Location = new System.Drawing.Point(9, 234);
            this.numBonus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numBonus.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numBonus.Name = "numBonus";
            this.numBonus.Size = new System.Drawing.Size(307, 22);
            this.numBonus.TabIndex = 9;
            // 
            // labelBonus
            // 
            this.labelBonus.AutoSize = true;
            this.labelBonus.Location = new System.Drawing.Point(5, 215);
            this.labelBonus.Name = "labelBonus";
            this.labelBonus.Size = new System.Drawing.Size(92, 16);
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
            this.comboBoxTipoFunc.Location = new System.Drawing.Point(9, 183);
            this.comboBoxTipoFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTipoFunc.Name = "comboBoxTipoFunc";
            this.comboBoxTipoFunc.Size = new System.Drawing.Size(307, 24);
            this.comboBoxTipoFunc.TabIndex = 7;
            this.comboBoxTipoFunc.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoFunc_SelectedIndexChanged);
            // 
            // labelTipoFunc
            // 
            this.labelTipoFunc.AutoSize = true;
            this.labelTipoFunc.Location = new System.Drawing.Point(5, 164);
            this.labelTipoFunc.Name = "labelTipoFunc";
            this.labelTipoFunc.Size = new System.Drawing.Size(122, 16);
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
            this.numSalarioBase.Location = new System.Drawing.Point(9, 134);
            this.numSalarioBase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSalarioBase.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numSalarioBase.Name = "numSalarioBase";
            this.numSalarioBase.Size = new System.Drawing.Size(307, 22);
            this.numSalarioBase.TabIndex = 5;
            // 
            // labelSalarioBase
            // 
            this.labelSalarioBase.AutoSize = true;
            this.labelSalarioBase.Location = new System.Drawing.Point(5, 114);
            this.labelSalarioBase.Name = "labelSalarioBase";
            this.labelSalarioBase.Size = new System.Drawing.Size(84, 16);
            this.labelSalarioBase.TabIndex = 4;
            this.labelSalarioBase.Text = "Salário base";
            // 
            // textBoxMatricula
            // 
            this.textBoxMatricula.Location = new System.Drawing.Point(9, 85);
            this.textBoxMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMatricula.Name = "textBoxMatricula";
            this.textBoxMatricula.Size = new System.Drawing.Size(307, 22);
            this.textBoxMatricula.TabIndex = 3;
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(5, 66);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(61, 16);
            this.labelMatricula.TabIndex = 2;
            this.labelMatricula.Text = "Matrícula";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(9, 37);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(307, 22);
            this.textBoxNome.TabIndex = 1;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(5, 18);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(103, 16);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome completo";
            // 
            // groupBoxFunc
            // 
            this.groupBoxFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxFunc.Controls.Add(this.listBoxFunc);
            this.groupBoxFunc.Location = new System.Drawing.Point(340, 12);
            this.groupBoxFunc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFunc.Name = "groupBoxFunc";
            this.groupBoxFunc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFunc.Size = new System.Drawing.Size(323, 318);
            this.groupBoxFunc.TabIndex = 12;
            this.groupBoxFunc.TabStop = false;
            this.groupBoxFunc.Text = "Funcionários";
            // 
            // listBoxFunc
            // 
            this.listBoxFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFunc.FormattingEnabled = true;
            this.listBoxFunc.ItemHeight = 16;
            this.listBoxFunc.Location = new System.Drawing.Point(7, 22);
            this.listBoxFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxFunc.Name = "listBoxFunc";
            this.listBoxFunc.Size = new System.Drawing.Size(308, 276);
            this.listBoxFunc.TabIndex = 0;
            // 
            // groupBoxFolhaSalarial
            // 
            this.groupBoxFolhaSalarial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFolhaSalarial.Controls.Add(this.buttonGerar);
            this.groupBoxFolhaSalarial.Controls.Add(this.richTextBoxGerarFolha);
            this.groupBoxFolhaSalarial.Location = new System.Drawing.Point(668, 12);
            this.groupBoxFolhaSalarial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFolhaSalarial.Name = "groupBoxFolhaSalarial";
            this.groupBoxFolhaSalarial.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxFolhaSalarial.Size = new System.Drawing.Size(323, 318);
            this.groupBoxFolhaSalarial.TabIndex = 13;
            this.groupBoxFolhaSalarial.TabStop = false;
            this.groupBoxFolhaSalarial.Text = "Folha salarial";
            // 
            // buttonGerar
            // 
            this.buttonGerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGerar.Location = new System.Drawing.Point(133, 272);
            this.buttonGerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(183, 34);
            this.buttonGerar.TabIndex = 12;
            this.buttonGerar.Text = "Gerar folha";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // richTextBoxGerarFolha
            // 
            this.richTextBoxGerarFolha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxGerarFolha.Location = new System.Drawing.Point(8, 22);
            this.richTextBoxGerarFolha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxGerarFolha.Name = "richTextBoxGerarFolha";
            this.richTextBoxGerarFolha.Size = new System.Drawing.Size(307, 235);
            this.richTextBoxGerarFolha.TabIndex = 0;
            this.richTextBoxGerarFolha.Text = "";
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 345);
            this.Controls.Add(this.groupBoxFolhaSalarial);
            this.Controls.Add(this.groupBoxFunc);
            this.Controls.Add(this.groupBoxAddFunc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JanelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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

