using System;

namespace DotnetPractice.Properties
{
    class Book
    {
        private string _name;
        private string _author;
        private int _pagecount;

        public Book(string name, string author, int pages)
        {       
            this._name = name;
            this._author = author;
            this._pagecount = pages;
        }

        public string Name { 
            get {
                return _name;
            } 
            set {
                _name = value;
            } 
        }

        public string Author { 
            get => _author; 
            set => _author = value; 
        }

        public int PageCount { 
            get => _pagecount; 
            set => _pagecount = value; 
        }

        public string Description { 
            get => $"{Name} by {Author}, {PageCount} pages";
        }
        
        public string ISBN { get; set; }      
        public decimal Price { get; set; }

    }
}