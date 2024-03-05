using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class vaca: Mamifero
    {
        //atributo
        private double LtsLeche {  get; set; }
        
        //constructor
        public vaca (string n, double p, double L): base (n,p) 
        {
            this.LtsLeche = L;
        }

        //metodo
        public void CantComida () 
        {
            double K;
            K = peso / LtsLeche;
            Console.WriteLine("la cantidad de comida es: " + K);
        }

        public void mostrarVaca()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es: " + nom);
            Console.WriteLine("Su peso en Kg es de: " + peso);
            Console.WriteLine("la cantidad de leche es: " + LtsLeche);
        }
    }
}
