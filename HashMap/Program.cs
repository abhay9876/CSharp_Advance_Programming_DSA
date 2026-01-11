using System;

namespace HashMap
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Inventory Management
            Inventory inventory = new InventoryManager();
            Product p1 = new Electronics("Laptop", 65000);
            Product p2 = new Cloths("T-Shirt",600);
            inventory.Add(101, p1);
            inventory.Add(102, p2);
            Product product = inventory.Get(101);
            product.Details();

            // Role-Based Access
            AuthSystem auth = new AuthSystem();
            auth.AssignRole("Abhay", new Admin());
            auth.AssignRole("Goku", new User());
            Console.WriteLine(auth.CheckAccess("Abhay", "DELETE")); 
            Console.WriteLine(auth.CheckAccess("Goku", "Read"));


            // Grade Calculate
            GradeService service = new GradeService();
            service.AddStudent(101, 88, new CBSE());
            service.AddStudent(102, 88, new GPA());
            service.PrintGrade(101);
            service.PrintGrade(102);

            //URl Shortner
        }
    }
}