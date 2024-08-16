using BlazorCRUD.Data;

namespace BlazorCRUD.Repositorio
{
    public interface IClienteRepositorio
    {

        Task<bool> GuardarCliente(Cliente cliente);
        Task<IEnumerable<Cliente>> ListarClientes();
    }
}
