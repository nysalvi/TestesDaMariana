using System.Collections.Generic;
using Dominio;
using Dominio.Compartilhado;
using Dominio.ModuloDisciplina;

namespace Dominio.ModuloMateria
{
    public class Materia : Entidade<Materia>
    {    
        public enum TipoSerie { Primeira, Segunda}

        public Disciplina Disciplina { get; set; }

        public TipoSerie Serie { get; set; }

        public override void Atualizar(Materia registro)
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

