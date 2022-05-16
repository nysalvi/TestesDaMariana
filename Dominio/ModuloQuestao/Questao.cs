using System;
using Dominio.Compartilhado;
using Dominio.ModuloDisciplina;
using Dominio.ModuloMateria;
using Dominio.ModuloAlternativa;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.ModuloQuestao
{
    public class Questao : Entidade<Questao>
    {
        public Questao()
        {

        }
        public Disciplina Disciplina { get; set; }
        public Materia Materia { get; set; }
        private Alternativa correta;
        public List<Alternativa> Alternativas { get; set; }

        public Alternativa Correta
        {
            get
            {
                correta = GetCorreta();
                return correta;
            }
        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public Alternativa GetCorreta()
        {
            return Alternativas.Find(x => x.Correta);
        }
        public override void Atualizar(Questao registro)
        {
        }
    }
}
