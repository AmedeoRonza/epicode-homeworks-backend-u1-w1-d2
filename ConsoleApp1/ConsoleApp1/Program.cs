using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Amedeo", "Ronza", 31);
            persona1.GetNome();
            persona1.GetCognome();
            persona1.GetEta();
            Console.WriteLine(persona1.GetDettagli());
            Console.ReadLine();
        }
    }
}
