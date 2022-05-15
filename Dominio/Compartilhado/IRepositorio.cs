using FluentValidation.Results;
using System.Collections.Generic;
using Dominio.Compartilhado;
namespace Dominio.Compartilhado
{
    public interface IRepositorio<T> where T : Entidade<T>
    {
        ValidationResult Inserir(T novoRegistro);

        ValidationResult Editar(T registro);

        ValidationResult Excluir(T registro);

        List<T> SelecionarTodos();

        T SelecionarPorNumero(int numero);
    }
}
