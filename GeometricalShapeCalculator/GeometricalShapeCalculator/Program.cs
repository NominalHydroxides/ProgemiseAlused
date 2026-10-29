namespace GeometricalShapeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matemaatika C#-is: Kujundite impeerium");
            // Ruudu sees asub ring. Ringi raadius on 3 ühikut.
            // Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt.

            int circleRadius = 3;
            int circleDiameter = 2 * circleRadius;

            double circleRadiusSquared = Math.Pow(circleRadius, 2);

            int squareSideHalf = 3;
            int squareSide = 2 * squareSideHalf;

            // Ruudu pindala
            double squareSurfaceArea = Math.Pow(squareSide, 2);
            Console.WriteLine($"Ruudu pindala on {squareSurfaceArea} ühikut ruudus.");

            // Ruudu ümbermõõt
            double squarePerimeter = 4 * squareSide;
            Console.WriteLine($"Ruudu ümbermõõt on {squarePerimeter} ühikut.");

            // Ringi pindala
            double circleSurfaceArea = Math.PI * circleRadiusSquared;
            Console.WriteLine($"Ringi pindala on {circleSurfaceArea} ühikut ruudus.");

            // Ringi ümbermõõt
            double circleCircumference = 2 * Math.PI * circleRadius;
            Console.WriteLine($"Ringi ümbermõõt on {circleCircumference} ühikut.");

            // NALJA VILUKS: Leiab Pi väärtuse
            double piYesPi = circleCircumference / circleDiameter;
            Console.WriteLine($"Pi väärtus on {piYesPi}");
        }
    }
}
