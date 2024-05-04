namespace Practica_2.Programas
{
    public class Operaciones
    {
        public void ComprobarNotas() 
        { 
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int promedio = 0;

            try
            {
                Console.WriteLine("Digite el primer número: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el segundo número: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite el primer número: ");
                num3 = Convert.ToInt32(Console.ReadLine());

                promedio = (num1 + num2 + num3) / 3;
                Console.WriteLine("---------------------------");

                if (promedio >= 7)
                {
                    Console.WriteLine("Promocionado");
                    Console.WriteLine($"Su calificación es: {promedio}");
                }
                else if ((promedio >= 4) && (promedio < 7))
                {
                    Console.WriteLine("Regular");
                    Console.WriteLine($"Su calificación es: {promedio}");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                    Console.WriteLine($"Su calificación es: {promedio}");
                }
                Console.WriteLine("---------------------------");

            }
            catch (Exception ex)
            {
               Console.WriteLine($"Ha ocurrido el siguiente error: {ex.Message} al realizar las operaciones");
            }
            
        }

    }
}
