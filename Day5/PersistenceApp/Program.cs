using Catlog;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

Product p1=new Product{ Id=11, Title="Gerbera", Description="Wedding Flower",UnitPrice=20};
Product p2=new Product{ Id=12, Title="Lotus", Description="Show",UnitPrice=30};
Product p3=new Product{ Id=13, Title="Jasmin", Description="Fregrance",UnitPrice=10};
Product p4=new Product{ Id=14, Title="Rose", Description="Couples fav",UnitPrice=50};


List<Product> basket=new List<Product>();

basket.Add(p1);
basket.Add(p2);
basket.Add(p3);
basket.Add(p4);

try
{
    var options=new JsonSerializerOptions {IncludeFields=true};
    var productJson=JsonSerializer.Serialize<List<Product>>(basket,options);
    string fileName=@"D:\dotnet_workspace\Practice\DotNet\Day5\PersistenceApp\Program.json";

    File.WriteAllText(fileName,productJson);

    string jsonString = File.ReadAllText(fileName);
    List<Product> jsonBasket = JsonSerializer.Deserialize<List<Product>>(jsonString);
    Console.WriteLine("\n JSON : Deserializing data from json file \n \n ");
    foreach( Product b in jsonBasket)
    {
        Console.WriteLine($"{b.Title} : {b.Description}");
    }
}
catch (Exception exp)
{
    
    
}
finally{}