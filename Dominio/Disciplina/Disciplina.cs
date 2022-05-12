using System.Collections.Generic;
using Dominio.ModuloMateria;
using Dominio.Compartilhado;

namespace Dominio.Disciplina
{
    public class Disciplina : Entidade
    {
        private List<Materia> materias = new List<Materia>();

        public Disciplina(int id, string titulo, List<Materia> materias) : base(id, titulo)
        {
            this.materias = materias;
        }

        public override string ToString()
        {
            throw new System.NotImplementedException();
        }

        public override string Validar()
        {
            throw new System.NotImplementedException();
        }
    }

}
