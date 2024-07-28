public class ImplementacionOperaciones : Operaciones
{
    public void Imprimir()
    {
        double areaRectangulo = CalcularAreaRectangulo(5, 10);
        double volumenCubo = CalcularVolumenCubo(3);
        double longitudCircunferencia = CalcularLongitudCircunferencia(7);

        Console.WriteLine("Resultados de las Operaciones:");
        Console.WriteLine($"Área del Rectángulo: {areaRectangulo}");
        Console.WriteLine($"Volumen del Cubo: {volumenCubo}");
        Console.WriteLine($"Longitud de la Circunferencia: {longitudCircunferencia}");
    }
}
