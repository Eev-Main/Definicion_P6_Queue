using System;
using System.Collections.Generic;

namespace Definicion_P6_Queue
{
    class Queue
    {
        public Queue<Cliente> fila = new Queue<Cliente>();

        int atendidos = 0; 
        
        public void Formarse()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Escribe el nombre del cliente");
            Console.WriteLine("pulsa ENTER");
            Console.WriteLine("Escribe el nombre del producto");
            Console.WriteLine("pulsa ENTER");
            fila.Enqueue(new Cliente(Console.ReadLine(), Console.ReadLine()));

            Console.WriteLine("El nuevo cliente se a formado correctamente");
        }
        public void atender()
        {
            Console.WriteLine("--------------------------------------");
            fila.Dequeue();
            atendidos = atendidos + 1;
            Console.WriteLine("cliente atendido");

        }
        public void Siguiente()
        {
            Console.WriteLine("--------------------------------------");
            Cliente nombre = fila.Peek();
            Console.WriteLine("El siguiente en la lista es " + nombre.nombre);              
        }
        public void cuantosFormados()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Actualmente hay " + fila.Count + " Clientes formados");
        }
        public void queCompran()
        {
            Console.WriteLine("--------------------------------------");
            foreach (Cliente obj in fila)
            {
                Console.WriteLine(obj.nombre + " va a comprar " + obj.Producto);         
            }   
        }
        public void totalAtendidos()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("se han atendido un total de: " + atendidos + " clientes");
        }
    }
}