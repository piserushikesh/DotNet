using MemberShip;
using HR;


Console.WriteLine("Hello Buddy, whaats Up !!!!!!!!!!!!");
Console.WriteLine("*-*-*-*-*-*-*-*-*-**-*-*-*-*");


Console.WriteLine("Enter the Email Id : ");
string email=Console.ReadLine();

Console.WriteLine("Enter the password : ");
string password=Console.ReadLine();

if(AuthManager.Validate(email,password))
{
    Console.WriteLine("Welcome To the Programming World !!!!!!");
    Employee emp=new EmployeeManager();
    emp.DoWork();
    string str=emp.ToString();
    Console.WriteLine(str);
   
    float salary=emp.ComputePay();
    Console.WriteLine("Salary is "+salary);
}
else
{
    Console.WriteLine("Invalid User");
}


Console.WriteLine("Thanks Rushikesh!!!!!!");






