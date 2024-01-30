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
        public string GustiMusicali { get; set; }
        public Persona(string Nome, string Cognome, int Eta, string GustiMusicali) 
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.Eta = Eta;
            this.GustiMusicali = GustiMusicali;
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
            Console.WriteLine("L'eta della persona e': " + Eta);
        }
        public void GetGustiMusicali()
        {
            Console.WriteLine("Il genere musicale preferito della persona e': " + GustiMusicali + "\n" + "\n");
        }
        public string GetDettagli()
        {
            string Messaggio = "I dettagli della persona sono: " + "\n" + "\n" + "Nome: " + Nome + "\n" + "Cognome: " + Cognome + "\n" + "Eta: " + Eta + " anni" + "\n" + "Genere musicale preferito: " + GustiMusicali;
            return Messaggio;
        }
    }
}
