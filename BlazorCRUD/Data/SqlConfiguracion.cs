namespace BlazorCRUD.Data
{
    public class SqlConfiguracion
    {

        private readonly string _cadenaConexion;
        public string CadenaConexion { get => _cadenaConexion; }
        public SqlConfiguracion(string Conexion)
        {
            _cadenaConexion = Conexion;
        }


    }
}
