using System;
using Dominio.ModuloDisciplina;
using Dominio.ModuloMateria;
using Dominio.Compartilhado;
using Dominio.ModuloQuestao;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ModuloTeste
{
    public class Teste : Entidade<Teste>
    {
        public DateTime Data { get; set; }

        public int NQuestoes { get; set; }

        public Disciplina Disciplina { get; set; }

        public Materia Materia { get; set; }
        public List<Questao> Questoes { get; set; }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
