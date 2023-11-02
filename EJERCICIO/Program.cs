
//EJERCICIO 2

using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        bool continuar = true;

        while (continuar)
        {
            int numeroAleatorio = random.Next(-12, 13);
            string mes = ObtenerNombreMes(numeroAleatorio);

            if (numeroAleatorio <= 0)
            {
                continuar = false;
                mes = "Fuera de rango";
            }

            Console.WriteLine($"Número aleatorio: {numeroAleatorio}, Mes: {mes}");
        }
    }

    static string ObtenerNombreMes(int numero)
    {
        switch (numero)
        {
            case 1: return "Enero";
            case 2: return "Febrero";
            case 3: return "Marzo";
            case 4: return "Abril";
            case 5: return "Mayo";
            case 6: return "Junio";
            case 7: return "Julio";
            case 8: return "Agosto";
            case 9: return "Septiembre";
            case 10: return "Octubre";
            case 11: return "Noviembre";
            case 12: return "Diciembre";
            default: return "Fuera de rango";
        }
    }
}
