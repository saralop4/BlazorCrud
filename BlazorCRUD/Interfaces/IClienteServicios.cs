using BlazorCRUD.Data;

namespace BlazorCRUD.Interfaces
{
    public interface IClienteServicios
    {
        Task<bool> GuardarCliente(Cliente cliente);
        Task<IEnumerable<Cliente>> ListarClientes();


    }
}
