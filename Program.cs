using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Calculos misCalculos= new Calculos(); // creo objeto e inicializo la variable/objeto
            
        
        Console.WriteLine($"El perimetro de mi circulo de radio 1 es: {misCalculos.calculoPerimetro(1)} y su area es: {misCalculos.calculoArea(1)}");

        Console.WriteLine($"El perimetro de mi circulo de radio 2 es: {misCalculos.calculoPerimetro(2)} y su area es: {misCalculos.calculoArea(2)}");
                
        Console.WriteLine($"El Volumen de mi rectangulo de base 2 altura es: {misCalculos.calculoAreaRectangulo(2, 2)}");

        Console.WriteLine($"El Volumen de mi triangulo de base 2 y altura 2 es: {misCalculos.calculoVolumenTriangulo(2,2,8)}");
    }


    class Calculos
    {
        private const double pi = 3.1416;

        public double calculoArea(int radio)
        {
            return pi * radio * radio;
        }
        public double calculoPerimetro(int radio)
        {
            return pi * (2 * radio);
        }
        public double calculoVolumenCirculo(int radio, int alto)
        {
            return calculoArea(radio) * alto;
        }
        public double calculoAreaRectangulo(int lado1, int lado2)
        {
            return lado1 * lado2;
        }
        public double calculoAreaCuadrado(int lado1)
        {
            return calculoAreaRectangulo(lado1,lado1);
        }
        public double calculoAreaTriangulo(int base1, int base2)
        {
            return calculoAreaRectangulo(base1,base2) /2;
        }
        public double calculoVolumenTriangulo(int base1, int base2, int altura )
        {
            return calculoAreaTriangulo(base1, base2) * altura;
        }

    }
    

}