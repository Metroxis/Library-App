
class Book{
        private string _title;
        private string _author;
        private string _genre;
        private long _isbn;

        public Book(string _title, string _author, string _genre, long _isbn)
        {
            this._title = _title;
            this._author = _author;
            this._genre = _genre;
            this._isbn = _isbn;

        }

        public string Title(){
            return this._title;
        }

        public string Auther(){
            return this._author;
        }

        public string Genre(){
            return this._genre;
        }

        public long ISBN(){
            return this._isbn;
        }
    }