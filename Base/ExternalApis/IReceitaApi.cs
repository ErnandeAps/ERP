using Base.Data;
using Refit;

namespace Base.ExternalApis;

public interface IReceitaApi
{
    [Get("/cnpj/{cnpj}")]
    public Task<ApiResponse<Cliente>> ConsultarCNPJ(string cnpj);
}