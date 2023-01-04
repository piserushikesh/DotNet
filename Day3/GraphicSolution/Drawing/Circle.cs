namespace Drawing;

public class Circle:Shape,IPrintable{

    public Point Center{get;set;}
    public int Radius{get;set;}

    public Circle()
    {
        this.Center=new Point(0,0);
        this.Radius=1;

    }
     public Circle(Point pt1,int r)
    {
        this.Center=pt1;
        this.Radius=r;
    }

     public override void Draw()
    {
        Type t=this.GetType();
        Console.WriteLine("Type "+t.Name);
        Console.WriteLine("Center = "+ this.Center+" , Radius= "+ this.Radius+ ", width= "+this.width+" Color= "+ this.color);
    }

    public void  print()
    {
        Console.WriteLine("I am from Circle");
         Type t=this.GetType();
        Console.WriteLine("Type"+t.Name);
        Console.WriteLine("Center = "+ this.Center+" , Radius= "+ this.Radius+ ", width= "+this.width+" Color= "+ this.color);
    }
}