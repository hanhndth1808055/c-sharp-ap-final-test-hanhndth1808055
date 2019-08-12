using System;
using System.Collections.Generic;

namespace finalexamaphanhndth1808055
{
    public class ProductList
    {
        List<Product> productList = new List<Product>();

        public void Add()
        {
            Console.WriteLine("---ADD A PRODUCT---");
            Console.WriteLine("Please insert Product ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("Please insert Product name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please insert Product price: ");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Product p = new Product(id, name, price);
            productList.Add(p);
            Console.WriteLine("This product has been added successfully.");
        }

        public void Display()
        {
            Console.WriteLine("---PRODUCT LIST---");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("|Product ID          |Product Name                  |Product Price   |");
            Console.WriteLine("----------------------------------------------------------------------");
            foreach (Product p in productList)
            {
                Console.WriteLine(String.Format("|{0,-19} | {1,-28} | ${2,-14}|", p.id, p.name, p.price));
//                Console.WriteLine("Product ID: " + p.id + " - Product Name: " + p.name + " - Product Price: " +
//                                  p.price);
            }

            Console.WriteLine("----------------------------------------------------------------------");
        }

        public void Delete(string id)
        {
            for (int i = 0; i < productList.Count; i++)
            {
                if (productList[i].id == id)
                {
                    productList.RemoveAt(i);
                    Console.WriteLine("This product has been deleted successfully.");
                }
            }
        }
    }
}