namespace ProeveEksamen1
{
    //Lavet af Mikkel Klitgaard 
    internal class Program
    {
        static void Main(string[] args)
        {
            //Opgave 3.2.3
            //Her opretter jeg en ny liste af albums, som jeg vil tilføje albums til
            List<Album> albums = new List<Album>();

            //Jeg opretter 5 forskellige albummer af klassen Album
            Album album1 = new Album("978-87-7085-590-7", "Tintin i Amerika", 1932, "Hergé", 150000, 59.95M);
            Album album2 = new Album("555-44-3333-230-8", "Mikkel på bjerget", 1994, "Linnea Damsgaard", 150, 149.95M);
            Album album3 = new Album("123-45-6789-101-2", "Anders And og Co.", 1949, "Al Taliaferro", 200000, 39.95M);
            Album album4 = new Album("987-65-4321-007-3", "Kodekrigerne", 2025, "Mikkel Klitgaard", 100, 99.95M);
            Album album5 = new Album("777-88-6666-555-3", "Tintin i Danmark", 1945, "Hergé", 10, 39.95M);

            //Her tilføjer jeg dem til min liste albums
            albums.Add(album1);
            albums.Add(album2);
            albums.Add(album3);
            albums.Add(album4);
            albums.Add(album5);

            //Opgave 3.2.4
            //Jeg starter med at lave en counter, som skal fortælle mig om der findes nogle albums
            //som er udgivet før 1990 og med Tegneren Hergé.
            //Hvis der findes nogle, bliver disse udskrevet og counteren stiger med 1.
            //Hvis der ikke findes nogle, forbliver counteren 0, og der udskrives "*** Ikke fundet ***"
            int count = 0;
            foreach (Album album in albums)
            {
                if (album.Udgivelsesår < 1990 && album.TegnerNavn == "Hergé")
                {
                    Console.WriteLine($"""
                        ISBN: {album.Isbn}
                        Titel: {album.Titel}
                        Udgivelsesår: {album.Udgivelsesår}
                        Tegner: {album.TegnerNavn}
                        Antal produceret: {album.AntalProduceret}
                        """);
                    Console.WriteLine("--------");
                    count++;
                }
            }
            if (count == 0) Console.WriteLine("*** Ikke fundet ***");
            Console.WriteLine();

            //Her udskriver jeg den totale pris for alle albums. Jeg bruger metoden FindTotal
            //og bruger suffix :C2, fordi det er en valuta.
            Console.WriteLine($"Total Pris for alle albums: \n{FindTotal(albums):C2}");

            //Jeg indsætter en linje for overskuelighedens skyld i console.
            Console.WriteLine("------------");

            //Opgave 3.3.1
            //Her ville man også kunne bruge en Console.ReadLine() for at bede om et input fra brugeren
            //Dette ville se sådan her ud: int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Opgave 3.3.1:");
            int num = 5;
            int numSum = 0;
            for (int i = 0; i < 5; i++)
            {
                numSum = num;
                num += num;
                Console.WriteLine(numSum);
            }

            Console.WriteLine("-----------");

            //Opgave 3.3.2
            //Jeg starter med at oprette en int tal som er -20
            //Denne bruger jeg i mit while-loop, som kører så længe tal er mindre end -10
            //Hvis "tal modulus 2" IKKE giver 0, så skal tallet udskrives. Ellers ikke
            //Derefter tilføjer jeg +1 til tal og loopet kører forfra.
            Console.WriteLine("Opgave 3.3.2");
            int tal = -20;
            while (tal < -10)
            {
                if (tal % 2 != 0) Console.WriteLine(tal);
                tal++;
            }


        }

        //Opgave 3.2.5
        //Min metode FindTotal. Jeg tilføjer alle albums pris til min sum
        //og returnerer til sidst denne sum, når den er færdig med at iterere igennem alle albums.
        public static decimal FindTotal(List<Album> albums)
        {
            decimal sum = 0;
            foreach (Album album in albums)
            {
                sum += album.Pris;
            }
            return sum;
        }
    }
}
