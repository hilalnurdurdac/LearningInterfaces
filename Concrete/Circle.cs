using System.Reflection.Emit;
using LearningInterfaces.Abstractions;

namespace LearningInterfaces;

public class Circle : IShape
{
    public decimal Radius { get; set; }
    public decimal CalculateArea()
    {
        var result=(decimal)Math.PI *(Radius*Radius); //3.14=Math.PI olarak yazılabilir.
        return Math.Floor(result*100)/100;
    }

    public decimal CalculatePerimeter()
    {
        return ((decimal)Math.PI*Radius)*2;
    }
}
