using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Autos
{
    public class AccesoDatos
    {
        private string cadenaConexion = @"Su_Acceso_al_Servidor";
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public AccesoDatos()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public SqlDataReader Lector
        {
            get { return lector; }
            set { lector = value; }
        }

        public void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        public void Desconectar()
        {
            conexion.Close();
        }
        public DataTable ConsultarTabla(string nombreTabla)
        {
            DataTable table = new DataTable();
            Conectar();
            comando.CommandText = "SELECT * FROM " + nombreTabla + " ORDER BY 2";
            table.Load(comando.ExecuteReader());
            Desconectar();
            return table;
        }
        public bool ActualizarconParametros(string sql, List<Parametro> parametros)
        {
            int filasafectadas = 0;
            Conectar();
            comando.CommandText = sql;
            foreach(Parametro param in parametros)
            {
                comando.Parameters.AddWithValue(param.Clave, param.Valor);
            }
            filasafectadas = comando.ExecuteNonQuery();
            Desconectar();
            return filasafectadas == 1;
        }

    }
}
