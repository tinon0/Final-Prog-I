using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autos
{
    public class Parametro
    {
        private string clave;
        private object valor;

        public Parametro()
        {
            clave = null;
            valor = null;
        }
        public Parametro(string clave, object valor)
        {
            this.clave = clave;
            this.valor = valor;
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public object Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
