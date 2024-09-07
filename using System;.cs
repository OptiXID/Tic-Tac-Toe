using System;
namespace TestMTK {

    static  Main(string{} args)
    {
        //fields buat mencari E constant values
        console.WriteLine("Math.E = " + Math.E);
        console.WriteLine("Math.PI = " + Math.PI);

        //methods
        console.WriteLine("FLoor value if 123.123: "+ Math.FLoor(123.123));
        console.WriteLine("Cos value of 0.35: " + Math.Cos(0.35));
        Console.WriteLine("Square Root of 81: " + Math.sqrt(81));
        Console.WriteLine("Round value of 14.6534: "+ Math.Round(14.6534));
    }
}