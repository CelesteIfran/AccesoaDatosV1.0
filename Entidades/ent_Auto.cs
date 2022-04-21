using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ent_Auto
    {
        public ent_Auto()
        {
        }

        public ent_Auto(object[] pO)
        {
            AuPatente = pO[0].ToString();
            AuAño = Convert.ToInt32(pO[1]);
            AuFechaIngreso = Convert.ToDateTime(pO[2]);
            AuFechaBaja = Convert.ToDateTime(pO[3]);
            AuValor = Convert.ToDecimal(pO[4]);
        }
        public ent_Auto(string auPatente, int auAño, DateTime auFechaIngreso, DateTime auFechaBaja, decimal auValor)
        {
            AuPatente = auPatente;
            AuAño = auAño;
            AuFechaIngreso = auFechaIngreso;
            AuFechaBaja = auFechaBaja;
            AuValor = auValor;
        }
        
       
        public string AuPatente { get; set; }
        public int AuAño { get; set; }
        public DateTime AuFechaIngreso { get; set; }
        public DateTime AuFechaBaja { get; set; }
        public decimal AuValor { get; set; }

        public object Clone()
        {
            ent_Auto _autoclonado = this.MemberwiseClone() as ent_Auto; return _autoclonado; 
        }
        public ent_Auto CloneTipado()
        {
            return Clone() as ent_Auto;
        }
       
    }

}


