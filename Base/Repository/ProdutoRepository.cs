using Base.Data;
using Base.Repository.FireBirdRepository;
using Microsoft.EntityFrameworkCore;

namespace Base.Repository;

public class ProdutoRepository: DatabaseRepository<Produto>, IProdutoRepository
{
    public ProdutoRepository(DbContext context) : base(context)
    {
    }
}

public interface IProdutoRepository: IDatabaseRepository<Produto>
{
}

