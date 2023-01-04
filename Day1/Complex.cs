namespace Maths;

public class Complex{

    private int real;
    private int imag;

    public Complex()    //parameterless constructor
    {
        this.real=1;
        this.imag=1;
    }

     public Complex(int r,int i) //parametrized constructor
    {
        this.real=r;
        this.imag=i;
    }

    //properties

    public int Real{
        get{return this.real;}
        set{this.real=value;}
    }

    public int Imag{
        get{return this.imag;}
        set{this.imag=value;}
    }

    //operator overloading

    public static Complex operator+(Complex c1,Complex c2){
        Complex temp=new Complex();
        temp.real=c1.Real + c2.Real;
        temp.imag=c1.Imag + c2.Imag;
        return temp;

    }
}