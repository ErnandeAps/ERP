using Base.Data;
using Base.Db;
using Microsoft.EntityFrameworkCore;

namespace Base.Repository.ClienteRepository;

public class ClienteRepository:IClienteRepository
{
    private readonly FireBirdContext dbContext;

    public ClienteRepository(FireBirdContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<bool> SalvarCliente(Cliente cliente)
    {
        try
        {
            await dbContext.AddAsync(cliente);
            var id = await dbContext.SaveChangesAsync();
            return id > 0;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        return false;
    }

    public async Task<IEnumerable<Cliente>> ListarClientes()
    {
        return await dbContext.Clientes.ToListAsync();
    }

    public async Task<Cliente> BuscarClienteById(int id)
    {
        return await dbContext.Clientes.Where(e => e.ID_CADASTRO == id).FirstOrDefaultAsync();
    }
}