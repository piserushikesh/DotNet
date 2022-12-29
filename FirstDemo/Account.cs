namespace Banking;

public class Account{

private float balance;

public Account()
{
    this.balance=15000;
}

public Account(float balance)
{
    this.balance=balance;
}

public float Balance
{
    get{return this.balance;}
    set{this.balance=value;}
}

public void Withdraw(float amount)
{
    if(this.balance < amount)
    {
        Console.WriteLine("insufficient balance!!!!!");
    }
    else{
        this.balance=this.balance-amount;
    }
}

public void Deposite(float amount)
{
    this.balance=this.balance + amount;
}

} 