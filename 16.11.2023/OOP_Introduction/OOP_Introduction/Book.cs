using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Introduction
{
    internal class Book
    {
        // Constructor
        public Book()
        {

                
        }


        // Fields
        //public int BookID { get; set; }
        //public int BookID
        //{
        //    get
        //    {
        //        return BookID;
        //    }
        //    set
        //    {
        //        //if BookID is 8 digits
        //        BookID = value;
        //    }
        //}


        public int BookID { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }


        public override string ToString()
        {
            return "Book Name: " + this.BookName +
                "Author: " + this.Author +
                "BookID: " + this.BookID;

        }



    }
}
