using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class ballena: Mamifero
    {
        public ballena(string n, double p): base (n, p) 
        {
            
        }

        public void mostrarballena()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es: " + nom);
            Console.WriteLine("Su peso en Kg es de: " + peso);
        }

    }
}
