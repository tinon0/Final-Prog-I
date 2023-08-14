using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos
{
    public class AutoService
    {
        private AccesoDatos oAccesoDatos;

        public AutoService()
        {
           oAccesoDatos = new AccesoDatos();
        }

        public DataTable getComboMarcas()
        {
            return oAccesoDatos.ConsultarTabla("Marcas");
        }
        public DataTable getComboColores()
        {
            return oAccesoDatos.ConsultarTabla("Colores");
        }
        public List<Auto> getLista()
        {
            List<Auto> lista = new List<Auto>();
            DataTable table = oAccesoDatos.ConsultarTabla("Autos");
            Auto oAuto = null;
            foreach(DataRow fila in table.Rows)
            {
                oAuto = new Auto();
                oAuto.Patente = Convert.ToString(fila["patente"]);
                oAuto.Marca = Convert.ToInt32(fila["marca"]);
                oAuto.Modelo = Convert.ToInt32(fila["modelo"]);
                oAuto.Color = Convert.ToInt32(fila["color"]);
                oAuto.Precio = Convert.ToDouble(fila["precio"]);
                lista.Add(oAuto);
            }
            return lista;
        }

        public bool Guardar(Auto oAuto, bool esNuevo)
        {
            bool success = false;
            string sql;
            if (esNuevo)
                sql = "INSERT INTO Autos VALUES (@patente, @marca, @modelo, @color, @precio)";
            else
                sql = "UPDATE Autos SET marca = @marca, modelo = @modelo, color = @color, precio = @precio WHERE patente = @patente";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@patente", oAuto.Patente));
            parametros.Add(new Parametro("@marca", oAuto.Marca));
            parametros.Add(new Parametro("@modelo", oAuto.Modelo));
            parametros.Add(new Parametro("@color", oAuto.Color));
            parametros.Add(new Parametro("@precio", oAuto.Precio));

            success = oAccesoDatos.ActualizarconParametros(sql, parametros);
            return success;
        }

        public bool Borrar(string patente)
        {
            bool success = false;
            string sql = "DELETE FROM Autos WHERE patente = @patente";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@patente", patente));
            success = oAccesoDatos.ActualizarconParametros(sql, parametros);
            return success;
        }
    }
}
