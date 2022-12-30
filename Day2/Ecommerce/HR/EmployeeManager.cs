namespace HR;


public class EmployeeManager:EmployeeSales{

    public float Bonus{get;set;}

    public EmployeeManager():base()
    {
        this.Bonus=0;
    }

    public EmployeeManager(int id,string firstname,string lastname,string email,string contactnumber,string location,DateTime birthdate,
                        float da,float hra,float basicsalary,float target,float sales,float bonus):base(id,firstname,lastname,email,contactnumber,location,birthdate,
                        da,hra,basicsalary,target,sales)
                        {
                            this.Bonus=bonus;
                        }

    public override void DoWork()
    {
        base.DoWork();
    }

    public override float ComputePay()
    {
        float salary = base.ComputePay() + Bonus;
        return salary;
    }

    public override string ToString()
    {
        string str=base.ToString() + " Bonus= "+Bonus;
        return str;
        // return base.ToString() + "Bonus="+Bonus;
    }



}