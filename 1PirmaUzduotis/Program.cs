namespace PirmaUzduotis_LaikoAtvaizdavimasSkirtingaisVienetais
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite metodą, kuris priima metų skaičių ir atspausdina,
                        // kiek mėnesių, dienų ir valandų tai yra. Tarkime kad metai turi 365 dienas.
                        // Pvz.: "16 metu, tai: 192 menesiu, 5840 dienu, 140160 valandu."

                        Console.Write("Iveskite metu skaiciu: ");
                        bool metaiCheck = int.TryParse(Console.ReadLine(), out int metai);
                        if (metaiCheck == false)
                        {
                                Console.WriteLine("");
                                Console.WriteLine(IvestisError(ref metaiCheck));
                                Environment.Exit(0);
                        }
                        else
                        {
                                int menesiai;
                                int dienos;
                                int valandos;

                                Metai_i_menesiai_konversija(ref metai, out menesiai);
                                Metai_i_dienos_konversija(ref metai, out dienos);
                                Metai_i_valandos_konversija(ref metai, out valandos);

                                Console.WriteLine($"Metai: {metai}\nMenesiai: {menesiai} \nDienos: {dienos} \nValandos: {valandos} \n");
                        }

                }

                public static int Metai_i_menesiai_konversija(ref int metai, out int menesiai)
                {
                        menesiai = metai * 12;
                        return menesiai;
                }

                public static int Metai_i_dienos_konversija(ref int metai, out int dienos)
                {
                        dienos = metai * 365;
                        return dienos;
                }

                public static int Metai_i_valandos_konversija(ref int metai, out int valandos)
                {
                        valandos = metai * 8760;
                        return valandos;
                }

                public static string IvestisError(ref bool metaiCheck)
                {
                        string errortext = "";
                        if (metaiCheck == false) errortext = "Opereacija nepavyko: patikrinkite ivesti!";
                        return errortext;
                }




        }
}