using Government;
using Banking;
using Manager;

CentralGov  cg=new CentralGov();

//cg.DeductIncomeTax(70000);
//cg.DeductServiceTax(4000);


TaxOperation itOperation=new TaxOperation(cg.DeductIncomeTax);
TaxOperation proOperation=new TaxOperation(cg.DeductProfessionalTax);

Accounts act1=new Accounts(70000);

act1.overBalance+=itOperation;
act1.overBalance+=proOperation;

Console.WriteLine("Enter the Amount ");
double amount = double.Parse(Console.ReadLine());
act1.Deposite(amount);
Console.WriteLine(act1);

act1.ProcessTax();
Console.WriteLine("After Tax processing");
Console.WriteLine(act1);

Console.WriteLine("-----------=-------------------=--------------------------");

BankManager bm=new BankManager();

ManageOperation baOperation=new ManageOperation(bm.BlockAccount);
ManageOperation seOperation=new ManageOperation(bm.SendMail);
ManageOperation ssOperation=new ManageOperation(bm.SendSms);

Accounts act2=new Accounts(60000);

act2.underBalance+=baOperation;
act2.underBalance+=seOperation;
act2.underBalance+=ssOperation;


Console.WriteLine("Enter the Amount ");
double amount1 = double.Parse(Console.ReadLine());
act2.Withdraw(amount1);
Console.WriteLine(act2);




