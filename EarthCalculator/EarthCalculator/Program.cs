namespace EarthCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Meil on münt, mille diameeter on 25.75 mm
            // Arvutada välja maa ümbermõõt ja mitu münti mahub järjestikku ümber maa
            // Arvutuses tohib kasutada ainult mündi diameetrit ja maa raadiust

            double coinDiameter = 25.75; //mm
            double earthRadius = 6378000000; //mm

            double earthCircumference = 2 * Math.PI * earthRadius; //mm
            Console.WriteLine($"Maa ümbermõõt on {earthCircumference} mm");

            double coinCumulativeAmount = earthCircumference / coinDiameter;
            Console.WriteLine($"Maa ümbermõõdu sisse mahub {coinCumulativeAmount} kaheeurost münti.");

            // Arvutab, kui mitu tervet münti sisse mahub.
            long wholeCoinCumulativeAmount = (long)Math.Floor(coinCumulativeAmount);
            Console.WriteLine($"Maa ümbermõõdu sisse mahub {wholeCoinCumulativeAmount} tervet kaheeurost münti.");
        }
    }
}
