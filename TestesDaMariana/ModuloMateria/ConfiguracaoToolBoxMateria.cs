using TestesMariana.Compartilhado;

namespace TestesMariana.ModuloMateria
{
    public class ConfiguracaoToolBoxMateria : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Matérias";

        public override string TooltipInserir { get { return "Inserir uma nova matéria"; } }

        public override string TooltipEditar { get { return "Editar uma matéria existente"; } }

        public override string TooltipExcluir { get { return "Excluir uma matéria existente"; } }

        public override string TooltipAgrupar { get { return "Agrupar matérias"; } }

        public override bool AgruparHabilitado { get { return true; } }
    }
}
