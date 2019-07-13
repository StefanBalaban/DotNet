using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    // Ova klasa je vježba dynamic keyword-a, trebala bi vratit bilo koju vrijednost koja joj se proslijedi
    class Dynamics
    {
        private dynamic _parameter;
        public Dynamics(dynamic parameter)
        {
            _parameter = parameter;
        }
        public dynamic Povratnik()
        {
            return _parameter;
        }
        public dynamic AnonimniPovratnik()
        {
            return new
            {
                Vrijednost = _parameter,
                Tip = _parameter.GetType()
            };
        }
    }
}
