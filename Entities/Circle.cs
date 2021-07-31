using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioAbstrato.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
