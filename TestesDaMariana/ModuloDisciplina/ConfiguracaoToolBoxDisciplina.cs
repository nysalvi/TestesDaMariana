using TestesDaMariana.Compartilhado;

namespace TestesDaMariana.ModuloDisciplina
{
    public class ConfiguracaoToolBoxDisciplina : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Disciplinas";

        public override string TooltipInserir { get { return "Inserir uma nova disciplina"; } }

        public override string TooltipEditar { get { return "Editar uma disciplina existente"; } }

        public override string TooltipExcluir { get { return "Excluir uma disciplina existente"; } }

        public override string TooltipAgrupar { get { return "Agrupar disciplinas"; } }

        public override bool AgruparHabilitado { get { return true; } }
    }
}
