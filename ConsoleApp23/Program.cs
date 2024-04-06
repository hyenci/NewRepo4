using ConsoleApp23.Clases;

Carro carrito = new Carro("toyota",2024, "blanco");
Carro carro2 = new Carro("Nissan", 2020, "Azul");

carrito.Color = "Rojo";
carrito.owner = "Juan";






//Console.WriteLine($"El carro es un {carrito.Marca}");
//Console.WriteLine($"El carro es un {carro2.Marca}");



Console.WriteLine(carrito.Acelerar());
Console.WriteLine(carrito.Acelerar());//ES ACELERAR 3 VECES
Console.WriteLine(carrito.Acelerar());

if (carrito.Acelerar() == 0)
{

    Console.WriteLine("El carro esta apagado");

}
else
{
    Console.WriteLine(carrito.Acelerar()+"/KPH");
}
