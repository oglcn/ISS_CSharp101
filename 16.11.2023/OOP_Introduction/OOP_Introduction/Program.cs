// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using OOP_Introduction;

int a = 5;

//
//Book book = new Book();
//book.BookID = 123;
//book.Author = "Ahmet";
//book.BookName = "CENG111";

//Book book2 = new Book();
//book2.BookID = 124;
//book2.Author = "Ahmet";
//book2.BookName = "C# Basics";

List<Book> books = new List<Book>();


while (true)
{
    Random rnd = new Random();
    int id = rnd.Next(1,10000);


    Book book = new Book();
    Console.Write("Book Name: ");
    book.BookName = Console.ReadLine();

    Console.Write("Author: ");
    book.Author = Console.ReadLine();

    book.BookID = id;

    books.Add(book);

    Console.WriteLine("Add more? (Y/N)");
    string answer = Console.ReadLine();

    if (answer == "N")
    {
        break;
    }



}


foreach (Book book in books)
{
    Console.WriteLine(book.ToString());
}

//OOP Introduction

//Encapsulation, Abstraction, Inheritance, and Polymorphism

//Encapsulation and Abstraction

//Inheritance

//Polymorphism