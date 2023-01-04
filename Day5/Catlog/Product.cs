namespace Catlog;
using System.ComponentModel.DataAnnotations;
[Serializable]
public class Product
{

    public int Id{get;set;}
    [Required]
    public string Title{get;set;}
    public string Description{get;set;}
    public double UnitPrice{get;set;}

    public Product()
    {
        this.Id=12;
        this.Title="Champa";
        this.Description="show flower";
        this.UnitPrice=20;
    }

    public Product(int id,string title,string description,int unitprice)
    {
         this.Id=id;
        this.Title=title;
        this.Description=description;
        this.UnitPrice=unitprice;
    }


}
