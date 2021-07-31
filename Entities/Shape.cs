using ExercicioAbstrato.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioAbstrato.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
        
    }
}
