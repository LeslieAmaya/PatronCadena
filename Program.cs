using PatronCadena;

var vendedor = new Vendedor();
var supervisor = new Supervisor();
var gerente = new Gerente();

vendedor.AsignarResponsabilidad(supervisor);
supervisor.AsignarResponsabilidad(gerente);

var c = new Compra();

int importe = 1;
while(importe != 0)
{
    Console.WriteLine("Ingrese monto de compra. Presione 0 para terminar de comprar");
    importe = int.Parse(Console.ReadLine());
    c.Importe = importe;
    vendedor.Procesar(c);
}
