using TestesMariana.Compartilhado;

namespace TestesMariana.ModuloQuestao
{
    public class ConfiguracaoToolBoxQuestao : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Questões";

        public override string TooltipInserir { get { return "Inserir uma nova questões"; } }

        public override string TooltipEditar { get { return "Editar uma questões existente"; } }

        public override string TooltipExcluir { get { return "Excluir uma questões existente"; } }

        public override string TooltipAgrupar { get { return "Agrupar questões"; } }

        public override bool AgruparHabilitado { get { return true; } }
    }
}
