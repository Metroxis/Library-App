
class Inventory{
        private List<Book> Books;

        public Inventory(){
            this.Books = new List<Book>();
        }

        public void addBook(Book book){
            Books.Add(book);
        }

        public void print(){
            foreach(Book book in Books){
                Console.WriteLine(book.Title());
            }
        }
    }