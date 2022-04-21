using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Mapeadores;


namespace BLL
{
    public class bll_Concesionaria
    {
      
        ent_Concesionaria _entc;
        bll_Auto _aubll;

        public bll_Concesionaria()
        {
           
            _entc = new ent_Concesionaria();
            _aubll = new bll_Auto();

            _entc.CargarAuto(_aubll.ConsultaTodo());
        }

    

         public void CargarAuto(ent_Auto pAuto)
         {

            _aubll.CargarAuto(pAuto);
            _entc.CargarAuto(_aubll.ConsultaTodo());

         }    

        

        public List<ent_Auto> ConsultaTodo()
        {
            
            return _entc.ConsultaTodo();
        }

    }
}
