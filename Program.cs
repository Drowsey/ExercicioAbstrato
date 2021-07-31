using System;
using System.Collections.Generic;
using ExercicioAbstrato.Entities;
using ExercicioAbstrato.Entities.Enums;

namespace ExercicioAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapeList = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int numShape = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numShape; i++)
            {
                Console.Write($"Shape #{i} data:\nRectangle or circle? (r/c)");
                string o = Console.ReadLine().ToLower();

                if (o == "r" || o == "c")
                {
                    Console.Write("Color (Black/Blue/Red): ");
                    Color c = Enum.Parse<Color>(Console.ReadLine());
                    if (o == "r")
                    {
                        Console.Write("Width: ");
                        double width = double.Parse(Console.ReadLine());
                        Console.Write("Height: ");
                        double height = double.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Comando inválido! Digite 'r' ou 'c' ");
                    i--;
                    continue;
                }
            }
        }
    }
}
