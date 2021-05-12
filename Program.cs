using System;

namespace Definicion_P6_Queue
{
    class Program
    {

        static void Main(string[] args)
        {

            //¿cuantos clientes en total se han atendido?
            //¿cuantos clientes estan formados?
            //¿que va a comprar cada cliente formado?
            //quin sigue
            //atender
            //formarse
            

            //clientes formados inicialmente
            Queue queue = new Queue();

            Cliente peter = new Cliente("Peter", "Coca-cola");
            Cliente jenny = new Cliente("Jenny", "Dr. pepper");
            Cliente harry = new Cliente("Harry", "Leche");

            queue.fila.Enqueue(peter);
            queue.fila.Enqueue(jenny);
            queue.fila.Enqueue(harry);

            //menu

            string opcion = "";
            while(opcion != "9")
            {   
                Console.WriteLine(" ");
                Console.WriteLine("Seleciona una opcion:");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine(" 1) Formarse");
                Console.WriteLine(" 2) Atender");
                Console.WriteLine(" 3) ¿Quien sigue?");
                Console.WriteLine(" 4) ¿cuantos clientes estan formados?");
                Console.WriteLine(" 5) ¿que va a comprar cada cliente?");
                Console.WriteLine(" 6) ¿cuantos clientes en total se han atendido?");
                Console.WriteLine(" 9) Salir");

                opcion =Console.ReadLine();

                //en caso de que no se selecione una opcion indicada

                if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5" && opcion != "6" && opcion != "9")
                {
                    Console.WriteLine("La opcion seleccionada no es correcta");
                    
                }

            //que hacer en cada opcion:

            switch(opcion)
            {
                case "1":
                    queue.Formarse();
                break;
                case "2":
                    queue.atender();
                break;
                case "3":
                    queue.Siguiente();
                break;
                case "4":
                    queue.cuantosFormados();
                break;
                case "5":
                    queue.queCompran();
                break;
                case "6":
                    queue.totalAtendidos();
                break;
                case "9":
                    Console.WriteLine("cerrando programa...");
                break;
            }
            
            }

        }
    }
}
