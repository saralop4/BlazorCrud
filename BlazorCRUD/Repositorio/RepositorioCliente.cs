using BlazorCRUD.Data;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System.Data.SqlClient;

namespace BlazorCRUD.Repositorio
{
    public class RepositorioCliente :IClienteRepositorio
    {
        private readonly string _cadenaConexion;

        public RepositorioCliente(string cadenaConexion)        {
            _cadenaConexion = cadenaConexion;
        }

        private SqlConnection conexion()
        {
            return new SqlConnection(_cadenaConexion);
        }

        public async Task<bool> GuardarCliente(Cliente cliente)
        {
            Boolean clienteCreado = false;
            SqlConnection sqlConexion = conexion();
            SqlCommand comm = null;

            try
            {
                sqlConexion.Open();
                comm = sqlConexion.CreateCommand();
                comm.CommandText = "dbo.GuardarCliente";
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Parameters.Add("@Nombre", System.Data.SqlDbType.VarChar, 80).Value = cliente.Nombre;
                comm.Parameters.Add("@Correo", System.Data.SqlDbType.VarChar, 80).Value = cliente.Correo;
                comm.Parameters.Add("@Telefono", System.Data.SqlDbType.VarChar, 20).Value = cliente.Telefono;
                comm.Parameters.Add("@Fecha", System.Data.SqlDbType.DateTime).Value = cliente.Fecha;

                await comm.ExecuteNonQueryAsync();
                clienteCreado = true;

            }catch(SqlException ex) 
            {
                throw new Exception(ex.Message + "Error al guardar datos del cliente");
            }
            finally
            {
                comm.Dispose();
                sqlConexion.Close();
                sqlConexion.Dispose();
            }

            return clienteCreado;


        }

    }
}
