using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using BLL;

namespace Vista_Auto
{
    class Vista
    {
        bll_Auto _bblauto;
        public Vista()
        {
            _bblauto = new bll_Auto();

        }
        public Vista(string patente, DateTime fechaingreso, DateTime fechabaja, int anio, decimal valor, bool en_uso, decimal valor_residual, int cantidad_dias)
        {
            Patente = patente;
            Fecha_Ingreso = fechaingreso;
            Fecha_Baja = fechabaja;
            Año = anio;
            Valor = valor;
            EnUso = en_uso;
            Valor_Residual = valor_residual;
            Cantidad_Dias = cantidad_dias;

        }

        public string Patente { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_Baja { get; set; }
        public int Año { get; set; }
        public decimal Valor { get; set; }
        public bool EnUso { get; set; }
        public decimal Valor_Residual { get; set; }
        public int Cantidad_Dias { get; set; }

        public List<Vista> RetornaListaVista(List<ent_Auto> _listaAuto)
        {
            List<Vista> _vistaList = new List<Vista>();
            try
            {
                foreach(var a in _listaAuto)
                {
                    _vistaList.Add(new Vista(a.AuPatente, a.AuFechaIngreso, a.AuFechaBaja, a.AuAño, a.AuValor, _bblauto.EnUso(a), _bblauto.Calcular_Valor_Residual(a), _bblauto.Cantidad_Dias(a)));
                }
            }
            catch (Exception ex) { throw ex; }
            return _vistaList;
        }
        
        
    }         
           
        
}    

