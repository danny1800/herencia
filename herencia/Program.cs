// See https://aka.ms/new-console-template for more information
//Variables 
using herencia;

string nombre;
double peso;
int nBigotes;
double LstLeche;

//Ingresar y mostrar clase gato
Console.WriteLine("------Clase gato------");
Console.Write("Ingresa el nombre del gato: ");
nombre = Console.ReadLine();

Console.Write("Ingresa el peso: ");
peso = double.Parse(Console.ReadLine());

Console.Write("Ingresa el numero de bigotes: ");
nBigotes = int.Parse(Console.ReadLine());

//Instancia de los objetos
//Gato 
gato gato1 = new gato(nombre, peso, nBigotes);

Console.WriteLine();
gato1.mostrarGato();

//Cambiando el nombre al gato
gato1.setNombre("Lucifer");
nombre = gato1.getNombre();
Console.WriteLine("\n---Le cambie el nombre al gato----\n");
gato1.mostrarGato();

//Ingresar y mostrar clase vaca
Console.WriteLine("------Clase vaca------");
Console.Write("Ingresa el nombre de la vaca: ");
nombre = Console.ReadLine();

Console.Write("Ingresa el peso: ");
peso = double.Parse(Console.ReadLine());

Console.Write("Ingresa litros de leche: ");
LstLeche = int.Parse(Console.ReadLine());

vaca vaca1 = new vaca(nombre, peso, LstLeche);  

Console.WriteLine();
vaca1.mostrarVaca();  
vaca1.CantComida();

//Ingresar y mostrar clase ballena
Console.WriteLine("------Clase ballena------");
Console.Write("Ingresa el nombre de la ballena: ");
nombre = Console.ReadLine();

Console.Write("Ingresa el peso: ");
peso = double.Parse(Console.ReadLine());

ballena ballena1 = new ballena(nombre, peso);
Console.WriteLine();
ballena1.mostrarballena();

