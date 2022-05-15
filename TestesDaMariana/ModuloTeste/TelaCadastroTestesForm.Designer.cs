namespace TestesMariana.ModuloTeste
{
    partial class TelaCadastroTestesForm
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelMateria = new System.Windows.Forms.Label();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.labelDisciplina = new System.Windows.Forms.Label();
            this.comboBoxDisciplina = new System.Windows.Forms.ComboBox();
            this.labelData = new System.Windows.Forms.Label();
            this.maskedTextBoxData = new System.Windows.Forms.MaskedTextBox();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.maskedTextBoxQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.checkBoxRecuperacao = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(41, 12);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(21, 15);
            this.labelNumero.TabIndex = 1;
            this.labelNumero.Text = "Nº";
            // 
            // maskedTextBoxNumero
            // 
            this.maskedTextBoxNumero.Location = new System.Drawing.Point(102, 9);
            this.maskedTextBoxNumero.Mask = "0000000000";
            this.maskedTextBoxNumero.Name = "maskedTextBoxNumero";
            this.maskedTextBoxNumero.Size = new System.Drawing.Size(128, 23);
            this.maskedTextBoxNumero.TabIndex = 3;
            this.maskedTextBoxNumero.ValidatingType = typeof(int);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(102, 38);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(128, 23);
            this.textBoxNome.TabIndex = 6;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(41, 41);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(37, 15);
            this.labelTitulo.TabIndex = 5;
            this.labelTitulo.Text = "Titulo";
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Location = new System.Drawing.Point(41, 96);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(47, 15);
            this.labelMateria.TabIndex = 9;
            this.labelMateria.Text = "Matéria";
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(102, 93);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMateria.TabIndex = 8;
            // 
            // labelDisciplina
            // 
            this.labelDisciplina.AutoSize = true;
            this.labelDisciplina.Location = new System.Drawing.Point(41, 68);
            this.labelDisciplina.Name = "labelDisciplina";
            this.labelDisciplina.Size = new System.Drawing.Size(58, 15);
            this.labelDisciplina.TabIndex = 11;
            this.labelDisciplina.Text = "Disciplina";
            // 
            // comboBoxDisciplina
            // 
            this.comboBoxDisciplina.FormattingEnabled = true;
            this.comboBoxDisciplina.Location = new System.Drawing.Point(102, 65);
            this.comboBoxDisciplina.Name = "comboBoxDisciplina";
            this.comboBoxDisciplina.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDisciplina.TabIndex = 10;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(236, 41);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(34, 15);
            this.labelData.TabIndex = 12;
            this.labelData.Text = "Data:";
            // 
            // maskedTextBoxData
            // 
            this.maskedTextBoxData.Location = new System.Drawing.Point(298, 38);
            this.maskedTextBoxData.Mask = "00/00/0000";
            this.maskedTextBoxData.Name = "maskedTextBoxData";
            this.maskedTextBoxData.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxData.TabIndex = 13;
            this.maskedTextBoxData.ValidatingType = typeof(System.DateTime);
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(41, 128);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(137, 15);
            this.labelQuantidade.TabIndex = 14;
            this.labelQuantidade.Text = "Quantidade de Questões";
            // 
            // maskedTextBoxQuantidade
            // 
            this.maskedTextBoxQuantidade.Location = new System.Drawing.Point(181, 125);
            this.maskedTextBoxQuantidade.Mask = "000";
            this.maskedTextBoxQuantidade.Name = "maskedTextBoxQuantidade";
            this.maskedTextBoxQuantidade.Size = new System.Drawing.Size(100, 23);
            this.maskedTextBoxQuantidade.TabIndex = 15;
            this.maskedTextBoxQuantidade.ValidatingType = typeof(int);
            // 
            // checkBoxRecuperacao
            // 
            this.checkBoxRecuperacao.AutoSize = true;
            this.checkBoxRecuperacao.Location = new System.Drawing.Point(236, 69);
            this.checkBoxRecuperacao.Name = "checkBoxRecuperacao";
            this.checkBoxRecuperacao.Size = new System.Drawing.Size(151, 19);
            this.checkBoxRecuperacao.TabIndex = 17;
            this.checkBoxRecuperacao.Text = "Prova de Recuperação ?";
            this.checkBoxRecuperacao.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(23, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 270);
            this.panel1.TabIndex = 18;
            // 
            // TelaCadastroTestesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBoxRecuperacao);
            this.Controls.Add(this.maskedTextBoxQuantidade);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.maskedTextBoxData);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelDisciplina);
            this.Controls.Add(this.comboBoxDisciplina);
            this.Controls.Add(this.labelMateria);
            this.Controls.Add(this.comboBoxMateria);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.maskedTextBoxNumero);
            this.Controls.Add(this.labelNumero);
            this.Name = "TelaCadastroTestesForm";
            this.Text = "TelaCadastroTestesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumero;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.Label labelDisciplina;
        private System.Windows.Forms.ComboBox comboBoxDisciplina;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxData;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxQuantidade;
        private System.Windows.Forms.CheckBox checkBoxRecuperacao;
        private System.Windows.Forms.Panel panel1;
    }
}