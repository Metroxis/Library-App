
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
        }
    }

}