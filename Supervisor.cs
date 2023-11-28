using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PatronCadena
{
    public class Supervisor : Aprobador
    {
        public override void Procesar(Compra c)
        {
            if (c.Importe <= 5000)
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
