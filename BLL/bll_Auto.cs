using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Mapeadores;


namespace BLL
{
    public class bll_Auto 
    {
        map_Auto _mapauto;

        public bll_Auto()
        {
            _mapauto = new map_Auto();
        }
        public void CargarAuto(ent_Auto pObject)
        {
            _mapauto.CargarAuto(pObject);
        }

    
        public bool EnUso(ent_Auto pAuto)
        {
            bool _EnUso;
            
            try
            {
                DateTime _FechaBaja = pAuto.AuFechaBaja;
                DateTime _fechadefault = new DateTime(2999, 1, 1);
                _EnUso = DateTime.Equals(_FechaBaja, _fechadefault);
            }
            catch (Exception ex) { throw ex; }

            return _EnUso;
        }
        public decimal Calcular_Valor_Residual(ent_Auto pAuto)
        {
            decimal res = 0;
            try
            {
                int AnioActual = DateTime.Now.Year;
                int AnioAuto = pAuto.AuAño;
                int Resta = AnioActual - AnioAuto;
                decimal AuValorRestar = 0.10m * Resta;
                res = pAuto.AuValor - AuValorRestar;

            }
            catch (Exception ex) { throw ex; }

            return res;
        }

        public int Cantidad_Dias(ent_Auto pAuto)
        {
            int dias = 0;
            try
            {
                dias = (int)(pAuto.AuFechaBaja - pAuto.AuFechaIngreso).TotalDays;


            }
            catch (Exception ex) { throw ex; }

            return dias;
        }


        public List<ent_Auto> ConsultaTodo()
        {
            
            return _mapauto.ConsultaTodo();

          
        }


        
    }

   
}
