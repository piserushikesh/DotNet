namespace MemberShip;
public class AuthManager{
public static bool Validate(string email,string password)
{
    bool status=false;

    if(email == "rpise4938@gmail.com" && password =="Rushi")
    {
         status=true;
    }
    return status;


}

public static bool Register(string firstname,
                            string lastname,string email,string contactnumber,
                            string location)
{
    bool status=false;
    try{
        User the_user=new User();
        the_user.FirstName=firstname;
        the_user.LastName=lastname;
        the_user.Email=email;
        the_user.ContactNumber=contactnumber;
        the_user.Location=location;
        status=true;
    }
    catch(Exception e){
        //Exception
    }
    finally{

    }
    return status;
}
}