using System.Collections.Generic;
using Dominio.ModuloMateria;
using Dominio.Compartilhado;

namespace Dominio.ModuloDisciplina
{
    public class Disciplina : Entidade<Disciplina>
    {
        private List<Materia> materias = new List<Materia>();

        public Disciplina()
        {

        }
        public override void Atualizar(Disciplina registro)
        {
            throw new System.NotImplementedException();
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
