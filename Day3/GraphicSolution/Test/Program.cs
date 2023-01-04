using Drawing;
using System.Collections.Generic;

Point pt1=new Point(10,20);
Point pt2=new Point(30,40);

Shape basket1=new Line(pt1,pt2);

Point pt3=new Point(20,70);
Point pt4=new Point(50,40);

Shape basket2=new Rectangle(pt3,pt4);

Point pt5=new Point(33,44);
int Radius=25;

Shape basket3=new Circle(pt5,Radius);

List<Shape> basket=new List<Shape>();

basket.Add(basket1);
basket.Add(basket2);
basket.Add(basket3);

Console.WriteLine("Drawing from all Baskets!!!!!!!");

foreach (Shape s in basket)
{
    s.Draw();
    Console.WriteLine("--------------------------------------------------------");
    IPrintable obj=(IPrintable)s;
    obj.print();
    Console.WriteLine("--------------------------------------------------------");
}






