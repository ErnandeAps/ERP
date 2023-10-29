using Base.Data;

namespace Base.Repository.ClienteRepository;

public interface IClienteRepository
{
    Task<bool> SalvarCliente(Cliente cliente);
    Task<IEnumerable<Cliente>> ListarClientes();
    Task<Cliente> BuscarClienteById(int id);
}