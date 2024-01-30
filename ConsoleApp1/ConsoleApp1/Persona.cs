using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }
        public Persona(string Nome, string Cognome, int Eta) 
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Eta = Eta;
        }
        public void GetNome() 
        {
            Console.WriteLine("Il nome della persona e': " + Nome);
        }
        public void GetCognome() 
        {
            Console.WriteLine("Il cognome della persona e': " + Cognome);
        }
        public void GetEta() 
        {
            Console.WriteLine("L'eta della persona e': " + Eta + "\n" + "\n");
        }
        public string GetDettagli()
        {
            string Messaggio = "I dettagli della persona sono: " + "\n" + "\n" + "Nome: " + Nome + "\n" + "Cognome: " + Cognome + "\n" + "Eta: " + Eta + " anni";
            return Messaggio;
        }
    }
}
