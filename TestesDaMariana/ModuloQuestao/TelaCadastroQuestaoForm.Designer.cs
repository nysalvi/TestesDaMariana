namespace TestesMariana.ModuloQuestao
{
    partial class TelaCadastroQuestaoForm
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
            this.labelNumero = new System.Windows.Forms.Label();
            this.maskedTextBoxNumero = new System.Windows.Forms.MaskedTextBox();
            this.labelEnunciado = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.labelMateria = new System.Windows.Forms.Label();
            this.labelDisciplina = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdicionar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBoxAlternativaCorreta = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelResposta = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGravar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(63, 15);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(21, 15);
            this.labelNumero.TabIndex = 0;
            this.labelNumero.Text = "Nº";
            // 
            // maskedTextBoxNumero
            // 
            this.maskedTextBoxNumero.Location = new System.Drawing.Point(167, 12);
            this.maskedTextBoxNumero.Mask = "0000000000";
            this.maskedTextBoxNumero.Name = "maskedTextBoxNumero";
            this.maskedTextBoxNumero.Size = new System.Drawing.Size(128, 23);
            this.maskedTextBoxNumero.TabIndex = 2;
            this.maskedTextBoxNumero.ValidatingType = typeof(int);
            // 
            // labelEnunciado
            // 
            this.labelEnunciado.AutoSize = true;
            this.labelEnunciado.Location = new System.Drawing.Point(63, 102);
            this.labelEnunciado.Name = "labelEnunciado";
            this.labelEnunciado.Size = new System.Drawing.Size(63, 15);
            this.labelEnunciado.TabIndex = 3;
            this.labelEnunciado.Text = "Enunciado";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(167, 99);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(128, 23);
            this.textBoxNome.TabIndex = 4;
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(167, 70);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMateria.TabIndex = 5;
            this.comboBoxMateria.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(167, 41);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDisciplina.TabIndex = 6;
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Location = new System.Drawing.Point(63, 73);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(47, 15);
            this.labelMateria.TabIndex = 7;
            this.labelMateria.Text = "Matéria";
            // 
            // labelDisciplina
            // 
            this.labelDisciplina.AutoSize = true;
            this.labelDisciplina.Location = new System.Drawing.Point(63, 44);
            this.labelDisciplina.Name = "labelDisciplina";
            this.labelDisciplina.Size = new System.Drawing.Size(58, 15);
            this.labelDisciplina.TabIndex = 8;
            this.labelDisciplina.Text = "Disciplina";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAdicionar);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.checkBoxAlternativaCorreta);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelResposta);
            this.panel1.Location = new System.Drawing.Point(12, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 292);
            this.panel1.TabIndex = 9;
            // 
            // buttonAdicionar
            // 
            this.buttonAdicionar.Location = new System.Drawing.Point(271, 22);
            this.buttonAdicionar.Name = "buttonAdicionar";
            this.buttonAdicionar.Size = new System.Drawing.Size(75, 23);
            this.buttonAdicionar.TabIndex = 4;
            this.buttonAdicionar.Text = "Adicionar";
            this.buttonAdicionar.UseVisualStyleBackColor = true;
            this.buttonAdicionar.Click += new System.EventHandler(this.buttonAdicionar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(18, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 184);
            this.listBox1.TabIndex = 3;
            // 
            // checkBoxAlternativaCorreta
            // 
            this.checkBoxAlternativaCorreta.AutoSize = true;
            this.checkBoxAlternativaCorreta.Location = new System.Drawing.Point(34, 60);
            this.checkBoxAlternativaCorreta.Name = "checkBoxAlternativaCorreta";
            this.checkBoxAlternativaCorreta.Size = new System.Drawing.Size(125, 19);
            this.checkBoxAlternativaCorreta.TabIndex = 2;
            this.checkBoxAlternativaCorreta.Text = "Alternativa Correta";
            this.checkBoxAlternativaCorreta.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 23);
            this.textBox1.TabIndex = 1;
            // 
            // labelResposta
            // 
            this.labelResposta.AutoSize = true;
            this.labelResposta.Location = new System.Drawing.Point(18, 25);
            this.labelResposta.Name = "labelResposta";
            this.labelResposta.Size = new System.Drawing.Size(54, 15);
            this.labelResposta.TabIndex = 0;
            this.labelResposta.Text = "Resposta";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(271, 439);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 33);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGravar
            // 
            this.buttonGravar.Location = new System.Drawing.Point(190, 439);
            this.buttonGravar.Name = "buttonGravar";
            this.buttonGravar.Size = new System.Drawing.Size(75, 33);
            this.buttonGravar.TabIndex = 12;
            this.buttonGravar.Text = "Gravar";
            this.buttonGravar.UseVisualStyleBackColor = true;
            this.buttonGravar.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // TelaCadastroQuestaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 484);
            this.Controls.Add(this.buttonGravar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDisciplina);
            this.Controls.Add(this.labelMateria);
            this.Controls.Add(this.comboBoxDisciplina);
            this.Controls.Add(this.comboBoxMateria);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelEnunciado);
            this.Controls.Add(this.maskedTextBoxNumero);
            this.Controls.Add(this.labelNumero);
            this.Name = "TelaCadastroQuestaoForm";
            this.Text = "TelaCadastroQuestaoForm";
            this.Load += new System.EventHandler(this.TelaCadastroQuestaoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumero;
        private System.Windows.Forms.Label labelEnunciado;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.Label labelDisciplina;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxAlternativaCorreta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelResposta;
        private System.Windows.Forms.Button buttonAdicionar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGravar;
    }
}