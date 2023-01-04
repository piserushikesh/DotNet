namespace OrderProcessing;
public class CRMHistory:IOrderDetails,ICustDetail{
    public void ShowOrderDetails(){
        Console.WriteLine("Showing customers Order Details");
    }

    public void ShowCustomerDetails(){
        Console.WriteLine("Showing customers Profile Details"); 
    }

    public  void ChangeProfile(){
        Console.WriteLine("Your Customer Profile has been Updated");
    }

    //Explicit Interface Inheritance
    void ICustDetail.ShowDetails(){
        Console.WriteLine("Customer Personalized Information");
    }
    void IOrderDetails.ShowDetails(){
            Console.WriteLine("Customers Review Details");
    }
}