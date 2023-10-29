using Refit;

namespace Base.ExternalApis;

public interface ICorreiosApi
{
    [Post("/consulta-cep")]
    public Task ConsultarCep(string cep);
}