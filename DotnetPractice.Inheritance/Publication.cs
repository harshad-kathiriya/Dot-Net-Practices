using System;

namespace DotnetPractice.Inheritance 
{
    class Publication
    {
        private string _name;
        public int PageCount { get; set; }
        public decimal Price { get; set; }
        
        public Publication(string name, int pagecount, decimal price) 
        {
            this._name = name;
            this.PageCount = pagecount;
            this.Price = price;
        }

        public string Name { 
            get { return _name; } 
            set {
                if(value == "")
                {
                    throw new ArgumentException("Name cannot be blank");
                }
                _name = value;
            }
        }
        
    }
}