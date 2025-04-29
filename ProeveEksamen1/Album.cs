namespace ProeveEksamen1
{
    internal class Album
    {
        //Opgave 3.2.1
        //Her sætter jeg alle Properties som mine objekter af klassen Album skal have
        //Jeg har tilføjet decimal Pris, da jeg skal bruge denne i opgave 3.2.5
        public string Isbn { get; set; }
        public string Titel { get; set; }
        public int Udgivelsesår { get; set; }
        public string TegnerNavn { get; set; }
        public int AntalProduceret { get; set; }
        public decimal Pris { get; set; }

        //Opgave 3.2.2
        //Dette er min constructor, som setter properties til en værdi.
        public Album(string isbn, string titel, int year, string tegnerNavn, int antal, decimal pris)
        {
            Isbn = isbn;
            Titel = titel;
            Udgivelsesår = year;
            TegnerNavn = tegnerNavn;
            AntalProduceret = antal;
            Pris = pris;
        }


    }
}
