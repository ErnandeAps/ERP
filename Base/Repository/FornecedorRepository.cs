using Base.Data;
using Base.Repository.FireBirdRepository;
using Microsoft.EntityFrameworkCore;

namespace Base.Repository.FornecedorRepository;

public class FornecedorRepository: DatabaseRepository<Fornecedor>, IFornecedorRepository
{
    public FornecedorRepository(DbContext context) : base(context)
    {
    }
} 

public interface IFornecedorRepository: IDatabaseRepository<Fornecedor>
{
}