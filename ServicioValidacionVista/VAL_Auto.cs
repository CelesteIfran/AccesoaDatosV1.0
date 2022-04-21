using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Entidades;

namespace ServicioValidacionVista
{
    public class VAL_Auto
    {
        public bool ExistePatente(ent_Auto _pAuto, List<ent_Auto> _pListaAutos)
        {
            return _pListaAutos.Exists(x => x.AuPatente == _pAuto.AuPatente);

        }

        Regex _r = new Regex("\\a{2}\\d{3}\\a{3}");
        public bool ValidaPatente(ent_Auto pAuto)
        {
            return _r.IsMatch(pAuto.AuPatente);
        }
    }
}
