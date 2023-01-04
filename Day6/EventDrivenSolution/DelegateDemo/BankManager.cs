namespace Manager;

public delegate void ManageOperation();

public class BankManager
{
    public void BlockAccount()
    {
        Console.WriteLine("Your account is Blocked !!!!!!!");
    }

    public void SendMail()
    {
         Console.WriteLine("Sending u SMS Activity Happen in your Account !!!!!!!");
    }

    public void SendSms()
    {
         Console.WriteLine("Sending u SMS Activity Happen in your Account !!!!!!!");
    }

}