using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;
using System.Data; //todos los objetos que hacen a la estructura de datos en memoria, eg data table, data column, etc


namespace Mapeadores
{
    public class map_Auto 
    {
         Dao_AccesoXML _dao; DataSet _ds;

          public map_Auto()
          { _dao = new Dao_AccesoXML(); _ds = _dao.RetornaDataSet(); }

          public void CargarAuto(ent_Auto pObject)
          {
              try
              {
                DataTable _dtAuto = _ds.Tables["Auto"];
                DataRow _drAuto = _dtAuto.NewRow();
                
                    
                _drAuto.ItemArray = new object[] { pObject.AuPatente, pObject.AuAño, pObject.AuFechaIngreso, pObject.AuFechaBaja, pObject.AuValor };
                    
                    
                

                _dtAuto.Rows.Add(_drAuto);
                _dao.GrabarDatos();
              }

              catch (Exception ex) { throw ex; }
          }

         
          public List<ent_Auto> ConsultaTodo()
          {
            
            try
            {
                List<ent_Auto> _list = new List<ent_Auto>();
                foreach (DataRow _r in _ds.Tables["Auto"].Rows)
                {
                    _list.Add(new ent_Auto(_r.ItemArray));
                }
                return _list;
            }
            catch (Exception ex) { throw ex; }
            
          }

         
    }
}
