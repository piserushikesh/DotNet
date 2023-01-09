using HR;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


var emp =new Employee(){ Id=23,FirstName="Rushikesh",LastName="Pise",Email="rpise4938@gmail.com",ContactNumber="8605145620"};

var employees=new List<Employee>();

employees.Add(new Employee(){ Id=24,FirstName="Avinash",LastName="Bhosale",Email="avinashbhosale@gmail.com",ContactNumber="9456812340"});
employees.Add(new Employee(){ Id=25,FirstName="Pratik",LastName="Pawar",Email="pratikpawar@gmail.com",ContactNumber="8123567890"});
employees.Add(new Employee(){ Id=26,FirstName="Shruti",LastName="Kulkarni",Email="shrutikulkarni@gmail.com",ContactNumber="9658745310"});
employees.Add(new Employee(){ Id=27,FirstName="Ajay",LastName="Jadhav",Email="ajayjadhav@gmail.com",ContactNumber="9456812390"});
employees.Add(new Employee(){ Id=28,FirstName="Anjali",LastName="Patil",Email="anjalipatil@gmail.com",ContactNumber="8123567980"});


app.MapGet("/",()=>"Hello World");
app.MapGet("/api/hello",()=>"Transflower Store");
app.MapGet("/api/employee",()=>emp);
app.MapGet("/api/employees",()=>employees);
app.Run();
