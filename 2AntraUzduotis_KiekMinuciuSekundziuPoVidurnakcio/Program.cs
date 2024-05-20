namespace AntraUzduotis_KiekMinuciuSekundziuNuoVakar
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        // Sukurkite metodą, kuris pagal šiuo metu esančių valandų bei minučių skaičių
                        // (naudokite parametrus hour ir minute iš DateTime) apskaičiuoja kiek minučių ir sekundžių
                        // praėjo po vidurnakčio.
                        TimeSpan Laikas = LaikasNuoVakar(out Laikas);
                        Console.WriteLine($"Minutes po vidurnakcio: {Convert.ToInt16(Laikas.TotalMinutes)}");
                        Console.WriteLine($"Sekundes po vidurnakcio: {Convert.ToInt32(Laikas.TotalSeconds)}");
                }

                public static TimeSpan LaikasNuoVakar(out TimeSpan Laikas)
                {
                        DateTime now = DateTime.Now;
                        DateTime today = DateTime.Today;
                        Laikas = now - today;
                        return Laikas;
                }
        }
}