using System;

namespace DotnetPractice.Classes
{
    public class Book
    {
        // member variable or fields
        string _name;
        string _author;
        int _pageCount;

        // constructor
        public Book(string name, string author, int pages) 
        {
            this._name = name;
            this._author = author;
            this._pageCount = pages;
        }

        // methods
        public string GetDescription() 
        {
            return $"{_name} by {_author}";
        }

    }
}