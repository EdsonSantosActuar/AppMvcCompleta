using DevEs.Business.Models;

namespace DevEs.Business.Interface
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<IEnumerable<Fornecedor>> ObterFornecedoresEnderecos();
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}
