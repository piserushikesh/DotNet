namespace Drawing;

public enum Color { RED, BLUE, GREEN };
public abstract class Shape{

    protected int width{get;set;}
    protected Color color{get;set;}
    public abstract void Draw();
}
