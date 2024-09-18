
namespace LibryApp
{
    class Libry{
        
        static void Main(string[] args)
        {
            Console.WriteLine("We got to main.");

            Book book1 = new Book("Percy Jackson and the Lightning Thief", "Rock Riordan", "YA", 9780786282258);
            Book book2 = new Book("The Art of War", "Sun Tzu", "Educational", 9780140439199);
            Book book3 = new Book("Percy Jackson and the Sea of Monsters", "Rick Riordan", "YA", 9780140439199);

            Inventory inv1 = new Inventory();

            inv1.addBook(book1);
            inv1.addBook(book2);
            inv1.addBook(book3);

            inv1.print();

            Console.WriteLine();
            Console.WriteLine("* * * * * * * * * * * *");
            Console.WriteLine();

            User test_user = new User("Bos", 1800267,"US Naval Prison Facility in Cuba", "Grover#1");

            test_user.addbook(book1);
            test_user.addbook(book3);

            test_user.BorrowedBooks();

            Console.WriteLine("enter password for " + test_user.Name());
            string pass = Console.ReadLine();
            Console.WriteLine(test_user.Login(pass));

        }
    }

}