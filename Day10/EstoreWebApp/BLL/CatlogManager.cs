﻿namespace BLL;
using BOL;
using DAL;
public class CatlogManager
{

    public List<Product> GetAllProducts()
    {
        List<Product> allProducts=new List<Product>();
        allProducts = DBManager.GetAllProducts();
        return allProducts;
    }

    public Product GetProduct(int id)
    {
        List<Product> allProducts=GetAllProducts();

        Product foundProduct = allProducts.Find((product)=>product.ProductId ==id);
        return foundProduct;
    }
}
