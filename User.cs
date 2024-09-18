class User{
        private string _name;
        private int _contactInfo;
        private string _address;
        public List<Book> _borrowedBooks = new List<Book>();
        private string _password; 

        public User(string name, int contact, string address, string password)
        {
            this._name = name;
            this._contactInfo = contact;
            this._address = address;
            this._password = password;
        }

        public void addbook(Book book) {
            _borrowedBooks.Add(book);
        }
       public void BorrowedBooks(){
            Console.WriteLine(this._name + " currently has the following books borrowed:");
            foreach(Book book in _borrowedBooks) {
                Console.WriteLine(book.Title());
            }
            Console.WriteLine();
        }
        public bool Login(string password) {
            if (password == this._password) {
                return true;
            } else {
                return false;
            }
        }

        public string Name(){
            return this._name;
        }

        public int ContactInfo(){
            return this._contactInfo;
        }

        public string Address(){
            return this._address;
        }

        
    }