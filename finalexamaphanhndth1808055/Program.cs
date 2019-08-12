using System;
using System.Threading;

namespace finalexamaphanhndth1808055
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool start = true;
            ProductList productList1 = new ProductList();
            while (start)
            {
                ShowMenu();
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        productList1.Add();
                        break;
                    case 2:
                        productList1.Display();
                        break;
                    case 3:
                        Console.WriteLine("Please insert Product ID to delete: ");
                        string id = Console.ReadLine();
                        productList1.Delete(id);
                        break;
                    case 4:
                        Console.WriteLine("Exit successfully.");
                        start = false;
                        break;
                }
            }
        }

        public static void ShowMenu()
        {
            Console.WriteLine("---MENU---");
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by ID");
            Console.WriteLine("4. Exit");
            Console.WriteLine("----------------------");
            Console.WriteLine("Please select an option: ");
        }
    }
}