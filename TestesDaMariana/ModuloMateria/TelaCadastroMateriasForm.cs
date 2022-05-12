using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Dominio.ModuloMateria;

namespace TestesDaMariana.ModuloMateria
{
    public partial class TelaCadastroMateriasForm : Form
    {
        public TelaCadastroMateriasForm()
        {
            InitializeComponent();
        }
        private Materia materia;

        public Func<Materia, ValidationResult> GravarRegistro { get; set; }

        public Materia Materia
        {
            get { return materia; }
            set
            {
                materia = value;

                maskedTextBoxNumero.Text = materia.ID.ToString();
                textBoxNome.Text = materia.Titulo;
                comboBox1.SelectedItem = materia.Disciplina;
                
                if (materia.Serie == Materia.TipoSerie.Primeira)
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
            }
        }


        private void buttonGravar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
