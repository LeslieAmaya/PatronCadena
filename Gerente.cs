using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCadena
{
    public class Gerente : Aprobador
    {
        public override void Procesar(Compra c)
        {
            Console.WriteLine(string.Format("La compra fue aprobada por el {0}", this.GetType().Name));   
        }
    }
}
