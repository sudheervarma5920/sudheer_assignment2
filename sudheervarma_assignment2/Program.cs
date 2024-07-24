using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace sudheervarma_assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }


        class Book1
        {
            public int BookId { get; set; }
            public string BookName { get; set; }
            public double Price { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
        }

        class Library
        {

            private List<Book1> books = new List<Book1>();

            public void CreateBook()
            {
                Book1 book = new Book1();
                Console.Write("Enter book ID: ");
                book.BookId = int.Parse(Console.ReadLine());
                Console.Write("Enter Book Name: ");
                book.BookName = Console.ReadLine();
                Console.Write("Enter Price: ");
                book.Price = double.Parse(Console.ReadLine());
                Console.Write("Enter Author: ");
                book.Author = Console.ReadLine();
                Console.Write("Enter Publisher: ");
                book.Publisher = Console.ReadLine();
                books.Add(book);
                Console.WriteLine("Book added successfully!");
            }

            public void UpdateBook()
            {
                Console.Write("Enter Book ID to update: ");
                int bookId = int.Parse(Console.ReadLine());
                Book1 book = books.FirstOrDefault(b => b.BookId == bookId);

                if (book != null)
                {

                    Console.WriteLine("Choose detail to update: ");
                    Console.WriteLine("3. Book Name");
                    Console.WriteLine("4. price");
                    Console.WriteLine("5.  Author");
                    Console.WriteLine("6. Publisher");
                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter new Book Name: ");
                            book.BookName = Console.ReadLine();
                            DisplayBookByName(book.BookName);  
                            break;
                        case 2:
                            Console.Write("Enter new Price: ");
                            book.Price = double.Parse(Console.ReadLine());
                            break;
                        case 3:
                            Console.Write("Enter Author: ");
                            string author = Console.ReadLine();
                          DisplayBooksByAuthor(author);
                            break;
                        

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                }
            public void test()

            {
                
            }
            public void DisplayBookById(int bookId)

                {
                    var book = books.FirstOrDefault(b => b.BookId == bookId);
                    if (book != null)
                    {
                    DisplayBook(book);
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                }

                public void DisplayBookByName(string bookName)
                {
                    var book = books.FirstOrDefault(b => b.BookName.Equals(bookName, StringComparison.OrdinalIgnoreCase));
                    if (book != null)
                    {
                        DisplayBook(book);
                    }
                    else
                    {
                        Console.WriteLine("Book not found.");
                    }
                }
            
                public void DisplayBooksByAuthor(string author)
                {
                    var authorBooks = books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
                    if (authorBooks.Any())
                    {
                        foreach (var book in authorBooks)
                        {
                            DisplayBook(book);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No books found by this author and publisher.");
                    }
                }

                public  void DisplayAllBooks()
                {
                    if (books.Any())
                    {
                        foreach (var book in books)
                        {
                            DisplayBook(book);
                        }
                    }


                }
                
               
                public void DisplayBook(Book1 book)
                {
                    Console.WriteLine($"Book ID: {book.BookId}");
                    Console.WriteLine($"Book Name: {book.BookName}");
                    Console.WriteLine($"Price: {book.Price}");
                    Console.WriteLine($"Author: {book.Author}");
                    Console.WriteLine($"Publisher: {book.Publisher}");
                    Console.WriteLine();
                }
            }






        }
    }    







            


        
            

        

        
               
                