namespace MINUKONSPEKT_NK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            //Muutujad, Matemaakilised tehted, IF, ELSE IF ja ELSE:

            //1. tusun njo921 2088wg
            Console.WriteLine("Tere kasutaja, mis on sunu nimi");
            string nimi = Console.ReadLine();

            if (nimi == "")
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime");
            }
            else if (nimi != "")
            {
                Console.WriteLine("Tere " + nimi + "!");

            }
            else
            {
                Console.WriteLine("Kasutaja ei sisestanud oma nime");
            }

            //2. tuvasta jsiugjs salam salam slama ///double/floart andmememrut
            Console.WriteLine(nimi + ", mis on sinu vanus?: ");
            int kasutajavanus = int.Parse(Console.ReadLine());
            //2.1 831246328HFDWUSI
            //if (kasutajavanus > 0 )
            //{
            //    if (kasutajavanus < 18)
            //    {
            //        Console.WriteLine("Kahjuks emergijoki sulle ei muuda. oled pivasik ilma 🤣👍😂🧐");
            //    }
            //    else
            //    {
            //        Console.WriteLine("saad osta pivasik salam💎💎💎🛠️🛠️🛠️🛠️");
            //    }
            if (kasutajavanus > 0 && kasutajavanus < 18)
            {
                Console.WriteLine("Kahjuks emergijoki sulle ei muuda. oled pivasik ilma 🤣👍😂🧐");
            }
            else
            {
                Console.WriteLine("saad osta pivasik salam💎💎💎🛠️🛠️🛠️🛠️");
            }
            Console.WriteLine("Sisesta oma pikkus ka, palun, " + nimi + ":");
            double pikkus = double.Parse(Console.ReadLine());
            if (pikkus < 1.00d)
            {
                Console.WriteLine("Oldes juntsu");
            }
            else if (pikkus < 1.25d && pikkus > 1.00d)
            {
                Console.WriteLine("Oled peaaegu allameetrimees");
            }
            else if (pikkus < 1.50d && pikkus > 1.25d)
            {
                Console.WriteLine("Oiosi pakapikk enam e olegi " + nimi + "!");
            }
            else if (pikkus < 1.75d && pikkus > 1.5d)
            {
                Console.WriteLine("Mne len pisat etu huynu");
            }
            else if (pikkus < 2.00d && pikkus > 1.75d)
            {
                Console.WriteLine("Pikk kolge vaata et sa pead vastu uksewpita ara ei löö.");
            }
            else if (pikkus > 2.00d)
            {
                Console.WriteLine("yu so tall hello");
            }
            else
            {
                Console.WriteLine("pikkust ei tunta");

            }
            Console.WriteLine("Tere. Sisesta esimene arv");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tere. Sisesta teine arv");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("sisesta tehtemärk: / * + - ");
            string tehtetyyp = Console.ReadLine();

            int tulemus = 0;
            if (tehtetyyp == "+")
            {
                tulemus = arv1 + arv2;
            }
            else if (tehtetyyp == "-")
            {
                tulemus = arv1 - arv2;
            }
            else if (tehtetyyp == "/")
            {
                tulemus = arv1 / arv2;
            }
            else if (tehtetyyp == "*")
            {
                tulemus = arv1 * arv2;
            }
            else if (tehtetyyp == "^")
            {
                tulemus = (int)Math.Pow(arv1, arv2);
            }
            else
            {
                Console.WriteLine("Palun sisesta tehe, mida kalkulaator tuvastada oskab");
            }

            if (tulemus != 0)
            {
                Console.WriteLine(tulemus);
            }
            else
            {
                Console.WriteLine("Tulemus on 0, või üritasid teha tehet, mida kalkulaator ei tunne");
            }

            Console.WriteLine("Kas sa tahad õuna või banaani?");
            string vastus = Console.ReadLine();
            if (vastus == "õuna")
            {
                Console.WriteLine("õuna panul: 🍏🍎");
            }
            else if (vastus == "banaani")
            {
                Console.WriteLine("banaan palun: 🍌🍌🍌🍌🍌🍌");
            }
            else
            {
                Console.WriteLine("Sellist puuvilja ma ei tunne");
            }
            double pi_ = Math.PI;
        }
    }
}
