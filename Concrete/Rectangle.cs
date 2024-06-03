namespace LearningInterfaces.Concrete;
using LearningInterfaces.Abstractions;
public class Rectangle : IShape
{
    public decimal SideA { get; set; }
    public decimal SideB { get; set; }
    public decimal CalculateArea() //alan hesabı
    {
        return SideA*SideB;
    }
    public decimal CalculatePerimeter()
    {
        return (SideA*SideB)*2; //çevre hesabı 
    }
}
