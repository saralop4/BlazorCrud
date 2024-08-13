using BlazorCRUD.Data;
using BlazorCRUD.Interfaces;
using BlazorCRUD.Repositorio;

namespace BlazorCRUD.Servicios
{
    public class ServicioCliente : IClienteServicios
    {

        private IClienteRepositorio _clienteRepositorio;
        private readonly SqlConfiguracion _configuracion;

        public ServicioCliente(SqlConfiguracion configuracion)
        {
            _clienteRepositorio = new RepositorioCliente(configuracion.CadenaConexion);
            _configuracion = configuracion;
        }

        public Task<bool> GuardarCliente(Cliente cliente)
        {
            if (cliente.Id == 0)
            {
                return _clienteRepositorio.GuardarCliente(cliente);

            }
            else
                return null; 
        }
    }
}
