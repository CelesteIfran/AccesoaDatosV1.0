using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //los especializados en este acceso de datos (sql), eg comand builder (borrado, modificacion, etc)
using System.Data;
using System.IO;

namespace DAO
{
    public class Dao_AccesoXML
    {
       

        DataSet _ds;
        DataTable _dtAuto;

       public Dao_AccesoXML()
        {


         _ds = new DataSet("Datos");

        if (!File.Exists("Datos.xml")) { CrearArchivo(); }
         else { _ds.ReadXml("Datos.xml"); }

        }

        public DataSet RetornaDataSet() { return _ds; }
        public void GrabarDatos()
        {
             _ds.WriteXml("Datos.xml", XmlWriteMode.WriteSchema);
        }

        private void CrearArchivo()
        {
        _dtAuto = new DataTable("Auto");

        _dtAuto.Columns.Add("Patente", typeof(string));
        _dtAuto.Columns.Add("Año", typeof(int));
        _dtAuto.Columns.Add("FechaIngreso", typeof(DateTime));
        _dtAuto.Columns.Add("FechaBaja", typeof(DateTime));
        _dtAuto.Columns.Add("Valor", typeof(decimal));
      
        _dtAuto.PrimaryKey = new DataColumn[] { _dtAuto.Columns[0] };

        _ds.Tables.AddRange(new DataTable[] { _dtAuto });

        GrabarDatos();
        }
       
    }


}
