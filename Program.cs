using ConsoleApp2.Class;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Darat darat = new Darat();
            Air air = new Air();
            Udara udara = new Udara();
            Hewan nafas = new Hewan();

            Console.WriteLine("___DARAT___\n");
            darat.jalan("Kambing");
            nafas.bernafas();
            darat.jalan("Kucing");
            nafas.bernafas();
            Console.WriteLine("___AIR___\n");
            air.berenang("Hiu");
            nafas.bernafas("Insang\n");
            air.berenang("Paus");
            nafas.bernafas();
            Console.WriteLine("___UDARA___\n");
            udara.terbang("Beo");
            nafas.bernafas();
            udara.terbang("Elang");
            nafas.bernafas();


        }

    }
}
