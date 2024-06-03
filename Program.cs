using LearningInterfaces;
using LearningInterfaces.Concrete;

Rectangle rectangle=new(); //dikdörtgen tanımla

rectangle.SideA=5;
rectangle.SideB=10;

decimal rectangleArea =rectangle.CalculateArea();//dikdörtgen alan
Console.WriteLine(rectangleArea); 

decimal rectanglePerimeter =rectangle.CalculatePerimeter(); //dikdörtgen çevre
Console.WriteLine(rectanglePerimeter);

Circle circle=new(); //çember tanımladık

circle.Radius=10; 
decimal circleArea=circle.CalculateArea(); //çember alanı
Console.WriteLine(circleArea);

decimal circlePerimeter =circle.CalculatePerimeter(); //çember çevresi
Console.WriteLine(circlePerimeter);
