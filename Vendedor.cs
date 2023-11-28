using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCadena
{
    public class Vendedor : Aprobador
    {
        public override void Procesar(Compra c)
        {
            if (c.Importe < 500)
            {
                Console.WriteLine(string.Format("La compra fue aprobada por el {0}", this.GetType().Name));
            }
            else
            {
                _siguiente.Procesar(c);  
            }
        }
    }
}
