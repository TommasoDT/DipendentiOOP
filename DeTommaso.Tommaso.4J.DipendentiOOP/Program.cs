using System;

namespace DeTommaso.Tommaso.J.DipendentiOOP
{
    class MainClass
    {

        class Dipendente
        {
            private string _nome;
            private string _reparto;
            private int _oreStraordinario;

            public Dipendente(string nome, string reparto, int oreStraordinario)
            {
                _nome = nome;
                _reparto = reparto;
                _oreStraordinario = oreStraordinario;
            }

            public string GetNome()
            {
                return _nome;
            }

            public string GetReparto()
            {
                return _reparto;
            }

            public int GetOreStraordinario()
            {
                return _oreStraordinario;
            }
        }

        static Dipendente[] dipendenti =
        {
            new Dipendente("Pasquale", "Elettronica", 21),
            new Dipendente("Mario", "Informatica", 12),
            new Dipendente("Giuseppe", "Informatica", 14),
            new Dipendente("Franco", "Progettazione", 2),
            new Dipendente("Ugo", "Elettronica", 18),
            new Dipendente("Alfredo", "Progettazione", 5),
            new Dipendente("Alfonso", "Informatica", 11),
            new Dipendente("Gilberto", "Elettronica", 19),
            new Dipendente("Arlesiana", "Progettazione", 3),
            new Dipendente("Jessie", "Elettronica", 1)
        };

        public static void Main(string[] args)
        {
            Console.WriteLine("Inserire il nome del dipendente di cui si vuole sapere le ore di straordinario");
            string dipendente = Console.ReadLine();

            Console.WriteLine("Inserire il nome del reparto di cui si vuole sapere le ore di straordinario complessive");
            string reparto = Console.ReadLine();

            int oreStraordinariDipendente = OreStraordinariDipendente(dipendente);
            int oreStraordinariComplessiveReparto = OreStaordinariComplessiveReparto(reparto);

            if (oreStraordinariDipendente == -1)
            {
                Console.WriteLine("Il dipendente " + dipendente + " non è nell'archivio.");
            }
            else
            {
                Console.WriteLine("Le ore di straordinario del dipendente " + dipendente + " sono " + oreStraordinariDipendente);
            }

            if (oreStraordinariComplessiveReparto == -1)
            {
                Console.WriteLine("Il reparto " + reparto + " non è nell'archivio.");
            }
            else
            {
                Console.WriteLine("Le ore di straordinario complessive del reparto " + reparto + " sono " + oreStraordinariComplessiveReparto);
            }
        }

        static int OreStraordinariDipendente(string dipendente)
        {
            for (int i = 0; i < dipendenti.Length; i++)
            {
                if (dipendenti[i].GetNome() == dipendente)
                {
                    return dipendenti[i].GetOreStraordinario();
                }
            }
            return -1;
        }

        static int OreStaordinariComplessiveReparto(string reparto)
        {
            bool repartoExists = false;
            int sommaOreStraordinari = 0;

            for (int i = 0; i < dipendenti.Length; i++)
            {
                if (dipendenti[i].GetReparto() == reparto)
                {
                    repartoExists = true;
                    sommaOreStraordinari = sommaOreStraordinari + dipendenti[i].GetOreStraordinario();
                }
            }

            if (!repartoExists)
            {
                sommaOreStraordinari = -1;
            }

            return sommaOreStraordinari;
        }

    }
}
