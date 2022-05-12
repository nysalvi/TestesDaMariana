using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Compartilhado
{
    public abstract class Entidade<T>
    {
        private int id;
        private string titulo;

        public Entidade(int id, string titulo)
        {
            this.id = id;
            this.titulo = titulo;
        }
        public int ID => id;
        public string Titulo => titulo;
        public abstract string Validar();
        public abstract void Atualizar(T registro);
        public abstract override string ToString();
    }
}
