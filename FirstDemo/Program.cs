using Maths;
using Banking;

Console.WriteLine("Hello all I am Rushikesh Pise");

var p=new{
    Fname="Rushikesh",
    Lname="Pise"
};

Console.WriteLine("my name is "+p.Fname+" my last name is "+p.Lname);


Complex c1=new Complex(2,3);
Complex c2=new Complex(4,5);
Complex c3=c1 + c2;

Console.WriteLine("Complex addition is "+c3.Real+" and "+c3.Imag+"j");


Account acc123=new Account(60000);
acc123.Withdraw(10000);


Account acc124=new Account(20000);
acc124.Deposite(10000);

List<Account> accounts=new List<Account>();
accounts.Add(acc123);
accounts.Add(acc124);
acc123.Balance=40000;
foreach(Account i in accounts)
{
 
    Console.WriteLine("Current Balance: "+i.Balance);
}
