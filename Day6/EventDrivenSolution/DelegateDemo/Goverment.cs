namespace Government ;

public delegate void TaxOperation(double amount);


public class CentralGov
{

    public void DeductIncomeTax(double amount)
    {
        Console.WriteLine("40% income tax is deducted from your Account");
    }

    public void DeductServiceTax(double amout)
    {
         Console.WriteLine("18% service tax is deducted from your Account");
    }

    public void DeductProfessionalTax(double amount)
    {
         Console.WriteLine("10% Professional Tax is deducted from your Account");
    }



}