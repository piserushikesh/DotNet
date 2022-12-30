namespace HR;
public abstract class Employee
{

    public int Id{get;set;}
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string Email{get;set;}
    public string ContactNumber{get;set;}
    public string Location{get;set;}
    public DateTime Birthdate{get;set;}
    public float DA{get;set;}
    public float HRA{get;set;}
    public float BasicSalary{get;set;}


    public Employee():this(10,"Rushikesh","Pise","rpise4938@gmail.com","8605145620","Kolhapur",new DateTime(1998-6-30),
                        2000,10000,40000){

                        }

     public Employee(int id,string firstname,string lastname,string email,string contactnumber,string location,DateTime birthdate,
                        float da,float hra,float basicsalary)
                        {
                            this.Id=id;
                            this.FirstName=firstname;
                            this.LastName=lastname;
                            this.Email=email;
                            this.ContactNumber=contactnumber;
                            this.Location=location;
                            this.Birthdate=birthdate;
                            this.DA=da;
                            this.HRA=hra;
                            this.BasicSalary=basicsalary;
                        }        


    public abstract void DoWork();     

    public virtual float ComputePay()
    {
        float pay=(DA*25)+BasicSalary+HRA;
        return pay;
    }  


    public override string ToString()
    {
        string str= string.Format("{0},{1},{2},{3},{4},{5}",Id,FirstName,LastName,Email,ContactNumber,Location);
        return str;
    }
   



}
