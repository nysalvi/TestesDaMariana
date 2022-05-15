namespace TestesMariana.ModuloMateria
{
    partial class TelaCadastroMateriasForm
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
            this.labelNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNumero = new System.Windows.Forms.MaskedTextBox();
            this.labelDisciplina = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.labelSerie = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(25, 121);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(40, 15);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nº";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(128, 121);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(221, 23);
            this.textBoxNome.TabIndex = 6;
            // 
            // maskedTextBoxNumero
            // 
            this.maskedTextBoxNumero.Location = new System.Drawing.Point(128, 48);
            this.maskedTextBoxNumero.Mask = "0000000000";
            this.maskedTextBoxNumero.Name = "maskedTextBoxNumero";
            this.maskedTextBoxNumero.Size = new System.Drawing.Size(221, 23);
            this.maskedTextBoxNumero.TabIndex = 5;
            this.maskedTextBoxNumero.ValidatingType = typeof(int);
            // 
            // labelDisciplina
            // 
            this.labelDisciplina.AutoSize = true;
            this.labelDisciplina.Location = new System.Drawing.Point(25, 173);
            this.labelDisciplina.Name = "labelDisciplina";
            this.labelDisciplina.Size = new System.Drawing.Size(64, 15);
            this.labelDisciplina.TabIndex = 7;
            this.labelDisciplina.Text = "Disciplina: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 19);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1ª Série";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(115, 216);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 37);
            this.panel1.TabIndex = 10;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(140, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(64, 19);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2ª Série";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // labelSerie
            // 
            this.labelSerie.AutoSize = true;
            this.labelSerie.Location = new System.Drawing.Point(25, 216);
            this.labelSerie.Name = "labelSerie";
            this.labelSerie.Size = new System.Drawing.Size(35, 15);
            this.labelSerie.TabIndex = 0;
            this.labelSerie.Text = "Série:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 47);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonGravar_Click);
            // 
            // TelaCadastroMateriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSerie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelDisciplina);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.maskedTextBoxNumero);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroMateriasForm";
            this.Text = "Cadastro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumero;
        private System.Windows.Forms.Label labelDisciplina;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label labelSerie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}