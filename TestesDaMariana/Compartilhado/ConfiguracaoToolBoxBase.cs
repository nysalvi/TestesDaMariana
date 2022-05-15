﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesMariana.Compartilhado
{
    public abstract class ConfiguracaoToolBoxBase
    {
        public abstract string TipoCadastro { get; }

        public abstract string TooltipInserir { get; }

        public abstract string TooltipEditar { get; }

        public abstract string TooltipExcluir { get; }

        public virtual string TooltipAdicionarItens { get; }

        public virtual string TooltipAtualizarItens { get; }

        public virtual string TooltipFiltrar { get; }

        public virtual string TooltipAgrupar { get; }

        public virtual string TooltipPDF { get; }

        public virtual bool InserirHabilitado { get { return true; } }

        public virtual bool EditarHabilitado { get { return true; } }

        public virtual bool ExcluirHabilitado { get { return true; } }

        public virtual bool AdicionarItensHabilitado { get { return false; } }

        public virtual bool AtualizarItensHabilitado { get { return false; } }

        public virtual bool FiltrarHabilitado { get { return false; } }

        public virtual bool AgruparHabilitado { get { return false; } }

        public virtual bool PDFHabilitado { get; }
    }
}
