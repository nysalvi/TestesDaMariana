using TestesMariana.Compartilhado;

namespace TestesMariana.ModuloTeste
{
    public class ConfiguracaoToolBoxTeste : ConfiguracaoToolBoxBase
    {
        public override string TipoCadastro => "Cadastro de Questões";

        public override string TooltipInserir { get { return "Inserir uma nova questão"; } }

        public override string TooltipEditar { get { return "Editar uma questão existente"; } }

        public override string TooltipExcluir { get { return "Excluir uma questão existente"; } }

        public override string TooltipAgrupar { get { return "Agrupar questões"; } }

        public override bool AgruparHabilitado { get { return true; } }
    }
}
