using imdbAPP.controller;
using imdbAPP.db;
using imdbAPP.service;

namespace imdbAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            AdminController adminController = new AdminController();
            adminController.save("ali", "ali123", "asd123");
            Console.WriteLine(adminController.getById(1).Name);
            Console.WriteLine(adminController.getById(1).Username);
            Console.WriteLine(adminController.getById(1).Id);


           

            CustomerCommentController controller = 
                new CustomerCommentController(new CommentService());

            CustomerCommentController controller2 =
               new CustomerCommentController(new CustomerService());

        }
        
    }
}