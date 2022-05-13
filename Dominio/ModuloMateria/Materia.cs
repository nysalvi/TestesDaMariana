using System.Collections.Generic;
using Dominio;
using Dominio.Compartilhado;
using Dominio.ModuloDisciplina;

namespace Dominio.ModuloMateria
{
    public class Materia : Entidade<Materia>
    {
        public Materia()
        {

        }
        public enum TipoSerie { Primeira, Segunda}

        public Disciplina Disciplina { get; set; }

        public TipoSerie Serie { get; set; }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}

