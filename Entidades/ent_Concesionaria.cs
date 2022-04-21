using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ent_Concesionaria
    {
        List<ent_Auto> _la;
        public ent_Concesionaria()
        { 
            _la = new List<ent_Auto>();
        }


    
            

         public void CargarAuto(List<ent_Auto> pAuto)
         {
             _la.Clear();
             foreach (ent_Auto _a in pAuto)
             {
                 _la.Add(_a.CloneTipado());

             }
         }

        public List<ent_Auto> ConsultaTodo()
        {
            List<ent_Auto> _auxla = new List<ent_Auto>();
            foreach (ent_Auto _a in _la)
            {
                _auxla.Add(_a.CloneTipado());
            }
            return _auxla;
        }

       
    }
}
