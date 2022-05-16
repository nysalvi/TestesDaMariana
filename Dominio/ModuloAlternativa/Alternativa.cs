using Dominio.Compartilhado;

namespace Dominio.ModuloAlternativa
{
    public class Alternativa : Entidade<Alternativa>
    {
        public bool Correta { get; set; }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }
        public override void Atualizar(Alternativa registro)
        {
        }
    }
}
