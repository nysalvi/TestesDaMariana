using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Compartilhado
{
    public abstract class Entidade<T>
    {
        public int Numero { get; set; }
        public string Titulo { get; set; }
        public abstract override string ToString();
    }
}
