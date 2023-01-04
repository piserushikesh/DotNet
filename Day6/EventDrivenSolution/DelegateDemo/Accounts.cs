using Government;
using Manager;
namespace Banking;




public class Accounts
{
    public event TaxOperation overBalance;
    public event ManageOperation underBalance;
    public double Balance{get;set;}

    public Accounts(double amount)
    {
        this.Balance=amount;
    }

    public void Deposite(double amount)
    {
        this.Balance+=amount;
    }

     public void Withdraw(double amount)
    {
        if(amount > this.Balance)
        {
            underBalance();
        }
        else
        {
            this.Balance-=amount;
        }
        
    }

    public override string ToString()
    {
        return base.ToString() + "Current Balance = "+this.Balance;
    }

    public void ProcessTax()
    {
        if(this.Balance >= 250000)
        {
            overBalance(this.Balance);
        }
    }

}