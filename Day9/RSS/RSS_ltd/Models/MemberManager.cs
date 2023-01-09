using System.Collections.Generic;
namespace RSS_ltd.Models;

public static class MemberManager
{
    public static List<RSS_members> GetAllMembers()
    {
         List<RSS_members> allMembers = new List<RSS_members>();

         allMembers.Add(new RSS_members(001,"Rushikesh Pise","Karad","/images/001.png"));
         allMembers.Add(new RSS_members(002, "Narendra Modi", "Varanasi","/images/002.png"));
        allMembers.Add(new RSS_members(003, "Amit Shah", "Gandhinagar","/images/003.png"));
        allMembers.Add(new RSS_members(004, "Rajnath Singh", "Lucknow","/images/004.png"));
        allMembers.Add(new RSS_members(005, "Nitin Gadkari", "Nagpur","/images/005.png"));
        allMembers.Add(new RSS_members(006, "Sushma Swaraj", "Madhya Pradesh","/images/006.png"));
        allMembers.Add(new RSS_members(007,"Shivam Sakore","Pune"));
        allMembers.Add(new RSS_members(008,"Shyam Karhale","Parbhani"));

        return allMembers;
    }

}