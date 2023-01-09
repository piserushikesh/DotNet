using System.Collections.Generic;
//using Garage;
using RPcollection;


// List<Object> allobjects=new List<Object>();
// allobjects.Add(12);
// allobjects.Add("Rushikesh Pise");
// allobjects.Add(true);
// allobjects.Add(45.6);



// foreach (Object item in allobjects)
// {
//     Console.WriteLine(item);
// }

//List<Parts> allparts=new List<Parts>();

// allparts.Add(new Parts(){ PartName="Wheels",PartId=11});
// allparts.Add(new Parts(){ PartName="Door",PartId=12});
// allparts.Add(new Parts(){ PartName="Stearing",PartId=13});
// allparts.Add(new Parts(){ PartName="Seat",PartId=14});

// foreach (Parts item in allparts)
// {
//     Console.WriteLine(item);
// }


// Stack<Parts> assembly=new Stack<Parts>();
// assembly.Push(new Parts(){ PartName="Wheels",PartId=11});
// assembly.Push(new Parts(){ PartName="Door",PartId=12});
// assembly.Push(new Parts(){ PartName="Stearing",PartId=13});
// foreach (Parts item in assembly)
// {
//     Console.WriteLine(item);   
// }


List<Employee> employeelist=new List<Employee>();
employeelist.Add(new Employee(1,"rushi",70000));
employeelist.Add(new Employee(2,"dhruvkumar",40000));
employeelist.Add(new Employee(3,"shyam",50000));
employeelist.Add(new Employee(4,"shivam",30000));
Console.WriteLine("List of Employees before Sort");

foreach(Employee emp in employeelist){
    Console.WriteLine(emp.id + "--"+ emp.name + "--"+ emp.salary);
}

EmpComparer ec = new EmpComparer();

employeelist.Sort(ec);
Console.WriteLine("List of Employees after Sort");

foreach(Employee emp in employeelist){
    Console.WriteLine(emp.id + "--"+ emp.name + "--"+ emp.salary);
}


Console.WriteLine("-----------------------------------------------------");

EmpComparerById ec1 = new EmpComparerById();

employeelist.Sort(ec1);
Console.WriteLine("List of Employees after Sortby Id");

foreach(Employee emp in employeelist){
    Console.WriteLine(emp.id + "--"+ emp.name + "--"+ emp.salary);
}



