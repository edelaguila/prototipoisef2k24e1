using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModeloPrototipo;
namespace CapaControladorPrototipo
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        public bool GuardarDatos(string tabla, Dictionary<string, object> valores)
        {
            return sn.Guardar(tabla, valores);
        }

        public List<string> llenarCombo(string columna1, string tabla)
        {
            return sn.llenarCombo(columna1, tabla);
        }

        public DataTable Buscar(string tabla, string columna, string dato)
        {
            return sn.Buscar(tabla, columna, dato);

        }

        public DataTable llenarDataGRID(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarDataGRID(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
    }
}
