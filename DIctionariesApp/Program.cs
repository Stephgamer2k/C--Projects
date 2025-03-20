using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;
namespace DIctionariesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionaries stores data in key-value pairs
            //Keys are unique identifiers of the value stored with it
            //Dictionaries allow for fast searches

            Dictionary<string, string> books = new Dictionary<string, string>();

            Console.WriteLine("Library System.");
            
            while(true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Remove Book");
                Console.WriteLine("4. Display all Books ");
                Console.WriteLine("5. Exit ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter the ISBN for the book.");
                        string isbn = Console.ReadLine();
                        Console.WriteLine("Enter the name of the book.");
                        string name = Console.ReadLine();
                        books.Add(isbn, name);
                        break;
                    case "2":
                        Console.WriteLine("Enter the ISBN for the book you are looking for.");
                        string searchBook = Console.ReadLine();
                        if(books.TryGetValue(searchBook,out string value))
                        {
                            Console.WriteLine($"ISBN: {searchBook}, Title: {value}");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine($"No bok found for {searchBook}");
                            Console.WriteLine();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter the ISBN for the book you want to remove.");
                        string removeBook = Console.ReadLine();
                        if(books.Remove(removeBook))
                        {
                            Console.WriteLine("Book removed");
                            Console.WriteLine();
                        }
                        else 
                        {
                            Console.WriteLine($"No book found for {removeBook}");
                            Console.WriteLine();
                        }
                        break;
                    case "4":
                        foreach(var book in books)
                        { 
                            Console.WriteLine($"Key: {book.Key}, Value: {book.Value}");
                            Console.WriteLine();
                        }
                        break;
                    case "5":
                        Console.WriteLine("Exiting program...");
                        return;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        Console.WriteLine();
                        break;
                }

            }
            

            //books.Add("789-01", "Harry Potter");
            //books.Add("789-02", "One Piece");

            ////How to display the dictionary with the keys and values
            ////usse the .Key and .Value methods to get the key and value respectivly

            //foreach(var book in books)
            //{
            //    Console.WriteLine($"Key: {book.Key}, Value: {book.Value}");
            //}

            ////Adding a book to the dictionary
            //Console.WriteLine("Enter the ISBN");
            //string bookCode = Console.ReadLine();
            //Console.WriteLine("Enter the book title");
            //string title = Console.ReadLine();

            ////ContainsKey checks if there is any duplicate  keys in
            //if(!books.ContainsKey(bookCode))
            //{
            //    books.Add(bookCode, title);
            //    foreach (var book in books)
            //    {
            //        Console.WriteLine($"Key: {book.Key}, Value: {book.Value}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("ISBN number already exits.");
            //}


            //Console.WriteLine("Enter the ISBN for the book you are looking for");
            //string search = Console.ReadLine();
            //if(books.TryGetValue(search,out string value))
            //{
            //    Console.WriteLine($"ISBN: {search}, Book Title: {value}");
            //}
            //else
            //{
            //    Console.WriteLine($"No book found for {search}");
            //}
            

        }
    }
}
