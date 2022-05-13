using System;
using Dominio.ModuloDisciplina;
using Dominio.ModuloQuestao;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Teste
{
    public class Teste
    {
        public DateTime Data { get; set; }

        public int NQuestoes { get; set; }

        public Disciplina Disciplina { get; set; }

        public List<Questao> Questoes { get; set; }
    }
}
