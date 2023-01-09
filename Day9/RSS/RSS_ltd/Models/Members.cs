namespace RSS_ltd.Models;

public class RSS_members
{
    public int Id{get;set;}
    public string Name{get;set;}
    public string City{get;set;}
    public string Path{get;set;}

    public RSS_members(int memId,string name,string city)
    {
        this.Id=memId;
        this.Name=name;
        this.City=city;
    } 
    public RSS_members(int memId,string name,string city,string path)
    {
        this.Id=memId;
        this.Name=name;
        this.City=city;
        this.Path=path;
    }
}