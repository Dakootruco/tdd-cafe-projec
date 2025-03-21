using System;

namespace MaquinadeCafe
{
    
    public class Cafetera
    {
        public bool TieneCafé { get; private set; }
        public bool TieneVasos { get; private set; }
        public bool TieneAzúcar { get; private set; }

        public Cafetera()
        {
            TieneCafé = true;
            TieneVasos = true;
            TieneAzúcar = true;
        }

        public string SeleccionarVaso(string tamaño)
        {
            if (!TieneVasos)
            {
                return "No hay vasos disponibles.";
            }

            if (tamaño == "Pequeño")
            {
                return "Vaso pequeño con 3 Oz de café preparado.";
            }
            if (tamaño == "Mediano")
            {
                return "Vaso mediano con 5 Oz de café preparado.";
            }
            if (tamaño == "Grande")
            {
                return "Vaso grande con 7 Oz de café preparado.";
            }

            return "Tamaño de vaso no válido.";
        }

        public string SeleccionarAzúcar(int cucharadas)
        {
            if (!TieneAzúcar)
            {
                return "No hay azúcar disponible.";
            }

            if (cucharadas < 0)
            {
                return "La cantidad de azúcar no puede ser negativa.";
            }

            return $"Café con {cucharadas} cucharadas de azúcar.";
        }

        public string RecogerVaso()
        {
            if (!TieneVasos)
            {
                return "No hay vasos disponibles.";
            }
            return "Vaso recogido con café listo.";
        }

        public void VaciarMáquina()
        {
            TieneCafé = false;
            TieneVasos = false;
            TieneAzúcar = false;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
         
            Cafetera cafetera = new Cafetera();

            
            Console.WriteLine("Selecciona el tamaño del vaso (Pequeño, Mediano, Grande):");
            string tamaño = Console.ReadLine();

      
            Console.WriteLine("Cuántas cucharadas de azúcar quieres?");
            int cucharadas = Convert.ToInt32(Console.ReadLine());

        
            string resultadoVaso = cafetera.SeleccionarVaso(tamaño);
            string resultadoAzúcar = cafetera.SeleccionarAzúcar(cucharadas);

           
            Console.WriteLine(resultadoVaso);
            Console.WriteLine(resultadoAzúcar);

            
            string resultadoRecoger = cafetera.RecogerVaso();
            Console.WriteLine(resultadoRecoger);
        }
    }
}
