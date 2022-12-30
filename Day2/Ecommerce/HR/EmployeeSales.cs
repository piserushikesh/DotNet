namespace  HR;

public class EmployeeSales:Employee{

    public float Target{get;set;}
    public float Incentive{get;set;}
    public float Sales{get;set;}

    public EmployeeSales():base()
    {
        this.Target=0;
        this.Incentive=0;
        this.Sales=0;
    }

    public EmployeeSales(int id,string firstname,string lastname,string email,string contactnumber,string location,DateTime birthdate,
                        float da,float hra,float basicsalary,float target,float sales):base(id,firstname,lastname,email,contactnumber,location,birthdate,
                        da,hra,basicsalary)
                        {
                             this.Target=target;
                            this.Incentive=0;
                            this.Sales=sales;
                        }

    public override void DoWork()
    {
        if(Sales >= Target)
        {
            this.Incentive=5000;
        }
        else
        {
            this.Incentive=0;
        }
    }   

    public override float ComputePay()
    {
         float salary= base.ComputePay() + Incentive;
        return salary;
    }

    public override string ToString()
    {
       // return base.ToString() + " , Target= "+Sales+" , Incentive= "+Incentive;
         return base.ToString()  + "Incentive =" +Incentive + ", Tartget="+ Target;
    }

}